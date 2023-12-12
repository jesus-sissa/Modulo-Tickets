using Bunifu.Framework.UI;
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
    public partial class Frm_TicketCategoria : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        int _Id_Rubro = 0;
        Image _img;
        public Frm_TicketCategoria(int Id_Rubro)
        {
            _Id_Rubro = Id_Rubro;
            InitializeComponent();
        }
        void Listar_Rubros()
        {
            FLow.Controls.Clear();
            //CategoriasRequest _CategoriasRequest = new CategoriasRequest();
            foreach (var item in CategoriasRepository.Consultar(new CategoriasRequest { Id_Rubro = _Id_Rubro }))
            {
                Agregar(item.Nombre, item.Id_Categoria.ToString());
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
            Frm_TicketSubCategoria _Sub = new Frm_TicketSubCategoria(Convert.ToInt32(btn.Name), btn.Text);
   

            DialogResult dr = _Sub.ShowDialog();
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
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Frm_TicketCategoria_Load(object sender, EventArgs e)
        {
            Listar_Rubros();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
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
