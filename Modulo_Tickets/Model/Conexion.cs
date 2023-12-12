using Modulo_Tickets.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Tickets
{
    class Conexion
    {

        public static SqlConnection creaConexion(string ClaveSucursal)
        {
            string connection;
            if (Properties.Settings.Default.Cnx != "" && Properties.Settings.Default.User!="")
            {
                if (Persistentes.ClaveSucursal == "01")
                {
                    connection = "Data Source=" + "SISSASQL" + ";Initial Catalog=SIAC;" + "User id=" + Properties.Settings.Default.User + "; pwd=" + Properties.Settings.Default.Password;
                }
                else if(Persistentes.ClaveSucursal == "02")
                {
                    connection = "Data Source=" + "192.168.10.1" + ";Initial Catalog=SAL_SIAC;" + "User id=" + Properties.Settings.Default.User + "; pwd=" + Properties.Settings.Default.Password;
                }
                else if (Persistentes.ClaveSucursal == "03")
                {
                    connection = "Data Source=" + "SQL-MTY-T01" + ";Initial Catalog=SIAC;" + "User id=" + Properties.Settings.Default.User + "; pwd=" + Properties.Settings.Default.Password;
                }
                else
                {
                    connection = "Data Source=" + "SQL-MTY-T01" + ";Initial Catalog=SIAC;" + "User id=" + Properties.Settings.Default.User + "; pwd=" + Properties.Settings.Default.Password;
                }

                return new SqlConnection(connection);

            }
            else
            {
                connection = System.Configuration.ConfigurationManager.ConnectionStrings[ClaveSucursal].ConnectionString;
            }
            return new SqlConnection(connection);
        }

        public static SqlConnection creaConexionCentral(string ClaveSucursal)
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionCentral"].ConnectionString;
            return new SqlConnection(connection);
        }

        public static SqlTransaction creaTransaccion(string ClaveSucursal)
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings[ClaveSucursal].ConnectionString;
            var cn = new SqlConnection(connection);
            cn.Open();
            return cn.BeginTransaction();
        }

        public static void creaParametro(SqlCommand cmd, string nombre, SqlDbType tipo, object valor, bool Mayusculas = false)
        {
            var prm = new SqlParameter(nombre, tipo);
            switch (tipo)
            {

                case SqlDbType.NChar:
                case SqlDbType.NText:
                case SqlDbType.NVarChar:
                case SqlDbType.Text:
                case SqlDbType.VarChar:
                    if (Mayusculas)
                    {
                        prm.Value = valor.ToString().ToUpper();
                    }
                    else
                    {
                        prm.Value = valor;
                    }
                    break;
                default:
                    prm.Value = valor;
                    break;
            }
            cmd.Parameters.Add(prm);
        }

        public static SqlCommand creaComando(string Procedimiento, SqlConnection conexion)
        {
            var cmd = new SqlCommand(Procedimiento, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static SqlCommand creaComando(string Procedimiento, SqlTransaction Transaccion)
        {
            var cmd = new SqlCommand(Procedimiento, Transaccion.Connection, Transaccion);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static DataTable ejecutaConsulta(SqlCommand cmd)
        {
            var Tbl = new DataTable();

            if (cmd.Connection.State == ConnectionState.Open)
            {
                Tbl.Load(cmd.ExecuteReader());
            }
            else
            {
                cmd.Connection.Open();
                Tbl.Load(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return Tbl;
        }

        public static void ejecutaConsulta(SqlCommand cmd, DataTable Tbl)
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                Tbl.Load(cmd.ExecuteReader());
            }
            else
            {
                cmd.Connection.Open();
                Tbl.Load(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
        }

        //public static DataSet ejecutaDataSet(SqlCommand cmd)
        //{
        //    DataSet Res;
        //    Res = new ds();

        //    if (!Res.Tables.Contains(cmd.CommandText))
        //        Res = new dsc();

        //    if (cmd.Connection.State == ConnectionState.Open)
        //        Res.Tables[cmd.CommandText].Load(cmd.ExecuteReader());
        //    else
        //    {
        //        cmd.Connection.Open();
        //        Res.Tables[cmd.CommandText].Load(cmd.ExecuteReader());
        //        cmd.Connection.Close();
        //    }

        //    return Res;
        //}

        //public static void ejecutaDataSet(SqlCommand cmd, ref ds Ds)
        //{
        //    if (cmd.Connection.State == ConnectionState.Open)
        //        Ds.Tables[cmd.CommandText].Load(cmd.ExecuteReader());
        //    else
        //    {
        //        cmd.Connection.Open();
        //        Ds.Tables[cmd.CommandText].Load(cmd.ExecuteReader());
        //        cmd.Connection.Close();
        //    }
        //}

        //public static void ejecutaDataSet(SqlCommand cmd, ref dsc Ds)
        //{
        //    if (cmd.Connection.State == ConnectionState.Open)
        //        Ds.Tables[cmd.CommandText].Load(cmd.ExecuteReader());
        //    else
        //    {
        //        cmd.Connection.Open();
        //        Ds.Tables[cmd.CommandText].Load(cmd.ExecuteReader());
        //        cmd.Connection.Close();
        //    }
        //}

        public static object ejecutaScalar(SqlCommand cmd)
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                return cmd.ExecuteScalar();
            }
            else
            {
                cmd.Connection.Open();
                var res = cmd.ExecuteScalar();
                cmd.Connection.Close();

                return res;
            }
        }

        public static int ejecutarNonquery(SqlCommand cmd)
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                return cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.Connection.Open();
                var res = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return res;
            }
        }
    }
}

