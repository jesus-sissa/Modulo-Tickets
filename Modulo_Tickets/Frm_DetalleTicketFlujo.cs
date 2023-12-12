using Modulo_Tickets.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Tickets
{
    public partial class Frm_DetalleTicketFlujo : Form
    {
        public Frm_DetalleTicketFlujo()
        {
            InitializeComponent();
        }
        private void Frm_DetalleTicketFlujo_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Ticket_Click(object sender, EventArgs e)
        {

        }
        private void Lbl_Status_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Avances_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 2;
            Persistentes.Id_Tarea = Convert.ToInt32(Persistentes.Id_Tarea);
            Frm_TreeView frm = new Frm_TreeView();
            frm.ShowDialog();
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 2;
            Frm_Estrellas frm = new Frm_Estrellas(false);
            Persistentes.Mensaje("El ticket a sido cerrado con exito");
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
