using Bunifu.Framework.UI;
using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using Newtonsoft.Json;
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
    public partial class Frm_TareasDptosAdd : Form
    {       
        MaterialSkin.Controls.MaterialCheckbox Chk = new MaterialSkin.Controls.MaterialCheckbox();
        int _IdTarea = Persistentes.Id_Tarea;
        public Frm_TareasDptosAdd( )
        {
            InitializeComponent();           
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Listar_Departamentos()
        {
            FLow.Controls.Clear();
            foreach (var item in TareasRepository.Consultar_Departamentos(new TareasRequest { Id_Tarea=Persistentes.Id_Tarea}))
            {
                Agregar(item.Nombre_Dpto, item.Id_Dptos.ToString(),item.Status);
            }
        }
        void Agregar(string Nombre, string Id,string Status)
        {
            Chk = new MaterialSkin.Controls.MaterialCheckbox();
            Chk.Name = Id.ToString();
            Chk.Size = new System.Drawing.Size(332, 34);
            Chk.TabIndex = 42;
            Chk.Text = "  " + Nombre;
            Chk.Checked = Status == "A" ? true : false;
            FLow.Controls.Add(Chk);

        }

        private void Frm_TareasDptosAdd_Load(object sender, EventArgs e)
        {
            Listar_Departamentos();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            foreach (Control C in FLow.Controls)
            {
                MaterialSkin.Controls.MaterialCheckbox Check = (MaterialSkin.Controls.MaterialCheckbox)C;
                int _IdDpto = Convert.ToInt32(Check.Name);
                TareasRepository.Guardar_TareasDptos(new TareasRequest { Id_Tarea=_IdTarea,Id_Dpto= _IdDpto,Status=Check.Checked==true?"A":"B" });
                DialogResult = DialogResult.OK;
                Close();                
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
