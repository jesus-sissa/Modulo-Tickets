using Bunifu.Framework.UI;
using Modulo_Tickets.Model.Repository;
using Modulo_Tickets.Properties;
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
using  Modulo_Tickets.Model;

namespace Modulo_Tickets
{
    public partial class Frm_NuevoTicket : Form
    {
        BunifuTileButton btn = new Bunifu.Framework.UI.BunifuTileButton();
        public Frm_NuevoTicket()
        {
            InitializeComponent();
        }        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_NuevoTicket_Load(object sender, EventArgs e)
        {
                Listar_Rubros();
        }
        void Listar_Rubros()
        {
            FLow.Controls.Clear();
            RubroRequest RubroRequest = new RubroRequest();

            foreach (var item in RubroRepository.ConsultarRubros(RubroRequest))
            {
                Agregar(item.Nombre, item.Id_Rubro.ToString(), item.Img);
            }
        }
        void Agregar(string Nombre, string Id, Image Img)
        {
            btn = new BunifuTileButton();
            btn.Image = Img;
            btn.ImagePosition = 10;
            btn.ImageZoom = 50;
            btn.LabelPosition = 60;
            btn.LabelText = Nombre;
            btn.Name = Id;
            btn.Size = new System.Drawing.Size(120, 120);
            btn.TabIndex = Convert.ToInt32(Id);
            FLow.Controls.Add(btn);
            btn.Click += new EventHandler(Cliq);

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
            btn.Size = new System.Drawing.Size(170, 140);
            btn.TabIndex = Convert.ToInt32(Id);
            FLow.Controls.Add(btn);
            btn.Click += new EventHandler(Cliq);

        }
        private void Cliq(Object sender, EventArgs e)
        {
            Persistentes.Id_ClienteExterno = 0;
            btn = new BunifuTileButton();
            btn = (BunifuTileButton)sender;
            Frn_TicketNew frm = new Frn_TicketNew();
            frm.Btn_Rubro.Image = btn.Image;
            frm.Btn_Rubro.LabelText = btn.LabelText;
            frm.Id_Rubro = Convert.ToInt32(btn.Name);
            Persistentes.numdoc = frm.Id_Rubro;
            frm.ShowDialog();

            //Persistentes.Nombre_Rubro = btn.LabelText;
            //Frm_TicketCategoria _frm = new Frm_TicketCategoria(Convert.ToInt32( btn.Name),btn.Image);

            //Persistentes.Id_RubroSeleccionado = Convert.ToInt32(btn.Name);
            //DialogResult dr = _frm.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    Listar_Rubros();
            //}
            //else
            //{
            //    this.Close();
            //}
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Alerta_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FLow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
