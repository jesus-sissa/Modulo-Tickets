using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Tickets.Model
{
    public class Documentos
    {
        private int id;
        private string nombre;
        private byte[] documento;
        private string extension;

        SqlConnection conexion = new SqlConnection("server=SQL-MTY-t01\\SQLEXPRESS;integrated security=true; database=SIAC");

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte[] Documento { get => documento; set => documento = value; }
        public string Extension { get => extension; set => extension = value; }

        public string AgregarDocumento()
        {
            conexion.Open();
            SqlCommand commando = new SqlCommand("insert into dbo.Tickets_Documentoss values (@nombre, @documento, @extension)", conexion);
            commando.CommandType = CommandType.Text;
            commando.Parameters.AddWithValue("@nombre", Nombre);
            commando.Parameters.AddWithValue("@documento", Documento);
            commando.Parameters.AddWithValue("@extension", Extension);
            commando.ExecuteNonQuery();
            conexion.Close();
            return "Agregado con exito";
        }
    }
}
