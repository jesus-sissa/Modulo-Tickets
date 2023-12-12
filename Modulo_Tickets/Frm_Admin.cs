using Bunifu.Framework.UI;
using CustomAlertBoxDemo;
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
using System.Timers;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sideMen.Width == 60)
            {
                sideMen.Visible = true;
                sideMen.Width = 260;
                PanelTransition.ShowSync(sideMen);
                PanelTransition.ShowSync(Pnl_Blocs);
                LogoTransition.ShowSync(Logo);
            }
            else
            {
                LogoTransition.Hide(Logo);
                sideMen.Visible = false;
                sideMen.Width = 60;
                PanelTransition.ShowSync(sideMen);
                PanelTransition.ShowSync(Pnl_Blocs);
            }
        }
        void Reducir()
        {
            if (sideMen.Width != 60)
            {
                LogoTransition.Hide(Logo);
                sideMen.Visible = false;
                sideMen.Width = 60;
                PanelTransition.ShowSync(sideMen);
            }
        }

        public void PanelContenido(Form Formulario)
        {
            if (Formulario == null)
            {
                Pnl_Contenedor.Controls.Clear();
                return;
            }
            Pnl_Contenedor.Controls.Clear();
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Pnl_Contenedor.Controls.Add(Formulario);
            Formulario.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            timer1.Enabled = true;
            ////notifyIcon1.Icon = SystemIcons.Application;
            //notifyIcon1.BalloonTipText = "El modulo se ejecutara en segundo plano";
            //notifyIcon1.ShowBalloonTip(500);
            //this.Hide();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Show();
            if (this.WindowState == FormWindowState.Maximized)
            {

                if (Persistentes.Usuario_Login == 0)
                {
                    Frm_Login frm = new Frm_Login();
                    frm.ShowDialog();//Esperar el resltado en una funcion recursiva
                    if (Persistentes.Usuario_Login==0)
                    {
                        this.WindowState = FormWindowState.Minimized;
                        //notifyIcon1.Icon = SystemIcons.Application;
                        //notifyIcon1.BalloonTipText = "El modulo se ejecutara en segundo plano";
                        //notifyIcon1.ShowBalloonTip(500);
                        this.Hide();
                    }
                    else
                    {
                        Privilegios();
                    }
                }
            }
        }

        public void Mensaje(object source, ElapsedEventArgs e)
        {
            TicketRequest Ticket = new TicketRequest {
            ClaveSucursal=Persistentes.ClaveSucursal
            };
            //TicketRepository.ConsultarTickets_Abiertos(Ticket)
            Form_Alert frm = new Form_Alert();
            frm.showAlert("Hola", Form_Alert.enmType.Info);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TicketRequest Ticket = new TicketRequest
            {                
                ClaveSucursal =Persistentes.ClaveSucursal
            };

            Form_Alert frm = new Form_Alert();
            frm.showAlert("Existen "+TicketRepository.ConsultarTickets_Abiertos(Ticket)+" tickets pendientes.", Form_Alert.enmType.Info);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                Login();            
        }
        void Login()
        {
            //FormSize();
            sideMen.Visible = false;
            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();
            if (Persistentes.Usuario_Login == 0)
            {
                this.Close();
                //this.WindowState = FormWindowState.Minimized;
                ////notifyIcon1.Icon = SystemIcons.Application;
                //notifyIcon1.BalloonTipText = "El modulo se ejecutara en segundo plano";
                //notifyIcon1.ShowBalloonTip(1000);
                //this.Hide();
            }
            else
            {
                Lbl_Nombre.Text +=" "+ Persistentes.Usuario_Login_Nombre;
                Lbl_Nombre.Visible = true;
                //FormSize();
                Privilegios();
                ModoContacto(0);
                //Listar_Departamentos();
                
            }
        }
        BunifuTileButton btn = new Bunifu.Framework.UI.BunifuTileButton();

            void Listar_Departamentos()
            {
            //FormSize();
            Persistentes.Mensaje("A continuacion se presentan los proyectos con los que se esta trabajando.", 1);
            Pnl_Contenedor.Controls.Clear();
            Flow.Controls.Clear();
                Proyectos _Proyectos = new Proyectos();
                foreach (var item in ProyectosRepository.ConsultarProyectosTodos(_Proyectos))
                {
                    Agregar(item.Nombre, item.Porcentaje_Avance,item.Departamento);
                }
            this.Pnl_Contenedor.Controls.Add(this.Flow);
            }
        BunifuCustomLabel Lbl_NombreDepartamento;
        BunifuCustomLabel Lbl_NombreProyecto;
             BunifuProgressBar Progress;
             Panel pnl;
             FlowLayoutPanel Flow=new FlowLayoutPanel();
            void Agregar(string Nombre, int Avance,string Departamento)
            {
            Lbl_NombreDepartamento = new BunifuCustomLabel();
            Lbl_NombreProyecto = new BunifuCustomLabel();
            Progress = new BunifuProgressBar();
            pnl = new Panel();            
            this.Lbl_NombreDepartamento.AutoSize = true;
            this.PanelTransition.SetDecoration(this.Lbl_NombreDepartamento, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Lbl_NombreDepartamento, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_NombreDepartamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_NombreDepartamento.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_NombreDepartamento.ForeColor = System.Drawing.Color.White;
            this.Lbl_NombreDepartamento.Location = new System.Drawing.Point(0, 0);
            //this.Lbl_NombreProyecto.Name = "Lbl_NombreProyecto";
            this.Lbl_NombreDepartamento.Size = new System.Drawing.Size(45, 24);
            this.Lbl_NombreDepartamento.TabIndex = 55;
            this.Lbl_NombreDepartamento.Text = Departamento;



            this.Lbl_NombreProyecto.AutoSize = true;
            this.PanelTransition.SetDecoration(this.Lbl_NombreProyecto, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Lbl_NombreProyecto, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_NombreProyecto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_NombreProyecto.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.Lbl_NombreProyecto.ForeColor = System.Drawing.Color.White;
            this.Lbl_NombreProyecto.Location = new System.Drawing.Point(0, 0);
            //this.Lbl_NombreProyecto.Name = "Lbl_NombreProyecto";
            this.Lbl_NombreProyecto.Size = new System.Drawing.Size(45, 24);
            this.Lbl_NombreProyecto.TabIndex = 55;
            this.Lbl_NombreProyecto.Text = Nombre;

            this.Progress.BackColor = System.Drawing.Color.Silver;
            this.Progress.BorderRadius = 5;
            this.PanelTransition.SetDecoration(this.Progress, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Progress, BunifuAnimatorNS.DecorationType.None);
            this.Progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Progress.Location = new System.Drawing.Point(0, 48);
            this.Progress.MaximumValue = 100;
            //this.Progress.Name = "bunifuProgressBar1";
            this.Progress.ProgressColor = System.Drawing.Color.Teal;
            this.Progress.Size = new System.Drawing.Size(284, 10);
            this.Progress.TabIndex = 54;
            this.Progress.Value = Avance;

            this.pnl.Controls.Add(this.Lbl_NombreProyecto);
            this.pnl.Controls.Add(this.Lbl_NombreDepartamento);
            this.pnl.Controls.Add(this.Progress);
            this.PanelTransition.SetDecoration(this.pnl, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.pnl, BunifuAnimatorNS.DecorationType.None);
            this.pnl.Location = new System.Drawing.Point(3, 3);
           // this.pnl.Name = "panel2";
            this.pnl.Size = new System.Drawing.Size(400, 58);
            this.pnl.TabIndex = 2;


            this.Flow.Controls.Add(this.pnl);
            this.LogoTransition.SetDecoration(this.Flow, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Flow, BunifuAnimatorNS.DecorationType.None);
            this.Flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow.Location = new System.Drawing.Point(0, 0);
            //this.Flow.Name = "flowLayoutPanel1";
            this.Flow.Size = new System.Drawing.Size(1000, 594);
            this.Flow.TabIndex = 0;
            this.Flow.AutoScroll = true;
        }
                    

        void ModoContacto(int Modo)
        {
            DataTable tbl;
            EmpleadosRequest Empleado = new EmpleadosRequest();
            tbl=EmpleadosRepository.ConsultaEmpleados_ModoContacto(Empleado);
            if(tbl.Rows.Count>0)
            {
                if(tbl.Rows[0][0].ToString()=="S/M" || tbl.Rows[0][1].ToString()=="S/E")
                {
                    Persistentes.Mensaje("Se necesita actualizar su informacion de contacto.", 5);
                    Frm_ModoContacto frm = new Frm_ModoContacto();
                    frm.Txt_Nombre.Text = Persistentes.Usuario_Login_Nombre;
                    frm.Txt_Mail.Text = tbl.Rows[0][0].ToString();
                    frm.Txt_Extension.Text = tbl.Rows[0][1].ToString();
                    frm.ShowDialog();
                }
                else if (Modo==2)
                {
                    Frm_ModoContacto frm = new Frm_ModoContacto();
                    frm.Txt_Nombre.Text = Persistentes.Usuario_Login_Nombre;
                    frm.Txt_Mail.Text = tbl.Rows[0][0].ToString();
                    frm.Txt_Extension.Text = tbl.Rows[0][1].ToString();
                    frm.ShowDialog();
                }
            }
        }
        void FormSize()
        {
            if (sideMen.Width == 60)
            {
                sideMen.Visible = true;
                sideMen.Width = 260;
                PanelTransition.ShowSync(sideMen);
                PanelTransition.ShowSync(Pnl_Blocs);
                LogoTransition.ShowSync(Logo);
            }
            else
            {
                LogoTransition.Hide(Logo);
                sideMen.Visible = false;
                sideMen.Width = 60;
                PanelTransition.ShowSync(sideMen);
                PanelTransition.ShowSync(Pnl_Blocs);
            }
        }
        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            //Persistentes.Usuario_Login = 0;
            //Application.Restart();
            Application.Exit();
        }
        void Privilegios()
        {
            LoginRequest Login = new LoginRequest();
            DataTable tbl = LoginRepository.Obtener_Privilegios(Login);
            foreach (DataRow Row in tbl.Rows)
            {
                foreach (Control c in Pnl_Blocs.Controls)
                {
                    if (c is BunifuFlatButton && Row["Descripcion"].ToString()==c.Tag.ToString())
                    {
                        c.Visible = true;
                        break;
                    }
                }
            }
            sideMen.Visible = true;
        }
        private void Btn_Tickets_Click(object sender, EventArgs e)
        {
            //Reducir();
            FrmTickets frm = new FrmTickets();
            PanelContenido(frm);
        }

        private void Btn_Rubros_Click(object sender, EventArgs e)
        {
            //Reducir();
            Frm_Rubros frm = new Frm_Rubros();
            PanelContenido(frm);
        }

        private void Btn_Staff_Click(object sender, EventArgs e)
        {
            Frm_AdminGeneral Admin = new Frm_AdminGeneral();
            PanelContenido(Admin);
            //Esta parte pasa a ser por permisos.
            //if (Persistentes.Controles("GENERAL"))
            //{
            //    Frm_AdminGeneral Admin = new Frm_AdminGeneral();
            //    PanelContenido(Admin);
            //}
            //else
            //{
            //    // Reducir();
            //    Frm_Staff frm = new Frm_Staff();
            //    PanelContenido(frm);
            //}

        }
        //bool Controles(string Control)
        //{
        //    foreach(DataRow Row in Persistentes.Datatable_Permisos.Rows)
        //    {
        //        if (Row[1].ToString() == Control)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //    //if (Persistentes.CadenaPermisosControles.IndexOf(Control) != -1)
        //    //{
              
        //    //    return true;
        //    //}
        //    //else
        //    //    return false;
        //}
        private void Btn_Soporte_Click(object sender, EventArgs e)
        {
            //Reducir();
            Soporte frm = new Soporte();
            PanelContenido(frm);
        }

        private void Btn_Proyectos_Click(object sender, EventArgs e)
        {
            Persistentes.Id_DepartamentoSeleccionado = 0;
           // Reducir();
            Frm_Departamentos frm = new Frm_Departamentos(true);
            PanelContenido(frm);
        }

        private void Btn_Seguimiento_Click(object sender, EventArgs e)
        {

           // Reducir();
            Frm_Seguimiento frm = new Frm_Seguimiento();
            PanelContenido(frm);
        }

        private void Btn_Reportes_Click(object sender, EventArgs e)
        {
            //Reducir();
            Frm_Reportes frm = new Frm_Reportes();
            PanelContenido(frm);
            //Frm_TipoReporte frm = new Frm_TipoReporte();
            //frm.ShowDialog();
        }

        private void Lbl_Nombre_DoubleClick(object sender, EventArgs e)
        {
            ModoContacto(2);
        }

        private void Lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

                Listar_Departamentos();
                         
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TicketRequest Ticket = new TicketRequest
            {
               Id_Rubro = Persistentes.Id_Rubro
            };

            Form_Alert frm = new Form_Alert();
            frm.showAlert("Existen " + TicketRepository.ConsultarTickets_Abiertos(Ticket) + " tickets pendientes.", Form_Alert.enmType.Info);
        }

        private void Pnl_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Tareas_Click(object sender, EventArgs e)
        {
            Frm_AdminTareas frm = new Frm_AdminTareas();
            PanelContenido(frm);
            // frm.ShowDialog();
        }
    }
}
