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
using Modulo_Tickets.Model;

namespace Modulo_Tickets
{
    public partial class Frm_ClientesHijos : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        int _IdPadre;
        public Frm_ClientesHijos(int Id_Padre)
        {
            _IdPadre = Id_Padre;
            InitializeComponent();
        }
        void Listar_Rubros()
        {
            Flow.Controls.Clear();
            //CategoriasRequest _CategoriasRequest = new CategoriasRequest();
            foreach (var item in ClienteRepository.ConsultarHijos(new ClientesRequest { Id_Padre=_IdPadre}))
            {
                Agregar(item.Nombre, item.Id_Cliente.ToString());
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

            Flow.Controls.Add(btn);
            btn.Click += new EventHandler(Cliq);

        }
        private void Cliq(Object sender, EventArgs e)
        {
            btn = new BunifuFlatButton();
            btn = (BunifuFlatButton)sender;
            Persistentes.Id_ClienteExterno = Convert.ToInt32(btn.Name);
            Persistentes.Nombre_ClienteExterno = btn.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Frm_ClientesHijos_Load(object sender, EventArgs e)
        {
            Listar_Rubros();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
