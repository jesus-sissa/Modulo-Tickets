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
    public partial class Frm_AdminTareas : Form
    {
        public Frm_AdminTareas()
        {
            InitializeComponent();
        }

        private void Btn_Flujos_Click(object sender, EventArgs e)
        {
                Frm_Tareas Frm = new Frm_Tareas();
                Frm.ShowDialog();
        }

        private void Flow_Rubros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Frm_Flujos Frm = new Frm_Flujos();
            PanelContenido(Frm);
            //Frm.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Frm_FlujoStaff frm = new Frm_FlujoStaff();
            PanelContenido(frm);
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
                Frm_ReporteFlujo frm = new Frm_ReporteFlujo();
                PanelContenido(frm);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Frm_AdminTareas_Load(object sender, EventArgs e)
        {
            if (Persistentes.Controles("PROCEDIMIENTOS"))
            {
                Btn_Flujos.Visible = true;
            }
            if (Persistentes.Controles("FORMULARIO"))
            {
                bunifuTileButton4.Visible = true;
            }
            if (Persistentes.Controles("REPORTES FLUJO"))
            {
                bunifuTileButton3.Visible = true;
            }
        }
        public void PanelContenido(Form Formulario)
        {
            if (Formulario == null)
            {
                panel1.Controls.Clear();
                return;
            }
            panel1.Controls.Clear();
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            panel1.Controls.Add(Formulario);
            Formulario.Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Frm_Formulario frm = new Frm_Formulario();
            frm.ShowDialog();
        }
    }
}
