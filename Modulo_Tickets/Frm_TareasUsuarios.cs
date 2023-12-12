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
    public partial class Frm_TareasUsuarios : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        public Frm_TareasUsuarios()
        {
            InitializeComponent();
            Lbl_Nombre.Text = (Persistentes.Nombre_Tarea+"/"+Persistentes.TareaNombre_Departamento+"/EMPLEADOS").Replace(" ",string.Empty);
        }

        private void Btn_NuevoRubro_Click(object sender, EventArgs e)
        {
            Frm_TareasUsuariosAdd Frm = new Frm_TareasUsuariosAdd();
            Frm.ShowDialog();
            Listar_Empleados();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Listar_Empleados()
        {
            FLow.Controls.Clear();                
            foreach (var item in TareasRepository.Consultar_Usuarios(new TareasRequest { Id_Tarea =Persistentes.Id_Tarea ,Id_Dpto=Persistentes.Id_Departamento}) )
            {
                Agregar(item.Nombre, item.Id_Empleado.ToString());
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
        }

        private void Frm_TareasUsuarios_Load(object sender, EventArgs e)
        {
            Listar_Empleados();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FLow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
