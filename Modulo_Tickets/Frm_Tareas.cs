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
    public partial class Frm_Tareas : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        public Frm_Tareas()
        {
            InitializeComponent();
        }
        void Listar_Tareas()
        {
            FLow.Controls.Clear();
            foreach (var item in TareasRepository.Consultar(new TareasRequest ()))
            {
                Agregar(item.Nombre, item.Id_Tarea.ToString());
            }
        }
        void Agregar(string Nombre, string Id)
        {
            btn = new BunifuFlatButton();
            btn.ButtonText = "Asignar";
            btn.Name = Id.ToString();
            btn.Iconimage = null;
            btn.Size = new System.Drawing.Size(332, 34);
            btn.TabIndex = 42;
            btn.Text = "  " + Nombre;
            btn.Textcolor = System.Drawing.Color.White;
            FLow.Controls.Add(btn);
            btn.Click += new EventHandler(Cliq);

        }
        private void Cliq(Object sender, EventArgs e)
        {
            btn = new BunifuFlatButton();
            btn = (BunifuFlatButton)sender;
            Persistentes.Id_Tarea = Convert.ToInt32(btn.Name);
            Persistentes.Id_Tarea_Flujo = Convert.ToInt32(btn.Name);
            Persistentes.Nombre_Tarea = btn.Text;
            Frm_TareasDptos _Sub = new Frm_TareasDptos();
            _Sub.ShowDialog();
        }

        private void Frm_Tareas_Load(object sender, EventArgs e)
        {
            Listar_Tareas();
        }

        private void Btn_NuevoRubro_Click(object sender, EventArgs e)
        {
            Frm_TareasAdd _Categoria = new Frm_TareasAdd();

            DialogResult dr = _Categoria.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Listar_Tareas();
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
