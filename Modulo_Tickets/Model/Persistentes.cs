using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Tickets.Model
{
    class Persistentes
    {
        public static DataTable Datatable_Permisos;
        public static int numdoc = 0; //se usara para validar el adjuntar documentos de un rubro no asignado 
        public static int Estrellas=0;
        public static string Comentarios_Estrellas = string.Empty;
        public static string Status_TickteStaff = string.Empty;
        public static bool Ticket_Nuevo = false;
        public static bool Ticket_Asignado = false;
        public static bool Ticket_Finalizado=false;
        public static bool Ticket_Cerrado = false;
        public static bool Ticket_Rechazado = false;  
        public static int Numero_Ticket=0;
        public static int Id_DepartamentoSeleccionado = 0;
        public static int Id_RubroSeleccionado = 0;
        public static string Nombre_Departamento = string.Empty;
        public static int Id_Rubro = 0;
        public static int Id_UsuarioA = 0;
        public static string Nombre_UsuarioA = string.Empty;
        public static int Usuario_Login = 0;
        public static string Usuario_Login_Nombre = string.Empty;
        public static string ClaveSucursal = string.Empty;
        public static int UsuarioLogin_IdDepartamento=0;
        public static byte[] usuarioLogin_Firma;
        public static string Nombre_Sucursal;
        //public static string CadenaPermisosControles = string.Empty;
        public static string Usuario_LoginCorreo = string.Empty;
        public static string Nombre_Rubro = string.Empty;
        public static int Numero_Documentos = 0; //agregado para limitacion de documentos 
        //Parametros de busqueda
        public static DateTime Fecha_Inicio;
        public static DateTime Fecha_Fin;
        public static string Status;
        //
        public static bool General = false;

        //Reporte Tipo
        public static object TipoReporte;

        public static int Id_ClienteExterno;
        public static string Nombre_ClienteExterno;

        //Tareas 
        public static int Tipo_tree = 0; // nos ayudara a diferenciar entre el historial de tickets y flujos
        public static int Id_Tarea = 0;
        public static int Id_Tarea_Flujo = 0;
        public static int Id_Departamento = 0;
        public static int Id_Flujo = 0;
        public static string Nombre_Tarea;
        public static string TareaNombre_Departamento;
        public static string Nombre_Formulario;
        public static int Id_Formato = 0;
        // Solicitud de vacaciones
        public static DataTable Empleado;
        //


        public static void Mensaje(String Texto, int Time = 2)
        {
            Frm_Mensaje msg = new Frm_Mensaje();
            msg.Txt_Mensaje.Text = Texto;
            msg.time = Time;
            msg.ShowDialog();
        }
        public static bool Controles(string Control)
        {
            foreach (DataRow Row in Persistentes.Datatable_Permisos.Rows)
            {
                if (Row[1].ToString() == Control)
                {
                    return true;
                }
            }
            return false;
            //if (Persistentes.CadenaPermisosControles.IndexOf(Control) != -1)
            //{

            //    return true;
            //}
            //else
            //    return false;
        }
    }
}
