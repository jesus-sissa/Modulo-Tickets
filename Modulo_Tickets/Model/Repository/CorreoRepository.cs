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
    class CorreoRepository
    {
        public static DataTable Parametros(CorreoRequest model)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Cat_ParametrosL_Read", cnn);
                Conexion.creaParametro(cmd, "@Id_Sucursal", SqlDbType.Int,model.Id_Sucursal);
                tbl = Conexion.ejecutaConsulta(cmd);
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tbl;
        }
        public static string decodificar(string valor)
        {
            byte[] byteValor = System.Convert.FromBase64String(valor);
            return System.Text.Encoding.UTF8.GetString(byteValor);
        }
        public static bool fn_ValidarMail(string sMail)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(sMail, @"^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$");
        }

    }
}
