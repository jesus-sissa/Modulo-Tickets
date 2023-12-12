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
    class EmpleadosRepository
    {
        public static List<EmpleadosResponse> ConsultaEmpleados(EmpleadosRequest model)
        {
            List<EmpleadosResponse> Empleados = new List<EmpleadosResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usuarios_Get_PorDepartamento", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Int, model.Id_Rubro);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Empleados.Add(new EmpleadosResponse
                    {
                        Id_Empleado=dataReader.GetInt32(0),
                        Nombre=dataReader.GetString(1)
                    });
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Empleados;
        }
        public static DataTable ConsultaEmpleados_ModoContacto(EmpleadosRequest model)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("cat_Empleados_ModoContacto", cnn);
                Conexion.creaParametro(cmd, "@Id_Empleado", SqlDbType.Decimal, model.UsuarioId);
                tbl = Conexion.ejecutaConsulta(cmd);
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tbl;
        }
        public static void GuardarEmpleados_ModoContacto(EmpleadosRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("cat_Empleados_ModoContactoAct", cnn);
                Conexion.creaParametro(cmd, "@Id_Empleado", SqlDbType.Decimal, model.UsuarioId);
                Conexion.creaParametro(cmd, "@Mail", SqlDbType.VarChar, model.Mail);
                Conexion.creaParametro(cmd, "@Extension", SqlDbType.VarChar, model.Extension);
                Conexion.ejecutarNonquery(cmd);


                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
    }
}
