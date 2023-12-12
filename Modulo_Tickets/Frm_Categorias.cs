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
    public partial class Frm_Categorias : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        int _Id_Rubro = 0;
        public Frm_Categorias(int Id_Rubro)
        {
            _Id_Rubro = Id_Rubro;
            InitializeComponent();
        }
        void Listar_Rubros()
        {
            FLow.Controls.Clear();
            //CategoriasRequest _CategoriasRequest = new CategoriasRequest();
            foreach (var item in CategoriasRepository.Consultar(new CategoriasRequest { Id_Rubro=_Id_Rubro}))
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
            Frm_SubCategorias _Sub = new Frm_SubCategorias(Convert.ToInt32(btn.Name),btn.Text);
            _Sub.ShowDialog();
        }

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            Listar_Rubros();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_NuevoRubro_Click(object sender, EventArgs e)
        {

            Frm_CategoriasAdd _Categoria = new Frm_CategoriasAdd(_Id_Rubro, 0,"Categoria");
           
            DialogResult dr = _Categoria.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Listar_Rubros();
            }
        }

        private void FLow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
