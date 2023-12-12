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
    public partial class Frm_Usuarios : Form
    {
        public int Id_Rubro = 0;
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        void Listar_Rubros()
        {
            Flow.Controls.Clear();
            EmpleadosRequest _EmpleadosRequest = new EmpleadosRequest
            {
                Id_Rubro = Persistentes.Id_Rubro
            };
            foreach (var item in EmpleadosRepository.ConsultaEmpleados(_EmpleadosRequest))
            {
                Agregar(item.Nombre, item.Id_Empleado);
            }
        }
        void Agregar(string Nombre, int Id)
        {

            btn = new BunifuFlatButton();


            
            btn.ButtonText = "Asignar";
            btn.Name = Id.ToString();
            btn.Iconimage = null;
            btn.Size = new System.Drawing.Size(332, 34);
            btn.TabIndex = 42;
            btn.Text ="  "+ Nombre;
            btn.Textcolor = System.Drawing.Color.White;

            Flow.Controls.Add(btn);
           btn.Click += new EventHandler(Cliq);

        }
        private void Cliq(Object sender, EventArgs e)
        {
            btn = new BunifuFlatButton();
            btn = (BunifuFlatButton)sender;
            Persistentes.Id_UsuarioA =Convert.ToInt32( btn.Name);
            Persistentes.Nombre_UsuarioA = btn.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            Listar_Rubros();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Persistentes.Id_UsuarioA = 0;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Flow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
