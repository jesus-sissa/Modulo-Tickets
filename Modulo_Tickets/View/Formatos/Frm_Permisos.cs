using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets.View.Formatos
{
    public partial class Frm_Permisos : Form
    {
        string Nombre;
        string Base64;
        string Nombre_archivo;
        public int Id_Flujo = 0;
        byte[] Firma_solicitante;
        int IdEmpleado;
        int dep = 0;
        int por = 0;
        string valorSeleccionado;
        string NombreRh;
        byte[] Firma_RH;
        public Frm_Permisos()
        {
            InitializeComponent();
        }

        private void Frm_Permisos_Load(object sender, EventArgs e)
        {
            List<string> elementos = new List<string>
            {
                "1.-Defunsion de familiares ",
                "2.-Por paternidad",
                "3.-Nupcias",
                "4.-Lactancia",
                "5.-Ausentismo en hrs habiles",
                "6.-Permiso menor sin goce de salario",
                "7.-Consulta medica",
                "8.-Otros"
            };
            cmb_Permisos.DataSource = elementos;
            string seleccionCompleta = cmb_Permisos.SelectedItem.ToString();
            string[] numero = seleccionCompleta.Split('.');
            if (numero.Length >= 1)
            {
                valorSeleccionado = numero[0].Trim();
            }
            if (Persistentes.Usuario_Login_Nombre == "ENRIQUE VILLANUEVA HERNANDEZ" || Persistentes.Usuario_Login_Nombre == "GUILLERMO GABRIEL MUÑOZ MANAUTOU" || Persistentes.Usuario_Login_Nombre == "GUILLERMO GABRIEL MUÑOZ GOMEZ JUNCO")
            {
                List<SolicitudVacacionesResponse> Empleado_Datos = FormatosRepository.Consultar_Empleado_Todos(new SolicitudVacacionesRequest());
                cmb_empleados.DisplayMember = "Nombre";
                cmb_empleados.ValueMember = "Id_Empleado";
                cmb_empleados.DataSource = Persistentes.Empleado;
                int seleccionar;
                if (int.TryParse(cmb_empleados.SelectedValue?.ToString(), out seleccionar))
                {
                    var datos = (from emp in Empleado_Datos
                                 where emp.Id_Empleado == seleccionar
                                 select emp).FirstOrDefault();
                    Nombre = datos.Nombre;
                    Firma_solicitante = datos.Firma;
                    IdEmpleado = datos.Id_Empleado;
                }
            }
            else
            {
                foreach (var item in FormatosRepository.Consultar_Jefe(new FormatosRequest { UsuarioId = Persistentes.Usuario_Login }))
                {
                    dep = item.departamento;
                }
                if (dep == 0)
                {
                    Persistentes.Mensaje("Favor de acercarse a su jefe directo o gerente");
                    this.Close();
                }
                else
                {
                    List<SolicitudVacacionesResponse> Empleado_Datos = FormatosRepository.Consultar_Empleado(new SolicitudVacacionesRequest { departamento = dep });
                    cmb_empleados.DisplayMember = "Nombre";
                    cmb_empleados.ValueMember = "Id_Empleado";
                    cmb_empleados.DataSource = Persistentes.Empleado;
                    int seleccionar;
                    if (int.TryParse(cmb_empleados.SelectedValue?.ToString(), out seleccionar))
                    {
                        var datos = (from emp in Empleado_Datos
                                     where emp.Id_Empleado == seleccionar
                                     select emp).FirstOrDefault();
                        Nombre = datos.Nombre;
                        Firma_solicitante = datos.Firma;
                        IdEmpleado = datos.Id_Empleado;
                    }
                }
            }
            Permisos formatos = new Permisos();
            Permisos repository = new Permisos();
            formatos = FormatosRepository.Consultar_FirmaRH(repository);
            NombreRh = formatos.Nombre_RH;
            Firma_RH = formatos.Firma;
            txt_Del.Text = DateTime.Now.ToString("dd");
            txt_Al.Text = DateTime.Now.ToString("dd");
            txt_Mes.Text = DateTime.Now.ToString("MMMM");
            txt_Año.Text = DateTime.Now.ToString("yyyy");
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Btn_Guardar.Enabled = false;
            string PaginaHTML_Texto = Properties.Resources.Plantilla3_Permisos.ToString();

            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = ".pdf";
                savefile.FileName = string.Format("{0}.pdf", "Backup-" + DateTime.Now.ToString("ddMMyyyyHHmmss"));
                Nombre_archivo = savefile.FileName;
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TP", valorSeleccionado);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Del", txt_Del.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Al", txt_Al.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Mes", txt_Mes.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Año", txt_Año.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@De", txt_De.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A", txt_A.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Otros", txt_Otros.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Comentario", txt_Comentario.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NombreTrabajador", Nombre);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NombreJefe", Persistentes.Usuario_Login_Nombre);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NombreRH", NombreRh);
                string filas = string.Empty;
                decimal total = 0;
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
                using (MemoryStream ms = new MemoryStream())
                {
                    Document _pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter _pdf = PdfWriter.GetInstance(_pdfDoc, ms);
                    _pdfDoc.Open();
                    _pdfDoc.Add(new Phrase(""));
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.SISSA, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(_pdfDoc.LeftMargin, _pdfDoc.Top - 60);
                    _pdfDoc.Add(img);
                    iTextSharp.text.Image img1 = iTextSharp.text.Image.GetInstance(Persistentes.usuarioLogin_Firma);
                    img1.ScaleToFit(130, 130);
                    img1.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img1.SetAbsolutePosition(230, 470);
                    _pdfDoc.Add(img1);
                    iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(Firma_solicitante);
                    img2.ScaleToFit(130, 130);
                    img2.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img2.SetAbsolutePosition(50, 470);
                    _pdfDoc.Add(img2);
                    iTextSharp.text.Image img3 = iTextSharp.text.Image.GetInstance(Firma_RH);
                    img3.ScaleToFit(130, 130);
                    img3.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img3.SetAbsolutePosition(420, 470);
                    _pdfDoc.Add(img3);
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(_pdf, _pdfDoc, sr);
                    }
                    _pdfDoc.Close();
                    if (txt_Del.Text == "" || txt_Al.Text == "" || txt_Mes.Text == "" || txt_Año.Text == "" || txt_Comentario.Text == "")
                    {
                        Persistentes.Mensaje("Llenar toda la informacion solicitada");
                    }
                    else
                    {
                        if(valorSeleccionado == "5" && (txt_De.Text == "" || txt_A.Text == ""))
                        {
                            Persistentes.Mensaje("Favor de ingresar el horario de ausentismo");
                        }
                        else
                        {
                            byte[] pdfBytes = ms.ToArray();
                            Base64 = Convert.ToBase64String(pdfBytes);
                            Guardarticket();
                        }
                    }
                    Btn_Guardar.Enabled = true;
                    //string filePath = savefile.FileName; //para abrir el pdf sin necesidad de guardar nada
                    //File.WriteAllBytes(filePath, ms.ToArray());
                    //Process.Start(filePath);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar generar el reporte", "Error");
                Btn_Guardar.Enabled = true;
            }
        }

        private void cmb_Permisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionCompleta = cmb_Permisos.SelectedItem.ToString();
            string[] numero = seleccionCompleta.Split('.');
            if (numero.Length >= 1)
            {
                valorSeleccionado = numero[0].Trim(); 
            }
            if(valorSeleccionado == "8")
            {
                txt_Otros.Enabled = true;
            }
            else
            {
                txt_Otros.Enabled = false;
                txt_Otros.Clear();
            }
        }

        private void cmb_empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Persistentes.Usuario_Login_Nombre == "ENRIQUE VILLANUEVA HERNANDEZ" || Persistentes.Usuario_Login_Nombre == "GUILLERMO GABRIEL MUÑOZ MANAUTOU" || Persistentes.Usuario_Login_Nombre == "GUILLERMO GABRIEL MUÑOZ GOMEZ JUNCO")
            {
                List<SolicitudVacacionesResponse> Empleado_Datos = FormatosRepository.Consultar_Empleado_Todos(new SolicitudVacacionesRequest());
                int seleccionar;
                if (int.TryParse(cmb_empleados.SelectedValue?.ToString(), out seleccionar))
                {
                    var datos = (from emp in Empleado_Datos
                                 where emp.Id_Empleado == seleccionar
                                 select emp).FirstOrDefault();
                    Nombre = datos.Nombre;
                    Firma_solicitante = datos.Firma;
                    IdEmpleado = datos.Id_Empleado;
                }
            }
            else
            {
                foreach (var item in FormatosRepository.Consultar_Jefe(new FormatosRequest { UsuarioId = Persistentes.Usuario_Login }))
                {
                    dep = item.departamento;
                }
                if (dep == 0)
                {
                    Persistentes.Mensaje("Favor de acercarse a su jefe directo o gerente");
                    this.Close();
                }
                else
                {
                    List<SolicitudVacacionesResponse> Empleado_Datos = FormatosRepository.Consultar_Empleado(new SolicitudVacacionesRequest { departamento = dep });
                    int seleccionar;
                    if (int.TryParse(cmb_empleados.SelectedValue?.ToString(), out seleccionar))
                    {
                        var datos = (from emp in Empleado_Datos
                                     where emp.Id_Empleado == seleccionar
                                     select emp).FirstOrDefault();
                        Nombre = datos.Nombre;
                        Firma_solicitante = datos.Firma;
                        IdEmpleado = datos.Id_Empleado;
                    }
                }
            }
        }
        void Enviar_Correo(int Id_Flujo)
        {
            Persistentes.Id_Tarea_Flujo = Persistentes.Id_Tarea;
            CorreoResponseFlujo Seguimiento;
            TicketFlujoRequest Ticket = new TicketFlujoRequest { Id_Flujo = Id_Flujo };
            CorreoResponseFlujo correo;
            TicketFlujoRequest ticketFlujo = new TicketFlujoRequest { Id_Tareas = Persistentes.Id_Tarea, Id_Flujo = Id_Flujo };
            try
            {
                Seguimiento = TareasRepository.Correo_Seguimiento(Ticket);
                correo = TareasRepository.Correo_Seguimiento_Involucrados(ticketFlujo);
                Correo.MailFlujo_UsuarioNotificacion(Seguimiento);
                Correo.Mail_ProcedimientoNotificacion(correo);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se puedo enviar el correo.");
            }
        }
        void Guardarticket()
        {
            int Numero_Flujo = 0;
            TareasRequest tareas = new TareasRequest();
            TareasRequest request = new TareasRequest();
            tareas = TareasRepository.Consultar_Status_Procedimiento(request);
            string status = tareas.Status == "S" ? "AC" : "IN";
            string Autorizacion = tareas.Autorizacion == "S" ? "P" : "NA";
            TicketFlujoRequest flujoRequest = new TicketFlujoRequest
            {
                Descripcion = "SOLICITUD DE PERMISOS ",
                Id_Flujo = Id_Flujo,
                UsuarioId = IdEmpleado,
                Status = status,
                Porcentaje = por,
                Autorizacion = Autorizacion
            };
            Numero_Flujo = TareasRepository.GuardarTicketFlujo(flujoRequest);
            TicketRepository.Guardar_Formatos(new ImagenRequest { Base64 = Base64, Id_Flujo = Numero_Flujo, Extension = ".pdf", Nombre = Nombre_archivo });
            TicketRepository.Guardar_Statuss(new TicketFlujoRequest { Id_Flujo = Numero_Flujo });
            flujoRequest = new TicketFlujoRequest { Id_Flujo = Numero_Flujo, UsuarioId = IdEmpleado, Descripcion = "NUEVA SOLICITUD" };
            TareasRepository.GuardarSprintFlujo(flujoRequest);
            Persistentes.Id_Flujo = Numero_Flujo;
            Enviar_Correo(Numero_Flujo);
            Mensaje("La Solicitud con # " + Numero_Flujo.ToString() + " se registro correctamente", 3);
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        void Mensaje(String Texto, int Time = 2)
        {
            Frm_Mensaje msg = new Frm_Mensaje();
            msg.Txt_Mensaje.Text = Texto;
            msg.time = Time;
            msg.ShowDialog();
        }
    }
}
