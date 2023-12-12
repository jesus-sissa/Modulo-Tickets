using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_Login : Form
    {
        int ClickCount = 0;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Txt_Usuario_Leave(object sender, EventArgs e)
        {
            if(Txt_Usuario.Text==string.Empty)
            {
                Txt_Usuario.Text = "CLAVE";
                Txt_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void Txt_Usuario_Enter(object sender, EventArgs e)
        {
            if(Txt_Usuario.Text== "CLAVE")
            {
                Txt_Usuario.Text = string.Empty;
                Txt_Usuario.ForeColor = Color.Black;
                
            }
        }

        private void Txt_Password_Leave(object sender, EventArgs e)
        {
            if (Txt_Password.Text == string.Empty)
            {
                Txt_Password.Text = "PASSWORD";
                Txt_Password.ForeColor = Color.DimGray;
                Txt_Password.UseSystemPasswordChar = false;
            }
        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            if (Txt_Password.Text == "PASSWORD")
            {
                Txt_Password.Text = string.Empty;
                Txt_Password.ForeColor = Color.Black;
                Txt_Password.UseSystemPasswordChar = true;
                //Txt_Usuario.PasswordChar =Convert.ToChar( "*");
                //Txt_Usuario.Refresh();
            }
        }

        private void Pic_Close_Click(object sender, EventArgs e)
        {            
            this.Close();
            //this.WindowState = FormWindowState.Minimized;
            //notifyIcon1.Icon = SystemIcons.Application;
            //notifyIcon1.BalloonTipText = "El modulo se ejecutara en segundo plano";
            //notifyIcon1.ShowBalloonTip(1000);
            //this.Hide();
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //e.Handled = !char.IsNumber(e.KeyChar) & !char.IsControl(e.KeyChar);
           // e.Handled = !char.IsNumber(e.KeyChar) ;
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (e.KeyChar == 13)
            {
                if (Validar())
                {
                    this.Close();
                }
                else
                {

                    Txt_Password.Focus();
                }
                //  e.Handled = char.IsControl(e.KeyChar);
            }
        }

        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                if (Validar())
                {
                    this.Close();
                }
                else
                {
                   
                    Txt_Password.Focus();
                }
                //  e.Handled = char.IsControl(e.KeyChar);
            }
            else if(Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = char.IsWhiteSpace(e.KeyChar);
            }
            
        }

        private void Chk_Mty_OnChange(object sender, EventArgs e)
        {
            if (Chk_Mty.Checked && Chk_Sal.Checked)
            {
                Chk_Sal.Checked = false;
            }
            else if(!Chk_Mty.Checked &&!Chk_Sal.Checked)
            {
                Chk_Mty.Checked = true;
            }
        }

        private void Chk_Sal_OnChange(object sender, EventArgs e)
        {
            if (Chk_Sal.Checked && Chk_Mty.Checked)
            {
                Chk_Mty.Checked = false;
            }
            else if (!Chk_Mty.Checked && !Chk_Sal.Checked)
            {
                Chk_Sal.Checked = true;
            }
        }
        public bool Validar()
        {
            if (Chk_Mty.Checked)
            {
                Persistentes.ClaveSucursal = "01";//01 MTY
                Persistentes.Nombre_Sucursal = "MONTERREY";
            }
            else
            {
                Persistentes.ClaveSucursal = "02";
                Persistentes.Nombre_Sucursal = "SALTILLO";
            }
            if (Txt_Usuario.Text.Trim()!=string.Empty /*&& Txt_Password.Text.Trim()!=string.Empty*/)
            {
                if (Txt_Usuario.Text.Trim().All(char.IsDigit))
                {
                    //string Contra = Txt_Password.Text.Trim();
                    DataTable DT = LoginRepository.Usuarios_Read(LoginRepository.Usuarios_ClaveEmpleado(Txt_Usuario.Text, Persistentes.ClaveSucursal), Persistentes.ClaveSucursal);
                    if (DT.Rows.Count == 0)
                    {
                        Persistentes.Mensaje("No se encontro el usuario con clave :"+ Txt_Usuario.Text.Trim(), 2);
                        return false;
                    }
                    //if (DT.Rows[0]["Password"].ToString() != FormsAuthentication.HashPasswordForStoringInConfigFile(Txt_Password.Text.Trim(), "SHA1"))
                    //{
                    //    //Contraseña incorrecta
                    //    Persistentes.Mensaje("Contraseña incorrecta.", 2);
                    //    return false;
                    //}
                    //if (DT.Rows[0]["Status"].ToString() != "A")
                    //{
                    //    //Usuario Bloqueado
                    //    return false;
                    //}
                    BaseRequest baseRequest = new BaseRequest();
                    FormatosRepository.Actualizar_lista_Vacaciones(baseRequest); //Actualizacion de la tabla que se usa para vacaciones 
                    Persistentes.Usuario_Login = Convert.ToInt32(DT.Rows[0]["Id_Empleado"].ToString());
                    Persistentes.Usuario_Login_Nombre = DT.Rows[0]["Nombre"].ToString();
                    Persistentes.UsuarioLogin_IdDepartamento = Convert.ToInt32(DT.Rows[0]["Id_Departamento"].ToString());
                    Persistentes.Usuario_LoginCorreo= DT.Rows[0]["Mail"].ToString();
                    Persistentes.Id_Rubro = Convert.ToInt32(DT.Rows[0]["Id_Rubro"].ToString());
                    Persistentes.usuarioLogin_Firma = (byte[])DT.Rows[0]["Firma"];
                    //Persistentes.Id_Departamento = Convert.ToInt32(DT.Rows[0]["Id_Departamento"].ToString());
                    LoginRequest Login = new LoginRequest();
                    Persistentes.Datatable_Permisos = LoginRepository.PermisosControles_Read(Login);
                    //foreach (DataRow Row in LoginRepository.PermisosControles_Read(Login).Rows)
                    //{
                    //    if(Persistentes.CadenaPermisosControles==string.Empty)
                    //    {
                    //        Persistentes.CadenaPermisosControles = Row["Descripcion"].ToString();
                    //    }
                    //    else
                    //    {
                    //        Persistentes.CadenaPermisosControles = Persistentes.CadenaPermisosControles+","+ Row["Descripcion"].ToString();
                    //    }
                    //}
                    return true;
                }
                else { return false; }
            }            
            else
            {
                return false;
            }             
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           if( Validar())
            {
                this.Close();
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            //Txt_Usuario.Text = "5106";
            //Txt_Password.Text = "1230";
            Version myVersion;
            string ModuloNombre = "Modulo Tickets";
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;

                Lbl_Version.Text = ModuloNombre + string.Format("{0}", myVersion);
            }
            else
            {
                Lbl_Version.Text = ModuloNombre + "1.0.0.0";
            }
            Pic_Close.Focus();
          
            //if (Properties.Settings.Default.Cnx != "")
            //{
            //    MessageBox.Show("Developer");
            //}
            //else
            //{
            //    MessageBox.Show("No developer");
            //}
            ////appSettings["User"] = Txt_User.Text;
            ////appSettings["Password"] = Txt_Password.Text;
            ////appSettings["Cnx"] = "Data Source=" + "
        }

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Persistentes.Usuario_Login = 0;
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Frm_Login.ModifierKeys == Keys.Alt || Frm_Login.ModifierKeys == Keys.F4)
            {
                e.Cancel = true;
            }

        }

        private void Lbl_Version_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            //If e.Control And e.Alt And e.KeyCode = Keys.S Then
            if(e.Control && e.Alt && e.KeyCode==Keys.D)
            {
                Frm_DeveloperSettings frm_dev = new Frm_DeveloperSettings();
                frm_dev.ShowDialog();
            }            
        }

        private void Txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
