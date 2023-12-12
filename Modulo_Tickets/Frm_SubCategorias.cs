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
    public partial class Frm_SubCategorias : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        int _Id_Categoria = 0;
        string _Nombre = string.Empty;
        public Frm_SubCategorias(int Id_Categoria,string Nombre)
        {
            _Id_Categoria = Id_Categoria;
            _Nombre = Nombre;
            InitializeComponent();
        }
        void Listar_Rubros()
        {
            Lbl_Nombre.Text = _Nombre+"/";
            FLow.Controls.Clear();
            //CategoriasRequest _CategoriasRequest = new CategoriasRequest();
            foreach (var item in CategoriasRepository.SubConsultar(new CategoriasRequest { Id_Categoria = _Id_Categoria }))
            {
                Agregar(item.Nombre, item.Id_Rubro.ToString());
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

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_SubCategorias_Load(object sender, EventArgs e)
        {
            Listar_Rubros();
        }

        private void Btn_NuevoRubro_Click(object sender, EventArgs e)
        {
            Frm_CategoriasAdd _Categoria = new Frm_CategoriasAdd(0,_Id_Categoria,"SubCategoria");

            DialogResult dr = _Categoria.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Listar_Rubros();
            }
        }
    }
}
