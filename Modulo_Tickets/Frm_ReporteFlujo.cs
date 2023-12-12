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
    public partial class Frm_ReporteFlujo : Form
    {
        public Frm_ReporteFlujo()
        {
            InitializeComponent();
        }

        private void Frm_ReporteFlujo_Load(object sender, EventArgs e)
        {
            ReporteTicketsEncabezadoResponse reporte;
            ReporteFlujoRequest reporteFlujo = new ReporteFlujoRequest {Id_Dpto = Persistentes.UsuarioLogin_IdDepartamento, Id_Empleado = Persistentes.Usuario_Login };
            reporte = TareasRepository.ReporteTicketFlujo_General(reporteFlujo);
            Lbl_Total.Text = reporte.Total.ToString();
            Lbl_Finalizados.Text = reporte.Finalizados.ToString();
            Lbl_Cerrados.Text = reporte.Cerrados.ToString();
            Lbl_Actuando.Text = reporte.Actuando.ToString();
            Listar_TicketFlujo();
        }
        void Listar_TicketFlujo()
        {
            List<ReporteTicketsResponse> Ticket;
            ReporteFlujoRequest _Reporte = new ReporteFlujoRequest { Id_Dpto = Persistentes.UsuarioLogin_IdDepartamento, Id_Empleado = Persistentes.Usuario_Login };
            Ticket = TareasRepository.ConsultarTicketFlujo_Todos(_Reporte);
            foreach (var item in Ticket)
            {
                Dgv_Tickets.Rows.Add(item.Numero_Flujo, item.Fecha_Registro, item.Sucursal, item.Nombre, item.Descripcion, item.Fecha_Finalizacion, item.Fecha_Cierre, item.Tiempo_Respuesta, item.Estrellas,item.Status,item.Porcentaje, item.Autorizacion);
            }
        }

        private void Lbl_Rubro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_Tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Actuando_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Finalizados_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Cerrados_Click(object sender, EventArgs e)
        {

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
                        if (columna.Index == 1 || columna.Index == 5 || columna.Index == 6)
                        {

                            string _Fecha = fila.Cells[columna.Index].Value.ToString();
                            if (_Fecha != "")
                            {
                                _Fecha = Convert.ToDateTime(_Fecha).ToString("dd/MM/yyyy hh:mm tt");
                                exHoja.Cells[fila.Index + 2, columna.Index + 1] = _Fecha;
                            }
                            else
                            {
                                exHoja.Cells[fila.Index + 2, columna.Index + 1] = _Fecha;
                            }
                            // exHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value.ToString();

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
    }
}
