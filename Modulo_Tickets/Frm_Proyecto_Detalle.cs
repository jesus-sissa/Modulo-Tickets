using Bunifu.Framework.UI;
using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_Proyecto_Detalle : Form
    {
        List<Proyectos> _Lista_Proyectos;
        int Id_Proyecto = 0;
        public Frm_Proyecto_Detalle(int _Id_Proyecto)
        {
            InitializeComponent();
            Id_Proyecto = _Id_Proyecto;
        }
        void Detalle()
        {

             Proyectos _Proyectos = new Proyectos { Id_Proyecto = Id_Proyecto };
            _Lista_Proyectos = ProyectosRepository.ConsultarProyectosPorId(_Proyectos);
            foreach (var item in _Lista_Proyectos)
            {
                Txt_Nombre.Text = item.Nombre;
                Txt_Descripcion.Text = item.Descripcion;
                if (item.Prioridad == 1)
                {
                    Lbl_Prioridad.Text = "NORMAL";
                }
                else if(item.Prioridad == 2)
                {
                    Lbl_Prioridad.Text = "MEDIA";

                }
                else
                {
                    Lbl_Prioridad.Text = "ALTA";
                }
                Txt_UltimoAvance.Text = item.Utimo_Avance;
                Lbl_Status.Text = item.Status;
                Lbl_Fecha_Inicio.Text = item.Fecha_Inicio.ToShortDateString();
                Lbl_Duracion.Text = item.Duracion_Semanas.ToString()+ " SEMANAS";
                Pro_Porcentaje.Value = item.Porcentaje_Avance;
                Lbl_FechaActual.Text = DateTime.Now.ToShortDateString();
            }
            if(Persistentes.Id_DepartamentoSeleccionado==Persistentes.UsuarioLogin_IdDepartamento)
            {
                Btn_Avance.Visible = true;
            }
        }

        private void Frm_Proyecto_Detalle_Load(object sender, EventArgs e)
        {
            Detalle();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Poner_Pendiente();
            this.Close();
        }

        private void Btn_Avance_Click(object sender, EventArgs e)
        {
            if(Pro_Porcentaje.Value!=100)
            {
                Frm_ProyectoAvance frm = new Frm_ProyectoAvance(Pro_Porcentaje.Value, Id_Proyecto);
                frm.ShowDialog();
                Detalle();
            }
        }
        void Poner_Pendiente()
        {
            if (Persistentes.Id_DepartamentoSeleccionado == Persistentes.UsuarioLogin_IdDepartamento && Lbl_Status.Text=="NUEVO")
            {
                Proyectos _Proyectos = new Proyectos { Id_Proyecto = Id_Proyecto,Status="P"};
                ProyectosRepository.Proyecto_CambiarStatus(_Proyectos);
            }
        }

    }
}
