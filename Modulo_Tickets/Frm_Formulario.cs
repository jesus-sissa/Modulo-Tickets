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
    public partial class Frm_Formulario : Form //, Actualizar
    {
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        public Frm_Formulario()
        {
            InitializeComponent();
        }
        void Listar_Formularios()
        {
            FLow.Controls.Clear();
            foreach(var item in FormatosRepository.Consultar(new FormatosRequest()))
            {
                Agregar(item.Id_Formato, item.Nombre, item.Status);
            }
        }
        void Agregar(int id,string nombre,string status)
        {
            if(status == "S")
            {
                btn = new BunifuFlatButton();
                btn.ButtonText = "Asignar";
                btn.Name = id.ToString();
                btn.Iconimage = null;
                btn.Size = new System.Drawing.Size(332, 34);
                btn.TabIndex = 42;
                btn.Text = "  " + nombre;
                btn.Textcolor = System.Drawing.Color.White;
                FLow.Controls.Add(btn);
                btn.Click += new EventHandler(Cliq);
            }
            else
            {
                btn = new BunifuFlatButton();
                btn.ButtonText = "Asignar";
                btn.Name = id.ToString();
                btn.Iconimage = null;
                btn.Size = new System.Drawing.Size(332, 34);
                btn.TabIndex = 42;
                btn.Text = "  " + nombre;
                btn.Textcolor = System.Drawing.Color.White;
                btn.Normalcolor = System.Drawing.Color.Red;
                btn.OnHovercolor = System.Drawing.Color.Red;
                FLow.Controls.Add(btn);
                btn.Click += new EventHandler(Cliq);
            }
            
        }
        private void Cliq(Object sender, EventArgs e)
        {
            btn = new BunifuFlatButton();
            btn = (BunifuFlatButton)sender;
            Persistentes.Nombre_Formulario = btn.Text;
            Persistentes.Id_Formato = Convert.ToInt32(btn.Name);
            //Frm_Status frm_Status = new Frm_Status(this);
            Frm_Status frm_Status = new Frm_Status();
            frm_Status.ShowDialog();
            this.Close();
        }
        private void Frm_Formulario_Load(object sender, EventArgs e)
        {
            Listar_Formularios();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_NuevoFormulario_Click(object sender, EventArgs e)
        {
            Frm_FormularioAdd frm = new Frm_FormularioAdd();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Listar_Formularios();
            }
        }

        private void FLow_Paint(object sender, PaintEventArgs e)
        {

        }
        
        //public void Actualizardatos()
        //{
        //    Listar_Formularios();
        //}
    }
}
