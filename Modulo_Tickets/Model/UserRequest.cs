using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Tickets.Model
{
    class UserRequest
    {
        public class BaseRequest
        {
            public decimal UsuarioId = Persistentes.Usuario_Login;
            public string ClaveSucursal = Persistentes.ClaveSucursal;
            public string ClaveModulo = "46";
            public int Id_Tareas = Persistentes.Id_Tarea;
        }
        public class TicketRequest:BaseRequest
        {
            public string Clave_Modulo { set; get; }//0
            public string Opcion { set; get; }//"Solicitud Otros"3
            public string Descripcion { set; get; }
            public decimal Tipo { set; get; }//3
            public decimal Id_Opcion { set; get; }//0
            public decimal Id_Reporte { set; get; }//0
            public decimal Id_Rubro { set; get; }
            public int Id_Ticket { set; get; }
            public decimal Id_UsuarioA { set; get; }
            public string Status { set; get; }
            public int Estrellas { set; get; }
            public int Nivel_Servicio { set; get; }
            public DateTime Fecha_Inicio { set; get; }
            public DateTime Fecha_Fin { set; get; }
            public int Id_Categoria { set; get; }
            public string Comentarios_Estrellas { set; get; }
            public int Id_UsurioRecibe { get; set; }
            public int Id_SubCategoria { set; get; }
            public int Id_Cliente { set; get; }


        }
        public class TicketResponse
        {
            public string _NumeroTicket { set; get; }//0
            public string _Descripcion { set; get; }//0
            public string _Status { set; get; }//0
            public string _Fecha { set; get; }//0
            public string _Usuario_Reporta { set; get; }
            public string _AsignadoA { set; get; }//0
            public int Id_Rubro { set; get; }
            public int IdUsuario_Asignado { set; get; }
            public string _FechaFin { set; get; }//0
            public string Nivel_Servicio { set; get; }//0
            public string _FechaAsignacion { set; get; }//0

            public string Categoria { set; get; }
            public double Tipo { get; set; }

            public string _SolicitudCambio { get; set; }
            public string _FechaRecibe { set; get; }//0
            public string SubCategoria { set; get; }
            public string Ticket_Proveedor { set; get; }
            public string T { set; get; }
            public string S { set; get; }

        }
        public class RubroRequest:BaseRequest
        {
            public string Nombre { set; get; }
            public Byte[] Img { set; get; }
            public string Mail { set; get; }
            public string Extension { set; get; }
            public int Id_Departamento { set; get; }
            public int Id_Rubro { set; get; }//Solo para cuando se tiene el Id rubro
            public int Num_Documento { set; get;  } //agregado para la limitacion de documentos
            public string Proveedor { set; get; } //agregado para la validacion de proveedor 
        }
        public class ArchivosRequest:BaseRequest
        {
            public int Id_Ticket { set; get; }
        }
        public class ArchivosResponse
        {
            public int Id_Ticket { set; get; }
            public int Id_Archivo { set; get; }
            public string Nombre { set; get; }
            public string Ext { set; get; }
            public string Formato { set; get; }
            public byte[] Imagen { set; get; }
            public string Peso { set; get; }
            public string Status { set; get; }
        }
        public class RubroResponse
        {
            public int Id_Rubro { set; get; }
            public string Nombre { set; get; }
            public Byte[] Img { set; get; }
            public string Mail { set; get; }
            public string Extension { set; get; }
            public int Id_Departamento { set; get; }
            public int Num_Documento { set; get; } //agregado para la limitacion de documentos 
            public string Proveedor { set; get; } //agregado para la validacion de proveedor
        }
        public class DepartamentosRequest:BaseRequest
        {
            public int Id_Departamento { set; get; }
        }
        public class DepartamentoResponse
        {
            public int Id_Departamento { set; get; }
            public string Nombre { set; get; }
        }
        public class EmpleadosRequest : BaseRequest
        {
            public int Id_Rubro { set; get; }
            public string Mail { set; get; }
            public string Extension { set; get; }
        }
        public class EmpleadosResponse
        {
            public int Id_Empleado { set; get; }
            public string Nombre { set; get; }
        }
        public class TicketDResponse
        {
            public string Fecha { set; get; }
            public string Hora { set; get; }
            public string Descripcion { set; get; }
        }
        public class Proyectos:BaseRequest
        {
            public int Id_Proyecto { set; get; }
            public string Nombre { set; get; }
            public string Descripcion { set; get; }
            public DateTime Fecha_Inicio { set; get; }
            public int Duracion_Semanas { set; get; }
            public int Prioridad { set; get; }
            public int Id_Departamento { set; get; }
            public string Status { set; get; }
            public int Porcentaje_Avance { set; get; }
            public string Utimo_Avance { set; get; }
            public string Departamento { set; get; }
        }
        public class LoginRequest : BaseRequest { }
        public class ReporteRequest : BaseRequest {
            public int Id_Rubro { set; get; }
            public DateTime Fecha_Inicio { set; get; }
            public DateTime Fecha_Fin { set; get; }
            public string Status { set; get; }
        }
        public class FechasRequest : BaseRequest
        {
            public int Id_Ticket { get; set; }
            public decimal Tipo { set; get; }//3
            public string Fecha_Proveedor_IN { set; get; }
            public string Fecha_Proveedor_Fn { set; get; }
            public string Proveedor { set; get; }
            public DateTime Fecha_Prov_Fn { set; get; }
        }
        public class ReporteTicketsEncabezadoResponse
        {
            public int Total { set; get; }
            public int Nuevos { set; get; }
            public int Asignados { set; get; }
            public int Actuando { set; get; }
            public int Finalizados { set; get; }
            public int Cerrados { set; get; }
            public int Rechazados { set; get; }

        }
        public class ReporteTicketsResponse
        {
            public decimal Numero { set; get; }
            public int Numero_Flujo { set; get; }
            public string Fecha_Registro { set; get; }
            public string Fecha_Asignacion { set; get; }
            public string Fecha_Finalizacion { set; get; }
            public string Fecha_Actuando { set; get; }
            public string Fecha_Cierre { set; get; }
            public string Fecha_Cancela { set; get; }
            public string Nivel_Servicio { set; get; }
            public int Estrellas { set; get; }
            public string Status { set; get; }
            public string Asignadoa { set; get; }
            public string Tiempo_Respuesta { set; get; }
            public string Departamento { set; get; }
            public string Categoria { set; get; }
            public string SubCategoria { set; get; }
            public string Descripcion { set; get; }
            public string Fecha_Proveedor_IN { set; get; }
            public string Fecha_Proveedor_Fn { set; get; }
            public string Sucursal { set; get; }
            public string Nombre { set; get; }
            public string Descripcion_Final { set; get; }
             public string Porcentaje { get; set; }
            public string Autorizacion { get; set; }
        }
        public class CorreoRequest:BaseRequest
        {
            public int Id_Sucursal { set; get; }
        }
        public class CorreoResponse 
        {
            public int Id_Flujo { get; set; }
            public string Area { set; get; }
            public string AreaMail { set; get; }
            public string AreaExtension { set; get; }
            public decimal Numeroticket { set; get; }
            public string TicketDescripcion { set; get; }
            public string UsuarioReporta { set; get; }
            public string UsuarioReportaMail { set; get; }
            public string UsuarioReportaExtension { set; get; }
            public string UsuarioAsignadoMail { set; get; }
            public byte[] Archivo { set; get; }
            public string Nombre_Archivo { set; get; }
        }
        public class CategoriasRequest:BaseRequest
        {
            public int Id_Categoria { get; set; }
            public string Nombre { get; set; }
            public int Id_Rubro { get; set; }
            public string Status { get; set; }
        }
        public class CategoriasResponse
        {
           public int Id_Rubro { get; set; }
           public int Id_Categoria { get; set; }
           public int Id_SubCategoria { get; set; }
           public string Nombre { get; set; }
           public string Status { get; set; }
        }
        public class ImagenRequest:BaseRequest
        {
            public string Nombre { get; set; }
            public string Extension { get; set; }
            public string Formato { get; set; }
            public byte[] Archivo_Byte { get; set; }
            public string Base64 { get; set; }
            public double Peso { get; set; }
            public int Id_Ticket { get; set; }
            public int Id_Flujo { get; set; }
            public string Id { get; set; }

        }
        public class ClientesRequest: BaseRequest
        {
            public int Id_Padre { get; set; }
        }
        public class ClienteResponse
        {
            public int Id_Cliente { get; set; }
            public string Nombre { get; set; }

        }
        public class TareasRequest : BaseRequest
        {
            public int Id_Tarea { set; get; }
            public int Id_Dpto { set; get; }
            public string Nombre { get; set; }
            public string Status { get; set; }
            public string Porcentaje { get; set; }
            public string Autorizacion { get; set; }

        }
        public class TareasResponse
        {
            public int Id_Tarea { get; set; }
            public string Nombre { get; set; }
            public int Id_Formato { get; set; }
        }
        public class TareasDptosResponse
        {
            public int Id_Dptos { get; set; }
            public string Nombre_Dpto { get; set; }
            public string Status { get; set; }
        }
        public class TareasUsuariosResponse
        {
            public int Id_Empleado { get; set; }
            public string Nombre { get; set; }
            public int Status { get; set; }
        }
        public class TareasUsuariosResquest : TareasRequest
        {
            public int Id_Empleado { get; set; }
        }
        public class TicketFlujoRequest : BaseRequest
        {
            public int Id_Flujo { get; set; }
            public decimal Id_UsuarioA { set; get; }
            public DateTime Fecha_Inicio { set; get; }
            //public int Id_Tarea { get; set; }
            public string Nombre_Flujo { set; get; }
            public string Descripcion { set; get; }
            public string Status { set; get; }
            public int Estrellas { set; get; }
            public DateTime Fecha_Fin { set; get; }
            public int Porcentaje { get; set; }
            public string Autorizacion { get; set; }
            //LLENADO DE PRESTAMO
            public int Can_Sol { get; set; }
            public string Fecha_Ult_Pres { get; set; }
            public int Prestamos_UltA { get; set; }
            public string MyF { get; set; }
            public int Id_Autoriza { get; set; }

        }
        public class TicketFlujoResponse
        {
            public string _Id_Flujo { get; set; }
            public string _Fecha_Inicio { set; get; }
            //public int Id_Tarea { get; set; }
            public string _Nombre_Flujo { get; set; }
            public string _Descripcion { set; get; }
            public string _Status { set; get; }
            public string _Estrellas { set; get; }
            public string _Fecha_Resuelto { set; get; }
            public string _Fecha_Fin { set; get; }
            public string _Usuario_Reporta { set; get; }
            public string _Porcentaje { set; get; }
            public string _Autorizacion { set; get; }
        }
        public class FlujoDResponse
        {
            public string Fecha { set; get; }
            public string Hora { set; get; }
            public string Descripcion { set; get; }
        }
        public class ReporteFlujoRequest : BaseRequest
        {
            public int Id_Dpto { set; get; }
            public int Id_Empleado { set; get; }
            public DateTime Fecha_Inicio { set; get; }
            public DateTime Fecha_Fin { set; get; }
            public string Status { set; get; }
        }
        public class CorreoResponseFlujo
        {
            public int Id_Flujo { get; set; }
            public int Id_Tarea { get; set; }
            public string Nombre_Inv { set; get; }
            public string Nombre_Flujo { set; get; }
            public string Nombre_Dep_Inv { set; get; }
            public string Mail_Inv { set; get; }
            public string Extension_Inv { set; get; }
            public string Descripcion { set; get; }
            public string UsuarioReporta { set; get; }
            public string UsuarioReportaMail { set; get; }
            public string UsuarioReportaExtension { set; get; }
            public byte[] Archivo { set; get; }
            public string Nombre_Archivo { set; get; }
        }
        public class FormatosRequest:BaseRequest
        {
            public int Id_Formato { set; get; }
            public int Id_Tarea { set; get; }
            public string Nombre { set; get; }
            public string status { set; get; }
            public int departamento { get; set; }
        }
        public class FormatosResponse
        {
            public int Id_Formato { set; get; }
            public string Nombre { set; get; }
            public string Status { set; get; }
            public string Status2 { set; get; }
        }
        public class SolicitudVacacionesRequest:BaseRequest
        {
            public int departamento { get; set; }
            public int Id_Empleado { get; set; }
            public string Clave_Empleado { get; set; }
            public int Periodo { get; set; }
            public int DiasT { get; set; }
            public int DTomados { get; set; }
            public int SaldoV { get; set; }
            public string Fecha_Requerida { get; set; }
            public string Comentario_Solicita { get; set; }
            public int Usuario_Registro { get; set; }
            public int Usuario_Autoriza { get; set; }
            public string Fecha_Regreso { get; set; }
        }
        public class SolicitudVacacionesResponse
        {
            public int Id_Empleado { set; get; }
            public int Clave_Empleado { set; get; }
            public string Nombre { set; get; }
            public string Fecha_Ingreso { set; get; }
            public string Departamento { set; get; }

            public string Puesto { set; get; }
            public int Id_Formato { set; get; }
            public byte [] Firma { set; get; }
            public byte [] Huella { set; get; }
        }
        public class Prestamo:BaseRequest
        {
            public int Id_Flujo { get; set; }
            public int Can_Sol { get; set; }
            public string Fecha_Ult_Pres { get; set; }
            public int Prestamos_UltA { get; set; }
            public string MyF { get; set; }
            public int Id_Empleado { set; get; }
            public string Nombre { set; get; }
            public int Clave_Empleado { set; get; }
            public DateTime Fecha_Ingreso { set; get; }
            public DateTime Fecha_Registro { set; get; }
            public byte[] Firma { set; get; }
            public byte[] Huella { set; get; }
            public int Id_Autoriza { get; set; }
            public string Nombre_Autoriza { set; get; }
            public byte[] Firma_Autoriza { set; get; }
            public string Autorizacion { set; get; }
            public string status_autorizacion { set; get; }
        }
        public class Permisos: BaseRequest
        {
            public string Nombre_RH { set; get; }
            public byte[] Firma { set; get; }
        }
    }
}
