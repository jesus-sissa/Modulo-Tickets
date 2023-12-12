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
    class ClienteRepository
    {
        public static List<ClienteResponse> ConsultarPadre(ClientesRequest model)
        {
            DataTable tbl;
            List<ClienteResponse> ClientesPadre = new List<ClienteResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tickets_ClientesPadre", cnn);
                tbl = Conexion.ejecutaConsulta(cmd);

                foreach (DataRow Row in tbl.Rows)
                {
                    ClientesPadre.Add(new ClienteResponse
                    {
                        Id_Cliente= Convert.ToInt32(Row["Id_Cliente"].ToString()),             
                        Nombre = Row["Nombre_Fiscal"].ToString()
                       
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ClientesPadre;
        }
        public static List<ClienteResponse> ConsultarHijos(ClientesRequest model)
        {
            DataTable tbl;
            List<ClienteResponse> ClientesPadre = new List<ClienteResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tickets_ClientesHijos", cnn);
                Conexion.creaParametro(cmd, "@Id_Padre", SqlDbType.Int, model.Id_Padre);
                tbl = Conexion.ejecutaConsulta(cmd);

                foreach (DataRow Row in tbl.Rows)
                {
                    ClientesPadre.Add(new ClienteResponse
                    {
                        Id_Cliente = Convert.ToInt32(Row["Id_Cliente"].ToString()),
                        Nombre = Row["Nombre_Comercial"].ToString()

                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ClientesPadre;
        }
    }
}
