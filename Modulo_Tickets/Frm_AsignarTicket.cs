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
using Modulo_Tickets.Model.Repository;
using Modulo_Tickets.Model;
using System.IO;
using System.Diagnostics;

namespace Modulo_Tickets
{
    public partial class Frm_AsignarTicket : Form
    {
        public bool active_solicitud = false;
        public string vSolicitudCambio = null;
        RadioButton btn = new RadioButton();
        bool IsAdmin;
        private SolicitudCambio _solicitudCambio;
        private SolicitudCambioRepository _repositorySolicitud;
        public Frm_AsignarTicket(bool _IsAdmin)
        {
            InitializeComponent();
            IsAdmin = _IsAdmin;

        }

        private void Frm_AsignarTicket_Load(object sender, EventArgs e)
        {
            if(Persistentes.General)
            {
                Btn_Siguiente.Enabled = true;
            }
            _repositorySolicitud = new SolicitudCambioRepository();
            Btn_Traspaso.Enabled = true; 
            Lbl_AsignacionN.Text = Persistentes.Nombre_UsuarioA;
            Lbl_NumeroTicket.Text = Persistentes.Numero_Ticket.ToString();
            //Persistentes.Id_UsuarioA = 0;
            //Ticket_VerificarAsignacion();
            Controles();
            if (active_solicitud)
            {
                lbl_text_solicitud.Visible = true;
                lbl_numero_Solicitud.Visible = true;
            }

            if (vSolicitudCambio != null && vSolicitudCambio !="")
            {
                _solicitudCambio = _repositorySolicitud.Get_Solicitud(vSolicitudCambio);
                if (_solicitudCambio != null)
                {
                    lbl_numero_Solicitud.Text = _solicitudCambio.Id_SolicitudCambio;
                }
            }
           
        }

