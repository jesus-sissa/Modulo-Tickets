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
    public partial class Frm_FiltroBusqueda : Form
    {
        public Frm_FiltroBusqueda()
        {
            InitializeComponent();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Persistentes.Fecha_Inicio = Dat_FechaInicio.Value;
            Persistentes.Fecha_Fin = Dat_FechaFin.Value;
            if(Chk_Todos.Checked)
            {
                Persistentes.Status = "T";
            }
            else
            {
                if (Cmb_Status.Text=="NUEVO")
                {
                    Persistentes.Status = "A";
                }
                else if(Cmb_Status.Text == "ASIGNADO")
                {
                    Persistentes.Status = "AS";
                }
                else if (Cmb_Status.Text == "ACTUANDO")
                {
                    Persistentes.Status = "AC";
                }
                else if (Cmb_Status.Text == "RESUELTO")
                {
                    Persistentes.Status = "F";
                }
                else if (Cmb_Status.Text == "CERRADO")
                {
                    Persistentes.Status = "CE";
                }
                else if (Cmb_Status.Text == "RECHAZADO")
                {
                    Persistentes.Status = "R";
                }

            }
            this.Close();
            
        }

        private void Chk_Todos_CheckedChanged(object sender, EventArgs e)
        {
            if(Chk_Todos.Checked)
            {
                Cmb_Status.Enabled = false;
            }
            else
            {
                Cmb_Status.Enabled = true;
            }
        }
        private void Frm_FiltroBusqueda_Load(object sender, EventArgs e)
        {
            Dat_FechaInicio.Value =Convert.ToDateTime( DateTime.Now.AddDays(-7));
            Dat_FechaFin.Value= Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }
    }
}
