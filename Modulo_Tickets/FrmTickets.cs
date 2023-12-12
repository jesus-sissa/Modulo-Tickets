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
using Modulo_Tickets.Model;
using static Modulo_Tickets.Model.UserRequest;
using Newtonsoft.Json;

namespace Modulo_Tickets
{

    public partial class FrmTickets : Form
    {
        private ConfiguracionRubrosTickesRepository _config_Rubros;
        private ConfiguracionRubrosTickets _configuracion;

        TicketRequest List_Ticktes;
        bool Filtro = false;
        public FrmTickets()
        {
            InitializeComponent();
        }
        private void FrmTickets_Load(object sender, EventArgs e)
        {
                Listar_Tickets(new TicketRequest(), false);
        }
        void Listar_Tickets(TicketRequest ticketRequest, bool Filtro)
        {
            List<TicketResponse> Tickets;
            Dgv_Tickets.Rows.Clear();
            if (Filtro)
            {
                Tickets = TicketRepository.ConsultarTicket_FiltroUsuario(ticketRequest);
            }
            else
            {
                Tickets = TicketRepository.ConsultarTicketGeneral(ticketRequest);
            }
                //TicketRequest ticketRequest = new TicketRequest();
            foreach (var item in Tickets)
            {

                if (item._Status == "NUEVO" || item._Status == "ASIGNADO" || item._Status == "ACTUANDO")
                {
                    Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket,item._SolicitudCambio, item._Descripcion, item._Status, item._Fecha);
                }
                else
                {
                    Dgv_Tickets.Rows.Add(imageList1.Images[1], item._NumeroTicket, item._SolicitudCambio, item._Descripcion, item._Status, item._Fecha);
                }

                if (item._SolicitudCambio !=null || item._SolicitudCambio !="")
                {
                    Dgv_Tickets.Columns["SolicitudCambio"].Visible = true;
                }
            }
        }
        //void Listar_Tickets()
        //{
        //    Dgv_Tickets.Rows.Clear();
        //    WsCajeroInteligente.WsCashFlowSoapClient WsCajero = new WsCajeroInteligente.WsCashFlowSoapClient();
        //    string json = WsCajero.Consultar_ReporteSucursales_RFC(Properties.Settings.Default.Plaza+"%"+"1"+"%"+Properties.Settings.Default.Sucursal);
        //    DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);
        //    //TicketRequest ticketRequest = new TicketRequest();
        //    foreach (DataRow item in dt.Rows)
        //    {

        //        if (item["Status"].ToString() == "NUEVO" || item["Status"].ToString() == "ASIGNADO")
        //        {
        //            Dgv_Tickets.Rows.Add(imageList1.Images[0], item["Ticket"].ToString(), item["SolicitudCambio"].ToString(), item["Descripcion"].ToString(), item["Status"].ToString(), item["Fecha"].ToString());
        //        }
        //        else
        //        {
        //            //Dgv_Tickets.Rows.Add(imageList1.Images[1], item._NumeroTicket, item._SolicitudCambio, item._Descripcion, item._Status, item._Fecha);
        //            Dgv_Tickets.Rows.Add(imageList1.Images[1], item["Ticket"].ToString(), item["SolicitudCambio"].ToString(), item["Descripcion"].ToString(), item["Status"].ToString(), item["Fecha"].ToString());
        //        }
             
        //    }
        //}

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            Frm_NuevoTicket NuevoTicket = new Frm_NuevoTicket(); 
            NuevoTicket.ShowDialog();
            Listar_Tickets(new TicketRequest(), false); //Cuando se agrega un nuevo ticket, se elimina el filtro en caso de existir.          
            
        }

        private void Txt_Filtro_OnTextChange(object sender, EventArgs e)
        {
            if (Txt_Filtro.text!="")
            {
                Dgv_Tickets.CurrentCell = null;
                foreach(DataGridViewRow r in Dgv_Tickets.Rows)
                {
                    r.Visible =false;
                }
                foreach (DataGridViewRow r in Dgv_Tickets.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if((c.Value.ToString().ToUpper()).IndexOf(Txt_Filtro.text.ToUpper())==0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                if (Filtro)
                {
                    Listar_Tickets(List_Ticktes, Filtro);
                }
                else
                {
                    Listar_Tickets(new TicketRequest (), Filtro);
                }
            }
        }

        private void Dgv_Tickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Frm_DetalleTicket Detalle = new Frm_DetalleTicket();
                Detalle.Lbl_Ticket.Text += Dgv_Tickets.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
                Detalle.Lbl_Status.Text += Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                Detalle.Txt_Descripcion.Text = Dgv_Tickets.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                Persistentes.Numero_Ticket = Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
                Detalle.vSolicitudCambio = Dgv_Tickets.Rows[e.RowIndex].Cells["SolicitudCambio"].Value.ToString();


                    if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "RESUELTO")
                    {
                        Detalle.Btn_Enviar.Enabled = true;
                    }
                    Detalle.ShowDialog();

                    if (Filtro)
                    {
                        Listar_Tickets(List_Ticktes, Filtro);
                    }
                    else
                    {
                        Listar_Tickets(new TicketRequest(), Filtro);
                    }
                
            }
        }

        private void Dgv_Tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filtroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Frm_FiltroBusqueda frm = new Frm_FiltroBusqueda();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                List_Ticktes = new TicketRequest { Fecha_Inicio = Persistentes.Fecha_Inicio, Fecha_Fin = Persistentes.Fecha_Fin, Status = Persistentes.Status };
                Filtro = true;
                Listar_Tickets(List_Ticktes, Filtro);
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
