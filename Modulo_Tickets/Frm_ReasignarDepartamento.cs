using Bunifu.Framework.UI;
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
    public partial class Frm_ReasignarDepartamento : Form
    {
        bool accion = false;
        BunifuTileButton btn = new Bunifu.Framework.UI.BunifuTileButton();
        public Frm_ReasignarDepartamento()
        {
            InitializeComponent();
        }
        void Listar_Rubros()
        {
            Flow.Controls.Clear();
            RubroRequest RubroRequest = new RubroRequest();

            foreach (var item in RubroRepository.ConsultarRubros(RubroRequest))
            {
                Agregar(item.Nombre, item.Id_Rubro.ToString(), item.Img);
            }
        }
        void Agregar(string Nombre, string Id, byte[] Img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(Img);
            btn = new BunifuTileButton();
            btn.Image = Image.FromStream(ms);
            btn.ImagePosition = 10;
            btn.ImageZoom = 50;
            btn.LabelPosition = 60;
            btn.LabelText = Nombre;
            btn.Font = new System.Drawing.Font("Century Gothic", 7.75F);
            btn.Name = Id;
            btn.Size = new System.Drawing.Size(170, 135);
            btn.TabIndex = Convert.ToInt32(Id);            
            Flow.Controls.Add(btn);
            btn.Click += new EventHandler(Cliq);
        }
        private void Cliq(Object sender, EventArgs e)
        {
            btn = new BunifuTileButton();
            btn = (BunifuTileButton)sender;
            Persistentes.Id_RubroSeleccionado = Convert.ToInt32(btn.Name);
            if(accion)
            {
               
                Activar(btn.Name, accion);
                accion = false;
            }
            else
            {
                
                Activar(btn.Name, accion);
                accion = true;
            }
        }
        void Activar(string nombre,bool Accion)
        {
            if (accion)
            {
                foreach (Control c in Flow.Controls)
                { 
                    c.Visible = true;
                }
                Btn_Asignar.Enabled = false;
                Lbl_Descripcion.Visible = false;
                Txt_Descripcion.Visible = false;
            }
            else
            {
                foreach (Control c in Flow.Controls)
                {
                    if (c.Name != nombre)
                    {
                        c.Visible = false;
                    }
                }
                Btn_Asignar.Enabled = true;
                Lbl_Descripcion.Visible = true;
                Txt_Descripcion.Visible = true;
                Txt_Descripcion.Focus();
            }
        }

        private void Frm_ReasignarDepartamento_Load(object sender, EventArgs e)
        {
            Listar_Rubros();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Asignar_Click(object sender, EventArgs e)
        {
            if(Txt_Descripcion.Text == string.Empty || Txt_Descripcion.Text.Length <50)
            {
                Persistentes.Mensaje("Ingrese una descripción mas completa.", 1);
                Txt_Descripcion.Focus();
            }
            else
            {
                TicketRequest _Ticket = new TicketRequest { Id_Ticket = Persistentes.Numero_Ticket, Id_Rubro = Persistentes.Id_RubroSeleccionado, Descripcion = Persistentes.Usuario_Login_Nombre + " Reasigno el Ticket: " + Txt_Descripcion.Text };
                TicketRepository.Ticket_ReasignarDepartamento(_Ticket);
                TicketRepository.GuardarSprint(_Ticket);
                Persistentes.Mensaje("La reaciongacion se realizo correctamente.", 2);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Flow_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Descripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
