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
    public partial class Frm_ProyetosLista : Form
    {
     
        Bunifu.Framework.UI.BunifuFlatButton btn_Proyectos = new BunifuFlatButton();
        public Frm_ProyetosLista()
        {
            InitializeComponent();

        }
        void Listar_Proyectos()//Lista proyectos por el ID deparatmento 
        {
            Flow_Proyectos.Controls.Clear();
            Proyectos _Proyectos = new Proyectos
            {
                Id_Departamento = Persistentes.Id_DepartamentoSeleccionado
            };
            foreach (var item in ProyectosRepository.ConsultarProyectos(_Proyectos))
            {
                Agregar_Proyectos(item.Nombre, item.Id_Proyecto);
            }
        }
        void Agregar_Proyectos(string Nombre, int Id)
        {

            btn_Proyectos = new BunifuFlatButton();



            btn_Proyectos.ButtonText = "Asignar";
            btn_Proyectos.Name = Id.ToString();
            btn_Proyectos.Iconimage = null;
            btn_Proyectos.Size = new System.Drawing.Size(332, 34);
            btn_Proyectos.TabIndex = 42;
            btn_Proyectos.Text = "  " + Nombre;
            btn_Proyectos.Textcolor = System.Drawing.Color.White;

            Flow_Proyectos.Controls.Add(btn_Proyectos);
            btn_Proyectos.Click += new EventHandler(Cliq_Proyectos);

        }
        private void Cliq_Proyectos(Object sender, EventArgs e)
        {
            btn_Proyectos = new BunifuFlatButton();
            btn_Proyectos = (BunifuFlatButton)sender;
            Frm_Proyecto_Detalle frm = new Frm_Proyecto_Detalle(Convert.ToInt32(btn_Proyectos.Name));
            frm.ShowDialog();
        }

        private void Frm_ProyetosLista_Load(object sender, EventArgs e)
        {
            Listar_Proyectos();
            if(Persistentes.Controles("NUEVO PROYECTO"))
            {
                Btn_Nuevo.Visible = true;
            }
            else
            {
                Btn_Nuevo.Visible = false;
            }
        }
        private void Btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_Proyectos frm = new Frm_Proyectos();
            frm.ShowDialog();
            Listar_Proyectos();
        }
        //bool Controles(string Control)
        //{

        //    if (Persistentes.CadenaPermisosControles.IndexOf(Control) != -1)
        //    {
        //        Btn_Nuevo.Visible = true;
        //        return true;
        //    }
        //    else
        //        return false;
        //}
    }
}
