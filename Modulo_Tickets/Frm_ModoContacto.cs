using Bunifu.Framework.UI;
using CustomAlertBoxDemo;
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
using System.Timers;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_ModoContacto : Form
    {
        public Frm_ModoContacto()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            EmpleadosRequest Empleados = new EmpleadosRequest
            {
                Mail = Txt_Mail.Text.Trim(),
                Extension=Txt_Extension.Text.Trim()
            };
            EmpleadosRepository.GuardarEmpleados_ModoContacto(Empleados);
            Persistentes.Mensaje("Informacion actualizada correctamente (Doble clic en su nombre para actualizar nuevamente).", 5);
            this.Close();
        }
    }
}
