using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_Tickets.Model;
using static Modulo_Tickets.Model.UserRequest;
using Modulo_Tickets.Model.Repository;

namespace Modulo_Tickets
{
    public partial class Frm_AdminGeneral : Form
    {
        FlowLayoutPanel Flow = new FlowLayoutPanel();
        BunifuTileButton btn = new Bunifu.Framework.UI.BunifuTileButton();
        public Frm_AdminGeneral()
        {
            InitializeComponent();
        }

        private void Frm_AdminGeneral_Load(object sender, EventArgs e)
        {
            Listar_Rubros();
            Pnl_Centro.Controls.Add(Flow);
            Flow.Dock = System.Windows.Forms.DockStyle.Fill;

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
        private void CliqRubro(Object sender, EventArgs e) //------------
        {
            Persistentes.General = false;
            btn = new BunifuTileButton();
            btn = (BunifuTileButton)sender;
            Frm_StaffAdminGeneral frm = new Frm_StaffAdminGeneral(Convert.ToInt32(btn.Name),btn.LabelText);
            Persistentes.Nombre_Rubro = btn.LabelText;
            PanelContenido(frm);
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

        private void Btn_Tickets_Click(object sender, EventArgs e)
        {

        }
    }
}
