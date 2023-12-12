using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Tickets.Model.Repository
{
    class ConfiguracionRubrosTickesRepository
    {
        public ConfiguracionRubrosTickets Get_ConfiguracionRubro(int Id_Rubro) 
        {
            ConfiguracionRubrosTickets config = new ConfiguracionRubrosTickets();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(Persistentes.ClaveSucursal);
                cmd = Conexion.creaComando("Config_TkS_Get_Configuracion_Rubros_Tickets", cnn);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.VarChar, Id_Rubro);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    config.Id_Rubro = dataReader.GetInt32(0);
                    config.Tickets = dataReader.GetBoolean(1);
                    config.SolicitudCambio = dataReader.GetBoolean(2);
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return config;
        }

        public bool Configuracion_Rubro_Tickets(ConfiguracionRubrosTickets config) 
        {
            bool resp = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(Persistentes.ClaveSucursal);
                cmd = Conexion.creaComando("Config_TkS_Agregar_ConfiguracionRubros", cnn);
                Conexion.creaParametro(cmd, "@IdRubro", SqlDbType.Int, config.Id_Rubro);
                Conexion.creaParametro(cmd, "@Ticket", SqlDbType.Bit, config.Tickets);
                Conexion.creaParametro(cmd, "@Solicitud", SqlDbType.Bit, config.SolicitudCambio);
                cmd.Connection.Open();
                Conexion.ejecutaConsulta(cmd);
                cmd.Connection.Close();
                resp = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return resp;
        }
    }
}
