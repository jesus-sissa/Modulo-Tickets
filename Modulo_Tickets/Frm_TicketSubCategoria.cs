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
    public partial class Frm_TicketSubCategoria : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        int _Id_Categoria = 0;
        string _Nombre = string.Empty;
        Image _img;
        public Frm_TicketSubCategoria(int Id_Categoria, string Nombre)
        {
            _Id_Categoria = Id_Categoria;
            _Nombre = Nombre;
            InitializeComponent();
        }
        void Listar_Rubros()
        {
            Lbl_Nombre.Text = _Nombre + "/";
            FLow.Controls.Clear();
            //CategoriasRequest _CategoriasRequest = new CategoriasRequest();
            foreach (var item in CategoriasRepository.SubConsultar(new CategoriasRequest { Id_Categoria = _Id_Categoria }))
            {
                Agregar(item.Nombre, item.Id_SubCategoria.ToString());
            }
        }
        void Agregar(string Nombre, string Id)
        {

            btn = new BunifuFlatButton();



            btn.ButtonText = "Asignar";
            btn.Name = Id.ToString();
            btn.Iconimage = null;
            btn.Size = new System.Drawing.Size(332, 34);
            btn.TabIndex = 42;
            btn.Text = "  " + Nombre;
            btn.Textcolor = System.Drawing.Color.White;

            FLow.Controls.Add(btn);
            btn.Click += new EventHandler(Cliq);

        }
        private void Cliq(Object sender, EventArgs e)
        {
            btn = new BunifuFlatButton();
            btn = (BunifuFlatButton)sender;

            Frm_NivelServicio frm = new Frm_NivelServicio(Persistentes.Numero_Ticket,_Id_Categoria,Convert.ToInt32(btn.Name),_Nombre,btn.Text);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //Listar_Rubros();
                //this.DialogResult = DialogResult.OK;
                //this.Refresh();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

            //Frn_TicketNew frm = new Frn_TicketNew(_Nombre+"/"+btn.Text,_img);
            ////frm.Btn_Rubro.Image = btn.Image;
            ////frm.Btn_Rubro.LabelText = btn.LabelText;
            //frm.Id_Rubro = Convert.ToInt32(btn.Name);

            //DialogResult dr = frm.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    //Listar_Rubros();
            //}
            //else
            //{
            //    this.DialogResult = DialogResult.Cancel;
            //    this.Close();
            //}
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Frm_TicketSubCategoria_Load(object sender, EventArgs e)
        {
            Listar_Rubros();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void FLow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
