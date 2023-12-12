using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets.Model.Repository
{
    class ReporteRepository
    {
        public static ReporteTicketsEncabezadoResponse ReporteTicket_General(ReporteRequest model)
        {
            DataTable tbl;
            ReporteTicketsEncabezadoResponse Reporte;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Reporte_Ticktes_Total", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Decimal, model.Id_Rubro);
                tbl = Conexion.ejecutaConsulta(cmd);


                    Reporte = new ReporteTicketsEncabezadoResponse
                    {
                        Nuevos =Convert.ToInt32( tbl.Rows[0][0].ToString()),
                        Asignados = Convert.ToInt32(tbl.Rows[0][1].ToString()),
                        Finalizados = Convert.ToInt32(tbl.Rows[0][2].ToString()),
                        Cerrados = Convert.ToInt32(tbl.Rows[0][3].ToString()),
                        Rechazados = Convert.ToInt32(tbl.Rows[0][4].ToString()),
                        Total= Convert.ToInt32(tbl.Rows[0][5].ToString()),
                        Actuando = Convert.ToInt32(tbl.Rows[0][6].ToString()),
                    };                                                    
                cmd.Connection.Close();
            }
            catch(Exception ex)
            {

                throw ex;
            }
            return Reporte;
        }
        public static ReporteTicketsEncabezadoResponse ReporteTicket_Filtro(ReporteRequest model)
        {
            DataTable tbl;
            ReporteTicketsEncabezadoResponse Reporte;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Reporte_Ticktes_TotalFiltro", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Decimal, model.Id_Rubro);
                Conexion.creaParametro(cmd, "@Fecha_Inicio", SqlDbType.Date, model.Fecha_Inicio);
                Conexion.creaParametro(cmd, "@Fecha_Fin", SqlDbType.Date, model.Fecha_Fin);
                tbl = Conexion.ejecutaConsulta(cmd);


                Reporte = new ReporteTicketsEncabezadoResponse
                {
                    Nuevos = Convert.ToInt32(tbl.Rows[0][0].ToString()),
                    Asignados = Convert.ToInt32(tbl.Rows[0][1].ToString()),
                    Finalizados = Convert.ToInt32(tbl.Rows[0][2].ToString()),
                    Cerrados = Convert.ToInt32(tbl.Rows[0][3].ToString()),
                    Rechazados = Convert.ToInt32(tbl.Rows[0][4].ToString()),
                    Total = Convert.ToInt32(tbl.Rows[0][5].ToString()),
                    Actuando= Convert.ToInt32(tbl.Rows[0][6].ToString())
                };
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Reporte;
        }
        public static void  GuardarFechas(FechasRequest model) // se esta agregando para una prueba 
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("GuardarFechas", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", System.Data.SqlDbType.VarChar, model.Id_Ticket);
                Conexion.creaParametro(cmd, "@Tipo", SqlDbType.Int, model.Tipo);
                Conexion.ejecutarNonquery(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void GuardarFechas_Fin(FechasRequest model) // se esta agregando para una prueba 
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("GuardarFechas_Fin", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", System.Data.SqlDbType.VarChar, model.Id_Ticket);
                Conexion.ejecutarNonquery(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<ReporteTicketsResponse> ConsultarTicket_PorRubro(ReporteRequest model)
        {
            List<ReporteTicketsResponse> Tickets = new List<ReporteTicketsResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Reporte_Tickets_Todos", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Decimal, model.Id_Rubro);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new ReporteTicketsResponse
                    {
                        Numero = dataReader.GetDecimal(0),
                        Sucursal = dataReader.GetString(1),// agregado para nombre sucursal
                        Fecha_Registro = dataReader.GetString(2),
                        Fecha_Asignacion = dataReader.GetString(3),
                        Fecha_Finalizacion = dataReader.GetString(4),
                        Fecha_Cierre = dataReader.GetString(5),
                        Fecha_Cancela = dataReader.GetString(6),
                        Fecha_Proveedor_IN = dataReader.GetString(7), //se sigue trabajando con las variables 
                        Fecha_Proveedor_Fn = dataReader.GetString(8), // se sigue trabajando con las variables
                        Nivel_Servicio = dataReader.GetString(9),
                        Estrellas = dataReader.GetInt32(10),
                        Status = dataReader.GetString(11),
                        Asignadoa = dataReader.GetString(12),
                        Tiempo_Respuesta = dataReader.GetString(13),
                        Departamento = dataReader.GetString(14),
                        Categoria = dataReader.GetString(15),
                        Descripcion = dataReader.GetString(16),
                        Fecha_Actuando = dataReader.GetString(17),
                        SubCategoria = dataReader.GetString(18),
                        Descripcion_Final = dataReader.GetString(19),

                    });
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Tickets;
        }
        public static List<ReporteTicketsResponse> ConsultarTicket_PorFiltro(ReporteRequest model)
        {
            List<ReporteTicketsResponse> Tickets = new List<ReporteTicketsResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Reporte_Tickets_TodosFiltro", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Decimal, model.Id_Rubro);
                Conexion.creaParametro(cmd, "@Fecha_Inicio", SqlDbType.Date,model.Fecha_Inicio);
                Conexion.creaParametro(cmd, "@Fecha_Fin", SqlDbType.Date,model.Fecha_Fin);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar,model.Status);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new ReporteTicketsResponse
                    {
                        //Numero = dataReader.GetDecimal(0),
                        //Fecha_Registro = dataReader.GetString(1),
                        //Fecha_Asignacion = dataReader.GetString(2),
                        //Fecha_Finalizacion = dataReader.GetString(3),
                        //Fecha_Cierre = dataReader.GetString(4),
                        //Fecha_Cancela = dataReader.GetString(5),
                        //Nivel_Servicio = dataReader.GetString(6),
                        //Estrellas = dataReader.GetInt32(7),
                        //Status = dataReader.GetString(8),
                        //Asignadoa = dataReader.GetString(9),
                        //Tiempo_Respuesta = dataReader.GetString(10),
                        //Departamento = dataReader.GetString(11),
                        //Categoria = dataReader.GetString(12),
                        //Descripcion= dataReader.GetString(13),
                        //Fecha_Actuando= dataReader.GetString(14),
                        //SubCategoria = dataReader.GetString(15)
                        Numero = dataReader.GetDecimal(0),
                        Sucursal = dataReader.GetString(1),// agregado para nombre sucursal
                        Fecha_Registro = dataReader.GetString(2),
                        Fecha_Asignacion = dataReader.GetString(3),
                        Fecha_Finalizacion = dataReader.GetString(4),
                        Fecha_Cierre = dataReader.GetString(5),
                        Fecha_Cancela = dataReader.GetString(6),
                        Fecha_Proveedor_IN = dataReader.GetString(7), //se sigue trabajando con las variables 
                        Fecha_Proveedor_Fn = dataReader.GetString(8), // se sigue trabajando con las variables
                        Nivel_Servicio = dataReader.GetString(9),
                        Estrellas = dataReader.GetInt32(10),
                        Status = dataReader.GetString(11),
                        Asignadoa = dataReader.GetString(12),
                        Tiempo_Respuesta = dataReader.GetString(13),
                        Departamento = dataReader.GetString(14),
                        Categoria = dataReader.GetString(15),
                        Descripcion = dataReader.GetString(16),
                        Fecha_Actuando = dataReader.GetString(17),
                        SubCategoria = dataReader.GetString(18),
                        Descripcion_Final = dataReader.GetString(19),
                    });
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Tickets;
        }
    }
}
