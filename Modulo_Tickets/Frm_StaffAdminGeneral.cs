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
    public partial class Frm_StaffAdminGeneral : Form
    {
        private int _IdRubro = 0;
        int count = 0;
        private string _NombreRubro = string.Empty;
        private ConfiguracionRubrosTickesRepository _config_Rubros;
        private ConfiguracionRubrosTickets _configuracion;
        TicketRequest List_Ticktes;
        bool Filtro = false;
        int Id_RubroSeleccionado = 0;//Para mantener la seleccion inicial del rubro
        BunifuTileButton btn = new Bunifu.Framework.UI.BunifuTileButton();
        public Frm_StaffAdminGeneral(int IdRubro,string NombreRubro)
        {
            _IdRubro = IdRubro;
            _NombreRubro = NombreRubro;
            InitializeComponent();
        }

        private void Frm_StaffAdminGeneral_Load(object sender, EventArgs e)
        {
            _config_Rubros = new ConfiguracionRubrosTickesRepository();
            _configuracion = _config_Rubros.Get_ConfiguracionRubro(_IdRubro);
            Dgv_Tickets.Columns["Id_Rubro"].Visible = false;
            //Dgv_Tickets.Columns["Usuario_Reporta"].Visible = false;
            Listar_Rubros();
            if (_configuracion.SolicitudCambio)
            {
                Dgv_Tickets.Columns["SolicitudCambio"].Visible = true;
            }
        }
        void Listar_Rubros()
        {
            //FLow.Controls.Clear();
            Listar_Tickets(new TicketRequest { Id_Rubro = _IdRubro }, Filtro);
            RubroRequest RubroRequest = new RubroRequest { Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento };
            foreach (var item in RubroRepository.ConsultarRubros(RubroRequest))
            {
                //Lbl_Rubro.Text = _NombreRubro + "[ " + count + " ]";
                Id_RubroSeleccionado = Convert.ToInt32(_IdRubro);
                Filtro = false;

                //Agregar(item.Nombre, item.Id_Rubro.ToString(), item.Img);
            }
            Listar_Tickets(new TicketRequest { Id_Rubro = _IdRubro }, Filtro);
        }
        void Listar_Tickets_Status(string Status)
        {
            //FLow.Controls.Clear();
            RubroRequest RubroRequest = new RubroRequest { Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento };
            foreach (var item in RubroRepository.ConsultarRubros(RubroRequest))
            {
                //Lbl_Rubro.Text = _NombreRubro + "[" + count + "]";
                Id_RubroSeleccionado = Convert.ToInt32(_IdRubro);
                Filtro = false;

                //Agregar(item.Nombre, item.Id_Rubro.ToString(), item.Img);
            }
            Listar_TicketsPorStatus(new TicketRequest { Id_Rubro = _IdRubro, Status = Status }, false);
            //Listar_TicketsPorStatus(new TicketRequest { Id_Rubro = Id_RubroSeleccionado, Status = Status }, false);
        }
        void Listar_TicketsPorStatus(TicketRequest ticketRequest, bool Filtro)
        {
            List<TicketResponse> Tickets;
            Dgv_Tickets.Rows.Clear();
            Tickets = TicketRepository.ConsultarTicket_PorStatus(ticketRequest);
            count = Tickets.Count;
            Lbl_Rubro.Text = _NombreRubro + "[" + count + "]";
            foreach (var item in Tickets)
            {
                if (item._Status == "NUEVO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
                if (item._Status == "ASIGNADO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
                if (item._Status == "RESUELTO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[3];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[3];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
                if (item._Status == "ACTUANDO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
                if (item._Status == "RECHAZADO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[2];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[2];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
                if (item._Status == "CERRADO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[1];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[1];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
            }
        }
        void Listar_Tickets(TicketRequest ticketRequest, bool Filtro)
        {
            List<TicketResponse> Tickets;
            Dgv_Tickets.Rows.Clear();
            //TicketRequest tickets = new TicketRequest
            //{
            //    Id_Rubro = _IdRubro
            //};
            if (Filtro)
            {
                Tickets = TicketRepository.ConsultarTicket_PorFiltro(ticketRequest);
            }
            else
            {

                Tickets = TicketRepository.ConsultarTicket_PorRubro(ticketRequest);
                count = Tickets.Count;
                Lbl_Rubro.Text = _NombreRubro + "[" + count + "]";
            }
            foreach (var item in Tickets)
            {
                if (item._Status == "NUEVO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
                if (item._Status == "ASIGNADO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
                if (item._Status == "RESUELTO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[3];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[3];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
                if (item._Status == "ACTUANDO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[0];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
                if (item._Status == "RECHAZADO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[2];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[2];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
                if (item._Status == "CERRADO")
                {
                    if (item.Tipo == 1 || item.Tipo == 3)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.White;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[1];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else if (item.Tipo == 2)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.ForeColor = Color.Orange;
                        row.CreateCells(Dgv_Tickets);
                        row.Cells[0].Value = imageList1.Images[1];
                        row.Cells[1].Value = item._NumeroTicket;
                        row.Cells[1].Style = style;
                        row.Cells[2].Value = item._Usuario_Reporta;
                        row.Cells[2].Style = style;
                        row.Cells[3].Value = item._Descripcion;
                        row.Cells[3].Style = style;
                        row.Cells[4].Value = item._Fecha;
                        row.Cells[4].Style = style;
                        row.Cells[5].Value = item._AsignadoA;
                        row.Cells[5].Style = style;
                        row.Cells[6].Value = item._FechaAsignacion;
                        row.Cells[6].Style = style;
                        row.Cells[7].Value = item._FechaRecibe;
                        row.Cells[7].Style = style;
                        row.Cells[8].Value = item._FechaFin;
                        row.Cells[8].Style = style;
                        row.Cells[9].Value = item.Categoria;
                        row.Cells[9].Style = style;
                        row.Cells[10].Value = item.SubCategoria;
                        row.Cells[10].Style = style;
                        row.Cells[11].Value = item.Nivel_Servicio;
                        row.Cells[11].Style = style;
                        row.Cells[12].Value = item._Status;
                        row.Cells[12].Style = style;
                        row.Cells[13].Value = item.Id_Rubro;
                        row.Cells[13].Style = style;
                        row.Cells[14].Value = item.IdUsuario_Asignado;
                        row.Cells[14].Style = style;
                        row.Cells[15].Value = item.Tipo;
                        row.Cells[15].Style = style;
                        row.Cells[16].Value = item._SolicitudCambio;
                        Dgv_Tickets.Rows.Add(row);
                    }
                    else
                    {
                        Dgv_Tickets.Rows.Add(imageList1.Images[0], item._NumeroTicket, item._Usuario_Reporta, item._Descripcion, item._Fecha, item._AsignadoA, item._FechaAsignacion, item._FechaRecibe, item._FechaFin, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item._Status, item.Id_Rubro, item.IdUsuario_Asignado, item.Tipo, item._SolicitudCambio);
                    }
                }
            }
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            Frm_FiltroBusqueda frm = new Frm_FiltroBusqueda();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                List_Ticktes = new TicketRequest { Id_Rubro = Id_RubroSeleccionado, Fecha_Inicio = Persistentes.Fecha_Inicio, Fecha_Fin = Persistentes.Fecha_Fin, Status = Persistentes.Status };
                Filtro = true;
                Listar_Tickets(List_Ticktes, Filtro);
            }
        }

        private void Dgv_Tickets_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    if (Dgv_Tickets.Rows[e.RowIndex].Cells["Nivel_Servicio"].Value.ToString() == "S/P" && Dgv_Tickets.Rows[e.RowIndex].Cells["Categoria"].Value.ToString() == "S/C" && Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "NUEVO")
            //    {
            //        //Persistentes.Id_RubroSeleccionado= Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Id_Rubro"].Value.ToString());
            //        //Frm_NivelServicio frm = new Frm_NivelServicio(Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Numero"].Value.ToString()));
            //        //frm.ShowDialog();
            //    }
            //    //else
            //    //{
            //    Persistentes.Id_UsuarioA = 0;
            //    Persistentes.Ticket_Finalizado = false;
            //    Persistentes.Ticket_Cerrado = false;
            //    Persistentes.Ticket_Rechazado = false;
            //    Frm_AsignarTicket Detalle = new Frm_AsignarTicket(true);
            //    int _Posicion = e.RowIndex;
            //    Detalle.Txt_Descripcion.Text = Dgv_Tickets.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            //    Detalle.active_solicitud = _configuracion.SolicitudCambio;
            //    Detalle.vSolicitudCambio = Dgv_Tickets.Rows[e.RowIndex].Cells["SolicitudCambio"].Value.ToString();
            //    Persistentes.Numero_Ticket = Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
            //    Persistentes.Id_Rubro = Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Id_Rubro"].Value.ToString());
            //    Persistentes.Nombre_UsuarioA = Dgv_Tickets.Rows[e.RowIndex].Cells["AsignadoA"].Value.ToString();
            //    Persistentes.Id_UsuarioA = Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Id_Usuario"].Value.ToString());
            //    if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "NUEVO")
            //    {
            //        Persistentes.Status_TickteStaff = "N";
            //    }
            //    else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "ASIGNADO")
            //    {
            //        Persistentes.Status_TickteStaff = "AS";
            //    }
            //    else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "FINALIZADO" || Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "RESUELTO")
            //    {
            //        Persistentes.Status_TickteStaff = "F";
            //    }
            //    else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "CERRADO")
            //    {
            //        Persistentes.Status_TickteStaff = "CE";
            //    }
            //    else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "RECHAZADO")
            //    {
            //        Persistentes.Status_TickteStaff = "R";
            //    }
            //    else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "ACTUANDO")
            //    {
            //        Persistentes.Status_TickteStaff = "AC";
            //    }


            //    //if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "FINALIZADO")
            //    //    Persistentes.Ticket_Finalizado = true;
            //    //if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "CERRADO")
            //    //    Persistentes.Ticket_Cerrado = true;
            //    //if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "RECHAZADO")
            //    //    Persistentes.Ticket_Rechazado = true;
            //    //if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "NUEVO")
            //    //{
            //    //    Detalle.Btn_Traspaso.Visible = true;
            //    //    Detalle.Btn_Enviar.Enabled = true;
            //    //    Detalle.Btn_Rechazar.Enabled = true;
            //    //}
            //    //else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "ASIGNADO")
            //    //{
            //    //    Detalle.Btn_Finalizar.Enabled = true;
            //    //}
            //    Detalle.ShowDialog();
            //    if (Filtro)
            //    {
            //        Listar_Tickets(List_Ticktes, Filtro);
            //    }
            //    else
            //    {
            //        //Listar_Tickets(new TicketRequest { Id_Rubro = Id_RubroSeleccionado }, Filtro);
            //        //_ = Dgv_Tickets.SelectedRows[0].Selected=true;
            //        Listar_Tickets(new TicketRequest { Id_Rubro = Id_RubroSeleccionado }, Filtro);
            //        Dgv_Tickets.CurrentCell = Dgv_Tickets.Rows[_Posicion].Cells[0];
            //    }
            //    //if (dr != dialogresult.cancel)
            //    //{
            //    //    listar_tickets(new ticketrequest { id_rubro = id_rubroseleccionado }, false);
            //    //}
            //}
            if (e.RowIndex >= 0)
            {
                if (Dgv_Tickets.Rows[e.RowIndex].Cells["Nivel_Servicio"].Value.ToString() == "S/P" && Dgv_Tickets.Rows[e.RowIndex].Cells["Categoria"].Value.ToString() == "S/C" && Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "NUEVO")
                {
                    //Persistentes.Id_RubroSeleccionado= Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Id_Rubro"].Value.ToString());
                    //Frm_NivelServicio frm = new Frm_NivelServicio(Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Numero"].Value.ToString()));
                    //frm.ShowDialog();
                }
                //else
                //{
                Persistentes.Id_UsuarioA = 0;
                Persistentes.Ticket_Finalizado = false;
                Persistentes.Ticket_Cerrado = false;
                Persistentes.Ticket_Rechazado = false;
                Frm_AsignarTicket Detalle = new Frm_AsignarTicket(true);
                int _Posicion = e.RowIndex;
                Detalle.Txt_Descripcion.Text = Dgv_Tickets.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                Detalle.active_solicitud = _configuracion.SolicitudCambio;
                Detalle.vSolicitudCambio = Dgv_Tickets.Rows[e.RowIndex].Cells["SolicitudCambio"].Value.ToString();
                Persistentes.Numero_Ticket = Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Numero"].Value.ToString());
                Persistentes.Id_Rubro = Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Id_Rubro"].Value.ToString());
                Persistentes.Nombre_UsuarioA = Dgv_Tickets.Rows[e.RowIndex].Cells["AsignadoA"].Value.ToString();
                Persistentes.Id_UsuarioA = Convert.ToInt32(Dgv_Tickets.Rows[e.RowIndex].Cells["Id_Usuario"].Value.ToString());
                if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "NUEVO")
                {
                    Persistentes.Status_TickteStaff = "N";
                }
                else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "ASIGNADO")
                {
                    Persistentes.Status_TickteStaff = "AS";
                }
                else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "FINALIZADO" || Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "RESUELTO")
                {
                    Persistentes.Status_TickteStaff = "F";
                }
                else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "CERRADO")
                {
                    Persistentes.Status_TickteStaff = "CE";
                }
                else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "RECHAZADO")
                {
                    Persistentes.Status_TickteStaff = "R";
                }
                else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "ACTUANDO")
                {
                    Persistentes.Status_TickteStaff = "AC";
                }


                //if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "FINALIZADO")
                //    Persistentes.Ticket_Finalizado = true;
                //if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "CERRADO")
                //    Persistentes.Ticket_Cerrado = true;
                //if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "RECHAZADO")
                //    Persistentes.Ticket_Rechazado = true;
                //if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "NUEVO")
                //{
                //    Detalle.Btn_Traspaso.Visible = true;
                //    Detalle.Btn_Enviar.Enabled = true;
                //    Detalle.Btn_Rechazar.Enabled = true;
                //}
                //else if (Dgv_Tickets.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "ASIGNADO")
                //{
                //    Detalle.Btn_Finalizar.Enabled = true;
                //}
                DialogResult dr;
                dr = Detalle.ShowDialog();
                if (Filtro)
                {
                    Listar_Tickets(List_Ticktes, Filtro);
                }
                else if (Chk_Todos.Checked) //---------------------------------------------------------------------------
                {
                    //Listar_Tickets(new TicketRequest { Id_Rubro = Id_RubroSeleccionado }, Filtro);
                    //_ = Dgv_Tickets.SelectedRows[0].Selected=true;
                    //Listar_Tickets(new TicketRequest { Id_Rubro = Id_RubroSeleccionado }, Filtro);
                    Listar_Tickets(new TicketRequest { Id_Rubro = _IdRubro }, Filtro);
                    Dgv_Tickets.CurrentCell = Dgv_Tickets.Rows[_Posicion].Cells[0];
                    //if (_Posicion >= 0 && _Posicion < Dgv_Tickets.Rows.Count)
                    //{
                    //    Dgv_Tickets.CurrentCell = Dgv_Tickets.Rows[_Posicion].Cells[0];
                    //}
                    //else
                    //{
                    //   Listar_Tickets(new TicketRequest { Id_Rubro = _IdRubro }, Filtro);
                    //}
                }
                else if (dr == DialogResult.Yes)
                {
                    if (_Posicion + 1 < Dgv_Tickets.Rows.Count)
                    {
                        Check();
                        Dgv_Tickets.CurrentCell = Dgv_Tickets.Rows[_Posicion + 1].Cells[0];
                        Dgv_Tickets_CellClick_2(Dgv_Tickets, new DataGridViewCellEventArgs(0, _ = _Posicion + 1));
                    }
                    else
                    {
                        Check();
                        Dgv_Tickets.CurrentCell = Dgv_Tickets.Rows[0].Cells[0];
                        Dgv_Tickets_CellClick_2(Dgv_Tickets, new DataGridViewCellEventArgs(0, 0));
                    }
                }

                //if (dr != dialogresult.cancel)
                //{
                //    listar_tickets(new ticketrequest { id_rubro = id_rubroseleccionado }, false);
                //}
            }
        }

        //void Listar_Tickets_Status(string Status)
        //{
        //    //FLow.Controls.Clear();
        //    RubroRequest RubroRequest = new RubroRequest { Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento };
        //    foreach (var item in RubroRepository.ConsultarRubros(RubroRequest))
        //    {
        //        Lbl_Rubro.Text = item.Nombre;
        //        Id_RubroSeleccionado = Convert.ToInt32(item.Id_Rubro);
        //        Filtro = false;

        //        //Agregar(item.Nombre, item.Id_Rubro.ToString(), item.Img);
        //    }
        //    Listar_Tickets(new TicketRequest { Id_Rubro = Id_RubroSeleccionado, Status = Status }, false);
        //    Listar_TicketsPorStatus(new TicketRequest { Id_Rubro = Id_RubroSeleccionado, Status = Status }, false);
        //}
        bool Check()
        {
            if (Rdb_Nuevos.Checked)
            {
                Listar_Tickets_Status("A");
                return true;
            }
            if (Rdb_Asignados.Checked)
            {
                Listar_Tickets_Status("AS");
                return true;
            }
            if (Rdb_Actuando.Checked)
            {
                Listar_Tickets_Status("AC");
                return true;
            }
            if (Rdb_Terminados.Checked)
            {
                Listar_Tickets_Status("F");
                return true;
            }
            if (Rdb_Terminados.Checked)
            {
                Listar_Tickets_Status("CE");
                return true;
            }
            if (radioButton1.Checked)
            {
                Listar_Tickets_Status("R");
                return true;
            }
            return false;
        }

        private void Chk_Todos_CheckedChanged(object sender, EventArgs e) //---------------------
        {

            if (Chk_Todos.Checked)
            {
                Persistentes.General = false;
                Listar_Rubros();
            }
        }

        private void Rdb_Nuevos_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Nuevos.Checked)
            {
                Listar_Tickets_Status("A");
                Persistentes.General = true;
            }
            else
            {
                //Listar_Rubros();
            }
        }

        private void Rdb_Asignados_CheckedChanged(object sender, EventArgs e)
        {

            if (Rdb_Asignados.Checked)
            {
                Listar_Tickets_Status("AS");
                Persistentes.General = true;
            }
            else
            {
                //Listar_Rubros();
            }
        }

        private void Rdb_Actuando_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Actuando.Checked)
            {
                Listar_Tickets_Status("AC");
                Persistentes.General = true;
            }
            else
            {
                //Listar_Rubros();
            }
        }

        private void Rdb_Terminados_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Terminados.Checked)
            {
                Listar_Tickets_Status("F");
                Persistentes.General = true;
            }
            else
            {
                //Listar_Rubros();
            }
        }

        private void Rdb_Cerrados_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Cerrados.Checked)
            {
                Listar_Tickets_Status("CE");
                Persistentes.General = true;
            }
            else
            {
                //Listar_Rubros();
            }
        }

        private void Dgv_Tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                        if ((c.Value.ToString().ToUpper()).IndexOf(Txt_Filtro.text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow r in Dgv_Tickets.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        private void Lbl_Rubro_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Listar_Tickets_Status("R");
                Persistentes.General = true;
            }
            else
            {
                //Listar_Rubros();
            }
        }
    }
}
