using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_Comentarios : Form
    {
        int Tipo = 0;
        bool IsAdmin;
        string NombreDep;
        public Frm_Comentarios(int _Tipo, bool _IsAdmin)
        {
            InitializeComponent();
            Tipo = _Tipo;
            IsAdmin = _IsAdmin;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if(Persistentes.Tipo_tree == 2)
            {
                if (Tipo == 1)//Tipo Actividad
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 5)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 1);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        DepartamentosRequest _DepartamentoRequest = new DepartamentosRequest();
                        foreach (var item in DepartamentosRepository.ConsultaDepto(_DepartamentoRequest))
                        {
                            if(item.Id_Departamento == Persistentes.UsuarioLogin_IdDepartamento)
                            {
                                NombreDep = item.Nombre;
                            }
                        }
                        TicketFlujoRequest Ticket = new TicketFlujoRequest
                        {
                            Id_Flujo = Persistentes.Id_Tarea,
                            Descripcion = NombreDep + ":" + Persistentes.Usuario_Login_Nombre + ":" + Txt_Cometarios.Text 
                        };
                        TareasRepository.GuardarSprintFlujo(Ticket);
                        Persistentes.Mensaje("Actividad agregada correctamente.", 1);
                       // Enviar_CorreoAvance();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else if (Tipo == 2) //Tipo Finalizar
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 5)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 1);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        this.Enabled = false;
                        string _Descripcion;
                        //if (IsAdmin)
                        //{
                        //    _Descripcion = " El ticket se resolvió [RESUELTO]. " + Txt_Cometarios.Text;
                        //}
                        //CorreoResponse Seguimiento;
                        DepartamentosRequest _DepartamentoRequest = new DepartamentosRequest();
                        foreach (var item in DepartamentosRepository.ConsultaDepto(_DepartamentoRequest))
                        {
                            if (item.Id_Departamento == Persistentes.UsuarioLogin_IdDepartamento)
                            {
                                NombreDep = item.Nombre;
                            }
                        }
                        TicketFlujoRequest Ticket = new TicketFlujoRequest
                        {
                            Id_Flujo = Persistentes.Id_Tarea,
                            Descripcion = NombreDep + ":" + Persistentes.Usuario_Login_Nombre + ":" + " El Procedimiento se resolvió [RESUELTO]. " + Txt_Cometarios.Text
                        };
                        TareasRepository.GuardarSprintFlujo(Ticket);
                        //try
                        //{
                        //    Seguimiento = TicketRepository.Mail_Seguimiento(_Ticket);
                        //    Correo.Mail_RubroNotificacionResuelto(Seguimiento); //Cuando se finaliza el ticket se envia un correo de notificacion al Admin
                        //    Enviar_Correo();
                        //    Persistentes.Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se resolvió correctamente.", 1);
                        //}
                        //catch (Exception ex)
                        //{
                        //    Persistentes.Mensaje("No se puedo enviar el correo.");
                        //}
                        int ss = Persistentes.Id_Tarea;
                        TicketFlujoRequest ticket = new TicketFlujoRequest();
                        List<TicketFlujoResponse> ticketFlujos = new List<TicketFlujoResponse>();
                        ticketFlujos = TareasRepository.ConsultarFlujoGeneral(ticket);
                        foreach (var item in ticketFlujos)
                        {
                            if (Convert.ToInt32(item._Id_Flujo) == Persistentes.Id_Tarea)
                            {
                                if (item._Status == "RESUELTO")
                                {
                                    Enviar_Correo_Usuario();
                                }
                            }
                        }
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }
            }
            else
            {
                if (Tipo == 1)//Tipo Actividad
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 50)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 1);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        TicketRequest Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket,
                            Descripcion = Persistentes.Usuario_Login_Nombre + ":" + Txt_Cometarios.Text
                        };
                        TicketRepository.GuardarSprint(Ticket);
                        Persistentes.Mensaje("Actividad agregada correctamente.", 1);
                        Enviar_CorreoAvance();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else if (Tipo == 2) //Tipo Finalizar
                {

                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 50)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 1);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        this.Enabled = false;
                        string _Descripcion;
                        if (IsAdmin)
                        {
                            _Descripcion = " El ticket se resolvió [ADMIN][RESUELTO]. " + Txt_Cometarios.Text;
                        }
                        else
                        {
                            _Descripcion = Persistentes.Usuario_Login_Nombre + ":" + " El ticket se resolvió [RESUELTO]. " + Txt_Cometarios.Text;
                        }

                        CorreoResponse Seguimiento;
                        TicketRequest _Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket
                        };

                        TicketRequest Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket,
                            Descripcion = _Descripcion

                        };
                        TicketRepository.GuardarSprint(Ticket);
                        TicketRepository.Ticket_Finalizar(Ticket);
                        try
                        {
                            Seguimiento = TicketRepository.Mail_Seguimiento(_Ticket);
                            Correo.Mail_RubroNotificacionResuelto(Seguimiento); //Cuando se finaliza el ticket se envia un correo de notificacion al Admin
                            Enviar_Correo();
                            Persistentes.Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se resolvió correctamente.", 1);
                        }
                        catch (Exception ex)
                        {
                            Persistentes.Mensaje("No se puedo enviar el correo.");
                        }
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }
                else if (Tipo == 3)//Tipo Rechazo solo ADMIN
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 50)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 1);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        TicketRequest Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket,
                            Descripcion = Persistentes.Usuario_Login_Nombre + ":" + " El ticket se rechazo [RECHAZADO]." + Txt_Cometarios.Text

                        };
                        TicketRepository.GuardarSprint(Ticket);
                        TicketRepository.Ticket_Rechazar(Ticket);
                        Persistentes.Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se rechazo: ", 1);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else if (Tipo == 4) //Tipo Regresar
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 50)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 2);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        TicketRequest Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket,
                            Descripcion = Persistentes.Usuario_Login_Nombre + ":" + " El ticket ha sido regresado [NUEVO]. " + Txt_Cometarios.Text

                        };
                        TicketRepository.GuardarSprint(Ticket);
                        TicketRepository.Ticket_RegresarAsignacion(Ticket);
                        Persistentes.Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se ha regresado correctamente.", 2);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }


                }
                else if (Tipo == 5) //Tipo Recibir
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 50)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 2);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        TicketRequest Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket,
                            Descripcion = Persistentes.Usuario_Login_Nombre + ":" + " El ticket ha sido recibido correctamente [ACTUANDO]. " + Txt_Cometarios.Text,
                            Id_UsurioRecibe = Persistentes.Usuario_Login,
                            Status = "AC"

                        };
                        TicketRepository.GuardarSprint(Ticket);
                        TicketRepository.Ticket_RecibirAsignacion(Ticket);
                        Persistentes.Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se ha recibido correctamente.", 2);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }


                }
                else if (Tipo == 6) //Tipo Reasignar
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 50)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 2);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        TicketRequest Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket,
                            Descripcion = Persistentes.Usuario_Login_Nombre + ":" + " El ticket ha sido reasignado correctamente [ASIGNADO]. " + Txt_Cometarios.Text,
                            Id_UsurioRecibe = Persistentes.Usuario_Login,
                            Status = "AS"

                        };
                        TicketRepository.GuardarSprint(Ticket);
                        //TicketRepository.Ticket_RecibirAsignacion(Ticket);
                        //Persistentes.Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se ha recibido correctamente.", 2);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }


                }
                else if (Tipo == 7) //Tipo Abrir Proveedor 
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 50)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 2);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        TicketRequest Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket,
                            Descripcion = " El Ticket proveedor ha sido abierto correctamente. " + Txt_Cometarios.Text,
                            Id_UsurioRecibe = Persistentes.Usuario_Login,
                            Status = "AS"

                        };
                        TicketRepository.GuardarSprint(Ticket);
                        //TicketRepository.Ticket_RecibirAsignacion(Ticket);
                        //Persistentes.Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se ha recibido correctamente.", 2);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }


                }
                else if (Tipo == 8) //Tipo Cerrar Proveedor
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 50)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 2);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        TicketRequest Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket,
                            Descripcion = " El Ticket proveedor ha sido cerrado correctamente. " + Txt_Cometarios.Text,
                            Id_UsurioRecibe = Persistentes.Usuario_Login,
                            Status = "AS"

                        };
                        TicketRepository.GuardarSprint(Ticket);
                        //TicketRepository.Ticket_RecibirAsignacion(Ticket);
                        //Persistentes.Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se ha recibido correctamente.", 2);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else if (Tipo == 9) //Tipo Cerrar Proveedor
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 50)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 2);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        TicketRequest Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket,
                            Descripcion = Persistentes.Usuario_Login_Nombre + ":" + " La Recategorizacion ha sido correctamente. " + Txt_Cometarios.Text,
                            Id_UsurioRecibe = Persistentes.Usuario_Login,
                            //Status = "AS"

                        };
                        TicketRepository.GuardarSprint(Ticket);
                        //TicketRepository.Ticket_RecibirAsignacion(Ticket);
                        //Persistentes.Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se ha recibido correctamente.", 2);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else if (Tipo == 10) //Tipo Cerrar Proveedor
                {
                    if (Txt_Cometarios.Text.Trim() == string.Empty || Txt_Cometarios.Text.Length < 50)
                    {
                        Persistentes.Mensaje("Ingrese una descripción mas completa.", 2);
                        Txt_Cometarios.Focus();
                    }
                    else
                    {
                        TicketRequest Ticket = new TicketRequest
                        {
                            Id_Ticket = Persistentes.Numero_Ticket,
                            Descripcion = Persistentes.Usuario_Login_Nombre + ":" + " El ticket ha sido regresado [INCOMPLETO]. " + Txt_Cometarios.Text

                        };
                        TicketRepository.GuardarSprint(Ticket);
                        TicketRepository.RegresarTicket(new TicketRequest { Id_Ticket = Persistentes.Numero_Ticket });
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            
        }
        void Enviar_Correo()
        {
            CorreoResponse Seguimiento;
            TicketRequest Ticket = new TicketRequest
            {
                Id_Ticket = Persistentes.Numero_Ticket
            };
            try
            {
                Seguimiento = TicketRepository.Mail_Seguimiento(Ticket);
                Correo.Mail_Finalizado(Seguimiento.Numeroticket, "ESTIMADO: " + Seguimiento.UsuarioReporta + ",", Seguimiento.UsuarioReportaMail, Seguimiento.Area, Seguimiento.AreaMail, Seguimiento.AreaExtension);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se puedo enviar el corre ");
            }

        }
        void Enviar_CorreoAvance ()
        {
            CorreoResponse Seguimiento;
            TicketRequest Ticket = new TicketRequest
            {
                Id_Ticket = Persistentes.Numero_Ticket
            };
            try
            {
                Seguimiento = TicketRepository.Mail_Seguimiento(Ticket);
                Seguimiento.TicketDescripcion = Txt_Cometarios.Text;
                Correo.Mail_Avance(Seguimiento.Numeroticket, Seguimiento.TicketDescripcion, "ESTIMADO: " + Seguimiento.UsuarioReporta + ",", Seguimiento.UsuarioReportaMail, Seguimiento.Area, Seguimiento.AreaMail, Seguimiento.AreaExtension);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se puedo enviar el corre ");
            }

        }
        void Enviar_Correo_Usuario()
        {
            CorreoResponseFlujo Seguimiento;
            int ss = Persistentes.Id_Tarea;
            TicketFlujoRequest Ticket = new TicketFlujoRequest { Id_Flujo = Persistentes.Id_Tarea };
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
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Cometarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Comentarios_Load(object sender, EventArgs e)
        {

        }
    }
}
