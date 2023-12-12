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
    public partial class Frm_Clientes : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        public Frm_Clientes()
        {
            InitializeComponent();
        }
        void Listar_Rubros()
        {
            Flow.Controls.Clear();
            //CategoriasRequest _CategoriasRequest = new CategoriasRequest();
            foreach (var item in ClienteRepository.ConsultarPadre(new ClientesRequest()))
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
            DialogResult dr=new DialogResult();
            btn = new BunifuFlatButton();
            btn = (BunifuFlatButton)sender;
            Frm_ClientesHijos _Sub = new Frm_ClientesHijos(Convert.ToInt32(btn.Name));
           dr= _Sub.ShowDialog();
            if(dr==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            Listar_Rubros();
        }

        private void Flow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
