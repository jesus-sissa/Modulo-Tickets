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
    class DepartamentosRepository
    {
        public static List<DepartamentoResponse> ConsultaDepto(DepartamentosRequest model)
        {
            DataTable tbl;
            List<DepartamentoResponse> Departamentos = new List<DepartamentoResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Tick_Cat_DepartamentosCombo_Get", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Departamento);
                tbl = Conexion.ejecutaConsulta(cmd);
                foreach (DataRow Row in tbl.Rows)
                {          
                    Departamentos.Add(new DepartamentoResponse
                    {
                        Id_Departamento=Convert.ToInt32( Row["Id_Departamento"].ToString()),
                        Nombre=Row["Descripcion"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Departamentos;
        }
    }
}
