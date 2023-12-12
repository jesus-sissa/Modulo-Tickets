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
    class FormatosRepository
    {
        public static List<FormatosRequest> Consultar_Jefe(FormatosRequest model)
        {
            DataTable tbl;
            List<FormatosRequest> formatos = new List<FormatosRequest>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Consultar_Jefes", cnn);
                Conexion.creaParametro(cmd, "@Id_Usuario", SqlDbType.VarChar, model.UsuarioId);
                tbl = Conexion.ejecutaConsulta(cmd);
                foreach (DataRow row in tbl.Rows)
                {
                    formatos.Add(new FormatosRequest
                    {
                        departamento = Convert.ToInt32(row["Id_Departamento"])
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return formatos;
        }

        public static void Guardar_Formato(FormatosRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Guardar_Formatos", cnn);
                Conexion.creaParametro(cmd, "@Nombre", SqlDbType.VarChar, model.Nombre);
                Conexion.creaParametro(cmd, "@status", SqlDbType.VarChar, model.status);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Cambiar_status_Formulario(FormatosRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Cambiar_Status", cnn);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.status);
                Conexion.creaParametro(cmd, "@Id_Formato", SqlDbType.VarChar, model.Id_Formato);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static List<FormatosResponse> Consultar(FormatosRequest model)
        {
            DataTable tbl;
            List<FormatosResponse> Categorias = new List<FormatosResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Get_Catformatos", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Tarea);
                tbl = Conexion.ejecutaConsulta(cmd);

                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new FormatosResponse
                    {
                        Id_Formato = Convert.ToInt32(Row["Id_Formato"].ToString()),
                        Nombre = Row["Nombre"].ToString(),
                        Status = Row["StatusActivo"].ToString(),
                        Status2 = Row["status"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }
        public static void Guardar(FormatosRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Save_Tareasformatos", cnn);
                Conexion.creaParametro(cmd, "@Id_Tarea", SqlDbType.Int, model.Id_Tarea);
                Conexion.creaParametro(cmd, "@Id_Formato", SqlDbType.Int, model.Id_Formato);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }

        #region Solitud de vacaciones
        public static List<SolicitudVacacionesResponse> Consultar_Empleado(SolicitudVacacionesRequest model)
        {
            DataTable tbl;
            List<SolicitudVacacionesResponse> Categorias = new List<SolicitudVacacionesResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Get_TEmpleadosvacaciones", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.departamento);
                tbl = Conexion.ejecutaConsulta(cmd);
                Persistentes.Empleado = tbl;

                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new SolicitudVacacionesResponse
                    {
                        Id_Empleado = Convert.ToInt32(Row["Id_Empleado"].ToString()),
                        Clave_Empleado = Convert.ToInt32(Row["Clave_Empleado"].ToString()),
                        Nombre = Row["Nombre"].ToString(),
                        Fecha_Ingreso = Row["Fecha_Ingreso"].ToString(),
                        Departamento = Row["Departamento"].ToString(),
                        Puesto = Row["Puesto"].ToString(),
                        Firma = Row["Firma"].Equals(System.DBNull.Value) ? new byte[0] : (byte[])Row["Firma"],
                        Huella = Row["Huella"].Equals(System.DBNull.Value) ? new byte[0] : (byte[])Row["Huella"]
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }
        #endregion

        #region Solicitud de Prestamos
        public static List<SolicitudVacacionesResponse> Consultar_Empleado_Todos(SolicitudVacacionesRequest model)
        {
            DataTable tbl;
            List<SolicitudVacacionesResponse> Categorias = new List<SolicitudVacacionesResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Get_TEmpleadostodos", cnn);
                tbl = Conexion.ejecutaConsulta(cmd);
                Persistentes.Empleado = tbl;

                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new SolicitudVacacionesResponse
                    {
                        Id_Empleado = Convert.ToInt32(Row["Id_Empleado"].ToString()),
                        Clave_Empleado = Convert.ToInt32(Row["Clave_Empleado"].ToString()),
                        Nombre = Row["Nombre"].ToString(),
                        Fecha_Ingreso = Row["Fecha_Ingreso"].ToString(),
                        Departamento = Row["Departamento"].ToString(),
                        Puesto = Row["Puesto"].ToString(),
                        Firma = Row["Firma"].Equals(System.DBNull.Value) ? new byte[0] : (byte[])Row["Firma"],
                        Huella = Row["Huella"].Equals(System.DBNull.Value) ? new byte[0] : (byte[])Row["Huella"]
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }
        #endregion

        public static List<SolicitudVacacionesResponse> Consultar_Empleado_Prestamos(SolicitudVacacionesRequest model)
        {
            DataTable tbl;
            List<SolicitudVacacionesResponse> Categorias = new List<SolicitudVacacionesResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Get_TEmpleadosprestamos", cnn);
                Conexion.creaParametro(cmd, "@Id_Empleado", SqlDbType.Int, Persistentes.Usuario_Login);
                tbl = Conexion.ejecutaConsulta(cmd);
                Persistentes.Empleado = tbl;

                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new SolicitudVacacionesResponse
                    {
                        Id_Empleado = Convert.ToInt32(Row["Id_Empleado"].ToString()),
                        Clave_Empleado = Convert.ToInt32(Row["Clave_Empleado"].ToString()),
                        Nombre = Row["Nombre"].ToString(),
                        Fecha_Ingreso = Row["Fecha_Ingreso"].ToString(),
                        Departamento = Row["Departamento"].ToString(),
                        Puesto = Row["Puesto"].ToString(),
                        Firma = Row["Firma"].Equals(System.DBNull.Value) ? new byte[0] : (byte[])Row["Firma"],
                        Huella = Row["Huella"].Equals(System.DBNull.Value) ? new byte[0] : (byte[])Row["Huella"]
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }
        public static void Guardar_Prestamo(Prestamo model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Prestamos_Llenado", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, model.Id_Flujo);
                Conexion.creaParametro(cmd, "@Can_Sol", SqlDbType.Int, model.Can_Sol);
                Conexion.creaParametro(cmd, "@Fecha_Ult_Pres", SqlDbType.VarChar, model.Fecha_Ult_Pres);
                Conexion.creaParametro(cmd, "@Prestamos_Ult_Año", SqlDbType.Int, model.Prestamos_UltA);
                Conexion.creaParametro(cmd, "@MyF", SqlDbType.Text, model.MyF);
                Conexion.ejecutarNonquery(cmd);
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Actualizar_DiasVacaciones(SolicitudVacacionesRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Actualizar_DiasVacaciones", cnn);
                Conexion.creaParametro(cmd, "@Clave_Empleado", SqlDbType.VarChar, model.Clave_Empleado);
                Conexion.creaParametro(cmd, "@Periodo", SqlDbType.Int, model.Periodo);
                Conexion.creaParametro(cmd, "@DTotales", SqlDbType.Int, model.DiasT);
                Conexion.creaParametro(cmd, "@DiasT", SqlDbType.Int, model.DTomados);
                Conexion.creaParametro(cmd, "@SV", SqlDbType.Int, model.SaldoV);
                Conexion.ejecutarNonquery(cmd);
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Guardar_PersonaAutorizo(Prestamo model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Prestamos_Persona_Autorizo", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, Persistentes.Id_Flujo);
                Conexion.creaParametro(cmd, "@Id_Autorizo", SqlDbType.Int, model.Id_Autoriza);
                Conexion.ejecutarNonquery(cmd);
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Guardar_EmpleadosVacaciones(SolicitudVacacionesRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Guardar_EmpleadosVacaciones", cnn);
                Conexion.creaParametro(cmd, "@Id_Empleado", SqlDbType.Int, model.Id_Empleado);
                Conexion.creaParametro(cmd, "@Fecha_Requerida", SqlDbType.Date, model.Fecha_Requerida);
                Conexion.creaParametro(cmd, "@DiasT", SqlDbType.Int, model.DiasT);
                Conexion.creaParametro(cmd, "@SaldoV", SqlDbType.Int, model.SaldoV);
                Conexion.creaParametro(cmd, "@Comentario", SqlDbType.VarChar, model.Comentario_Solicita);
                Conexion.creaParametro(cmd, "@Usuario_Registro", SqlDbType.Int, model.Usuario_Registro);
                Conexion.creaParametro(cmd, "@Usuario_Autoriza", SqlDbType.Int, model.Usuario_Autoriza);
                Conexion.creaParametro(cmd, "@Fecha_Regreso ", SqlDbType.Date, model.Fecha_Regreso);
                Conexion.ejecutarNonquery(cmd);
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static Prestamo Consultar_Info_Prestamo(Prestamo model)
        {
            Prestamo prestamo = new Prestamo();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Consultar_Info_Prestamo", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, Persistentes.Id_Flujo);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    prestamo = new Prestamo
                    {
                        Id_Empleado = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Clave_Empleado = Convert.ToInt32(dataReader.GetString(2)),
                        Fecha_Ingreso = dataReader.GetDateTime(3),
                        Firma = (byte[])dataReader["Firma"],
                        Huella = (byte[])dataReader["Huella"],
                        Can_Sol = dataReader.GetInt32(6),
                        Fecha_Ult_Pres = dataReader.GetString(7),
                        MyF = dataReader.GetString(8),
                        Prestamos_UltA = dataReader.GetInt32(9),
                        Fecha_Registro = dataReader.GetDateTime(10),
                    };
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return prestamo;
        }
        public static Prestamo Consultar_Persona_Autoriza(Prestamo model)
        {
            Prestamo prestamo = new Prestamo();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Consultar_Persona_Autorizo ", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, Persistentes.Id_Flujo);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    prestamo = new Prestamo
                    {
                        Id_Autoriza = dataReader.GetInt32(0),
                        Nombre_Autoriza = dataReader.GetString(1),
                        Firma_Autoriza = (byte[])dataReader["Firma"],
                    };
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return prestamo;
        }
        public static int Guardar_Archivo_Autorizado(ImagenRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Archivo_Prestamo_Actualizar", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, model.Id_Flujo);
                Conexion.creaParametro(cmd, "@Archivo", SqlDbType.VarChar, model.Base64); ;
                if (Conexion.ejecutarNonquery(cmd) == 0)
                    return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;
        }
        public static void Cambiar_Autorizacion(Prestamo model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Cambiar_Autorizacion", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, model.Id_Flujo);
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
        public static Prestamo Consultar_Status_Procedimiento(Prestamo model)
        {
            Prestamo prestamo = new Prestamo();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Status_Autorizacion", cnn);
                Conexion.creaParametro(cmd, "@Id_Flujo", SqlDbType.Int, Persistentes.Id_Flujo);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    prestamo = new Prestamo
                    {
                        status_autorizacion = dataReader.GetString(0)
                    };
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return prestamo;
        }
        public static Permisos Consultar_FirmaRH(Permisos model)
        {
            Permisos permisos = new Permisos();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Consulta_FirmaRH", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, 27);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    permisos = new Permisos
                    {
                        Nombre_RH = dataReader.GetString(0),
                        Firma = (byte[])dataReader["Firma"],
                    };
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return permisos;
        }
        public static SolicitudVacacionesRequest Consultar_Dias_Vacaciones(SolicitudVacacionesRequest model)
        {
            SolicitudVacacionesRequest solicitud = new SolicitudVacacionesRequest();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Consular_Vacaciones", cnn);
                Conexion.creaParametro(cmd, "@Clave_Empleado", SqlDbType.VarChar, model.Clave_Empleado);
                Conexion.creaParametro(cmd, "@Periodo", SqlDbType.Int, model.Periodo);
                cmd.Connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    solicitud = new SolicitudVacacionesRequest
                    {
                        DiasT = dataReader.GetInt32(0),
                        SaldoV = dataReader.GetInt32(1),
                    };
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return solicitud;
        }
        public static void Actualizar_lista_Vacaciones(BaseRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Actualizar_Diasdevacaciones", cnn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
