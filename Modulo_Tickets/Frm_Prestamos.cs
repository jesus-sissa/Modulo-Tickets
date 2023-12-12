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
using static Modulo_Tickets.Model.UserRequest;
using System.Windows.Forms;

namespace Modulo_Tickets
{
    public partial class Frm_Prestamos : Form
    {
        string Nombre;
        string Base64;
        string Nombre_archivo;
        public int Id_Flujo = 0;
        byte[] Huella;
        byte[] Firma_solicitante;
        int IdEmpleado;
        int por = 0;
        public Frm_Prestamos()
        {
            InitializeComponent();
        }

        private void Frm_Prestamos_Load(object sender, EventArgs e)
        {
            List<SolicitudVacacionesResponse> Empleado_Datos = FormatosRepository.Consultar_Empleado_Prestamos(new SolicitudVacacionesRequest {Id_Empleado = Persistentes.Usuario_Login });
            cmb_empleados.DisplayMember = "Nombre";
            cmb_empleados.ValueMember = "Id_Empleado";
            cmb_empleados.DataSource = Persistentes.Empleado;
            int seleccionar;
            if (int.TryParse(cmb_empleados.SelectedValue?.ToString(), out seleccionar))
            {
                var datos = (from emp in Empleado_Datos
                             where emp.Id_Empleado == seleccionar
                             select emp).FirstOrDefault();
                txt_nomina.Text = datos.Clave_Empleado.ToString();
                txt_fechaingreso.Text = datos.Fecha_Ingreso;
                txt_puntodeservicio.Text = Persistentes.Nombre_Sucursal; 
                Nombre = datos.Nombre;
                Huella = datos.Huella;
                Firma_solicitante = datos.Firma;
                IdEmpleado = datos.Id_Empleado;
            }
            cmb_empleados.Enabled = false;
        }
        private void cmb_empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<SolicitudVacacionesResponse> Empleado_Datos = FormatosRepository.Consultar_Empleado_Prestamos(new SolicitudVacacionesRequest { Id_Empleado = Persistentes.Usuario_Login });
            //int seleccionar;
            //if (int.TryParse(cmb_empleados.SelectedValue?.ToString(), out seleccionar))
            //{
            //    var datos = (from emp in Empleado_Datos
            //                 where emp.Id_Empleado == seleccionar
            //                 select emp).FirstOrDefault();
            //    txt_nomina.Text = datos.Clave_Empleado.ToString();
            //    txt_fechaingreso.Text = datos.Fecha_Ingreso;
            //    Nombre = datos.Nombre;
            //    Huella = datos.Huella;
            //    Firma_solicitante = datos.Firma;
            //    IdEmpleado = datos.Id_Empleado;
            //}
        }
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Btn_Guardar.Enabled = false;
            string PaginaHTML_Texto = Properties.Resources.Plantilla2.ToString();
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = ".pdf";
                savefile.FileName = string.Format("{0}.pdf", "Backup-" + DateTime.Now.ToString("ddMMyyyyHHmmss"));
                Nombre_archivo = savefile.FileName;
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Nomina", txt_nomina.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Nombre", Nombre);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fingreso",txt_fechaingreso.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Pservicio", txt_puntodeservicio.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CSolicitada",txt_cantidadsolicitada.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MYFprestamo", txt_finalidadprestamo.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Paño",txt_prestamosenelaño.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FUprestamo",txt_fechaultimoprestamo.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Pautoriza", "");
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
                    iTextSharp.text.Image img1 = iTextSharp.text.Image.GetInstance(Firma_solicitante);
                    img1.ScaleToFit(150, 150);
                    img1.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img1.SetAbsolutePosition(30, 500);
                    _pdfDoc.Add(img1);
                    iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(Huella);
                    img2.ScaleToFit(70, 70);
                    img2.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img2.SetAbsolutePosition(275, 510);
                    _pdfDoc.Add(img2);
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(_pdf, _pdfDoc, sr);
                    }
                    _pdfDoc.Close();
                    if (txt_fechaingreso.Text == "" || txt_cantidadsolicitada.Text == "" || txt_finalidadprestamo.Text == "" || txt_prestamosenelaño.Text == "" || txt_fechaultimoprestamo.Text == "")
                    {
                        Persistentes.Mensaje("Llenar toda la informacion solicitada");
                    }
                    else
                    {
                        byte[] pdfBytes = ms.ToArray();
                        Base64 = Convert.ToBase64String(pdfBytes);
                        Guardarticket();
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
                Descripcion = "SOLICITUD DE PRESTAMO PERSONAL ",
                Id_Flujo = Id_Flujo,
                UsuarioId = IdEmpleado,
                Status = status,
                Porcentaje = por,
                Autorizacion = Autorizacion

            };
            Numero_Flujo = TareasRepository.GuardarTicketFlujo(flujoRequest);
            Prestamo prestamo = new Prestamo
            {
                Id_Flujo = Numero_Flujo,
                Can_Sol = Convert.ToInt32(txt_cantidadsolicitada.Text),
                Fecha_Ult_Pres = txt_fechaultimoprestamo.Text,
                Prestamos_UltA = Convert.ToInt32(txt_prestamosenelaño.Text),
                MyF = txt_finalidadprestamo.Text
            };
            FormatosRepository.Guardar_Prestamo(prestamo);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
