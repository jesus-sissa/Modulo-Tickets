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
    public partial class Frm_ReporteTickets : Form
    {
        int _IdRubro = 0;
        public Frm_ReporteTickets()
        {
            InitializeComponent();
        }
        private void Frm_ReporteTickets_Load(object sender, EventArgs e)
        {
            //RubroRequest Rubro;
            //Rubro = new RubroRequest { Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento };
            //foreach (var item in RubroRepository.ConsultarRubros(Rubro))
            //{
            //    _IdRubro = item.Id_Rubro;
            //}
            //DepartamentosRequest departamentos = new DepartamentosRequest();
            //departamentos = DepartamentosRepository.Consultardepartamentos(departamentos);
            //Persistentes.Id_Departamento = departamentos.Id_Departamento;
            _IdRubro = Persistentes.Id_Rubro;
            ReporteTicketsEncabezadoResponse _Response;
            ReporteRequest _Reporte = new ReporteRequest { Id_Rubro=_IdRubro};
            _Response=ReporteRepository.ReporteTicket_General(_Reporte);
            Lbl_Total.Text = _Response.Total.ToString();
            Lbl_Nuevos.Text = _Response.Nuevos.ToString();
            Lbl_Asignados.Text = _Response.Asignados.ToString();
            Lbl_Finalizados.Text = _Response.Finalizados.ToString();
            Lbl_Cerrados.Text = _Response.Cerrados.ToString();
            Lbl_Rechazados.Text = _Response.Rechazados.ToString();
            Lbl_Actuando.Text = _Response.Actuando.ToString();
            Lbl_Rubro.Text = Persistentes.Nombre_Rubro;
            Tickets_Anuales();
        }

        void Tickets_Anuales()
        {
            RubroRequest Rubro;
            Rubro = new RubroRequest { Id_Departamento = Persistentes.Id_Departamento };
            foreach (var item in RubroRepository.ConsultarRubros(Rubro))
            {
                _IdRubro = item.Id_Rubro;
            }
            List<ReporteTicketsResponse> Tickets;
            ReporteRequest _Reporte = new ReporteRequest { Id_Rubro = _IdRubro };
            Tickets = ReporteRepository.ConsultarTicket_PorRubro(_Reporte);
            foreach (var item in Tickets)
            {

                Dgv_Tickets.Rows.Add(item.Numero, item.Fecha_Registro,item.Fecha_Registro,item.Sucursal, item.Departamento,item.Descripcion, item.Asignadoa, item.Fecha_Asignacion, item.Fecha_Asignacion, item.Fecha_Actuando, item.Fecha_Actuando, item.Fecha_Proveedor_IN, item.Fecha_Proveedor_IN, item.Fecha_Proveedor_Fn, item.Fecha_Proveedor_Fn, item.Fecha_Finalizacion, item.Fecha_Finalizacion, item.Fecha_Cierre, item.Fecha_Cierre, item.Fecha_Cancela, item.Fecha_Cancela, item.Categoria,item.SubCategoria, item.Nivel_Servicio,item.Tiempo_Respuesta, item.Estrellas, item.Status, item.Descripcion_Final);

            }
        }
        void Tablero_Filtro()
        {
            RubroRequest Rubro;
            Rubro = new RubroRequest { Id_Departamento = Persistentes.Id_Departamento };
            foreach (var item in RubroRepository.ConsultarRubros(Rubro))
            {
                _IdRubro = item.Id_Rubro;
            }
            ReporteTicketsEncabezadoResponse _Response;
            ReporteRequest _Reporte = new ReporteRequest { Id_Rubro = _IdRubro, Status = Persistentes.Status, Fecha_Inicio = Persistentes.Fecha_Inicio, Fecha_Fin = Persistentes.Fecha_Fin };
            _Response = ReporteRepository.ReporteTicket_Filtro(_Reporte);
            Lbl_Total.Text = _Response.Total.ToString();
            Lbl_Nuevos.Text = _Response.Nuevos.ToString();
            Lbl_Asignados.Text = _Response.Asignados.ToString();
            Lbl_Finalizados.Text = _Response.Finalizados.ToString();
            Lbl_Cerrados.Text = _Response.Cerrados.ToString();
            Lbl_Rechazados.Text = _Response.Rechazados.ToString();
            Lbl_Actuando.Text = _Response.Actuando.ToString();
        }
        void Tickets_Filtro()
        {
            RubroRequest Rubro;
            Rubro = new RubroRequest { Id_Departamento = Persistentes.Id_Departamento };
            foreach (var item in RubroRepository.ConsultarRubros(Rubro))
            {
                _IdRubro = item.Id_Rubro;
            }
            List<ReporteTicketsResponse> Tickets;
            ReporteRequest _Reporte = new ReporteRequest { Id_Rubro =_IdRubro,Status=Persistentes.Status,Fecha_Inicio=Persistentes.Fecha_Inicio,Fecha_Fin=Persistentes.Fecha_Fin };
            Tickets = ReporteRepository.ConsultarTicket_PorFiltro(_Reporte);
            Dgv_Tickets.Rows.Clear();
            foreach (var item in Tickets)
            {

                //Dgv_Tickets.Rows.Add(item.Numero, item.Fecha_Registro, item.Departamento, item.Asignadoa, item.Fecha_Asignacion, item.Fecha_Finalizacion, item.Fecha_Cierre, item.Fecha_Cancela,item.Categoria,item.SubCategoria, item.Nivel_Servicio, item.Tiempo_Respuesta, item.Estrellas, item.Status);
                Dgv_Tickets.Rows.Add(item.Numero, item.Fecha_Registro, item.Fecha_Registro, item.Sucursal, item.Departamento, item.Descripcion, item.Asignadoa, item.Fecha_Asignacion, item.Fecha_Asignacion, item.Fecha_Actuando, item.Fecha_Actuando, item.Fecha_Proveedor_IN, item.Fecha_Proveedor_IN, item.Fecha_Proveedor_Fn, item.Fecha_Proveedor_Fn, item.Fecha_Finalizacion, item.Fecha_Finalizacion, item.Fecha_Cierre, item.Fecha_Cierre, item.Fecha_Cancela, item.Fecha_Cancela, item.Categoria, item.SubCategoria, item.Nivel_Servicio, item.Tiempo_Respuesta, item.Estrellas, item.Status, item.Descripcion_Final);

            }
        }
        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            
            Frm_FiltroBusqueda frm = new Frm_FiltroBusqueda();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Tickets_Filtro();
                Tablero_Filtro();
            }

        }

        private void Btn_Exportar_Click(object sender, EventArgs e)
        {
            
            llenarExcel(Dgv_Tickets);
        }
        public bool llenarExcel(DataGridView ElGrid)
        {

            // Creamos las variables
            //ElGrid.Columns(0).Name = "Id";
            //ElGrid.Columns(1).Name = "Nombre";
            //ElGrid.Columns(2).Name = "Apellido";
            //ElGrid.Columns(3).Name = "Edad";

            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbook exLibro;

            Microsoft.Office.Interop.Excel.Worksheet exHoja;

            try
            {

                // Añadimos el Libro al programa, y la hoja al libro

                exLibro = exApp.Workbooks.Add();

                exHoja = exLibro.Worksheets.Add();

                // ¿Cuantas columnas y cuantas filas?

                int NCol = ElGrid.ColumnCount;

                int NRow = ElGrid.RowCount;

                // Aqui recorremos todas las filas, y por cada fila todas las columnas

                // y vamos escribiendo.
                Progrees.Visible = true;
                Progrees.Value = 0;
                Progrees.MaxValue = ElGrid.Columns.Count;

                foreach (DataGridViewColumn columna in ElGrid.Columns)
                {
                    exHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                    foreach (DataGridViewRow fila in ElGrid.Rows)
                    {
                        if (columna.Index == 1 || columna.Index == 7 || columna.Index == 9|| columna.Index == 11 || columna.Index == 13 || columna.Index == 15 || columna.Index == 17 || columna.Index == 19)
                        {
                            string _Fecha = fila.Cells[columna.Index].Value.ToString();
                            if (_Fecha != "")
                            {
                                //_Fecha = Convert.ToDateTime(_Fecha).ToString("dd/MM/yyyy");
                                //exHoja.Cells[fila.Index + 2, columna.Index + 1] = _Fecha;
                                _Fecha = Convert.ToDateTime(_Fecha).ToString("yyyy/MM/dd");
                                exHoja.Cells[fila.Index + 2, columna.Index + 1] = _Fecha;
                            }
                            else
                            {
                                exHoja.Cells[fila.Index + 2, columna.Index + 1] = _Fecha;                                
                            }
                           // exHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value.ToString();

                        }
                        else if(columna.Index == 2 || columna.Index == 8 || columna.Index == 10 || columna.Index == 12 || columna.Index == 14 || columna.Index == 16 || columna.Index == 18 || columna.Index == 20)
                        {
                            string _Fecha = fila.Cells[columna.Index].Value.ToString();
                            if (_Fecha != "")
                            {
                                _Fecha = Convert.ToDateTime(_Fecha).ToString("hh: mm tt");
                                exHoja.Cells[fila.Index + 2, columna.Index + 1] = _Fecha;
                            }
                            else
                            {
                                exHoja.Cells[fila.Index + 2, columna.Index + 1] = _Fecha;
                            }
                        }
                        else
                        {
                            exHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value.ToString();
                        }
                    }
                    Progrees.Value += 1;
                }
                // Titulo en negrita, Alineado al centro y que el tamaño de la columna

                // se ajuste al texto

                exHoja.Rows.Item[1].Font.Bold = 1;

                exHoja.Rows.Item[1].HorizontalAlignment = 3;

                exHoja.Columns.AutoFit();

                // Aplicación visible
                Progrees.Visible = false;
                exApp.Application.Visible = true;

                exHoja = null/* TODO Change to default(_) if this is not a reference type */;

                exLibro = null/* TODO Change to default(_) if this is not a reference type */;

                exApp = null/* TODO Change to default(_) if this is not a reference type */;
            }
            catch (Exception ex)
            {              
                return false;
            }

            return true;
        }

        private void Dgv_Tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCards6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_Rubro_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Nuevos_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
