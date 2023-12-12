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
    public partial class Frm_Reportes : Form
    {
        int _IdRubro = 0;
        int _idDepartamento = 0;
        private ConfiguracionRubrosTickesRepository _config_Rubros;
        private ConfiguracionRubrosTickets _configuracion;
        FlowLayoutPanel Flow = new FlowLayoutPanel();
        BunifuTileButton btn = new Bunifu.Framework.UI.BunifuTileButton();
        public Frm_Reportes()
        {
            InitializeComponent();
        }
        void Listar_Rubros()
        {
            Flow.Controls.Clear();
            RubroRequest RubroRequest = new RubroRequest();
            foreach (var item in RubroRepository.ConsultarRubros(RubroRequest))
            {
                AgregarRubro(item.Nombre, item.Id_Rubro.ToString(), item.Img);
            }
        }


        void AgregarRubro(string Nombre, string Id, byte[] Img)
        {
            foreach (DataRow Row in Persistentes.Datatable_Permisos.Rows)
            {
                if (Row[1].ToString() == Nombre)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(Img);
                    btn = new BunifuTileButton();
                    btn.Image = Image.FromStream(ms);
                    btn.ImagePosition = 20;
                    btn.ImageZoom = 50;
                    btn.LabelPosition = 41;
                    btn.LabelText = Nombre;
                    btn.Name = Id;
                    btn.Font = new System.Drawing.Font("Century Gothic", 9F);
                    btn.Size = new System.Drawing.Size(229, 186);

                    btn.TabIndex = Convert.ToInt32(Id);
                    Flow.Controls.Add(btn);
                    btn.Click += new EventHandler(CliqRubro);
                }
            }
           

        }
        private void CliqRubro(Object sender, EventArgs e)
        {
            btn = new BunifuTileButton();
            btn = (BunifuTileButton)sender;
            Frm_ReporteTickets frm = new Frm_ReporteTickets();
            Persistentes.Id_Rubro = Convert.ToInt32(btn.Name);
            Persistentes.Nombre_Rubro = btn.LabelText;
            var p = RubroRepository.ConsultarRubrosU(new RubroRequest(), Convert.ToInt32(btn.Name));
            Persistentes.Id_Departamento = p.Id_Departamento;
            PanelContenido(frm);
        }

        private void Frm_Reportes_Load(object sender, EventArgs e)
        {
            // Listar_Rubros();
            //if (Persistentes.Controles("REPORTES GENERAL"))
            //{
                Listar_Rubros();
                Pnl_Centro.Controls.Add(Flow);
                Flow.Dock = System.Windows.Forms.DockStyle.Fill;
            //    return;
            //}
            //else
            //{
            //    Persistentes.Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento;
            //    Frm_ReporteTickets frm = new Frm_ReporteTickets();
            //    RubroRequest RubroRequest = new RubroRequest { Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento };
            //    foreach (var item in RubroRepository.ConsultarRubros(RubroRequest))
            //    {
            //        Persistentes.Nombre_Rubro = item.Nombre;
            //        btn.LabelText = Persistentes.Nombre_Rubro;
            //        //Persistentes.Nombre_Rubro = btn.LabelText;
            //    }
            //    PanelContenido(frm);
            //}
            //RubroRequest Rubro;
            //Rubro = new RubroRequest { Id_Departamento = Persistentes.UsuarioLogin_IdDepartamento };
            //foreach (var item in RubroRepository.ConsultarRubros(Rubro))
            //{
            //    _IdRubro = item.Id_Rubro;
            //}
            //var p = RubroRepository.ConsultarRubrosU(new RubroRequest(), _IdRubro);
            //_idDepartamento = p.Id_Departamento;
            //if(_idDepartamento != Persistentes.UsuarioLogin_IdDepartamento || _IdRubro == 0)
            //{
            //    Pnl_Centro.Visible = false;
            //    Persistentes.Mensaje("Reportese con su Administrador para ver su situacion");
            //}
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
        private void Btn_Tickets_Click(object sender, EventArgs e)
        {
            //Listar_Rubros();
            //Pnl_Centro.Controls.Add(Flow);
            //Flow.Dock = System.Windows.Forms.DockStyle.Fill;
            //panel1.Visible = false;
            

        }
        public void PanelContenido(Form Formulario)
        {
            if (Formulario == null)
            {
                Pnl_Centro.Controls.Clear();
                return;
            }
            Pnl_Centro.Controls.Clear();
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Pnl_Centro.Controls.Add(Formulario);
            Formulario.Show();
        }

        private void Btn_Proyectos_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_Centro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Flow_Rubros_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
