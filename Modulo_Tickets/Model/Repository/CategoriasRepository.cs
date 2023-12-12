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
    class CategoriasRepository
    {
        public static void Guardar(CategoriasRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Rubros_CatGuardar", cnn);
                Conexion.creaParametro(cmd, "@Nombre", SqlDbType.VarChar, model.Nombre);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Int, model.Id_Rubro);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void GuardarSub(CategoriasRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Rubros_CatSubGuardar", cnn);
                Conexion.creaParametro(cmd, "@Nombre", SqlDbType.VarChar, model.Nombre);
                Conexion.creaParametro(cmd, "@Id_Categoria", SqlDbType.Int, model.Id_Categoria);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static void Editar(CategoriasRequest model)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Rubros_CatStatus", cnn);
                Conexion.creaParametro(cmd, "@Id_Categoria", SqlDbType.Int, model.Id_Categoria);
                Conexion.creaParametro(cmd, "@Status", SqlDbType.VarChar, model.Status);

                if (Conexion.ejecutarNonquery(cmd) == 0)
                    throw new Exception("No se pudo insertar el registro");


            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw ex;
            }
        }
        public static List<CategoriasResponse> Consultar(CategoriasRequest model)
        {
            DataTable tbl;
            List<CategoriasResponse> Categorias = new List<CategoriasResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Rubros_CatConsultar", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Int, model.Id_Rubro);
                tbl = Conexion.ejecutaConsulta(cmd);
   
                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new CategoriasResponse
                    {
                        Id_Categoria = Convert.ToInt32(Row["Id_Categoria"].ToString()),
                        Nombre = Row["Nombre"].ToString(),
                        Status = Row["Status"].ToString(),
                        Id_Rubro = Convert.ToInt32(Row["Id_Rubro"].ToString())

                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }
        public static List<CategoriasResponse> SubConsultar(CategoriasRequest model)
        {
            DataTable tbl;
            List<CategoriasResponse> Categorias = new List<CategoriasResponse>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(model.ClaveSucursal);
                cmd = Conexion.creaComando("Rubros_SubCatConsultar", cnn);
                Conexion.creaParametro(cmd, "@Id_Categoria", SqlDbType.Int, model.Id_Categoria);
                tbl = Conexion.ejecutaConsulta(cmd);

                foreach (DataRow Row in tbl.Rows)
                {
                    Categorias.Add(new CategoriasResponse
                    {
                        Id_Categoria = Convert.ToInt32(Row["Id_Categoria"].ToString()),
                        Id_SubCategoria = Convert.ToInt32(Row["Id_SubCategoria"].ToString()),
                        Nombre = Row["Nombre"].ToString(),
                        Status = Row["Status"].ToString()

                    });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Categorias;
        }

    }
}
