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
    class ProyectosRepository
    {
        public static void GuardarProyecto(Proyectos model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Proyectos_Create", cnn);
                Conexion.creaParametro(cmd, "@Nombre", SqlDbType.VarChar, model.Nombre);
                Conexion.creaParametro(cmd, "@Descripcion", SqlDbType.VarChar, model.Descripcion);
                Conexion.creaParametro(cmd, "@Fecha_Inicio", SqlDbType.Date, model.Fecha_Inicio);
                Conexion.creaParametro(cmd, "@Duracion_Semanas", SqlDbType.Int, model.Duracion_Semanas);
                Conexion.creaParametro(cmd, "@Prioridad", SqlDbType.Int, model.Prioridad);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Departamento);
                Conexion.creaParametro(cmd, "@Id_Usuario_Registra", SqlDbType.Int,Persistentes.Usuario_Login);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }

        public static List<Proyectos> ConsultarProyectos(Proyectos model)
        {
            List<Proyectos> Tickets = new List<Proyectos>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Obtener_Proyectos", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Departamento);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new Proyectos
                    {
                        Id_Proyecto=dataReader.GetInt32(0),
                        Nombre=dataReader.GetString(1)
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
        public static List<Proyectos> ConsultarProyectosPorId(Proyectos model)
        {
            List<Proyectos> Tickets = new List<Proyectos>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Obtener_ProyectosId", cnn);
                Conexion.creaParametro(cmd, "@Id_Proyecto", SqlDbType.Int, model.Id_Proyecto);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new Proyectos
                    {
                        Id_Proyecto = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Descripcion= dataReader.GetString(2),
                        Fecha_Inicio=dataReader.GetDateTime(3),
                        Duracion_Semanas= dataReader.GetInt32(4),
                        Prioridad= dataReader.GetInt32(5),
                        Status= dataReader.GetString(6),
                        Porcentaje_Avance= dataReader.GetInt32(7),
                        Utimo_Avance=dataReader.GetString(8)

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
        public static void GuardarAvance(Proyectos model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Proyecto_Avance", cnn);
                Conexion.creaParametro(cmd, "@Id_Proyecto", SqlDbType.Int, model.Id_Proyecto);
                Conexion.creaParametro(cmd, "@Usuario_Registro", SqlDbType.Int, Persistentes.Usuario_Login);
                Conexion.creaParametro(cmd, "@Descripcion", SqlDbType.VarChar, model.Utimo_Avance);
                Conexion.creaParametro(cmd, "@Porcentaje_Avance", SqlDbType.Int, model.Porcentaje_Avance);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Proyecto_CambiarStatus(Proyectos model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Proyecto_CambiarStatus", cnn);
                Conexion.creaParametro(cmd, "@Id_Proyecto", SqlDbType.Int, model.Id_Proyecto);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar,model.Status);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static List<Proyectos> ConsultarProyectosTodos(Proyectos model)
        {
            List<Proyectos> Tickets = new List<Proyectos>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Obtener_ProyectosTodos", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int,0);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Tickets.Add(new Proyectos
                    {
                        Id_Proyecto = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Porcentaje_Avance = dataReader.GetInt32(2),
                        Departamento=dataReader.GetString(3)

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
