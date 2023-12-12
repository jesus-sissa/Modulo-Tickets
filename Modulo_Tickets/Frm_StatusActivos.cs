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
    public partial class Frm_StatusActivos : Form
    {
        MaterialSkin.Controls.MaterialRadioButton btn;
        public Frm_StatusActivos()
        {
            InitializeComponent();
        }
        void Listar()
        {
            FLow.Controls.Clear();
            foreach (var item in FormatosRepository.Consultar(new FormatosRequest { Id_Tarea = Persistentes.Id_Tarea }))
            {
                if (item.Status == "S")
                {
                    Agregar_Controles(item.Nombre, item.Id_Formato.ToString(), item.Status2);
                }
            }
        }
        void Agregar_Controles(string Nombre, string Id, string Status)
        {
            btn = new MaterialSkin.Controls.MaterialRadioButton();
            btn.Name = Id.ToString();
            btn.Size = new System.Drawing.Size(332, 34);
            btn.TabIndex = 42;
            btn.Text = "  " + Nombre;
            btn.Checked = Status == "A" ? true : false;
            FLow.Controls.Add(btn);
        }
        private void Frm_StatusActivos_Load(object sender, EventArgs e)
        {
            Listar();
            Lbl_NomSol.Text = Persistentes.Nombre_Tarea;
            TareasRequest tareas = new TareasRequest();
            TareasRequest request = new TareasRequest();
            tareas = TareasRepository.Consultar_Status_Procedimiento(request);
            string status = tareas.Status == "S" ? "AC" : "IN";
            string porcentaje = tareas.Porcentaje == "S" ? "S" : "N";
            string autorizacion = tareas.Autorizacion == "S" ? "S" : "N";
            if (status == "AC")
            {
                Chk_Status.Checked = true;
            }
            else
            {
                Chk_Status.Checked = false;
            }
            if(porcentaje == "S")
            {
                Chk_Porcentaje.Checked = true;
            }
            else
            {
                Chk_Porcentaje.Checked = false;
            }
            if(autorizacion == "S")
            {
                Chk_Autorizacion.Checked = true;
            }
            else
            {
                Chk_Autorizacion.Checked = false;
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            TareasRepository.Status_Tareas_Procedimientos(new TareasRequest { Id_Tarea = Persistentes.Id_Tarea, Status = Chk_Status.Checked == true ? "S" : "N", Porcentaje = Chk_Porcentaje.Checked == true ? "S" : "N", Autorizacion = Chk_Autorizacion.Checked == true ? "S" : "N" });
            Persistentes.Mensaje("El cambio de configuracion se ha hecho correctamente");
            foreach (Control C in FLow.Controls)
            {
                MaterialSkin.Controls.MaterialRadioButton Radio = (MaterialSkin.Controls.MaterialRadioButton)C;
                int _IdFormato = Convert.ToInt32(Radio.Name);
                if (Radio.Checked)
                {
                    FormatosRepository.Guardar(new FormatosRequest { Id_Formato = _IdFormato, Id_Tarea = Persistentes.Id_Tarea });
                    break;
                }
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chk_Status_CheckedChanged(object sender, EventArgs e)
        {
            if(Chk_Autorizacion.Checked == true)
            {
                //Persistentes.Mensaje("No puede estar activado status y autorizacion al mismo tiempo");
                Chk_Status.Checked = false;
                Chk_Porcentaje.Checked = false;
            }
        }

        private void FLow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Chk_Autorizacion_CheckedChanged(object sender, EventArgs e)
        {
            if ( Chk_Status.Checked == true || Chk_Porcentaje.Checked == true)
            {
                //Persistentes.Mensaje("No puede estar activado status y autorizacion al mismo tiempo");
                Chk_Autorizacion.Checked = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Lbl_Porcentaje_Click(object sender, EventArgs e)
        {

        }

        private void Chk_Porcentaje_CheckedChanged(object sender, EventArgs e)
        {
            if(Chk_Autorizacion.Checked == true)
            {
                Chk_Status.Checked = false;
                Chk_Porcentaje.Checked = false;
            }
        }
    }
}
