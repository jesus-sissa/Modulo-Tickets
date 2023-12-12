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
    public partial class Frm_Seguimiento : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn_Proyectos = new BunifuFlatButton();
        BunifuTileButton btn = new Bunifu.Framework.UI.BunifuTileButton();
        public Frm_Seguimiento()
        {
            InitializeComponent();
        }

        private void Frm_Seguimiento_Load(object sender, EventArgs e)
        {
    ;
            //Listar_Departamentos(Controles("NUEVO PROYECTO"));
            Listar_Departamentos(true);

        }
        //bool Controles(string Control)
        //{

        //    if (Persistentes.CadenaPermisosControles.IndexOf(Control) != -1)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        void Listar_Departamentos(bool FiltroDepartamento)
        {
            Flow_Departamentos.Controls.Clear();
            DepartamentosRequest _DepartamentoRequest;
            if (!FiltroDepartamento)
            {
                _DepartamentoRequest = new DepartamentosRequest { Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento };
            }
            else
            {
                _DepartamentoRequest = new DepartamentosRequest { Id_Departamento = 0};
            }
            foreach (var item in DepartamentosRepository.ConsultaDepto(_DepartamentoRequest))
            {
                Agregar(item.Nombre, item.Id_Departamento);
            }
        }
        void Agregar(string Nombre, int Id)
        {

            btn = new BunifuTileButton();
            btn.ImagePosition = 20;
            btn.ImageZoom = 50;
            btn.LabelPosition = 41;
            btn.LabelText = Nombre;
            btn.Name = Id.ToString();
            btn.Font = new System.Drawing.Font("Century Gothic", 10F);
            btn.Size = new System.Drawing.Size(120, 120);
            btn.TabIndex = Convert.ToInt32(Id);
            Flow_Departamentos.Controls.Add(btn);
            btn.Click += new EventHandler(Cliq);

        }
        private void Cliq(Object sender, EventArgs e)
        {
            btn = new BunifuTileButton();
            btn = (BunifuTileButton)sender;
            Persistentes.Id_DepartamentoSeleccionado = Convert.ToInt32(btn.Name);
            Persistentes.Nombre_Departamento = btn.LabelText;
            //Listar_Proyectos();
            Frm_ProyetosLista frm = new Frm_ProyetosLista();
            frm.ShowDialog();
        }



        void Listar_Proyectos()//Lista proyectos por el ID deparatmento 
        {
            Flow_Departamentos.Controls.Clear();
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

            Flow_Departamentos.Controls.Add(btn_Proyectos);
            btn_Proyectos.Click += new EventHandler(Cliq_Proyectos);

        }
        private void Cliq_Proyectos(Object sender, EventArgs e)
        {
            btn_Proyectos = new BunifuFlatButton();
            btn_Proyectos = (BunifuFlatButton)sender;
            //this.Close();

        }
    }
}
