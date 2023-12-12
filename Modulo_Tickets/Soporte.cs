using Bunifu.Framework.UI;
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
    public partial class Soporte : Form
    {
        int _idDepartamento = 0;
        private ConfiguracionRubrosTickesRepository _config_Rubros;
        private ConfiguracionRubrosTickets _configuracion;
        public Soporte()
        {
            InitializeComponent();
        }
        void Listar_Tickets(int Id_Rubro)
        {
            Dgv_Tickets.Columns["Id_Rubro"].Visible = false;
            Dgv_Tickets.Rows.Clear();
            TicketRequest ticketRequest = new TicketRequest
            {
                Id_Rubro=Id_Rubro
            };
            foreach (var item in TicketRepository.ConsultarTicket_PorRubro2(ticketRequest))
            {

                if (item._Status == "PENDIENTE")
                {
                    Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Status, item._Fecha, item._AsignadoA, item.Id_Rubro);
                }
                else
                {
                    Dgv_Tickets.Rows.Add(imageList1.Images[1], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Status, item._Fecha, item._AsignadoA, item.Id_Rubro);
                }

            }
        }
        void Listar_Tickets()
        {
            Dgv_Tickets.Columns["Id_Rubro"].Visible = false;
            Dgv_Tickets.Rows.Clear();
            TicketRequest ticketRequest = new TicketRequest();
            foreach (var item in TicketRepository.ConsultarTicket_Soporte(ticketRequest))
            {

                if (item._Status == "PENDIENTE")
                {
                    Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket,item._SolicitudCambio ,item._Usuario_Reporta, item._Descripcion, item._Status, item._Fecha, item.Id_Rubro,item.Tipo,item.Ticket_Proveedor,item.T, item.S);
                }
                else
                {
                    Dgv_Tickets.Rows.Add(imageList1.Images[1], item._NumeroTicket, item._SolicitudCambio,item._Usuario_Reporta, item._Descripcion, item._Status, item._Fecha, item.Id_Rubro, item.Tipo, item.Ticket_Proveedor,item.T, item.S);
                }
            }
        }

        private void Soporte_Load(object sender, EventArgs e)
        {
            _config_Rubros = new ConfiguracionRubrosTickesRepository();
            _configuracion = _config_Rubros.Get_ConfiguracionRubro(Persistentes.Id_Rubro);

            if (_configuracion.SolicitudCambio)
            {
                Dgv_Tickets.Columns["SolicitudCambio"].Visible = true;
            }
            Listar_Tickets();
            Txt_Filtro.Focus();
            RubroRequest RubroRequest;
            RubroRequest = new RubroRequest { Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento };
            foreach (var item in RubroRepository.ConsultarRubros(RubroRequest))
            {
                Persistentes.Id_Rubro = item.Id_Rubro;
            }
            var p = RubroRepository.ConsultarRubrosU(new RubroRequest(), Persistentes.Id_Rubro);
            _idDepartamento = p.Id_Departamento;
            if (_idDepartamento != Persistentes.UsuarioLogin_IdDepartamento || Persistentes.Id_Rubro == 0)
            {
                Dgv_Tickets.Visible = false;
                panel1.Visible = false;
                Persistentes.Mensaje("Reportese con su Administrador para ver su situacion");
            }
        }
        private void Dgv_Tickets_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Frm_SoporteD Detalle = new Frm_SoporteD(false);
                Detalle.Txt_Descripcion.Text = Dgv_Tickets.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                Persistentes.Numero_Ticket = Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
                Persistentes.Id_UsuarioA = 1;//Cambiar por el usuario logeado
                Detalle.vSolicitudCambio = Dgv_Tickets.Rows[e.RowIndex].Cells["SolicitudCambio"].Value.ToString();
                Detalle.Active_SolicitudCambio = _configuracion.SolicitudCambio;
                Detalle.Status= Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                Detalle.tipo= Convert.ToInt32( Dgv_Tickets.Rows[e.RowIndex].Cells["Tipo"].Value);
                Detalle.proveedor= Dgv_Tickets.Rows[e.RowIndex].Cells["Tck_P"].Value.ToString();
                Detalle.T = Dgv_Tickets.Rows[e.RowIndex].Cells["T"].Value.ToString();
                Detalle.S = Dgv_Tickets.Rows[e.RowIndex].Cells["S"].Value.ToString();
                Detalle.ShowDialog();
                Listar_Tickets();
            }
        }

        private void Txt_Filtro_OnTextChange(object sender, EventArgs e)
        {
            if (Txt_Filtro.text != "")
            {
                Dgv_Tickets.CurrentCell = null;
                foreach (DataGridViewRow r in Dgv_Tickets.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in Dgv_Tickets.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if (c.Value != null)
                        {
                            if ((c.Value.ToString().ToUpper()).IndexOf(Txt_Filtro.text.ToUpper()) == 0)
                            {
                                r.Visible = true;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                Listar_Tickets();
            }
        }

        private void Dgv_Tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
