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
using Modulo_Tickets.View.Formatos;

namespace Modulo_Tickets
{
    public partial class Frm_FlujosNew : Form
    {
        List<TareasResponse> Formatos;
        Bunifu.Framework.UI.BunifuFlatButton btn = new BunifuFlatButton();
        public Frm_FlujosNew()
        {
            InitializeComponent();
        }
        private void Frm_FlujosNew_Load_1(object sender, EventArgs e)
        {
            Listar_Tareas();
        }
        void Listar_Tareas()
        {
            FLow.Controls.Clear();
            Formatos = TareasRepository.Consultar(new TareasRequest());
            foreach (var item in Formatos)
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
            Persistentes.Nombre_Tarea = btn.Text;
            if (Formatos.Where(x => x.Id_Tarea == Persistentes.Id_Tarea).Select(x => x.Id_Formato).SingleOrDefault() != 0)
            {
                int idFormato = Formatos.Where(x => x.Id_Tarea == Persistentes.Id_Tarea).Select(x => x.Id_Formato).SingleOrDefault();
                if (idFormato == 1)
                {
                    Frm_Vacaciones frm = new Frm_Vacaciones();
                    frm.ShowDialog();
                }
                if(idFormato == 2)
                {
                    Frm_Prestamos fr = new Frm_Prestamos();
                    fr.ShowDialog();
                }
                if(idFormato == 3)
                {
                    Frm_Permisos frm_ = new Frm_Permisos();
                    frm_.ShowDialog();
                }
            }
            else
            {
                Frm_FlujoNuevo flujoNuevo = new Frm_FlujoNuevo();
                flujoNuevo.ShowDialog();
            }
            //var Existeformato = (from formato in Formatos
            //                    where formato.Id_Tarea == Persistentes.Id_Tarea
            //                    select formato.Id_Formato).FirstOrDefault() ;

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void FLow_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
