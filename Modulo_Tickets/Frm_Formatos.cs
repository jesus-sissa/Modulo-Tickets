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
    public partial class Frm_Formatos : Form
    {
        MaterialSkin.Controls.MaterialRadioButton btn;
        public Frm_Formatos()
        {
            InitializeComponent();
        }
        void Listar()
        {
            FLow.Controls.Clear();
            foreach (var item in FormatosRepository.Consultar(new FormatosRequest { Id_Tarea=Persistentes.Id_Tarea }))
            {
                if(item.Status == "S")
                {
                    Agregar_Controles(item.Nombre, item.Id_Formato.ToString(), item.Status2);
                }
            }
        }
        void Agregar_Controles(string Nombre, string Id,string Status)
        {
            btn = new MaterialSkin.Controls.MaterialRadioButton();
            btn.Name = Id.ToString();
            btn.Size = new System.Drawing.Size(332, 34);
            btn.TabIndex = 42;
            btn.Text = "  " + Nombre;
            btn.Checked = Status == "A" ? true : false;
            FLow.Controls.Add(btn);
        }

        private void Frm_Formatos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            foreach (Control C in FLow.Controls)
            {
                MaterialSkin.Controls.MaterialRadioButton Radio = (MaterialSkin.Controls.MaterialRadioButton)C;
                int _IdFormato = Convert.ToInt32(Radio.Name);
                if (Radio.Checked)
                {
                    FormatosRepository.Guardar(new FormatosRequest { Id_Formato= _IdFormato,Id_Tarea= Persistentes.Id_Tarea });
                    break;
                }                                                
            }
            Close();
        }

        private void FLow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
