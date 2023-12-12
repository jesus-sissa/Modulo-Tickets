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
    class ArchivosRepository
    {
        public static List<ArchivosResponse> ConsultarArchivos(ArchivosRequest model)
        {
            DataTable tbl;
            List<ArchivosResponse> _Archivos = new List<ArchivosResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tickets_Archivoss_Consultar", cnn);
                Conexion.creaParametro(cmd, "@Id_Ticket", SqlDbType.Int, Persistentes.Numero_Ticket);
                tbl = Conexion.ejecutaConsulta(cmd);

                foreach (DataRow Row in tbl.Rows)
                {
                    _Archivos.Add(new ArchivosResponse
                    {
                        Id_Ticket=Convert.ToInt32( Row["id"].ToString()),
                        Id_Archivo= Convert.ToInt32(Row["id"].ToString()),                         
                        Nombre = Row["Nombre_Archivo"].ToString(),
                        Ext= Row["Extension"].ToString(),
                        Formato= Row["Formato"].ToString(),
                        Peso = Row["Tamanio"].ToString(),
                        Imagen = Convert.FromBase64String(Row["Archivo"].ToString()),  
                        Status = Row["status"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return _Archivos;
        }

    }
}
