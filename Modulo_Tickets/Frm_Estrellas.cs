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
    public partial class Frm_Estrellas : Form
    {
        bool IsAdmin;
        public Frm_Estrellas(bool _IsAdmin)
        {
            InitializeComponent();
            IsAdmin = _IsAdmin;
        }

        private void Frm_Estrellas_Load(object sender, EventArgs e)
        {
            Txt_Descripcion.Focus();
        }
      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Rat_Estrellas_onValueChanged_1(object sender, EventArgs e)
        {
            Txt_Descripcion.Focus();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(Persistentes.Tipo_tree == 1)
            {
                if (Txt_Descripcion.Text.Trim().Length >= 20 && Rat_Estrellas.Value > 0)
                {
                    string _Descripcion;
                    if (IsAdmin)
                    {
                        _Descripcion = Persistentes.Usuario_Login_Nombre + ":" + "El ticket ha sido cerrado [ADMIN][CERRADO]." + Txt_Descripcion.Text.Trim();
                    }
                    else
                    {
                        _Descripcion = Persistentes.Usuario_Login_Nombre + ":" + "El ticket ha sido cerrado [CERRADO]." + Txt_Descripcion.Text.Trim();
                    }
                    //Persistentes.Estrellas = Rat_Estrellas.Value;
                    //Persistentes.Comentarios_Estrellas = Txt_Descripcion.Text.Trim();
                    //this.Close();              
                    TicketRequest Ticket = new TicketRequest
                    {
                        Id_Ticket = Persistentes.Numero_Ticket,
                        Descripcion = _Descripcion,
                        Estrellas = Rat_Estrellas.Value

                    };
                    TicketRepository.GuardarSprint(Ticket);
                    TicketRepository.Ticket_CerrarPorUsuario(Ticket);
                    Persistentes.Mensaje("El ticket con #" + Persistentes.Numero_Ticket + " se a cerrado correctamente.", 2);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (Txt_Descripcion.Text.Trim().Length < 20)
                {
                    Persistentes.Mensaje("Agrega un comentario mas detallado.", 2);
                }
                else if (Rat_Estrellas.Value == 0)
                {
                    Persistentes.Mensaje("Califica la atencion del ticket con una estrella.", 2);
                }
            }
            else
            {
                if (Txt_Descripcion.Text.Trim().Length >= 20 && Rat_Estrellas.Value > 0)
                {
                    string _Descripcion;
                    _Descripcion = "El Procedimiento ha sido cerrado [CERRADO]." + Txt_Descripcion.Text.Trim();
                    //if (IsAdmin)
                    //{
                    //    _Descripcion = "El Flujo ha sido cerrado [ADMIN][CERRADO]." + Txt_Descripcion.Text.Trim();
                    //}
                    //else
                    //{
                    //    _Descripcion = "El Flujo ha sido cerrado [CERRADO]." + Txt_Descripcion.Text.Trim();
                    //}
                    //Persistentes.Estrellas = Rat_Estrellas.Value;
                    //Persistentes.Comentarios_Estrellas = Txt_Descripcion.Text.Trim();
                    //this.Close();
                    TicketFlujoRequest ticketFlujo = new TicketFlujoRequest
                    {
                        Id_Flujo = Persistentes.Id_Tarea,
                        Descripcion = _Descripcion,
                        Estrellas = Rat_Estrellas.Value
                    };
                    TareasRepository.GuardarSprintFlujo(ticketFlujo);
                    TareasRepository.Flujo_CerrarPorUsuario(ticketFlujo);
                    Persistentes.Mensaje("El Procedimiento con #" + Persistentes.Id_Tarea + " se a cerrado correctamente.", 2);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (Txt_Descripcion.Text.Trim().Length < 20)
                {
                    Persistentes.Mensaje("Agrega un comentario mas detallado.", 2);
                }
                else if (Rat_Estrellas.Value == 0)
                {
                    Persistentes.Mensaje("Califica la atencion del ticket con una estrella.", 2);
                }
            }
        }

        private void Txt_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
