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
    public partial class Frm_FlujoStaff : Form
    {
        TicketFlujoRequest List_Tickets;
        bool Filtro = false;
        public Frm_FlujoStaff()
        {
            InitializeComponent();
        }

        private void Frm_FlujoStaff_Load(object sender, EventArgs e)
        {
            Listar_TicketsFlujos(new TicketFlujoRequest());
        }
        void Listar_TicketsFlujos(TicketFlujoRequest ticketFlujo)
        {
            List<TicketFlujoResponse> tickets;
            Dgv_Tickets.Rows.Clear();
            tickets = TareasRepository.ConsultarFlujoGeneral(ticketFlujo);
            foreach (var item in tickets)
            {
                if (item._Status == "ACTUANDO")
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.ForeColor = Color.White;
                    row.CreateCells(Dgv_Tickets);
                    row.Cells[0].Value = imageList1.Images[0];
                    row.Cells[1].Value = item._Id_Flujo;
                    row.Cells[1].Style = style;
                    row.Cells[2].Value = item._Usuario_Reporta;
                    row.Cells[2].Style = style;
                    row.Cells[3].Value = item._Nombre_Flujo;
                    row.Cells[3].Style = style;
                    row.Cells[4].Value = item._Descripcion;
                    row.Cells[4].Style = style;
                    row.Cells[5].Value = item._Status;
                    row.Cells[5].Style = style;
                    row.Cells[6].Value = item._Fecha_Inicio;
                    row.Cells[6].Style = style;
                    row.Cells[7].Value = item._Fecha_Resuelto;
                    row.Cells[7].Style = style;
                    row.Cells[8].Value = item._Fecha_Fin;
                    row.Cells[8].Style = style;
                    row.Cells[9].Value = item._Porcentaje;
                    row.Cells[9].Style = style;
                    row.Cells[10].Value = item._Autorizacion;
                    row.Cells[10].Style = style;
                    Dgv_Tickets.Rows.Add(row);
                }
                else if (item._Status == "RESUELTO")
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.ForeColor = Color.White;
                    row.CreateCells(Dgv_Tickets);
                    row.Cells[0].Value = imageList1.Images[3];
                    row.Cells[1].Value = item._Id_Flujo;
                    row.Cells[1].Style = style;
                    row.Cells[2].Value = item._Usuario_Reporta;
                    row.Cells[2].Style = style;
                    row.Cells[3].Value = item._Nombre_Flujo;
                    row.Cells[3].Style = style;
                    row.Cells[4].Value = item._Descripcion;
                    row.Cells[4].Style = style;
                    row.Cells[5].Value = item._Status;
                    row.Cells[5].Style = style;
                    row.Cells[6].Value = item._Fecha_Inicio;
                    row.Cells[6].Style = style;
                    row.Cells[7].Value = item._Fecha_Resuelto;
                    row.Cells[7].Style = style;
                    row.Cells[8].Value = item._Fecha_Fin;
                    row.Cells[8].Style = style;
                    row.Cells[9].Value = item._Porcentaje;
                    row.Cells[9].Style = style;
                    row.Cells[10].Value = item._Autorizacion;
                    row.Cells[10].Style = style;
                    Dgv_Tickets.Rows.Add(row);
                }
                else// (item._Status == "CERRADO")
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.ForeColor = Color.White;
                    row.CreateCells(Dgv_Tickets);
                    row.Cells[0].Value = imageList1.Images[1];
                    row.Cells[1].Value = item._Id_Flujo;
                    row.Cells[1].Style = style;
                    row.Cells[2].Value = item._Usuario_Reporta;
                    row.Cells[2].Style = style;
                    row.Cells[3].Value = item._Nombre_Flujo;
                    row.Cells[3].Style = style;
                    row.Cells[4].Value = item._Descripcion;
                    row.Cells[4].Style = style;
                    row.Cells[5].Value = item._Status;
                    row.Cells[5].Style = style;
                    row.Cells[6].Value = item._Fecha_Inicio;
                    row.Cells[6].Style = style;
                    row.Cells[7].Value = item._Fecha_Resuelto;
                    row.Cells[7].Style = style;
                    row.Cells[8].Value = item._Fecha_Fin;
                    row.Cells[8].Style = style;
                    row.Cells[9].Value = item._Porcentaje;
                    row.Cells[9].Style = style;
                    row.Cells[10].Value = item._Autorizacion;
                    row.Cells[10].Style = style;
                    Dgv_Tickets.Rows.Add(row);
                }
            }
        }
        void Listar_TicketsFlujosPorStatus(TicketFlujoRequest ticketFlujo,bool Filtro)
        {
            List<TicketFlujoResponse> tickets;
            Dgv_Tickets.Rows.Clear();
            tickets = TareasRepository.ConsultarFlujoPorStatus(ticketFlujo);
            foreach (var item in tickets)
            {
                if (item._Status == "ACTUANDO")
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.ForeColor = Color.White;
                    row.CreateCells(Dgv_Tickets);
                    row.Cells[0].Value = imageList1.Images[0];
                    row.Cells[1].Value = item._Id_Flujo;
                    row.Cells[1].Style = style;
                    row.Cells[2].Value = item._Usuario_Reporta;
                    row.Cells[2].Style = style;
                    row.Cells[3].Value = item._Nombre_Flujo;
                    row.Cells[3].Style = style;
                    row.Cells[4].Value = item._Descripcion;
                    row.Cells[4].Style = style;
                    row.Cells[5].Value = item._Status;
                    row.Cells[5].Style = style;
                    row.Cells[6].Value = item._Fecha_Inicio;
                    row.Cells[6].Style = style;
                    row.Cells[7].Value = item._Fecha_Resuelto;
                    row.Cells[7].Style = style;
                    row.Cells[8].Value = item._Fecha_Fin;
                    row.Cells[8].Style = style;
                    row.Cells[9].Value = item._Porcentaje;
                    row.Cells[9].Style = style;
                    row.Cells[10].Value = item._Autorizacion;
                    row.Cells[10].Style = style;
                    Dgv_Tickets.Rows.Add(row);
                }
                else if (item._Status == "RESUELTO")
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.ForeColor = Color.White;
                    row.CreateCells(Dgv_Tickets);
                    row.Cells[0].Value = imageList1.Images[3];
                    row.Cells[1].Value = item._Id_Flujo;
                    row.Cells[1].Style = style;
                    row.Cells[2].Value = item._Usuario_Reporta;
                    row.Cells[2].Style = style;
                    row.Cells[3].Value = item._Nombre_Flujo;
                    row.Cells[3].Style = style;
                    row.Cells[4].Value = item._Descripcion;
                    row.Cells[4].Style = style;
                    row.Cells[5].Value = item._Status;
                    row.Cells[5].Style = style;
                    row.Cells[6].Value = item._Fecha_Inicio;
                    row.Cells[6].Style = style;
                    row.Cells[7].Value = item._Fecha_Resuelto;
                    row.Cells[7].Style = style;
                    row.Cells[8].Value = item._Fecha_Fin;
                    row.Cells[8].Style = style;
                    row.Cells[9].Value = item._Porcentaje;
                    row.Cells[9].Style = style;
                    row.Cells[10].Value = item._Autorizacion;
                    row.Cells[10].Style = style;
                    Dgv_Tickets.Rows.Add(row);
                }
                else// (item._Status == "CERRADO")
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.ForeColor = Color.White;
                    row.CreateCells(Dgv_Tickets);
                    row.Cells[0].Value = imageList1.Images[1];
                    row.Cells[1].Value = item._Id_Flujo;
                    row.Cells[1].Style = style;
                    row.Cells[2].Value = item._Usuario_Reporta;
                    row.Cells[2].Style = style;
                    row.Cells[3].Value = item._Nombre_Flujo;
                    row.Cells[3].Style = style;
                    row.Cells[4].Value = item._Descripcion;
                    row.Cells[4].Style = style;
                    row.Cells[5].Value = item._Status;
                    row.Cells[5].Style = style;
                    row.Cells[6].Value = item._Fecha_Inicio;
                    row.Cells[6].Style = style;
                    row.Cells[7].Value = item._Fecha_Resuelto;
                    row.Cells[7].Style = style;
                    row.Cells[8].Value = item._Fecha_Fin;
                    row.Cells[8].Style = style;
                    row.Cells[9].Value = item._Porcentaje;
                    row.Cells[9].Style = style;
                    row.Cells[10].Value = item._Autorizacion;
                    row.Cells[10].Style = style;
                    Dgv_Tickets.Rows.Add(row);
                }
            }
        }
        private void Dgv_Tickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Frm_FlujoSoporteD frm = new Frm_FlujoSoporteD();
                frm.Txt_Descripcion.Text = Dgv_Tickets.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                Persistentes.Id_Flujo = Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
                int _Posicion = e.RowIndex;
                if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "ACTUANDO")
                {
                    Persistentes.Status_TickteStaff = "AC";
                }
                else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "FINALIZADO" || Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "RESUELTO")
                {
                    Persistentes.Status_TickteStaff = "F";
                }
                else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "CERRADO")
                {
                    Persistentes.Status_TickteStaff = "CE";
                }
                else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "NA")
                {
                    Persistentes.Status_TickteStaff = "IN";
                }
                DialogResult dr;
                dr = frm.ShowDialog();
                if (Chk_Todos.Checked)
                {
                    Listar_TicketsFlujos(new TicketFlujoRequest());
                    Dgv_Tickets.CurrentCell = Dgv_Tickets.Rows[_Posicion].Cells[0];
                }
                if (Rdb_Actuando.Checked)
                {
                    Listar_Tickets_Status("AC");
                    Persistentes.General = true;
                }
                if (Rdb_Terminados.Checked)
                {
                    Listar_Tickets_Status("F");
                    Dgv_Tickets.CurrentCell = Dgv_Tickets.Rows[_Posicion].Cells[0];
                }
                if (Rdb_Cerrados.Checked)
                {
                    Listar_Tickets_Status("CE");
                    Persistentes.General = true;
                }
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dgv_Tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Chk_Todos_CheckedChanged(object sender, EventArgs e)
        {
            if(Chk_Todos.Checked)
            {
                Persistentes.General = false;
                Listar_TicketsFlujos(new TicketFlujoRequest());
            }
        }
        void Listar_Tickets_Status(string Status)
        {
            Listar_TicketsFlujosPorStatus(new TicketFlujoRequest{ Status = Status }, false);
        }
        private void Rdb_Actuando_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Actuando.Checked)
            {
                Listar_Tickets_Status("AC");
                Persistentes.General = true;
            }
        }

        private void Rdb_Terminados_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Terminados.Checked)
            {
                Listar_Tickets_Status("F");
                Persistentes.General = true;
            }
        }

        private void Rdb_Cerrados_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Cerrados.Checked)
            {
                Listar_Tickets_Status("CE");
                Persistentes.General = true;
            }
        }
    }
}
