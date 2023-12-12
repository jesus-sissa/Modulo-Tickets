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
    class LoginRepository
    {
        public static DataTable Usuarios_Read(int Id,string Sucursal)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(Sucursal);
                cmd = Conexion.creaComando("Tick_UsuariosLogin_Read", cnn);
                Conexion.creaParametro(cmd, "@Id_Empleado", SqlDbType.Int, Id);
                tbl = Conexion.ejecutaConsulta(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tbl;
        }
        public static int Usuarios_ClaveEmpleado(string Clave_Empleado,string Sucursal)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(Sucursal);
                cmd = Conexion.creaComando("Tick_UsuariosLoginClave_Read", cnn);
                Conexion.creaParametro(cmd, "@Clave_Empleado", SqlDbType.VarChar, Clave_Empleado);
                tbl = Conexion.ejecutaConsulta(cmd);
                if(tbl.Rows.Count>0)
                {
                    return Convert.ToInt32( tbl.Rows[0][0].ToString());
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable Obtener_Privilegios(LoginRequest model)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_Permisos_Get_Tickets", cnn);
                Conexion.creaParametro(cmd, "@Id_Empleado", SqlDbType.Int,model.UsuarioId);
                Conexion.creaParametro(cmd, "@Clave_Modulo", SqlDbType.VarChar,"46");
                tbl = Conexion.ejecutaConsulta(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tbl;



        }

        public static DataTable PermisosControles_Read(LoginRequest model)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_PermisosControles_Get", cnn);
                Conexion.creaParametro(cmd, "@Id_Empleado", SqlDbType.Int, model.UsuarioId);
                Conexion.creaParametro(cmd, "@Clave_Modulo", SqlDbType.VarChar, "46");
                tbl = Conexion.ejecutaConsulta(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tbl;



        }

    }
}
