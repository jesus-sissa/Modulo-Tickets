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
    public partial class Frm_TareasDptos : Form
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        int _IdTarea = Persistentes.Id_Tarea;
        List<TareasDptosResponse> _Departamentos;
        public Frm_TareasDptos()
        {
            InitializeComponent();
            Lbl_Nombre.Text = Persistentes.Nombre_Tarea+ "/DEPARTAMENTOS";  
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Listar_Departamentos()
        {
            FLow.Controls.Clear();            
            _Departamentos = TareasRepository.Consultar_Dptos(new TareasRequest { Id_Tarea = _IdTarea });
            foreach (var item in _Departamentos)
            {
                Agregar(item.Nombre_Dpto, item.Id_Dptos.ToString());
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
            Persistentes.Id_Departamento = Convert.ToInt32(btn.Name);
            Persistentes.TareaNombre_Departamento = btn.Text;
            Frm_TareasUsuarios _Sub = new Frm_TareasUsuarios();
            _Sub.ShowDialog();
        }

        private void Frm_TareasDptos_Load(object sender, EventArgs e)
        {
            Listar_Departamentos();
        }

        private void Btn_NuevoRubro_Click(object sender, EventArgs e)
        {
            Frm_TareasDptosAdd Frm = new Frm_TareasDptosAdd();
            Frm.ShowDialog();
            Listar_Departamentos();
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

        private void Frm_TareasDptos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Space)
            {
                Frm_Formatos frm_dev = new Frm_Formatos();
                frm_dev.ShowDialog();
            }
            if(e.Control && e.KeyCode == Keys.Enter)
            {
                Frm_StatusActivos frm = new Frm_StatusActivos();
                frm.ShowDialog();
            }
        }
    }
}
