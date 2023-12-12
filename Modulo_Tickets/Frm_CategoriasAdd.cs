using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_Tickets.Model.Repository;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_CategoriasAdd : Form
    {
        int _IdRubro;
        int _IdCategoria;
        string _Ventana;
        public Frm_CategoriasAdd(int Id_Rubro,int Id_Categoria,string Ventana)
        {
            InitializeComponent();
            _IdRubro = Id_Rubro;
            _IdCategoria = Id_Categoria;
            _Ventana = Ventana;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                CategoriasRequest _Categoria = new CategoriasRequest { Id_Rubro = _IdRubro, Nombre = Txt_Nombre.Text, Id_Categoria = _IdCategoria };
                if (_IdRubro != 0 && _IdCategoria==0)
                {
                    CategoriasRepository.Guardar(_Categoria);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    CategoriasRepository.GuardarSub(_Categoria);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                Txt_Nombre.Focus();
            }
        }
        bool Validar()
        {

            if (Txt_Nombre.Text.Trim()!=string.Empty)
            {
                return true;
            }
            return false;
        }

        private void Frm_CategoriasAdd_Load(object sender, EventArgs e)
        {
            Lbl_Nombre.Text = _Ventana;
        }
    }
}
