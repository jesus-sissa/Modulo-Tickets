using Bunifu.Framework.UI;
using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets.Model
{
    class Correo
    {
        public static bool fn_Enviar_MailHTML(string Destino, string Asunto, string Texto, bool Adjunto, byte[] file, string Nombre_Archivo)
        {
            string MailServer;
            string MailRemitente;
            string MailRemitenteNombre;
            string MailUser;
            string MailClaveEnc;
            string MailClave;
            int MailPuerto;
            int MailTiempoEspera;
            bool MailUsarSSL = false;
            bool Hubo_Destinos = false;
            System.Net.Mail.SmtpClient SMTP = new System.Net.Mail.SmtpClient(); // Variable con la que se envia el correo
            System.Net.Mail.MailMessage CORREO = new System.Net.Mail.MailMessage(); // Variable que almacena los Attachment

            DataTable Tabla;
            CorreoRequest _Correo = new CorreoRequest { Id_Sucursal=1};
            Tabla =CorreoRepository.Parametros(_Correo);
            if (Tabla == null)
            {
                CORREO.Dispose();
                return false;
            }
            if (Tabla.Rows.Count == 0)
            {
                CORREO.Dispose();
                return false;
            }
            if (Tabla.Rows[0]["Mail_Server"].ToString() == "" || Tabla.Rows[0]["Mail_User"].ToString()== "" || Tabla.Rows[0]["Mail_Clave"].ToString() == "" || Tabla.Rows[0]["Mail_Remitente"].ToString() == "" || Tabla.Rows[0]["Mail_RemitenteNombre"].ToString() == "")
            {
                CORREO.Dispose();
                return false;
            }
            MailServer = Tabla.Rows[0]["Mail_Server"].ToString();
            MailUser = Tabla.Rows[0]["Mail_User"].ToString();
            MailClaveEnc = Tabla.Rows[0]["Mail_Clave"].ToString();
            MailRemitente = Tabla.Rows[0]["Mail_Remitente"].ToString();
            MailRemitenteNombre = Tabla.Rows[0]["Mail_RemitenteNombre"].ToString();
            MailClave = CorreoRepository.decodificar(MailClaveEnc);
            MailPuerto =Convert.ToInt32( Tabla.Rows[0]["Mail_Puerto"].ToString());
            MailTiempoEspera =Convert.ToInt32( Tabla.Rows[0]["Mail_TiempoEspera"].ToString());
            if (Tabla.Rows[0]["Mail_UsarSSL"].ToString() == "S")
                MailUsarSSL = true;
            else
                MailUsarSSL = false;

            // Configuracion del Mensaje
            CORREO.From = new System.Net.Mail.MailAddress(MailRemitente, MailRemitenteNombre, System.Text.Encoding.UTF8);
            //var Destinos = Destino.Split(','); 
            //for (int Ilocal = 0; Ilocal <= Destinos.Length - 1; Ilocal++)
            //{
            //    if (CorreoRepository.fn_ValidarMail(Destinos[Ilocal].Trim()))
            //    {
            //        CORREO.To.Add(Destinos[Ilocal].Trim());
            //        Hubo_Destinos = true;
            //    }
            //}
            CORREO.To.Add(Destino);
            CORREO.Subject = Asunto;
            CORREO.IsBodyHtml = true;
            CORREO.Body = Texto;

            System.Net.Mail.Attachment Att;

            if (Adjunto)
            {
                // CORREO.Attachments.Add(New System.Net.Mail.Attachment(Adjunto))
                Att = new System.Net.Mail.Attachment(new MemoryStream(file),Nombre_Archivo);
                Att.ContentId = "1";
                CORREO.Attachments.Add(Att);
            }

            SMTP.Host = MailServer;
            SMTP.UseDefaultCredentials = false;
            SMTP.Credentials = new System.Net.NetworkCredential(MailUser, MailClave);
            SMTP.EnableSsl = MailUsarSSL;
            if (MailPuerto > 0)
                SMTP.Port = MailPuerto;
            SMTP.Timeout = MailTiempoEspera * 1000;

            //if (!Hubo_Destinos)
            //{
            //    CORREO.Dispose();
            //    return false;
            //}

            try
            {
                SMTP.Send(CORREO);
            }
            catch (System.Net.Mail.SmtpException ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CORREO.Dispose();
            }
            return true;
        }

        public static bool Mail_Finalizado(decimal Numero_Ticket, string Nombre,string Destino, string NombreRubro = "", string MailRubro = "", string ExtensionRubro = "")
        {
            string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>TICKET RESUELTO </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label>" + Nombre + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "El ticket con: #" + Numero_Ticket + " ha sido finalizado, como proximo paso es necesario cerrarlo." + "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + NombreRubro + "</h4></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Mail:"+ MailRubro + "</h4></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Ext :" + ExtensionRubro + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h3>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h2></body></html>";


            if (fn_Enviar_MailHTML(Destino, "TICKET RESUELTO", DetalleHTML, false, null,""))
            {
                return true;
            }
            return false;
        }
        public static bool Mail_Avance(decimal Numero_Ticket, string Descripcion, string Nombre, string Destino, string NombreRubro = "", string MailRubro = "", string ExtensionRubro = "")
        {
            string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>TICKET EN PROGRESO </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label>" + Nombre + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "El ticket con: #" + Numero_Ticket + " está en progreso." + "</label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "Comentarios:" + Descripcion+ "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + NombreRubro + "</h4></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Mail:" + MailRubro + "</h4></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Ext :" + ExtensionRubro + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h3>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h2></body></html>";


            if (fn_Enviar_MailHTML(Destino, "TICKET EN PROGRESO", DetalleHTML, false, null,""))
            {
                return true;
            }
            return false;
        }
        public static bool Mail_UsuarioNotificacion(CorreoResponse _Correo)
        {
            string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>NUEVO TICKET </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label>" + "ESTIMADO: " + _Correo.UsuarioReporta + "," + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "El numero de su ticket es: #" + _Correo.Numeroticket + " con el cual podras realizar el seguimiento correspondiente." + "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + _Correo.Area + "</h4></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Mail:" + _Correo.AreaMail + "</h4></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Ext :" + _Correo.AreaExtension + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";


            if (Correo.fn_Enviar_MailHTML(_Correo.UsuarioReportaMail, "NUEVO TICKET", DetalleHTML, false,null,""))
            {
                return true;
            }
            return false;
        }
        public static bool MailFlujo_UsuarioNotificacion(CorreoResponseFlujo _Correo)
        {
            Console.WriteLine(_Correo.Id_Flujo);
            Console.WriteLine(_Correo.Id_Tarea);
            string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>NUEVA SOLICITUD </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label>" + "ESTIMADO: " + _Correo.UsuarioReporta + "," + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "El numero de su solicitud es: #" + _Correo.Id_Flujo + " con el cual podras realizar el seguimiento correspondiente." + "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Nombre de la solicitud : " + _Correo.Nombre_Flujo + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";


            if (Correo.fn_Enviar_MailHTML(_Correo.UsuarioReportaMail, "NUEVA SOLICITUD", DetalleHTML, false, null, ""))
            {
                return true;
            }
            return false;
        }
        public static bool MailFlujo_UsuarioNotificacionResuelto(CorreoResponseFlujo _Correo)
        {
            Console.WriteLine(_Correo.Id_Flujo);
            Console.WriteLine(_Correo.Id_Tarea);
            string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>INFORME DE TERMINADO </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label>" + "ESTIMADO: " + _Correo.UsuarioReporta + "," + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "Se le informa que su solicitud con el numero: #" + _Correo.Id_Flujo + " ha sido resuelto, como proximo paso es necesario cerrarlo." + "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Nombre de la Solicitud : " + _Correo.Nombre_Flujo + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";


            if (Correo.fn_Enviar_MailHTML(_Correo.UsuarioReportaMail, "INFORME DE TERMINADO", DetalleHTML, false, null, ""))
            {
                return true;
            }
            return false;
        }
        public static bool MailPrestamo_UsuarioAceptado(CorreoResponseFlujo _Correo)
        {
            string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>PRESTAMO APROBADO </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label>" + "ESTIMADO: " + _Correo.UsuarioReporta + "," + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "Se le informa que su solicitud de prestamo con el numero #" + _Correo.Id_Flujo + " ha sido aprobado" + "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Nombre de la Solicitud : " + _Correo.Nombre_Flujo + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";


            if (Correo.fn_Enviar_MailHTML(_Correo.UsuarioReportaMail, "PRESTAMO APROBADO", DetalleHTML, false, null, ""))
            {
                return true;
            }
            return false;
        }
        public static bool MailPrestamo_UsuarioDeclinado(CorreoResponseFlujo _Correo)
        {
            string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>PRESTAMO DECLINADO </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label>" + "ESTIMADO: " + _Correo.UsuarioReporta + "," + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "Se le informa que su solicitud de prestamo con el numero #" + _Correo.Id_Flujo + " ha sido declinada" + "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Nombre de la Solicitud : " + _Correo.Nombre_Flujo + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";


            if (Correo.fn_Enviar_MailHTML(_Correo.UsuarioReportaMail, "PRESTAMO DECLINADO", DetalleHTML, false, null, ""))
            {
                return true;
            }
            return false;
        }
        public static bool Mail_RubroNotificacion(CorreoResponse _Correo)
        {
            string[] Correos = _Correo.AreaMail.Split('/');
            bool x = true;
            foreach (string correo in Correos)
            {
                string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                                + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>NUEVO TICKET </b></td></tr>"
                                + "</tr><tr><td colspan='4' align='center'><label>" + _Correo.Area +" </label>  </td>"
                                + "</tr><tr><td colspan='4' align='center'><label> " + "Se ha creado un nuevo ticket, con numero : #" + _Correo.Numeroticket + " con el cual podras realizar el seguimiento correspondiente." + "</label>  </td>"
                                + "</tr><tr><td colspan='4' align='center'><label> " + "[ " + _Correo.TicketDescripcion + " ]" + "</label>  </td>"
                                + "</tr><tr><td colspan='4'><br><hr /></td>"
                                + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + _Correo.UsuarioReporta + "</h4></td>"
                                + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Mail:" + _Correo.UsuarioReportaMail + "</h4></td>"
                                + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Ext :" + _Correo.UsuarioReportaExtension + "</h4></td>"
                                + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
                                + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";
                Correo.fn_Enviar_MailHTML(correo.Trim(), "NUEVO TICKET", DetalleHTML, _Correo.Archivo == null ? false:true, _Correo.Archivo == null ? null:_Correo.Archivo,_Correo.Nombre_Archivo);
                //bool y = Correo.fn_Enviar_MailHTML(correo.Trim(), "NUEVO TICKET", DetalleHTML, "");
                //if (!y)
                //{
                //    x = false; // Si un correo falla, cambiamos el valor a false
                //}
            }
            return x;
            //string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
            //                + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>NUEVO TICKET </b></td></tr>"
            //                + "</tr><tr><td colspan='4' align='center'><label>" + _Correo.Area + " </label>  </td>"
            //                + "</tr><tr><td colspan='4' align='center'><label> " + "Se ha creado un nuevo ticket, con numero : #" + _Correo.Numeroticket + " con el cual podras realizar el seguimiento correspondiente." + "</label>  </td>"
            //                + "</tr><tr><td colspan='4' align='center'><label> " + "[ "+_Correo.TicketDescripcion +" ]"+ "</label>  </td>"
            //                + "</tr><tr><td colspan='4'><br><hr /></td>"
            //                + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + _Correo.UsuarioReporta + "</h4></td>"
            //                + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Mail:" + _Correo.UsuarioReportaMail + "</h4></td>"
            //                + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Ext :" + _Correo.UsuarioReportaExtension + "</h4></td>"
            //                + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
            //                + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";
            //if (Correo.fn_Enviar_MailHTML(_Correo.AreaMail, "NUEVO TICKET", /*DetalleHTML,*/ ""))
            //{
            //    return true;
            //}
            //return false;
        }
        public static bool Mail_ProcedimientoNotificacion(CorreoResponseFlujo _Correo)
        {
            TicketFlujoRequest ticket = new TicketFlujoRequest();
            List<CorreoResponseFlujo> correos = new List<CorreoResponseFlujo>();
            correos = TareasRepository.Consultacorreo(ticket);
            foreach (var item in correos)
            {
                if (item.Id_Tarea == Persistentes.Id_Tarea && item.Id_Flujo == Persistentes.Id_Flujo)//Esta se usara para cuando se levante nuevo ticket flujo
                {
                    _Correo.Mail_Inv = item.Mail_Inv;
                    _Correo.Nombre_Inv = item.Nombre_Inv;
                    string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>NUEVA SOLICITUD </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label>" + _Correo.Nombre_Inv + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "Se ha creado un nueva solicitud, con numero : #" + _Correo.Id_Flujo + " con el cual podras realizar el seguimiento correspondiente." + "</label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "[ " + _Correo.Descripcion + " ]" + "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Nombre de la solicitud : " + _Correo.Nombre_Flujo + "</h4></td>"
                            //+ "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + _Correo.UsuarioReporta + "</h4></td>"
                            //+ "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Mail:" + _Correo.UsuarioReportaMail + "</h4></td>"
                            //+ "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Ext :" + _Correo.UsuarioReportaExtension + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";
                    Correo.fn_Enviar_MailHTML(_Correo.Mail_Inv, "NUEVA SOLICITUD", DetalleHTML, _Correo.Archivo == null ? false : true, _Correo.Archivo == null ? null : _Correo.Archivo, _Correo.Nombre_Archivo);
                }
            }
            return true;
        }
        public static bool Mail_ProcedimientoNotificacionResuelto(CorreoResponseFlujo _Correo)
        {
            TicketFlujoRequest ticket = new TicketFlujoRequest();
            List<CorreoResponseFlujo> correos = new List<CorreoResponseFlujo>();
            correos = TareasRepository.Consultacorreo(ticket);
            foreach (var item in correos)
            {
                if (item.Id_Tarea == Persistentes.Id_Tarea_Flujo && item.Id_Flujo == Persistentes.Id_Flujo) // esta se usara para el envio de que esta resuelto una parte del colaborador del flujo
                {
                    _Correo.Mail_Inv = item.Mail_Inv;
                    string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>INFORME DE TERMINADO </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "Se informa que el usuario : " + Persistentes.Usuario_Login_Nombre + " a terminado su parte encargada" + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "de la solicitud, con numero : #" + _Correo.Id_Flujo + "." + "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Nombre de la solicitud : " + _Correo.Nombre_Flujo + "</h4></td>"
                            //+ "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + _Correo.UsuarioReporta + "</h4></td>"
                            //+ "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Mail:" + _Correo.UsuarioReportaMail + "</h4></td>"
                            //+ "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Ext :" + _Correo.UsuarioReportaExtension + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";
                    Correo.fn_Enviar_MailHTML(_Correo.Mail_Inv, "INFORME DE TERMINADO", DetalleHTML, false, null, "");

                }
            }
            return true;
        }
        public static bool Mail_RubroNotificacionResuelto(CorreoResponse _Correo)
        {
            string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>TICKET RESUELTO </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label>" + _Correo.Area + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + " #" + _Correo.Numeroticket + "" + "</label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "[ " + _Correo.TicketDescripcion + " ]" + "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + _Correo.UsuarioReporta + "</h4></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Mail:" + _Correo.UsuarioReportaMail + "</h4></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Ext :" + _Correo.UsuarioReportaExtension + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";
            if (Correo.fn_Enviar_MailHTML(_Correo.AreaMail, "NUEVO TICKET", DetalleHTML, false,null,""))
            {
                return true;
            }
            return false;
        }
        public static bool Mail_NuevaAsignacion(CorreoResponse _Correo)
        {
            string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                            + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>NUEVO TICKET ASIGNADO </b></td></tr>"
                            + "</tr><tr><td colspan='4' align='center'><label>" + _Correo.Area + " </label>  </td>"
                            + "</tr><tr><td colspan='4' align='center'><label> " + "#" + _Correo.Numeroticket + " " + "</label>  </td>"
                            + "</tr><tr><td colspan='4'><br><hr /></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + _Correo.UsuarioReporta + "</h4></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Mail:" + _Correo.UsuarioReportaMail + "</h4></td>"
                            + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + "Ext :" + _Correo.UsuarioReportaExtension + "</h4></td>"
                            + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString() + "</h4>"
                            + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC</h4></body></html>";


            if (Correo.fn_Enviar_MailHTML(_Correo.UsuarioAsignadoMail, "NUEVO TICKET ASIGNADO", DetalleHTML, false, null,""))
            {
                return true;
            }
            return false;
        }

        public static bool Main_ActualizacionDocumentoSolicitud(CorreoResponse _Correo,SolicitudCambio _solicitudCambio) 
        {

            string DetalleHTML = "<html><style media='screen'>body{font-family: 'Lucida Console', 'Courier New', monospace;background-color:#d7d5d5;}</style><body><Table style=background-color: '#E3DFD9;' width='100%'><tr><td colspan='4' align='center'><b style='color: #D68910;'>Boletín Informativo</b></td>"
                             + "</tr> <tr><td colspan='4' align='center'><b style='color: #D68910;'>SE CREO UNA SOLICITUD DE CAMBIO </b></td></tr>"
                             + "</tr><tr><td colspan='4' align='center'><label>" + _Correo.Area + " </label>  </td>"
                             + "</tr><tr><td colspan='4' align='center'><label> SOLICITUD   # " + _solicitudCambio.Id_SolicitudCambio+ "</label>  </td>"
                             + "</tr><tr><td colspan='4' align='center'><label>   TICKET # " + _Correo.Numeroticket+ "</label>  </td>"
                             + "</tr><tr><td colspan='4'><br><hr /></td>"
                             + "</tr><tr><td colspan='4' style='text-align: center;'><br>SE CREO UNA SOLICITUD DE CAMBIO PARA SU TICKET, FAVOR DE LLENAR EL FORMATO CORRESPONDIENTE</td>"
                             + "</tr><tr><td colspan='4' style='text-align: center;'><br>EL FORMATO LO PUEDE DESCARGAR DESDE EL TICKET QUE ABRIO</td>"
                             + "</tr><tr><td colspan='4' style='text-align: center;'><br>SEGUIR LO SIGUIENTES PASOS Y LA IMAGEN DE EJEMPLO</td>"
                             + "</tr><tr><td colspan='4' style='text-align: center;'><br>1-ABRIR MODULO DE TICKETS</td>"
                             + "</tr><tr><td colspan='4' style='text-align: center;'><br>2-IR A TICKETS</td>"
                             + "</tr><tr><td colspan='4' style='text-align: center;'><br>3-ABRIR MI TICKET</td>"
                             + "</tr><tr><td colspan='4' style='text-align: center;'><br>4-DESCARGAR EL FORMATO</td>"
                             + "</tr><tr><td colspan='4' style='text-align: center;'><br>5-UNA VEZ LLENO SUBIRLO</td>"
                             + "</tr><tr><td colspan='4' style='text-align: center;'><br><img src=data:image/gif;base64," + Conversor(Properties.Resources.formato_tickets) + " width='1000px' height='500px'/></td>"
                             + "</tr><tr><td colspan='4'><br><hr /></td>"
                             + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>" + _Correo.UsuarioReporta + "</h4></td>"
                             + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>  Mail: " + _Correo.UsuarioReportaMail + " </h4></td>"
                             + "</tr><tr><td colspan='4'><h4 style='' colspan='2' align='center'>  Ext :" + _Correo.UsuarioReportaExtension + " </h4></td>"
                             + "</tr></Table><h4 style='' colspan='2' align='center'>" + DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString() + "</h4>"
                             + "<h4 style='color: #D68910;' colspan='2' align='center'>Agente de Servicios SIAC 2022</h4></body></html>";

            if (Correo.fn_Enviar_MailHTML(_Correo.UsuarioAsignadoMail, "SOLICITUD DE CAMBIO AGREGADA", DetalleHTML,false,null,""))
            {
                return true;
            }
            return false;
        }


        private static string Conversor(Bitmap newImage)
        {
            Bitmap bImage = newImage;  // Your Bitmap Image
            System.IO.MemoryStream ms = new MemoryStream();
            bImage.Save(ms, ImageFormat.Jpeg);
            byte[] byteImage = ms.ToArray();
            return Convert.ToBase64String(byteImage);
        }
    }
}