        void Controles()
        {
            if(Persistentes.Status_TickteStaff=="N")
            {
                Btn_Asignar.Enabled = true;
                Btn_Rechazar.Enabled = true;
                //Btn_Traspaso.Enabled = true;
                //Btn_Prioridad.Enabled = true;
            }
            else if(Persistentes.Status_TickteStaff == "AS")
            {
                Btn_Finalizar.Enabled = true;
                Btn_Avance.Enabled = true;
                //Btn_Prioridad.Enabled = true;
                Btn_Reasignar.Enabled = true;
            }
            else if (Persistentes.Status_TickteStaff == "F")
            {
                Btn_CerraTicket.Enabled = true;
                Btn_Traspaso.Enabled = false;
            }
            else if (Persistentes.Status_TickteStaff == "CE")
            {
                Btn_Traspaso.Enabled = false;
            }
            else if (Persistentes.Status_TickteStaff == "R")
            {
                Btn_Traspaso.Enabled = false;
            }
            else if (Persistentes.Status_TickteStaff == "AC")
            {
                Btn_Finalizar.Enabled = true;
                Btn_Avance.Enabled = true;
                //Btn_Prioridad.Enabled = true;
                Btn_Reasignar.Enabled = true;
            }
            //if (Persistentes.Ticket_Finalizado )
            //{
            //    Btn_Atender.Enabled = false;
            //    Btn_Asignar.Enabled = false;
            //    Btn_CerraTicket.Enabled = true;
            //}
            //if (Persistentes.Ticket_Cerrado || Persistentes.Ticket_Rechazado)
            //{
            //    Btn_Atender.Visible = false;
            //    Btn_Asignar.Enabled = false;
            //    Btn_CerraTicket.Enabled = false;
            //}
        }
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            if(this.DialogResult==DialogResult.None)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }
        //void Ticket_VerificarAsignacion()
        //{
        //    TicketRequest Ticket = new TicketRequest {
        //        Id_Ticket = Persistentes.Numero_Ticket
        //    };
        //    if (!Persistentes.Ticket_Cerrado)
        //    {
        //        Btn_Atender.Visible = TicketRepository.ConsultarTicket_UsuarioAsignado(Ticket);
        //        Btn_Enviar.Visible = Btn_Atender.Visible;
        //    }
        //    else
        //    {
        //        Btn_Atender.Visible = false;
        //        Btn_Enviar.Visible = false;
        //    }
        //}
        void Enviar_Correo(int Id_Ticket)
        {

            CorreoResponse Seguimiento;
            TicketRequest Ticket = new TicketRequest
            {
                Id_Ticket = Id_Ticket
            };
            try
            {
                Seguimiento = TicketRepository.Mail_Seguimiento(Ticket);

                Correo.Mail_NuevaAsignacion(Seguimiento);
            }
            catch (Exception ex)
            {
                Persistentes.Mensaje("No se puedo enviar el correo.");
            }

        }
        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            if (Persistentes.Id_UsuarioA != 0)
            {
                Persistentes.Mensaje("El ticket ya se encuentra asignado.",1);                
            }
            else
            {
                TicketRequest Ticket = new TicketRequest { Id_Ticket = Persistentes.Numero_Ticket };
                if (TicketRepository.ConsultarTickets_NivelServicioYCategoria(Ticket))
                {
                    Frm_Usuarios usr = new Frm_Usuarios();
                    DialogResult dr = usr.ShowDialog();
                    if (dr == DialogResult.OK && Persistentes.Id_UsuarioA != 0)
                    {
                        //Ticket = new TicketRequest
                        //{
                        //    Id_Ticket = Persistentes.Numero_Ticket,
                        //    Descripcion = "Ticket asignado a: " + Persistentes.Nombre_UsuarioA,

                        //};
                        Ticket.Descripcion = "Ticket asignado a: " + Persistentes.Nombre_UsuarioA;
                        TicketRepository.GuardarSprint(Ticket);

                        //Ticket = new TicketRequest
                        //{
                        //    Id_Ticket = Persistentes.Numero_Ticket,
                        //    Id_UsuarioA = Persistentes.Id_UsuarioA,
                        //    Status = "AS"

                        //};
                        Ticket.Id_UsuarioA = Persistentes.Id_UsuarioA;
                        Ticket.Status = "AS";
                        TicketRepository.AsignarTicket(Ticket);
                        Lbl_AsignacionN.Text = Persistentes.Nombre_UsuarioA;
                        Enviar_Correo(Ticket.Id_Ticket);
                        Persistentes.Mensaje("El ticket se asignó correctamente.", 1);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    //Persistentes.Mensaje("El ticket no tiene asignado prioridad o categoria.", 2);

                    //Persistentes.Nombre_Rubro = btn.LabelText;
                    Frm_TicketCategoria _frm = new Frm_TicketCategoria(Persistentes.Id_Rubro);

                    //Persistentes.Id_RubroSeleccionado = Convert.ToInt32(btn.Name);
                    DialogResult dr = _frm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        //Listar_Rubros();
                    }
                    else
                    {
                       // this.Close();
                    }
                }

            }

            ////if (Persistentes.Id_UsuarioA != 0)
            ////{
            ////    TicketRequest Ticket = new TicketRequest
            ////    {
            ////        Id_Ticket = Persistentes.Numero_Ticket,
            ////        Descripcion = "Ticket asignado a: " + Lbl_AsignacionN.Text

            ////    };
            ////    TicketRepository.GuardarSprint(Ticket);

            ////    Ticket = new TicketRequest
            ////    {
            ////        Id_Ticket = Persistentes.Numero_Ticket,
            ////        Id_UsuarioA = Persistentes.Id_UsuarioA,
            ////        Status = "AS"

