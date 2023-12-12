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
    class RubroRepository
    {
        public static void GuardarRubro(RubroRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Cat_Nuevo_Rubro", cnn);
                Conexion.creaParametro(cmd, "@Nombre", SqlDbType.VarChar, model.Nombre);
                Conexion.creaParametro(cmd, "@Img", SqlDbType.Image, model.Img);
                Conexion.creaParametro(cmd, "@Mail", SqlDbType.VarChar, model.Mail);
                Conexion.creaParametro(cmd, "@Extension", SqlDbType.VarChar, model.Extension);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Departamento);
                Conexion.creaParametro(cmd, "@Num_Documento", SqlDbType.Int, model.Num_Documento);
                Conexion.creaParametro(cmd, "@Ticket_Proveedor", SqlDbType.VarChar, model.Proveedor);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void EditarRubro(RubroRequest model,int Id_rubro)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Cat_Update_Rubros", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Int, Id_rubro);
                Conexion.creaParametro(cmd, "@Nombre", SqlDbType.VarChar, model.Nombre);
                Conexion.creaParametro(cmd, "@Img", SqlDbType.Image, model.Img);
                Conexion.creaParametro(cmd, "@Mail", SqlDbType.VarChar, model.Mail);
                Conexion.creaParametro(cmd, "@Extension", SqlDbType.Text, model.Extension);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int, model.Id_Departamento);
                Conexion.creaParametro(cmd, "@Num_Documento", SqlDbType.Int, model.Num_Documento);
                Conexion.creaParametro(cmd, "@Ticket_Proveedor", SqlDbType.VarChar, model.Proveedor);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static List<RubroResponse> ConsultarRubros(RubroRequest model)
        {
            DataTable tbl;
            List<RubroResponse> Tickets = new List<RubroResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Cat_Get_Rubros", cnn);
                Conexion.creaParametro(cmd, "@Id_Departamento", SqlDbType.Int,model.Id_Departamento);
                tbl = Conexion.ejecutaConsulta(cmd);
                byte[] Imagen;
                foreach (DataRow Row in tbl.Rows)
                {
                    Imagen = (byte[])Row["Img"];
                    Tickets.Add(new RubroResponse
                    {
                        Id_Rubro =Convert.ToInt32( Row["Id_Rubro"].ToString()),
                        Nombre =Row["Nombre"].ToString(),
                        Img =Imagen,
                        Extension = Row["Extension"].ToString(),
                        Mail = Row["Mail"].ToString()
                    });
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Tickets;
        }

        public static RubroResponse ConsultarRubrosU(RubroRequest model,int Id_Rubro)
        {
            DataTable tbl;
            RubroResponse Tickets = new RubroResponse() ;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Cat_Get_RubrosU", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Int, Id_Rubro);
                tbl = Conexion.ejecutaConsulta(cmd);
                byte[] Imagen;
                foreach (DataRow Row in tbl.Rows)
                {
                    Imagen = (byte[])Row["Img"];
                    Tickets = new RubroResponse {
                        Id_Rubro = Convert.ToInt32(Row["Id_Rubro"].ToString()),
                        Nombre = Row["Nombre"].ToString(),
                        Img = Imagen,
                        Extension = Row["Extension"].ToString(),
                        Mail = Row["Mail"].ToString(),
                        Id_Departamento= Convert.ToInt32(Row["Id_Departamento"].ToString()),
                        Num_Documento = Convert.ToInt32(Row["Num_Documento"].ToString()), 
                        Proveedor = Row["Ticket_Proveedor"].ToString()
                    };

                    //Tickets.Add(new RubroResponse
                    //{
                    //    Id_Rubro = Convert.ToInt32(Row["Id_Rubro"].ToString()),
                    //    Nombre = Row["Nombre"].ToString(),
                    //    Img = Imagen,
                    //    Extension = Row["Extension"].ToString(),
                    //    Mail = Row["Mail"].ToString()
                    //});
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Tickets;
        }
        public static DataTable ConsultarCategorias(RubroRequest model)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Rubros_CategoriasT", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Int, model.Id_Rubro);
                tbl = Conexion.ejecutaConsulta(cmd);
                if (tbl.Rows.Count > 0)
                {
                    return tbl;
                }
                else
                {
                    return new DataTable();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
