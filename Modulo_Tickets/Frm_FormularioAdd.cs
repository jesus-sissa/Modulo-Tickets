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
    public partial class Frm_FormularioAdd : Form
    {
        public Frm_FormularioAdd()
        {
            InitializeComponent();
        }

        private void Frm_FormularioAdd_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            FormatosRepository.Guardar_Formato(new FormatosRequest { Nombre = Txt_Nombre.Text, status = Chk_Status.Checked == true ? "S" : "N" });
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
