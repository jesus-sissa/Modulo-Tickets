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
    public partial class Frm_TareasUsuariosAdd : Form
    {
        MaterialSkin.Controls.MaterialCheckbox Chk = new MaterialSkin.Controls.MaterialCheckbox();
        public Frm_TareasUsuariosAdd()
        {
            InitializeComponent();
        }
        void Listar_Departamentos()
        {
            FLow.Controls.Clear();            
            foreach (var item in TareasRepository.Consultar_UsuariosT(new TareasRequest {Id_Dpto=Persistentes.Id_Departamento,Id_Tarea=Persistentes.Id_Tarea }))
            {
                Agregar(item.Nombre, item.Id_Empleado.ToString(), item.Status);
            }
        }
        void Agregar(string Nombre, string Id, int Status)
        {
            Chk = new MaterialSkin.Controls.MaterialCheckbox();
            Chk.Name = Id.ToString();
            Chk.Size = new System.Drawing.Size(332, 34);
            Chk.TabIndex = 42;
            Chk.Text = "  " + Nombre;
            Chk.Checked = Status > 0 ? true : false;
            FLow.Controls.Add(Chk);
        }

        private void Frm_TareasUsuariosAdd_Load(object sender, EventArgs e)
        {
            Listar_Departamentos();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            foreach (Control C in FLow.Controls)
            {
                MaterialSkin.Controls.MaterialCheckbox Check = (MaterialSkin.Controls.MaterialCheckbox)C;
                int _IdEmpleado = Convert.ToInt32(Check.Name);
                TareasRepository.Guardar_TareasEmpleados(new TareasUsuariosResquest { Id_Empleado= _IdEmpleado, Id_Dpto = Persistentes.Id_Departamento, Status = Check.Checked == true ? "A" : "B" });
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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

        private void Lbl_Nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
