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
    public partial class Frm_TareasAdd : Form
    {
        public Frm_TareasAdd()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            TareasRepository.Guardar(new TareasRequest { Nombre=Txt_Nombre.Text,Status=Chk_Status.Checked==true ?"S":"N"});
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_TareasAdd_Load(object sender, EventArgs e)
        {

        }

        private void Chk_Status_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Status_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
