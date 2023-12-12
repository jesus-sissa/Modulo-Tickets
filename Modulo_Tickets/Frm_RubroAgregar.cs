using Modulo_Tickets.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_Tickets.Model;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_RubroAgregar : Form
    {
        ConfiguracionRubrosTickesRepository _repo_conf_rubro;
        ConfiguracionRubrosTickets _conf_rubro;
        public Boolean Edit = false;
        public int Id_Rubro = 0;
        bool _IsAdmin;
        int num_documento = 0;
        string numdoc;
        string pro;
        public Frm_RubroAgregar(bool IsAdmin)
        {
            InitializeComponent();
            _IsAdmin = IsAdmin;
        }

        private void Btn_Imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult rs = op.ShowDialog();
            if(rs==DialogResult.OK)
            {
                Pic_Rubros.Image = Image.FromFile(op.FileName);
            }
        }
        RubroRequest Obtener_Info()
        {
            MemoryStream ms = new MemoryStream();
            Pic_Rubros.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            int numDocumento;
            bool esNumero = int.TryParse(bunifuCustomTextbox1.Text.Trim(), out numDocumento);
            if( checkBox1.Checked == false)
            {
                pro = "N";
            }
            else
            {
                pro = "S";
            }
            if (!esNumero)
            {
                Persistentes.Mensaje("El dato ingresado no es numerico por lo tanto se tomara como 0");
            }
            RubroRequest rubro = new RubroRequest
            {
                Nombre = Txt_Nombre.Text.Trim(),
                Img = ms.GetBuffer(),
                Extension = Txt_Extension.Text.Trim(),
                Mail = Txt_Mail.Text.Trim(),
                Id_Departamento=Persistentes.Id_DepartamentoSeleccionado,
                Num_Documento= numDocumento,
                Proveedor = pro // agregador
            };
            return rubro;
        }
        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
           
            if (Validar_Nuevo())
            {
                if (Edit)
                {
                    RubroRepository.EditarRubro(Obtener_Info(),Id_Rubro);
                    _conf_rubro.Id_Rubro = Id_Rubro;
                    _conf_rubro.Tickets = true;
                    if (cb_SolicitudCambio.Checked)
                    {
                        _conf_rubro.SolicitudCambio = true;
                    }
                    else 
                    {
                        _conf_rubro.SolicitudCambio = false;
                    }
                   
                    _repo_conf_rubro.Configuracion_Rubro_Tickets(_conf_rubro);
                    Mensaje("Rubro modificado correctamente.");
                    Nuevo_Rubro();
                }
                else
                {

                    RubroRepository.GuardarRubro(Obtener_Info());
                    Mensaje("Rubro agregado correctamente.");
                    Nuevo_Rubro();
                }
            }
            else
            {
                Mensaje("Todos los campos son requeridos.");
            }
        }
        void Mensaje(String Texto)
        {
            Frm_Mensaje msg = new Frm_Mensaje();
            msg.Txt_Mensaje.Text = Texto;
            msg.ShowDialog();
        }
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Persistentes.Id_DepartamentoSeleccionado = 0;
            this.Close();
        }
        Boolean Validar_Nuevo()
        {
            if (Txt_Nombre.Text.Trim()==string.Empty || Txt_Mail.Text.Trim()==string.Empty || Txt_Mail.Text.Trim()==string.Empty || Pic_Rubros.Image==null)
            {
                return false;
            }
            return true;
        }
        void Nuevo_Rubro()
        {
            Txt_Nombre.Text = string.Empty;
            Txt_Mail.Text = string.Empty;
            Txt_Extension.Text = string.Empty;
            Pic_Rubros.Image = null;
            Persistentes.Id_DepartamentoSeleccionado = 0;
            Txt_Nombre.Focus();
            cb_Tickets.Checked = false;
            cb_SolicitudCambio.Checked = false;
            checkBox1.Checked = false;  // Agregador para proveedor
            bunifuCustomTextbox1.Text = string.Empty;  //agregado para la limitacion de documentos
        }
        void Validar()
        {
            if (!_IsAdmin)
            {
                Btn_Depto.Enabled = false;
                Txt_Extension.Enabled = false;
                Txt_Mail.Enabled = false;
                Txt_Nombre.Enabled = false;
                groupBox1.Enabled = false;
                Pic_Rubros.Enabled = false;
                Btn_Imagen.Enabled = false;
                Btn_Enviar.Enabled = false;
                bunifuCustomTextbox1.Enabled = false;
            }
        }
        private void Frm_RubroAgregar_Load(object sender, EventArgs e)
        {
            Validar();
            _repo_conf_rubro = new ConfiguracionRubrosTickesRepository();
            _conf_rubro = new ConfiguracionRubrosTickets();

            if (Edit)
            {
                RubroRequest RubroRequest = new RubroRequest();
                RubroResponse rubro = RubroRepository.ConsultarRubrosU(RubroRequest,Id_Rubro);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(rubro.Img);
                Txt_Nombre.Text = rubro.Nombre;
                Txt_Mail.Text = rubro.Mail;
                Txt_Extension.Text = rubro.Extension;
                Pic_Rubros.Image = Image.FromStream(ms);
                Persistentes.Id_DepartamentoSeleccionado = rubro.Id_Departamento;
                num_documento = rubro.Num_Documento;
                numdoc = num_documento.ToString();
                bunifuCustomTextbox1.Text = numdoc;// agregado para numerar documentos 
                pro = rubro.Proveedor;
                if (pro == "S")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
                Btn_Enviar.Text = "Editar";
                _conf_rubro = _repo_conf_rubro.Get_ConfiguracionRubro(Id_Rubro);
                if (_conf_rubro.SolicitudCambio)
                {
                    cb_SolicitudCambio.Checked = true;
                }

            }
        }

        private void Btn_Depto_Click(object sender, EventArgs e)
        {
            Frm_Departamentos Dep = new Frm_Departamentos(false);
            Dep.ShowDialog();
            if (Persistentes.Id_DepartamentoSeleccionado != 0 && Persistentes.Nombre_Departamento != string.Empty)
            {
                Txt_Nombre.Text = Persistentes.Nombre_Departamento;
            }
        }

        private void Btn_Categorias_Click(object sender, EventArgs e)
        {
            Frm_Categorias _Cat = new Frm_Categorias(Id_Rubro);
            _Cat.ShowDialog();
        }

        private void Txt_Mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Extension_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cb_SolicitudCambio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_Tickets_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pic_Rubros_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
