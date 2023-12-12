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

    public partial class Frm_Departamentos : Form
    {
        bool EsProyecto = false;
        BunifuTileButton btn = new Bunifu.Framework.UI.BunifuTileButton();
        public Frm_Departamentos(bool _EsProyecto)
        {
            InitializeComponent();
            EsProyecto = _EsProyecto;
            Btn_Cerrar.Visible = !EsProyecto;
            if(_EsProyecto)
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59))))); 
        }
        void Listar_Departamentos()
        {
            Flow.Controls.Clear();
            DepartamentosRequest _DepartamentoRequest = new DepartamentosRequest();
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
            btn.Size = new System.Drawing.Size(120, 120);
            btn.TabIndex = Convert.ToInt32(Id);
            Flow.Controls.Add(btn);
            btn.Click += new EventHandler(Cliq);

        }
        private void Cliq(Object sender, EventArgs e)
        {
            btn = new BunifuTileButton();
            btn = (BunifuTileButton)sender;
            Persistentes.Id_DepartamentoSeleccionado = Convert.ToInt32(btn.Name);
            Persistentes.Nombre_Departamento = btn.LabelText;
            if (EsProyecto)
            {
                Frm_Proyectos frm = new Frm_Proyectos();
                frm.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Departamentos_Load_1(object sender, EventArgs e)
        {
            Listar_Departamentos();
        }
    }
}
