using Modulo_Tickets.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Tickets
{
    public partial class Frm_DeveloperSettings : Form
    {
        public Frm_DeveloperSettings()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Txt_User.Text.Trim()!="" && Txt_Password.Text.Trim()!="")
            {
                Properties.Settings.Default.User = Txt_User.Text;
                Properties.Settings.Default.Password = Txt_Password.Text;
                Properties.Settings.Default.Cnx = "Data Source=" + "SISSASQL" + ";Initial Catalog=SIAC;"+"User id=" + Properties.Settings.Default.User+ "; pwd="+ Properties.Settings.Default.Password;                
                try
                {
                    SqlConnection connection = new SqlConnection(Properties.Settings.Default.Cnx);
                    connection.Open();

                    if ((connection.State & ConnectionState.Open) > 0)
                    {
                        connection.Close();
                        Properties.Settings.Default.Save();
                        this.Close();
                    }
                    else
                    {
                        Persistentes.Mensaje("Las credenciales no son correctas.", 1);
                    }
                }
                catch (Exception ex)
                {
                    Properties.Settings.Default.User = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Cnx = "";
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.User = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Cnx = "";
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void Frm_DeveloperSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
