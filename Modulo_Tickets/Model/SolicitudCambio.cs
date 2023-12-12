using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Tickets.Model
{
    class SolicitudCambio
    {
        public int Id_Solicitud { get; set; }
        public string Id_SolicitudCambio { get; set; }
        public int Id_Ticket { get; set; }
        public DateTime Fech_Creacion { get; set; }
        public string Status_Solicitud { get; set; }
        public string Nombre_Doc_Solicitud { get; set; }
        public byte[] Doc_Solicitud  { get; set; }
        public string Nombre_Doc_Analisis { get; set; }
        public byte[] Doc_Analisis { get; set; }

    }
}
