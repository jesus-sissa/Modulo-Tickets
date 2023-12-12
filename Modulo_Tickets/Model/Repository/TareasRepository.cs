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
    class TareasRepository
    {
        public static void Status_Tareas_Procedimientos(TareasRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Status_Procedimiento_Tarea", cnn);
                Conexion.creaParametro(cmd, "@Id_tarea", SqlDbType.VarChar, model.Id_Tarea);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status);
                Conexion.creaParametro(cmd, "@Porcentaje", SqlDbType.VarChar, model.Porcentaje);
                Conexion.creaParametro(cmd, "@Autorizacion", SqlDbType.VarChar, model.Autorizacion);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static TareasRequest Consultar_IdTareas(TareasRequest model)
        {
            TareasRequest tareas = new TareasRequest();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Consultar_Idtarea", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, Persistentes.Id_Flujo);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tareas = new TareasRequest { Id_Tarea = dataReader.GetInt32(0)};
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tareas;
        }

        public static TareasRequest Consultar_Status_Procedimiento(TareasRequest model)
        {
            TareasRequest tareas = new TareasRequest();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Consultar_Status_Procedimientos", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, Persistentes.Id_Tarea);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tareas = new TareasRequest { Status = dataReader.GetString(0),Porcentaje = dataReader.GetString(1), Autorizacion= dataReader.GetString(2) };
                    //tareas.Add(new TareasRequest
                    //{
                    //    Status = dataReader.GetString(0)
                    //});;
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tareas;
        }

        public static CorreoResponseFlujo Correo_Seguimiento(TicketFlujoRequest model)
        {
            CorreoResponseFlujo Tickets = null;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Mail_Flujo", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Decimal, model.Id_Flujo);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    Tickets = new CorreoResponseFlujo
                    {
                        Id_Flujo = dataReader.GetInt32(0),
                        Nombre_Inv = dataReader.GetString(1),
                        Nombre_Dep_Inv = dataReader.GetString(2),
                        Mail_Inv = dataReader.GetString(3),
                        Extension_Inv = dataReader.GetString(4),
                        Descripcion = dataReader.GetString(5),
                        UsuarioReporta = dataReader.GetString(6),
                        UsuarioReportaMail = dataReader.GetString(7),
                        UsuarioReportaExtension = dataReader.GetString(8),
                        Archivo = dataReader.GetString(9) == "No existe" ? null : Convert.FromBase64String(dataReader.GetString(9)),
                        Nombre_Archivo = dataReader.GetString(10),
                        Id_Tarea = dataReader.GetInt32(11),
                        Nombre_Flujo = dataReader.GetString(12),
                    };
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Tickets;
        }
        public static CorreoResponseFlujo Correo_Seguimiento_Involucrados(TicketFlujoRequest model)
        {
            CorreoResponseFlujo Tickets = null;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Mail_Flujo_Involucrados", cnn);
                int ss = Persistentes.Id_Tarea_Flujo;
                int s = Persistentes.Id_Flujo;
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Decimal, Persistentes.Id_Tarea_Flujo);
                Conexion.creaParametro(cmd, "@Id_flujo", SqlDbType.Decimal, Persistentes.Id_Flujo);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Tickets = new CorreoResponseFlujo
                    {
                        Id_Flujo = dataReader.GetInt32(0),
                        Id_Tarea = dataReader.GetInt32(1),
                        Nombre_Inv = dataReader.GetString(2),
                        Nombre_Dep_Inv = dataReader.GetString(3),
                        Mail_Inv = dataReader.GetString(4),
                        Extension_Inv = dataReader.GetString(5),
                        Descripcion = dataReader.GetString(6),
                        UsuarioReporta = dataReader.GetString(7),
                        UsuarioReportaMail = dataReader.GetString(8),
                        UsuarioReportaExtension = dataReader.GetString(9),
                        Archivo = dataReader.GetString(10) == "No existe" ? null : Convert.FromBase64String(dataReader.GetString(10)),
                        Nombre_Archivo = dataReader.GetString(11),
                        Nombre_Flujo = dataReader.GetString(12)
                    };
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Tickets;
        }
        public static int Consultar_Departamentos_Inv(TicketFlujoRequest model)
        {
            DataTable cont ;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Dep_Involucrados", cnn);
                Conexion.creaParametro(cmd, "@Id_flujo", SqlDbType.Int, model.Id_Flujo);      
                cont = Conexion.ejecutaConsulta(cmd);

                if (cont.Rows.Count > 0)
                    return cont.Rows.Count;
                else
                    return 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }
        public static List<CorreoResponseFlujo>Consultacorreo(TicketFlujoRequest model)
        {
            List<CorreoResponseFlujo> correos = new List<CorreoResponseFlujo>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Mail_Flujo_Involucrados", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Decimal, Persistentes.Id_Tarea_Flujo);
                Conexion.creaParametro(cmd, "@Id_flujo", SqlDbType.Decimal, Persistentes.Id_Flujo);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    correos.Add(new CorreoResponseFlujo
                    {
                        Id_Flujo = dataReader.GetInt32(0),
                        Id_Tarea = dataReader.GetInt32(1),
                        Nombre_Inv = dataReader.GetString(2),
                        Mail_Inv = dataReader.GetString(4),
                    });
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return correos;
        }
        public static void Actualizar_Porcentaje(TicketFlujoRequest model, double Porcentaje)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Porcentaje", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, model.Id_Flujo);
                Conexion.creaParametro(cmd, "@Porcentaje", SqlDbType.Decimal,Porcentaje);
                Conexion.ejecutarNonquery(cmd);
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static int GuardarTicketFlujo(TicketFlujoRequest model)
        {
            int Numero_Flujo = 0;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tick_Flujo_Create", cnn);
                Conexion.creaParametro(cmd, "@Usuario_Registro", SqlDbType.Int, model.UsuarioId);
                Conexion.creaParametro(cmd, "@Descripcion", SqlDbType.Text, model.Descripcion);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Tareas);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status);
                Conexion.creaParametro(cmd, "@Porcentaje", SqlDbType.VarChar, model.Porcentaje);
                Conexion.creaParametro(cmd, "@Autorizacion", SqlDbType.VarChar, model.Autorizacion);
                Numero_Flujo = Convert.ToInt32(Conexion.ejecutaScalar(cmd));
                if (Numero_Flujo == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch(Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
            return Numero_Flujo;
        }
        public static List<TicketFlujoResponse>ConsultarTicketFlujo(TicketFlujoRequest model)
        {
            List<TicketFlujoResponse> ticketFlujos = new List<TicketFlujoResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_FlujoTickets", cnn);
                Conexion.creaParametro(cmd, "@Id_Usuario", SqlDbType.Int, model.UsuarioId);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    ticketFlujos.Add(new TicketFlujoResponse
                    {
                        _Id_Flujo = dataReader.GetInt32(0).ToString(),
                        _Descripcion = dataReader.GetString(1),
                        _Status = dataReader.GetString(2),
                        _Fecha_Inicio = dataReader.GetString(3),
                        _Porcentaje = dataReader.GetString(4),
                        _Autorizacion = dataReader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ticketFlujos;
        }
        public static List<TicketFlujoResponse>ConsultarFlujoGeneral(TicketFlujoRequest model)
        {
            List<TicketFlujoResponse> ticketFlujos = new List<TicketFlujoResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Flujos_ConsultarTodos", cnn);
                //int sss = Persistentes.Id_Departamento;
                int ss = Persistentes.UsuarioLogin_IdDepartamento;
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, Persistentes.UsuarioLogin_IdDepartamento);
                Conexion.creaParametro(cmd, "@Id_empleado", SqlDbType.Int, Persistentes.Usuario_Login);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ticketFlujos.Add(new TicketFlujoResponse
                    {
                        _Id_Flujo = dataReader.GetInt32(0).ToString(),
                        _Usuario_Reporta = dataReader.GetString(1),
                        _Nombre_Flujo = dataReader.GetString(2),
                        _Descripcion = dataReader.GetString(3),
                        _Status = dataReader.GetString(4),
                        _Fecha_Inicio = dataReader.GetString(5),
                        _Fecha_Resuelto = dataReader.GetString(6),
                        _Fecha_Fin = dataReader.GetString(7),
                        _Porcentaje = dataReader.GetString(8),
                        _Autorizacion = dataReader.GetString(9)
                    });
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            ticketFlujos.Reverse();
            return ticketFlujos;
        }
        public static List<TicketFlujoResponse> ConsultarFlujoPorStatus(TicketFlujoRequest model)
        {
            List<TicketFlujoResponse> ticketFlujos = new List<TicketFlujoResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Flujo_ConsultarPorStatus", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, Persistentes.UsuarioLogin_IdDepartamento);
                Conexion.creaParametro(cmd, "@Id_empleado", SqlDbType.Int, Persistentes.Usuario_Login);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status); // == null ? "T" : model.Status);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ticketFlujos.Add(new TicketFlujoResponse
                    {
                        _Id_Flujo = dataReader.GetInt32(0).ToString(),
                        _Usuario_Reporta = dataReader.GetString(1),
                        _Nombre_Flujo = dataReader.GetString(2),
                        _Descripcion = dataReader.GetString(3),
                        _Status = dataReader.GetString(4),
                        _Fecha_Inicio = dataReader.GetString(5),
                        _Fecha_Resuelto = dataReader.GetString(6),
                        _Fecha_Fin = dataReader.GetString(7),
                        _Porcentaje = dataReader.GetString(8),
                        _Autorizacion = dataReader.GetString(9)
                    });
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            ticketFlujos.Reverse();
            return ticketFlujos;
        }
        public static List<FlujoDResponse> ConsultarFlujoD_Soporte(BaseRequest model)
        {
            List<FlujoDResponse> flujoDs = new List<FlujoDResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_TicketFlujo_Id_Soporte", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, Persistentes.Id_Tarea);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    flujoDs.Add(new FlujoDResponse
                    {
                        Fecha=dataReader.GetString(0),
                        Hora=dataReader.GetString(1),
                        Descripcion=dataReader.GetString(2)
                    });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return flujoDs;
        }

        public static void GuardarSprintFlujo(TicketFlujoRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("TickFlujo_TareasD_Create", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, model.Id_Flujo);
                Conexion.creaParametro(cmd, "@Usuario_Registro", SqlDbType.Int, model.UsuarioId);
                Conexion.creaParametro(cmd, "@Descripcion", SqlDbType.Text, model.Descripcion);
                if (Convert.ToInt32(Conexion.ejecutarNonquery(cmd)) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch(Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Flujo_CerrarPorUsuario(TicketFlujoRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Flujo_CerrarPorUsuario", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, model.Id_Flujo);
                Conexion.creaParametro(cmd, "@Descripcion_Cierre", SqlDbType.VarChar, model.Descripcion);
                Conexion.creaParametro(cmd, "@Estrellas", SqlDbType.Int, model.Estrellas);

                if (Convert.ToInt32(Conexion.ejecutarNonquery(cmd)) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static ReporteTicketsEncabezadoResponse ReporteTicketFlujo_General(ReporteFlujoRequest model)
        {
            DataTable tbl;
            ReporteTicketsEncabezadoResponse reporte;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Reporte_Flujos_Total", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Dpto);
                Conexion.creaParametro(cmd, "@Id_Empleado", SqlDbType.Int, model.Id_Empleado);
                tbl = Conexion.ejecutaConsulta(cmd);
                reporte = new ReporteTicketsEncabezadoResponse
                {
                    Finalizados = Convert.ToInt32(tbl.Rows[0][0].ToString()),
                    Cerrados = Convert.ToInt32(tbl.Rows[0][1].ToString()),
                    Total = Convert.ToInt32(tbl.Rows[0][2].ToString()),
                    Actuando = Convert.ToInt32(tbl.Rows[0][3].ToString()),
                };
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reporte;
        }
        public static List<ReporteTicketsResponse>ConsultarTicketFlujo_Todos(ReporteFlujoRequest model)
        {
            List<ReporteTicketsResponse> tickets = new List<ReporteTicketsResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Reporte_Flujo_Todos", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Dpto);
                Conexion.creaParametro(cmd, "@Id_Empleado", SqlDbType.Int, model.Id_Empleado);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tickets.Add(new ReporteTicketsResponse
                    {
                        Numero_Flujo = dataReader.GetInt32(0),
                        Sucursal = dataReader.GetString(1),
                        Nombre = dataReader.GetString(2),
                        Descripcion = dataReader.GetString(3),
                        Fecha_Registro = dataReader.GetString(4),
                        Fecha_Finalizacion = dataReader.GetString(5),
                        Fecha_Cierre = dataReader.GetString(6),
                        Estrellas = dataReader.GetInt32(7),
                        Status = dataReader.GetString(8),
                        Tiempo_Respuesta = dataReader.GetString(9),
                        Departamento = dataReader.GetString(10),
                        Porcentaje = dataReader.GetString(11),
                        Autorizacion = dataReader.GetString(12)
                    });
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tickets;
        }
        //Guardar_status esta en TicketRepository 
        public static TicketFlujoRequest ConsultarFlujo_status(TicketFlujoRequest model)
        {
            DataTable data;
            TicketFlujoRequest ticket = new TicketFlujoRequest();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("FlujosStatus", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, model.Id_Flujo);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, Persistentes.UsuarioLogin_IdDepartamento);
                data = Conexion.ejecutaConsulta(cmd);
                foreach (DataRow row in data.Rows)
                {
                    ticket = new TicketFlujoRequest
                    {
                        Status = row["Status"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
            return ticket;
        }
        public static List<TareasResponse> Consultar(TareasRequest model)
        {
            DataTable tbl;
            List<TareasResponse> Categorias = new List<TareasResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tareas_ReadAll", cnn);

                tbl = Conexion.ejecutaConsulta(cmd);

                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new TareasResponse
                    {
                        Id_Tarea = Convert.ToInt32(Row["Id_Tarea"].ToString()),
                        Nombre = Row["Nombre"].ToString(),
                        Id_Formato = Convert.ToInt32(Row["Id_Formato"].ToString())
                    });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }
        public static List<TareasDptosResponse> Consultar_Dptos(TareasRequest model)
        {
            DataTable tbl;
            List<TareasDptosResponse> Categorias = new List<TareasDptosResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tareas_Departamentos", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Tarea);
                tbl = Conexion.ejecutaConsulta(cmd);

                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new TareasDptosResponse
                    {
                        Id_Dptos = Convert.ToInt32(Row["Id_TDptos"].ToString()),
                        Nombre_Dpto = Row["Descripcion"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }
        public static List<TareasDptosResponse> Consultar_Departamentos(TareasRequest model)
        {
            DataTable tbl;
            List<TareasDptosResponse> Categorias = new List<TareasDptosResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tareas_DptosT", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Tarea);
                tbl = Conexion.ejecutaConsulta(cmd);

                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new TareasDptosResponse
                    {
                        Id_Dptos = Convert.ToInt32(Row["Id_Departamento"].ToString()),
                        Nombre_Dpto = Row["Descripcion"].ToString(),
                        Status = Row["Status"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }
        public static List<TareasUsuariosResponse> Consultar_UsuariosT(TareasRequest model)
        {
            DataTable tbl;
            List<TareasUsuariosResponse> Categorias = new List<TareasUsuariosResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tareas_UsuariosT", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Dpto);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Tarea);
                tbl = Conexion.ejecutaConsulta(cmd);

                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new TareasUsuariosResponse
                    {
                        Id_Empleado = Convert.ToInt32(Row["Id_Empleado"].ToString()),
                        Nombre = Row["Nombre"].ToString(),
                        Status = Convert.ToInt32(Row["Status"].ToString())
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }
        public static List<TareasUsuariosResponse> Consultar_Usuarios(TareasRequest model)
        {
            DataTable tbl;
            List<TareasUsuariosResponse> Categorias = new List<TareasUsuariosResponse>();
            SqlCommand cmd = null;
            try
            { 
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tareas_Usuarios", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Dpto);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Tarea);
                tbl = Conexion.ejecutaConsulta(cmd);

                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new TareasUsuariosResponse
                    {
                        Id_Empleado = Convert.ToInt32(Row["Id_Empleado"].ToString()),
                        Nombre = Row["Nombre"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }
        public static void Guardar(TareasRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tareas_SaveAll", cnn);
                Conexion.creaParametro(cmd, "@Nombre", SqlDbType.VarChar, model.Nombre);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Guardar_TareasDptos(TareasRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tareas_DptosGuardar", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Dpto);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Tarea);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Guardar_TareasEmpleados(TareasUsuariosResquest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tareas_EmpleadosGuardar", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Dpto);
                Conexion.creaParametro(cmd, "@Id_Empleado", SqlDbType.Int, model.Id_Empleado);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static bool Flujos_Resuelto(TicketFlujoRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("TareasF_Status", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, model.Id_Flujo);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int,Persistentes.UsuarioLogin_IdDepartamento);
                if (Convert.ToInt32(Conexion.ejecutarNonquery(cmd)) == 0)
                    return false;
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
            return true;
        }
    }
}