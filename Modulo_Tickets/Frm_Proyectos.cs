using Modulo_Tickets.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_Tickets.Model.Repository;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_Proyectos : Form
    {
        int Prioridad_Proyecto=1;
        public Frm_Proyectos()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sli_Semanas_ValueChanged(object sender, EventArgs e)
        {
            Lbl_Semanas.Text = Sli_Semanas.Value.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           // MessageBox.Show(Mon_Semanas.SelectionStart.ToShortDateString());
        }

        private void Frm_Proyectos_Load(object sender, EventArgs e)
        {
            Btn_Departamento.LabelText = Persistentes.Nombre_Departamento;
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            if(Nuevo_Proyecto())
            {
                //int _Pirioridad = 0;
                //if (Swi_Prioridad.Value)
                //    _Pirioridad = 1;
                Proyectos _Proyectos = new Proyectos
                {
                    Nombre = Txt_Nombre.Text.Trim(),
                    Descripcion = Txt_Descripcion.Text.Trim(),
                    Fecha_Inicio = Mon_Semanas.SelectionStart,
                    Duracion_Semanas = Convert.ToInt32(Lbl_Semanas.Text),
                    Prioridad = Prioridad_Proyecto,
                    Id_Departamento = Persistentes.Id_DepartamentoSeleccionado,
                    Status="A"
                };
                ProyectosRepository.GuardarProyecto(_Proyectos);
                Persistentes.Mensaje("El proyecto se a guardado correctamente.",2);
                this.Close();
            }
            else
            {
                Persistentes.Mensaje("Todos los campos son requeridos.",2);
            }
            
        }
        bool Nuevo_Proyecto()
        {
            if(Txt_Nombre.Text.Trim()!=string.Empty && Txt_Descripcion.Text.Trim()!=string.Empty&& Convert.ToInt32(Lbl_Semanas.Text)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            if(Sli_Prioridad.Value<1)
            {
                Prioridad_Proyecto = 1;
                Lbl_Prioridad.Text = "NORMAL";
                Sli_Prioridad.IndicatorColor = Color.SeaGreen;
            }
            else if (Sli_Prioridad.Value<2)
            {
                Prioridad_Proyecto = 2;
                Lbl_Prioridad.Text = "MEDIA";
                Sli_Prioridad.IndicatorColor = Color.Orange;
            }
            else if(Sli_Prioridad.Value<3)
            {
                Prioridad_Proyecto = 3;
                Lbl_Prioridad.Text = "ALTA";
                Sli_Prioridad.IndicatorColor = Color.Red;
            }
        }
    }
}
