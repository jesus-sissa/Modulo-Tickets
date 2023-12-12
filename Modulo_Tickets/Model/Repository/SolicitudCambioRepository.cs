using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Tickets.Model.Repository
{
    class SolicitudCambioRepository
    {
        public string Get_Id_SolicitudCambio(int ticket) 
        {
            string Id_SolicitudCambio = null;
            SolicitudCambio _solicitud = new SolicitudCambio();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(Persistentes.ClaveSucursal);
                cmd = Conexion.creaComando("Urs_TkS_Get_Id_SolicitudCambio", cnn);
                Conexion.creaParametro(cmd, "@Ticket", SqlDbType.VarChar, ticket);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader.GetString(0)!=null)
                    {
                        Id_SolicitudCambio = dataReader.GetString(0);
                    }
                  

                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Id_SolicitudCambio;
        }
        public SolicitudCambio Get_Solicitud(string solicitud)
        {
            SolicitudCambio _solicitud = new SolicitudCambio();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(Persistentes.ClaveSucursal);
                cmd = Conexion.creaComando("Urs_TkS_Get_Solicitud", cnn);
                Conexion.creaParametro(cmd, "@Id_SolicitudCambio", SqlDbType.VarChar, solicitud);
                cmd.Connection.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    _solicitud.Id_Solicitud = dataReader.GetInt32(0);
                    _solicitud.Id_SolicitudCambio = dataReader.GetString(1).ToString();
                    _solicitud.Id_Ticket = dataReader.GetInt32(2);
                    if (dataReader.GetString(3) == null)
                    {
                        _solicitud.Nombre_Doc_Solicitud = "";
                    }
                    else {
                        _solicitud.Nombre_Doc_Solicitud = dataReader.GetString(3);
                    }
                   
                    if (dataReader.GetValue(4) != System.DBNull.Value)
                    {
                        _solicitud.Doc_Solicitud = (byte[])dataReader.GetValue(4);
                    }

                    _solicitud.Status_Solicitud = dataReader.GetString(5);
                }
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return _solicitud;
        }

        public bool Agregar_solicitud(int Ticket)
        {
            bool resp = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(Persistentes.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_TkS_Agregar_SolicitudCambio", cnn);
                Conexion.creaParametro(cmd, "@Ticket", SqlDbType.Int, Ticket);
                Conexion.creaParametro(cmd, "@Id_Rubro", SqlDbType.Int, Persistentes.Id_Rubro);
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

        public bool Agregar_Documento_Solicitud(int id_solicitud, string nombre_doc, byte[] documento)
        {

            //@Id_Solicitud int,@NombreDocSolicitud varchar(50),@Doc_Solicitud varbinary(MAX)
            bool resp = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(Persistentes.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_TkS_Actualizar_Doc_Solicitud_Cambio", cnn);
                Conexion.creaParametro(cmd, "@Id_Solicitud", SqlDbType.Int, id_solicitud);
                Conexion.creaParametro(cmd, "@NombreDocSolicitud", SqlDbType.VarChar, nombre_doc);
                Conexion.creaParametro(cmd, "@Doc_Solicitud", SqlDbType.VarBinary, documento);
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

        public bool Agregar_Documento_Solicitud_Usuario(int id_solicitud, string nombre_doc, byte[] documento)
        {

            //@Id_Solicitud int,@NombreDocSolicitud varchar(50),@Doc_Solicitud varbinary(MAX)
            bool resp = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion(Persistentes.ClaveSucursal);
                cmd = Conexion.creaComando("Usr_Tks_ActualizarDoc_Solicitud_Cambio_Usuario", cnn);
                Conexion.creaParametro(cmd, "@Id_Solicitud", SqlDbType.Int, id_solicitud);
                Conexion.creaParametro(cmd, "@NombreDocSolicitud", SqlDbType.VarChar, nombre_doc);
                Conexion.creaParametro(cmd, "@Doc_Solicitud", SqlDbType.VarBinary, documento);
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
        public SolicitudCambio Actualizar_Doc_Solicitud(SolicitudCambio _solicitud)
        {
            var solicitud = Get_Solicitud(_solicitud.Id_SolicitudCambio);
            _solicitud.Doc_Solicitud = solicitud.Doc_Solicitud;
            return _solicitud;
        }

    }
}
