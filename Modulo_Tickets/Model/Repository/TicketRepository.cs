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
    class TicketRepository
    {
        public string Documento { get; internal set; }

        public static void RegresarTicket(TicketRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("TicketRegresado", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.VarChar, model.Id_Ticket);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static TicketRequest Consultar_FechaResuelto(TicketRequest model)
        {
            TicketRequest ticket = new TicketRequest();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("TicketRegresar_Hora", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Ticket);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    ticket = new TicketRequest
                    {
                        Fecha_Fin = dataReader.GetDateTime(0)
                    };
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ticket;
        }

        public static int GuardarTicket(TicketRequest model)
        {
            int Numero_Ticket = 0;
            SqlCommand cmd = null;
            try
            {               
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tick_Tareas_Create", cnn);
                Conexion.creaParametro(cmd, "@Usuario_Registro", SqlDbType.Int, model.UsuarioId);
                Conexion.creaParametro(cmd, "@Clave_Modulo", SqlDbType.VarChar, model.Clave_Modulo);
                Conexion.creaParametro(cmd, "@Opcion", SqlDbType.VarChar, model.Opcion);
                Conexion.creaParametro(cmd, "@Descripcion", SqlDbType.Text, model.Descripcion);
                Conexion.creaParametro(cmd, "@Tipo", SqlDbType.Int, model.Tipo);
                Conexion.creaParametro(cmd, "@Id_Opcion", SqlDbType.Int, model.Id_Opcion);
                Conexion.creaParametro(cmd, "@Id_Reporte", SqlDbType.Int, model.Id_Reporte); 
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Int, model.Id_Rubro);
                Conexion.creaParametro(cmd, "@Id_Cliente", SqlDbType.Int, model.Id_Cliente);
                Numero_Ticket =Convert.ToInt32( Conexion.ejecutaScalar(cmd));
                if (Numero_Ticket == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
            return Numero_Ticket;
        }
        public static int Guardar_Formatos(ImagenRequest model)
        {
            SqlCommand cmd = null;
                try
                {
                    SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                    cmd = Conexion.creaComando("Tickets_Archivoss_Guardar", cnn);
                    Conexion.creaParametro(cmd, "@Nombre", System.Data.SqlDbType.VarChar,model.Nombre);
                    Conexion.creaParametro(cmd, "@Extension", System.Data.SqlDbType.VarChar,model.Extension);
                    Conexion.creaParametro(cmd, "@Formato", System.Data.SqlDbType.VarChar, "");
                    Conexion.creaParametro(cmd, "@Base64", System.Data.SqlDbType.VarChar, model.Base64);
                    Conexion.creaParametro(cmd, "@Peso", System.Data.SqlDbType.VarChar, "0");
                    Conexion.creaParametro(cmd, "@Id_Ticket", System.Data.SqlDbType.VarChar, model.Id_Ticket);
                    Conexion.creaParametro(cmd, "@Id_Flujo", System.Data.SqlDbType.VarChar, model.Id_Flujo);
                    if (Conexion.ejecutarNonquery(cmd) == 0)
                        return 0;

                }
                catch (Exception ex)
                {
                    return 0;
                }
            return 1;

        }
        public static int Guardar_Archivos(List<ImagenRequest> model, int Id_Ticket, int Id_Flujo)
        {
            SqlCommand cmd = null;
            try
            {
                foreach (var file in model)
                {
                    SqlConnection cnn = Conexion.creaConexion(file.ClaveSucursal);
                    cmd = Conexion.creaComando("Tickets_Archivoss_Guardar", cnn);
                    Conexion.creaParametro(cmd, "@Nombre", System.Data.SqlDbType.VarChar, file.Nombre);
                    Conexion.creaParametro(cmd, "@Extension", System.Data.SqlDbType.VarChar, file.Extension);
                    Conexion.creaParametro(cmd, "@Formato", System.Data.SqlDbType.VarChar, "");
                    Conexion.creaParametro(cmd, "@Base64", System.Data.SqlDbType.VarChar, file.Base64);
                    Conexion.creaParametro(cmd, "@Peso", System.Data.SqlDbType.VarChar, "0");
                    Conexion.creaParametro(cmd, "@Id_Ticket", System.Data.SqlDbType.VarChar, Id_Ticket);
                    Conexion.creaParametro(cmd, "@Id_Flujo", System.Data.SqlDbType.VarChar, Id_Flujo);
                    if (Conexion.ejecutarNonquery(cmd) == 0)
                        return 0;

                }

            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;
        }
        public static int Guardar_Statuss(TicketFlujoRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Flujos_Status2", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", System.Data.SqlDbType.VarChar, model.Id_Flujo);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    return 0;

            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;

        }
        public ImagenRequest GetDocumento(int Ticket, int Flujo)
        {
            ImagenRequest imagenRequest = new ImagenRequest();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(Persistentes.ClaveSucursal);
                cmd = Conexion.creaComando("Ver_Archivos_Ticket", cnn);
                Conexion.creaParametro(cmd, "@ticket", SqlDbType.Int, Ticket);
                Conexion.creaParametro(cmd, "@Flujo", SqlDbType.Int, Flujo);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    imagenRequest.Id_Ticket = Ticket;
                    if (dataReader.GetString(0) == null)
                    {
                        imagenRequest.Nombre = "";
                    }
                    else
                    {
                        imagenRequest.Nombre = dataReader.GetString(0);
                    }
                    if (dataReader.GetValue(2) != System.DBNull.Value)
                    {
                        byte[] documentoBytes = Convert.FromBase64String(dataReader.GetValue(2).ToString());
                        imagenRequest.Archivo_Byte = documentoBytes;
                    }
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return imagenRequest;
        }
        public static List<ImagenRequest> Consulta(ImagenRequest model)
        {
            DataTable tbl;
            List<ImagenRequest> imagen = new List<ImagenRequest>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Ver_Archivos_Ticket", cnn);
                Conexion.creaParametro(cmd, "@ticket", SqlDbType.Int, model.Id_Ticket);
                Conexion.creaParametro(cmd, "@Flujo", SqlDbType.Int, model.Id_Flujo);
                tbl = Conexion.ejecutaConsulta(cmd);
                foreach (DataRow Row in tbl.Rows)
                {
                    imagen.Add(new ImagenRequest
                    {
                        Id = Row["Id"].ToString(),
                        Nombre = Row["Nombre_Archivo"].ToString(),
                        Base64 = Row["Archivo"].ToString(),
                    });
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return imagen;
        }
        public static int AsignarTicket(TicketRequest model)
        {
            int Numero_Ticket = 0;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tick_Tareas_Asignar", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Ticket);
                Conexion.creaParametro(cmd, "@Usuario_Asignado", SqlDbType.Int, model.Id_UsuarioA);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
            return Numero_Ticket;
        }
        public static List<TicketResponse> ConsultarTicketGeneral(TicketRequest model)
        {
            List<TicketResponse> Tickets = new List<TicketResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_Tickets", cnn);
                Conexion.creaParametro(cmd, "@Id_Usuario", SqlDbType.Decimal, model.UsuarioId);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new TicketResponse
                    {
                        _NumeroTicket = dataReader.GetDecimal(0).ToString(),                        
                        _Descripcion = dataReader.GetString(1),
                        _Status = dataReader.GetString(2),
                        _Fecha = dataReader.GetString(3),
                        _SolicitudCambio = dataReader.GetString(6)
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
        public static List<TicketResponse> ConsultarTicket_FiltroUsuario(TicketRequest model)
        {
            List<TicketResponse> Tickets = new List<TicketResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_TicketsFiltro_Usuario", cnn);
                Conexion.creaParametro(cmd, "@Id_Usuario", SqlDbType.Decimal, model.UsuarioId);
                Conexion.creaParametro(cmd, "@Fecha_Inicio", SqlDbType.Date, model.Fecha_Inicio);
                Conexion.creaParametro(cmd, "@Fecha_Fin", SqlDbType.Date, model.Fecha_Fin);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new TicketResponse
                    {
                        _NumeroTicket = dataReader.GetDecimal(0).ToString(),
                        _Descripcion = dataReader.GetString(1),
                        _Status = dataReader.GetString(2),
                        _Fecha = dataReader.GetString(3),
                        _SolicitudCambio = dataReader.GetString(6)
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
        //public static List<TicketResponse> ConsultarTicket(TicketRequest model)
        //{
        //    List<TicketResponse> Tickets = new List<TicketResponse>();
        //    SqlCommand cmd = null;
        //    try
        //    {
        //        SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
        //        cmd = Conexion.creaComando("Usr_Tickets", cnn);
        //        Conexion.creaParametro(cmd, "@Id_Usuario", SqlDbType.Decimal, model.UsuarioId);
        //        cmd.Connection.Open();

        //        SqlDataReader dataReader = cmd.ExecuteReader();

        //        while (dataReader.Read())
        //        {
        //            Tickets.Add(new TicketResponse
        //            {
        //                _NumeroTicket=dataReader.GetDecimal(0).ToString(),
        //                _Descripcion=dataReader.GetString(1),
        //                _Status=dataReader.GetString(2),
        //                _Fecha=dataReader.GetString(3),
        //                _AsignadoA=dataReader.GetString(4),
        //                Id_Rubro=dataReader.GetInt32(5)
        //            });
        //        }
        //        cmd.Connection.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    return Tickets;
        //}
        public static List<TicketResponse> ConsultarTicket_PorRubro(TicketRequest model)
        {
            List<TicketResponse> Tickets = new List<TicketResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tickets_ConsultarTodos", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Decimal, model.Id_Rubro);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status==null? "T":model.Status);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new TicketResponse
                    {
                        _NumeroTicket = dataReader.GetDecimal(0).ToString(),
                        _Usuario_Reporta=dataReader.GetString(1),
                        _Descripcion = dataReader.GetString(2),
                        _Status = dataReader.GetString(3),
                        _Fecha = dataReader.GetString(4),
                        _AsignadoA=dataReader.GetString(5),
                        Id_Rubro=dataReader.GetInt32(6),
                        IdUsuario_Asignado=dataReader.GetInt32(7),
                        _FechaFin=dataReader.GetString(8),
                        Nivel_Servicio=dataReader.GetString(9),
                        _FechaAsignacion=dataReader.GetString(10),
                        Categoria=dataReader.GetString(11),
                       Tipo =Convert.ToDouble(dataReader.GetDecimal(12)),
                       _SolicitudCambio = dataReader.GetString(13),
                        _FechaRecibe = dataReader.GetString(14),
                        SubCategoria= dataReader.GetString(15)
                    });
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
          Tickets.Reverse();
            return Tickets;
        }
        public static List<TicketResponse> ConsultarTicket_PorStatus(TicketRequest model)
        {
            List<TicketResponse> Tickets = new List<TicketResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tickets_ConsultarPorStatus", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Decimal, model.Id_Rubro);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status == null ? "T" : model.Status);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new TicketResponse
                    {
                        _NumeroTicket = dataReader.GetDecimal(0).ToString(),
                        _Usuario_Reporta = dataReader.GetString(1),
                        _Descripcion = dataReader.GetString(2),
                        _Status = dataReader.GetString(3),
                        _Fecha = dataReader.GetString(4),
                        _AsignadoA = dataReader.GetString(5),
                        Id_Rubro = dataReader.GetInt32(6),
                        IdUsuario_Asignado = dataReader.GetInt32(7),
                        _FechaFin = dataReader.GetString(8),
                        Nivel_Servicio = dataReader.GetString(9),
                        _FechaAsignacion = dataReader.GetString(10),
                        Categoria = dataReader.GetString(11),
                        Tipo = Convert.ToDouble(dataReader.GetDecimal(12)),
                        _SolicitudCambio = dataReader.GetString(13),
                        _FechaRecibe = dataReader.GetString(14),
                        SubCategoria = dataReader.GetString(15)
                    });
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            Tickets.Reverse();
            return Tickets;
        }
        public static List<TicketResponse> ConsultarTicket_PorFiltro(TicketRequest model)
        {
            List<TicketResponse> Tickets = new List<TicketResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_TicketsFiltro", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Decimal, model.Id_Rubro);
                Conexion.creaParametro(cmd, "@Fecha_Inicio", SqlDbType.Date, model.Fecha_Inicio);
                Conexion.creaParametro(cmd, "@Fecha_Fin", SqlDbType.Date, model.Fecha_Fin);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    //Tickets.Add(new TicketResponse
                    //{
                    //    _NumeroTicket = dataReader.GetDecimal(0).ToString(),
                    //    _Usuario_Reporta = dataReader.GetString(1),
                    //    _Descripcion = dataReader.GetString(2),
                    //    _Status = dataReader.GetString(3),
                    //    _Fecha = dataReader.GetString(4),
                    //    _AsignadoA = dataReader.GetString(5),
                    //    Id_Rubro = dataReader.GetInt32(6),
                    //    IdUsuario_Asignado = dataReader.GetInt32(7),
                    //    _FechaFin = dataReader.GetString(8),
                    //    Nivel_Servicio = dataReader.GetString(9),
                    //    _FechaAsignacion = dataReader.GetString(10),
                    //    _FechaRecibe = dataReader.GetString(14),
                    //    SubCategoria = dataReader.GetString(15)

                    //});
                    Tickets.Add(new TicketResponse
                    {
                        _NumeroTicket = dataReader.GetDecimal(0).ToString(),
                        _Usuario_Reporta = dataReader.GetString(1),
                        _Descripcion = dataReader.GetString(2),
                        _Status = dataReader.GetString(3),
                        _Fecha = dataReader.GetString(4),
                        _AsignadoA = dataReader.GetString(5),
                        Id_Rubro = dataReader.GetInt32(6),
                        IdUsuario_Asignado = dataReader.GetInt32(7),
                        _FechaFin = dataReader.GetString(8),
                        Nivel_Servicio = dataReader.GetString(9),
                        _FechaAsignacion = dataReader.GetString(10),
                        Categoria = dataReader.GetString(11),
                        Tipo = Convert.ToDouble(dataReader.GetDecimal(12)),
                        _SolicitudCambio = dataReader.GetString(13),
                        _FechaRecibe = dataReader.GetString(14),
                        SubCategoria = dataReader.GetString(15)
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
        public static List<TicketResponse> ConsultarTicket_Soporte(TicketRequest model)
        {
            List<TicketResponse> Tickets = new List<TicketResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_Tickets_Soporte", cnn);
                Conexion.creaParametro(cmd, "@Id_Usuario", SqlDbType.Decimal, model.UsuarioId);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new TicketResponse
                    {
                        _NumeroTicket = dataReader.GetDecimal(0).ToString(),
                        _Usuario_Reporta=dataReader.GetString(1),
                        _Descripcion = dataReader.GetString(2),
                        _Status = dataReader.GetString(3),
                        _Fecha = dataReader.GetString(4),
                        Id_Rubro = dataReader.GetInt32(5),
                        _SolicitudCambio = dataReader.GetString(6),
                        Tipo = dataReader.GetInt32(7),
                        Ticket_Proveedor = dataReader.GetString(8),
                        T = dataReader.GetString(9),
                        S = dataReader.GetString(10)
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
        public static List<TicketResponse> ConsultarTicket_PorRubro2(TicketRequest model)
        {
            List<TicketResponse> Tickets = new List<TicketResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_Ticket_Id_Rubro_Soporte", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Decimal, model.Id_Rubro);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new TicketResponse
                    {
                        _NumeroTicket = dataReader.GetDecimal(0).ToString(),
                        _Usuario_Reporta = dataReader.GetString(1),
                        _Descripcion = dataReader.GetString(2),
                        _Status = dataReader.GetString(3),
                        _Fecha = dataReader.GetString(4),
                        Id_Rubro = dataReader.GetInt32(5)
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
        public static void GuardarSprint(TicketRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tick_TareasD_Create", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Ticket);
                Conexion.creaParametro(cmd, "@Usuario_Registro", SqlDbType.Int, model.UsuarioId);
                Conexion.creaParametro(cmd, "@Descripcion", SqlDbType.Text, model.Descripcion);

                if (Convert.ToInt32(Conexion.ejecutarNonquery(cmd))== 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static List<TicketDResponse> ConsultarTicketD_Soporte(BaseRequest model)
        {
            List<TicketDResponse> TicketsD = new List<TicketDResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_Ticket_Id_Soporte", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Decimal, Persistentes.Numero_Ticket);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())

                {
                    TicketsD.Add(new TicketDResponse
                    {
                       Fecha=dataReader.GetString(0),
                       Hora=dataReader.GetString(1),
                       Descripcion=dataReader.GetString(2)
                    });
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return TicketsD;
        }
        public static bool ConsultarTicket_UsuarioAsignado(TicketRequest model)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tickte_Get_UsuarioAsignado", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Decimal, model.Id_Ticket);
                tbl = Conexion.ejecutaConsulta(cmd);
                if(tbl.Rows.Count>0)
                {
                    Persistentes.Ticket_Asignado = true;
                    return false;
                }
                else {
                    Persistentes.Ticket_Asignado = false;
                    return true; }
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }
        public static void Ticket_RegresarAsignacion(TicketRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tickte_Regresar_Asignacion", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Int, model.Id_Ticket);

                if (Convert.ToInt32(Conexion.ejecutarNonquery(cmd)) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Ticket_RecibirAsignacion(TicketRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tick_RecibirAsignacion", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Ticket);
                Conexion.creaParametro(cmd, "@Usuario_Recibe", SqlDbType.Int, model.Id_UsurioRecibe);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status);

                if (Convert.ToInt32(Conexion.ejecutarNonquery(cmd)) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Ticket_Finalizar(TicketRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Ticket_Finalizar", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Int, model.Id_Ticket);
                Conexion.creaParametro(cmd, "@Comentarios_fin", SqlDbType.VarChar, model.Descripcion);

                if (Convert.ToInt32(Conexion.ejecutarNonquery(cmd)) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Ticket_CerrarPorUsuario(TicketRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Ticket_CerrarPorUsuario", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Int, model.Id_Ticket);
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
        public static void Ticket_Rechazar(TicketRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Ticket_Rechazar", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Int, model.Id_Ticket);
                Conexion.creaParametro(cmd, "@Id_UsuarioRechazo", SqlDbType.Int,Persistentes.Usuario_Login);
                Conexion.creaParametro(cmd, "@Comentarios_Rechazo", SqlDbType.VarChar, model.Descripcion);

                if (Convert.ToInt32(Conexion.ejecutarNonquery(cmd)) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static string ConsultarTickets_Abiertos(TicketRequest model)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Buscar_Tickets", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Int, model.Id_Rubro);
                tbl = Conexion.ejecutaConsulta(cmd);
                if (tbl.Rows.Count > 0)
                {
                    return tbl.Rows[0][0].ToString();
                }
                else
                {
                    return  "0";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void GuardarNivelServicio(TicketRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Ticket_NivelServicio", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Int, model.Id_Ticket);
                Conexion.creaParametro(cmd, "@Nivel_Servicio", SqlDbType.Int, model.Nivel_Servicio);
                Conexion.creaParametro(cmd, "@Id_Categoria", SqlDbType.Int, model.Id_Categoria);
                Conexion.creaParametro(cmd, "@Id_SubCategoria", SqlDbType.Int, model.Id_SubCategoria);

                if (Convert.ToInt32(Conexion.ejecutarNonquery(cmd)) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Ticket_ReasignarDepartamento(TicketRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Ticket_ReasignarDepartamento", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Int,model.Id_Ticket);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Int, model.Id_Rubro);

                if (Convert.ToInt32(Conexion.ejecutarNonquery(cmd)) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static bool ConsultarTickets_NivelServicioYCategoria(TicketRequest model)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Ticket_Datos1", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Int, model.Id_Ticket);
                tbl = Conexion.ejecutaConsulta(cmd);
                if (tbl.Rows.Count > 0)
                {
                    
                    if (Convert.ToInt32( tbl.Rows[0][0])!=0 && Convert.ToInt32(tbl.Rows[0][1]) != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static TicketRequest Consultar_NivelSeguridad(TicketRequest model)
        {
            DataTable tbl;
            TicketRequest ticket = new TicketRequest();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Ticket_Datos1", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Int, model.Id_Ticket);
                tbl = Conexion.ejecutaConsulta(cmd);
                foreach(DataRow row in tbl.Rows)
                {
                    ticket = new TicketRequest { Nivel_Servicio = Convert.ToInt32(row["Prioridad"].ToString()),
                                                 Id_Rubro = Convert.ToInt32(row["Id_Rubro"].ToString())   };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ticket;
        }
        public static CorreoResponse Mail_Seguimiento(TicketRequest model)
        {
            CorreoResponse Tickets=null;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Mail_Ticket", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Decimal, model.Id_Ticket);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {                    
                    Tickets =new CorreoResponse
                    {
                        Area = dataReader.GetString(0),
                        AreaMail = dataReader.GetString(1),
                        AreaExtension = dataReader.GetString(2),
                        Numeroticket = dataReader.GetDecimal(3),
                        TicketDescripcion = dataReader.GetString(4),
                        UsuarioReporta = dataReader.GetString(5),
                        UsuarioReportaMail=dataReader.GetString(6),
                        UsuarioReportaExtension=dataReader.GetString(7),
                        UsuarioAsignadoMail= dataReader.GetString(8),
                        Archivo = dataReader.GetString(9) == "No existe" ? null:Convert.FromBase64String(dataReader.GetString(9)),
                        Nombre_Archivo = dataReader.GetString(10)
                    };
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
