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

    public partial class Frm_Rubros : Form
    {
        int _idDepartamento = 0;
        public Frm_Rubros()
        {
            InitializeComponent();
        }
        void Listar_Rubros()
        {
            FLow.Controls.Clear();
            RubroRequest RubroRequest;
            if (Btn_NuevoRubro.Enabled)
            {
                 RubroRequest = new RubroRequest();
            }
            else
            {
                RubroRequest = new RubroRequest { Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento };//, Id_Rubro = Persistentes.Id_Rubro };
                
            }
            foreach (var item in RubroRepository.ConsultarRubros(RubroRequest))
            {
                Agregar(item.Nombre,item.Id_Rubro.ToString(),item.Img);
            }
        }
        private void Btn_NuevoRubro_Click(object sender, EventArgs e)
        {
            Frm_RubroAgregar _Rubros = new Frm_RubroAgregar(Btn_NuevoRubro.Enabled);
            _Rubros.ShowDialog();
            Listar_Rubros();
        }
        BunifuTileButton btn = new Bunifu.Framework.UI.BunifuTileButton();
        void Agregar(string Nombre,string Id,byte[] Img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(Img);
            btn = new BunifuTileButton();
            btn.Image = Image.FromStream(ms);
            btn.ImagePosition = 20;
            btn.ImageZoom = 50;
            btn.LabelPosition = 41;
            btn.LabelText = Nombre;
            btn.Font = new System.Drawing.Font("Century Gothic", 10F);
            btn.Name = Id;
            btn.Size = new System.Drawing.Size(260, 250);
            btn.TabIndex =Convert.ToInt32( Id);
            FLow.Controls.Add(btn);
            btn.Click += new EventHandler(Cliq);
        }
        private void Cliq(Object sender ,EventArgs e)
        {
            btn = new BunifuTileButton();
            btn = (BunifuTileButton)sender;
            Persistentes.Id_DepartamentoSeleccionado = 0;
            Frm_RubroAgregar _Rubros = new Frm_RubroAgregar(Btn_NuevoRubro.Enabled);
            _Rubros.Edit = true;
            _Rubros.Id_Rubro =Convert.ToInt32(btn.Name);
            _Rubros.ShowDialog();
            Listar_Rubros();
        }
        private void Frm_Rubros_Load(object sender, EventArgs e)
        {
            if (Persistentes.Controles("ADMIN"))
            {
                Btn_NuevoRubro.Enabled = true;
            }
            else
            {
                Btn_NuevoRubro.Enabled = false;
            }
            RubroRequest RubroRequest;
            RubroRequest = new RubroRequest { Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento };
            foreach (var item in RubroRepository.ConsultarRubros(RubroRequest))
            {
                Persistentes.Id_Rubro = item.Id_Rubro;
            }
            var p = RubroRepository.ConsultarRubrosU(new RubroRequest(), Persistentes.Id_Rubro);
            _idDepartamento = p.Id_Departamento;
            if (_idDepartamento != Persistentes.UsuarioLogin_IdDepartamento || Persistentes.Id_Rubro == 0)
            {
                FLow.Visible = false;
                Btn_NuevoRubro.Visible = false;
                Persistentes.Mensaje("Reportese con su Administrador para ver su situacion");
                //Persistentes.Mensaje("Hola");
            }
            else
            {
                Listar_Rubros();
            }
            //else if (Persistentes.Id_Rubro == 0)
            //{
            //    FLow.Visible = false;
            //    Btn_NuevoRubro.Visible = false;
            //    Persistentes.Mensaje("Reportese con su Administrador para ver su situacion");
            //}
            //else if (resultadoCero == true)
            //{
            //    FLow.Visible = false;
            //    Btn_NuevoRubro.Visible = false;
            //    Persistentes.Mensaje("Reportese con su Administrador para ver su situacion");
            //}
            //else if (Persistentes.Id_Rubro != 0 && resultadoCero == false)
            //{
            //    Listar_Rubros();
            //}
        }
        //bool Controles(string Control)
        //{

        //    if (Persistentes.CadenaPermisosControles.IndexOf(Control) != -1)
        //    {
        //        Btn_NuevoRubro.Enabled = true;
        //        return true;
        //    }
        //    else
        //    {
        //        Btn_NuevoRubro.Enabled = false;
        //        return false;
        //    }
        //}

        private void FLow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