            ////    };
            ////    TicketRepository.AsignarTicket(Ticket);
            ////    Mensaje("El ticket se asigno correctamente.");
            ////    Persistentes.Id_UsuarioA = 0;
            ////    this.Close();
            ////}
            ////else
            ////{
            ////    Mensaje("Seleccione un usuario.");
            ////    Persistentes.Id_UsuarioA = 0;
            ////    Persistentes.Nombre_UsuarioA = string.Empty;
            ////    Frm_Usuarios usr = new Frm_Usuarios();
            ////    usr.ShowDialog();
            ////    if (Persistentes.Id_UsuarioA != 0)
            ////    {
            ////        Lbl_AsignacionN.Text = Persistentes.Nombre_UsuarioA;
            ////        Btn_Atender.Enabled = false;
            ////    }
            ////    else
            ////    {
            ////        Lbl_AsignacionN.Text = string.Empty;
            ////        Btn_Atender.Enabled = true;
            ////    }
            ////}

        }
        void Nueva_Asignacion()
        {


        }
        void Mensaje(String Texto, int Time = 2)
        {
            Frm_Mensaje msg = new Frm_Mensaje();
            msg.Txt_Mensaje.Text = Texto;
            msg.time = Time;
            msg.ShowDialog();
        }

        

        private void Btn_Atender_Click(object sender, EventArgs e)
        {
            //Frm_SoporteD Detalle = new Frm_SoporteD(IsAdmin);
            //Detalle.Txt_Descripcion.Text = Txt_Descripcion.Text;
            //DialogResult dr= Detalle.ShowDialog();
            //if(dr==DialogResult.OK)
            //{
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            Frm_ReasignarDepartamento frm = new Frm_ReasignarDepartamento();
            DialogResult dr= frm.ShowDialog();
            if(dr==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Btn_Avances_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 1;
            Frm_TreeView frm = new Frm_TreeView();
            frm.ShowDialog();
        }

        private void Btn_CerraTicket_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 1;
            Frm_Estrellas frm = new Frm_Estrellas(true);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Btn_Traspaso_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Rechazar_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 1;
            Frm_Comentarios frm = new Frm_Comentarios(3, IsAdmin);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 1;
            Frm_Comentarios frm = new Frm_Comentarios(2, IsAdmin);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Btn_Avance_Click(object sender, EventArgs e)
        {
            this.Opacity = 50;
            Persistentes.Tipo_tree = 1;
            Persistentes.Numero_Ticket =Convert.ToInt32( Lbl_NumeroTicket.Text);
            Frm_Comentarios frm = new Frm_Comentarios(1, IsAdmin);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
            
        }

        private void Btn_Imagenes_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 1;
            Frm_Imagenes frm = new Frm_Imagenes(Persistentes.Numero_Ticket,0); //VERDOCUMENTOS ES FRM_IMAGENES
            frm.ShowDialog();

        }

        private void Btn_Reasignar_Click(object sender, EventArgs e)
        {                        
                TicketRequest Ticket = new TicketRequest { Id_Ticket = Persistentes.Numero_Ticket };
                Frm_Usuarios usr = new Frm_Usuarios();
                DialogResult dr = usr.ShowDialog();
                if (dr == DialogResult.OK && Persistentes.Id_UsuarioA != 0)
                {
                Persistentes.Tipo_tree = 1;
                Frm_Comentarios frm = new Frm_Comentarios(6, IsAdmin);
                    DialogResult drr = frm.ShowDialog();
                    if (drr == DialogResult.OK)
                    {

                        Ticket.Descripcion = "Ticket reasignado a [ASIGNADO]." + Persistentes.Nombre_UsuarioA;
                        TicketRepository.GuardarSprint(Ticket);


                        Ticket.Id_UsuarioA = Persistentes.Id_UsuarioA;
                        Ticket.Status = "AS";
                        TicketRepository.AsignarTicket(Ticket);
                        Lbl_AsignacionN.Text = Persistentes.Nombre_UsuarioA;
                        Enviar_Correo(Ticket.Id_Ticket);
                        Persistentes.Mensaje("El ticket se reasigno correctamente.", 1);
                        this.DialogResult = DialogResult.OK;
                    }
                }
               
            
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {      

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Lbl_NumeroTicket_Click(object sender, EventArgs e)
        {

        }

        //private void Btn_Prioridad_Click(object sender, EventArgs e)
        //{
        //    Frm_NivelServicio frm = new Frm_NivelServicio(Convert.ToInt32(Persistentes.Numero_Ticket));
        //    DialogResult dr= frm.ShowDialog();
        //    if(dr==DialogResult.OK)
        //    {
        //        this.Close();
        //    }
        //}
    }
}
