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

namespace Modulo_Tickets
{
    public partial class Frm_FlujoSoporteD : Form
    {
        bool IsAdmin;
        int Contador = 0;
        double por = 0.00;
        string Base64;
        string Nombre_archivo;
        public Frm_FlujoSoporteD()
        {
            InitializeComponent();
        }
        private void Frm_FlujoSoporteD_Load(object sender, EventArgs e)
        {
            TareasRequest tareas = new TareasRequest();
            TareasRequest request = new TareasRequest();
            Prestamo prestamo = new Prestamo();
            Prestamo status = new Prestamo();
            prestamo = FormatosRepository.Consultar_Status_Procedimiento(status);
            tareas = TareasRepository.Consultar_IdTareas(request);
            request = TareasRepository.Consultar_Status_Procedimiento(tareas);
            Persistentes.Id_Tarea = tareas.Id_Tarea;
            Lbl_NumeroTicket.Text = Persistentes.Id_Flujo.ToString();
            TicketFlujoRequest ticketFlujo = new TicketFlujoRequest
            {
                Id_Flujo = Persistentes.Id_Flujo
            };
            ticketFlujo = TareasRepository.ConsultarFlujo_status(ticketFlujo);
            if (ticketFlujo.Status == "OK") // Tickets con porcentaje 
            {
                Btn_Avance.Enabled = false;
                Btn_Resuelto.Enabled = false;
            }
            else if (ticketFlujo.Status == "NO")
            {
                Btn_Avance.Enabled = true;
                Btn_Resuelto.Enabled = true;
            }
            else if (Persistentes.Status_TickteStaff == "IN" && prestamo.status_autorizacion == "P") //Prestamos Con autorizacion pendiente 
            {
                Btn_Resuelto.Visible = false;
                Btn_Aceptado.Visible = true;
                Btn_Rechazado.Visible = true;
            }
            else if (Persistentes.Status_TickteStaff == "IN" && (prestamo.status_autorizacion == "SI" || prestamo.status_autorizacion == "NO")) //Prestamos con Autorizacion ya definida
            {
                Btn_Resuelto.Visible = false;
                Btn_Aceptado.Visible = true;
                Btn_Rechazado.Visible = true;
                Btn_Aceptado.Enabled = false;
                Btn_Rechazado.Enabled = false;
            }
            else//(request.Status == "N" && request.Autorizacion == "N" && request.Porcentaje == "N") // para los que son informativos 
            {
                Btn_Resuelto.Visible  = false;
                Btn_Aceptado.Visible  = false;
                Btn_Rechazado.Visible = false;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Avance_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 2;
            Frm_Comentarios frm = new Frm_Comentarios(1, IsAdmin);
            frm.Size = new Size(806, 505);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void Btn_Avances_Click_1(object sender, EventArgs e)
        {
            Frm_TreeView frm = new Frm_TreeView();
            Persistentes.Tipo_tree = 2;
            Persistentes.Id_Flujo = Convert.ToInt32(Persistentes.Id_Flujo);
            frm.Size = new Size(806, 505);
            frm.ShowDialog();
        }

        private void Btn_Imagenes_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 2;
            Frm_Imagenes frm = new Frm_Imagenes(0, Persistentes.Id_Flujo);
            frm.Size = new Size(806, 505);
            frm.ShowDialog();
        }

        private void Btn_Resuelto_Click(object sender, EventArgs e)
        {
            TicketFlujoRequest ticketFlujo = new TicketFlujoRequest
            {
                Id_Flujo = Persistentes.Id_Flujo
            };
            List<TicketFlujoRequest> tickets = new List<TicketFlujoRequest>();
            por = (99.99 / TareasRepository.Consultar_Departamentos_Inv(ticketFlujo));
            //foreach(var item in tickets)
            //{
            //    Contador = Contador + 1;
            //}
            //por = 100 / Contador;
            //TicketFlujoRequest t = new TicketFlujoRequest();
            //List<TicketFlujoResponse> tF = new List<TicketFlujoResponse>();
            //tF = TareasRepository.ConsultarFlujoGeneral(t);
            //foreach (var item in tF)
            //{
            //    if(Convert.ToInt32(item._Id_Flujo) == Persistentes.Id_Flujo)
            //    {
            //        PorcentajeActual = Convert.ToInt32(item._Porcentaje);
            //        PorcentajeActual = PorcentajeActual + por;
            //        if(PorcentajeActual == 99)
            //        {
            //            PorcentajeActual = 100;
            //        }
            //    }
            //}
            Persistentes.Tipo_tree = 2;
            Frm_Comentarios frm = new Frm_Comentarios(2, IsAdmin);
            frm.Size = new Size(806, 505);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (TareasRepository.Flujos_Resuelto(ticketFlujo))
                {
                    int ss = Persistentes.Id_Tarea;
                    TareasRequest tareas = new TareasRequest();
                    TareasRequest request = new TareasRequest();
                    tareas = TareasRepository.Consultar_Status_Procedimiento(request);
                    if(tareas.Porcentaje == "S")
                    {
                        TicketFlujoRequest flujoRequest = new TicketFlujoRequest { Id_Flujo = Persistentes.Id_Flujo};
                        TareasRepository.Actualizar_Porcentaje(flujoRequest,por);
                    }
                    Persistentes.Mensaje("El flujo se ha resuelto correctamente.", 2);
                    Enviar_Correo_Involucrados();
                    TicketFlujoRequest ticket = new TicketFlujoRequest();
                    List<TicketFlujoResponse> ticketFlujos = new List<TicketFlujoResponse>();
                    ticketFlujos = TareasRepository.ConsultarFlujoGeneral(ticket);
                    foreach (var item in ticketFlujos)
                    {
                        if (Convert.ToInt32(item._Id_Flujo) == Persistentes.Id_Flujo)
                        {
                            if (item._Status == "RESUELTO")
                            {
                                Enviar_Correo_Usuario();
                            }
                        }
                    }
                }
                else
                {
                    Persistentes.Mensaje("No perteneces inicalmente a este flujo.", 2);

                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        void Enviar_Correo_Involucrados()
        {
            CorreoResponseFlujo Seguimiento;
            TicketFlujoRequest Ticket = new TicketFlujoRequest { Id_Flujo = Persistentes.Id_Flujo };
            Seguimiento = TareasRepository.Correo_Seguimiento(Ticket);
            Persistentes.Id_Tarea_Flujo = Seguimiento.Id_Tarea;
            Persistentes.Id_Flujo = Seguimiento.Id_Flujo;
            CorreoResponseFlujo correo;
            TicketFlujoRequest ticketFlujo = new TicketFlujoRequest { Id_Tareas = Persistentes.Id_Tarea_Flujo, Id_Flujo = Persistentes.Id_Flujo };
            try
            {
                correo = TareasRepository.Correo_Seguimiento_Involucrados(ticketFlujo);
                Correo.Mail_ProcedimientoNotificacionResuelto(correo);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se puedo enviar el correo.");
            }
        }
        void Enviar_Correo_Usuario()
        {
            CorreoResponseFlujo Seguimiento;
            TicketFlujoRequest Ticket = new TicketFlujoRequest { Id_Flujo = Persistentes.Id_Flujo };
            try
            {
                Seguimiento = TareasRepository.Correo_Seguimiento(Ticket);
                Correo.MailFlujo_UsuarioNotificacionResuelto(Seguimiento);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se puedo enviar el correo.");
            }
        }
        void Enviar_Corre_Usuario_Prestamo_Aceptado()
        {
            CorreoResponseFlujo Seguimiento;
            TicketFlujoRequest Ticket = new TicketFlujoRequest { Id_Flujo = Persistentes.Id_Flujo };
            try
            {
                Seguimiento = TareasRepository.Correo_Seguimiento(Ticket);
                Correo.MailPrestamo_UsuarioAceptado(Seguimiento);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se puedo enviar el correo.");
            }
        }
        void Enviar_Corre_Usuario_Prestamo_Declinado()
        {
            CorreoResponseFlujo Seguimiento;
            TicketFlujoRequest Ticket = new TicketFlujoRequest { Id_Flujo = Persistentes.Id_Flujo };
            try
            {
                Seguimiento = TareasRepository.Correo_Seguimiento(Ticket);
                Correo.MailPrestamo_UsuarioDeclinado(Seguimiento);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se puedo enviar el correo.");
            }
        }

        private void Btn_Aceptado_Click(object sender, EventArgs e)
        {
            Btn_Aceptado.Enabled = false;
            Prestamo prestamo = new Prestamo
            {
                Id_Autoriza = Persistentes.Usuario_Login
            };
            FormatosRepository.Guardar_PersonaAutorizo(prestamo);
            Prestamo Consultar_info = new Prestamo();
            Prestamo Persona = new Prestamo();
            Consultar_info = FormatosRepository.Consultar_Info_Prestamo(Persona);
            Prestamo Per_ = new Prestamo();
            Prestamo Autorizo = new Prestamo();
            Per_ = FormatosRepository.Consultar_Persona_Autoriza(Autorizo);
            //SE CREA PDF
            string PaginaHTML_Texto = Properties.Resources.Plantilla2.ToString();
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = ".pdf";
                savefile.FileName = string.Format("{0}.pdf", "Backup-" + Consultar_info.Fecha_Registro.ToString("ddMMyyyyHHmmss"));
                Nombre_archivo = savefile.FileName;
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fecha", Consultar_info.Fecha_Registro.ToString("dd/MM/yyyy"));
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Nomina", Consultar_info.Clave_Empleado.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Nombre", Consultar_info.Nombre);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Fingreso", Consultar_info.Fecha_Ingreso.ToString("dd/MM/yyyy"));
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Pservicio", Persistentes.Nombre_Sucursal);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CSolicitada", Consultar_info.Can_Sol.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MYFprestamo", Consultar_info.MyF);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Paño", Consultar_info.Prestamos_UltA.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FUprestamo", Consultar_info.Fecha_Ult_Pres);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Pautoriza", Per_.Nombre_Autoriza);
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
                    iTextSharp.text.Image img1 = iTextSharp.text.Image.GetInstance(Consultar_info.Firma);
                    img1.ScaleToFit(150, 150);
                    img1.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img1.SetAbsolutePosition(30, 500);
                    _pdfDoc.Add(img1);
                    iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(Consultar_info.Huella);
                    img2.ScaleToFit(70, 70);
                    img2.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img2.SetAbsolutePosition(275, 510);
                    _pdfDoc.Add(img2);
                    iTextSharp.text.Image img3 = iTextSharp.text.Image.GetInstance(Per_.Firma_Autoriza);
                    img3.ScaleToFit(150, 150);
                    img3.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img3.SetAbsolutePosition(415,330);
                    _pdfDoc.Add(img3);
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(_pdf, _pdfDoc, sr);
                    }
                    _pdfDoc.Close();
                    byte[] pdfBytes = ms.ToArray();
                    Base64 = Convert.ToBase64String(pdfBytes);
                    FormatosRepository.Guardar_Archivo_Autorizado(new ImagenRequest { Id_Flujo = Persistentes.Id_Flujo, Base64 = Base64});
                    FormatosRepository.Cambiar_Autorizacion(new Prestamo { Id_Flujo = Persistentes.Id_Flujo, Autorizacion = "SI" });
                    Persistentes.Mensaje("La solicitud a sido aprobada con exito");
                    Enviar_Corre_Usuario_Prestamo_Aceptado();
                    Btn_Aceptado.Enabled = true;
                    this.Close();
                    //para abrir el pdf sin necesidad de guardar nada
                    //File.WriteAllBytes(Nombre_archivo, pdfBytes);
                    //Process.Start(Nombre_archivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar generar el reporte", "Error");
                Btn_Aceptado.Enabled = true;
            }
        }

        private void Btn_Rechazado_Click(object sender, EventArgs e)
        {
            Btn_Rechazado.Enabled = false;
            FormatosRepository.Cambiar_Autorizacion(new Prestamo { Id_Flujo = Persistentes.Id_Flujo, Autorizacion = "NO" });
            Enviar_Corre_Usuario_Prestamo_Declinado();
            Persistentes.Mensaje("La solicitud a sido declinada con exito");
            this.Close();
            Btn_Rechazado.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
