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
    public partial class Frm_ProyectoAvance : Form
    {
        int Porcentaje, Id_Proyecto;

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ProyectoAvance_Load(object sender, EventArgs e)
        {
            Sli_Avance.Value = Porcentaje;
            Lbl_Avance.Text = Porcentaje.ToString();
            this.ActiveControl = Txt_Descripcion;
        }

        private void Sli_Avance_ValueChanged(object sender, EventArgs e)
        {
            if (Sli_Avance.Value>=Porcentaje)
            {
                Lbl_Avance.Text = Sli_Avance.Value.ToString();
            }
            else
            {
                Lbl_Avance.Text = Porcentaje.ToString();
                Sli_Avance.Value = Porcentaje;
            }
        }
        bool Nuevo_Proyecto()
        {
            if (Txt_Descripcion.Text.Trim() != string.Empty && Txt_Descripcion.Text.Trim().Length>20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Nuevo_Proyecto())
            {
                //int _Pirioridad = 0;
                //if (Swi_Prioridad.Value)
                //    _Pirioridad = 1;
                Proyectos _Proyectos = new Proyectos
                {
                    Id_Proyecto=Id_Proyecto,
                    Utimo_Avance=Txt_Descripcion.Text.Trim(),
                    Porcentaje_Avance=Sli_Avance.Value
                };
                ProyectosRepository.GuardarAvance(_Proyectos);
                Persistentes.Mensaje("Avance registrado correctamente.", 1);
                this.Close();
            }
            else
            {
                Persistentes.Mensaje("Agregue una descripcion (Min 20 caracteres).", 1);
            }
        }

        public Frm_ProyectoAvance(int _Porcentaje,int _Id_Proyecto)
        {
            InitializeComponent();
            Porcentaje = _Porcentaje;
            Id_Proyecto = _Id_Proyecto;
        }
    }
}
