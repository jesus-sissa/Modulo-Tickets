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
    public partial class Frm_Status : Form//,Actualizar
    {
        //private Actualizar ac;
        //public Frm_Status(Actualizar formulario)
        //{
        //    InitializeComponent();
        //    ac = formulario;
        //}
        public Frm_Status()
        {
            InitializeComponent();
        }

        private void Frm_Status_Load(object sender, EventArgs e)
        {
            Lbl_Nombre.Text = Persistentes.Nombre_Formulario;
        }

        private void Btn_NuevoFormulario_Click(object sender, EventArgs e)
        {
            FormatosRepository.Cambiar_status_Formulario(new FormatosRequest {status = "S",Id_Formato = Persistentes.Id_Formato});
            Persistentes.Mensaje("El status de" + Persistentes.Nombre_Formulario + " a pasado a activo"); ;
            //ac.Actualizardatos();
            this.Close();  
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            FormatosRepository.Cambiar_status_Formulario(new FormatosRequest {status= "N", Id_Formato = Persistentes.Id_Formato });
            Persistentes.Mensaje("El status de" + Persistentes.Nombre_Formulario + " a pasado a inactivo");
            //ac.Actualizardatos();
            this.Close();
        }

        //public void Actualizardatos()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
