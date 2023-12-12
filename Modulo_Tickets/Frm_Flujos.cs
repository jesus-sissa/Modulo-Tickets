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
    public partial class Frm_Flujos : Form
    {
        TicketFlujoRequest List_Tickets;
        public Frm_Flujos()
        {
            InitializeComponent();
        }

        private void Frm_Flujos_Load(object sender, EventArgs e)
        {
            Listar_TicketsFlujo(new TicketFlujoRequest());
        }
        void Listar_TicketsFlujo(TicketFlujoRequest ticketFlujo)
        {
            List<TicketFlujoResponse> tickets;
            Dgv_Tickets.Rows.Clear();
            tickets = TareasRepository.ConsultarTicketFlujo(ticketFlujo);
            foreach(var item in tickets)
            {
                if (item._Status == "ACTUANDO")
                {
                    Dgv_Tickets.Rows.Add(imageList1.Images[0],item._Id_Flujo, item._Fecha_Inicio, item._Descripcion, item._Status, item._Porcentaje, item._Autorizacion);
                }
                else
                {
                    Dgv_Tickets.Rows.Add(imageList1.Images[1], item._Id_Flujo, item._Fecha_Inicio, item._Descripcion, item._Status, item._Porcentaje, item._Autorizacion);
                }
            }
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            Frm_FlujosNew Frm = new Frm_FlujosNew();
            Frm.ShowDialog();
            Listar_TicketsFlujo(new TicketFlujoRequest());
        }

        private void Dgv_Tickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                Frm_DetalleTicketFlujo Detalle = new Frm_DetalleTicketFlujo();
                Detalle.Lbl_Ticket.Text += Dgv_Tickets.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
                Detalle.Lbl_Status.Text += Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                Detalle.Txt_Descripcion.Text = Dgv_Tickets.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                Persistentes.Id_Flujo = Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
                if(Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "RESUELTO")
                {
                    Detalle.Btn_Enviar.Enabled = true;
                }
                if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "NA")
                {
                    Detalle.Btn_Enviar.Visible = false;
                }
                Detalle.ShowDialog();
                Listar_TicketsFlujo(new TicketFlujoRequest());
            }
        }

        private void Dgv_Tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
