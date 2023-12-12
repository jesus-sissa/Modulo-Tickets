using Modulo_Tickets.Model;
using Modulo_Tickets.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Modulo_Tickets.Model.UserRequest;

namespace Modulo_Tickets
{
    public partial class Frm_SoporteD : Form
    {
        int id_ticket = 0;
       public int tipo = 0;
       public string proveedor;
        public string T;
        public string S;
        private bool primerBotonClickeado = false;
        bool IsAdmin;
        public string vSolicitudCambio = null;
        private string nombre_solicitud = null;
        public string Status;
        string comparar;
        DateTime fecha;
        private SolicitudCambio _solicitudCambio;
        private SolicitudCambioRepository _repositorySolicitud;
        public bool Active_SolicitudCambio = false;
        public Frm_SoporteD(bool _IsAdmin)
        {
            InitializeComponent();
            IsAdmin = _IsAdmin;
        }

        private void Frm_SoporteD_Load(object sender, EventArgs e)
        {
            _repositorySolicitud = new SolicitudCambioRepository();
            Lbl_NumeroTicket.Text = Persistentes.Numero_Ticket.ToString();
            gb_Solicitud.Visible = true;
            //if (Persistentes.Id_UsuarioA == 0)
            //    Btn_Regresar.Visible = false;
            if (IsAdmin)
            {

                Btn_Regresar.Visible = !IsAdmin;
            }
            else
            {

                Btn_Regresar.Visible = !IsAdmin;
            }
            if (proveedor == "S" && S == "NO" && T == "NO")
            {
                Btn_AbrirP.Enabled = true;
            }
            else if ( proveedor=="S" && T=="OK")
            {
                Btn_CerrarP.Enabled = true;
            }
            if (Btn_CerrarP.Enabled == true)
            {
                Btn_CerrarTicket.Enabled = false;
            }
            if(Status == "RESUELTO")
            {
                btn_Agregar_Solicitud_Cambio.Visible = false;
                Btn_CerrarTicket.Enabled = false;
                Btn_Regresar.Enabled = false;
                Btn_AbrirP.Enabled = false;
                Btn_CerrarTicket.Enabled = false;
            }
            if(Persistentes.Controles("RECATEGORIZAR"))
            {
                bunifuFlatButton2.Enabled = true;
                bunifuFlatButton2.Visible = true;
            }
            else
            {
                bunifuFlatButton2.Enabled = false;
                bunifuFlatButton2.Visible = false;
            }
            if (!Active_SolicitudCambio)
            {
                btn_Agregar_Solicitud_Cambio.Visible = false;
                //gb_Solicitud.Visible = false;  
            }
            if (Status=="ASIGNADO")
            {
                Btn_RecibirTicket.Enabled = true;
                Btn_CerrarTicket.Enabled = false;
            }
            ActualizarDatosSolicitud();
        }
        //bool Controles(string Control)
        //{

        //    if (Persistentes.CadenaPermisosControles.IndexOf(Control) != -1)
        //    {

        //        return true;
        //    }
        //    else
        //        return false;
        //}
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Avance_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Persistentes.Tipo_tree = 1;
            Frm_Comentarios frm = new Frm_Comentarios(1, IsAdmin);
            frm.Size = new Size(806, 505);
            DialogResult dr=frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //this.Show();
        }
        void Mensaje(String Texto, int Time = 2)
        {
            Frm_Mensaje msg = new Frm_Mensaje();
            msg.Txt_Mensaje.Text = Texto;
            msg.time = Time;
            msg.ShowDialog();
        }

        private void Chk_Sprint_OnChange(object sender, EventArgs e)
        {
           
        }

        //VER HISTORIAL 
        //private void bunifuThinButton21_Click(object sender, EventArgs e)
        //{
        //    Frm_TreeView frm = new Frm_TreeView();
        //    frm.ShowDialog();
        //}

        private void Btn_CerrarTicket_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Persistentes.Tipo_tree = 1;
            Frm_Comentarios frm = new Frm_Comentarios(2,IsAdmin);
            frm.Size = new Size(806, 505);
            DialogResult dr=frm.ShowDialog();
            if (dr==DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //this.Show();
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Persistentes.Tipo_tree = 1;
            Frm_Comentarios frm = new Frm_Comentarios(4, IsAdmin);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
           // this.Show();
        }

        private void Btn_Rechazar_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 1;
            Frm_Comentarios frm = new Frm_Comentarios(3, IsAdmin);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.DialogResult=DialogResult.OK;
                this.Close();
            }
        }

        private void Btn_Avances_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Persistentes.Tipo_tree = 1;
            Persistentes.Numero_Ticket = Convert.ToInt32(Lbl_NumeroTicket.Text);
            Frm_TreeView frm = new Frm_TreeView();
            frm.Size = new Size(806, 505);
            frm.ShowDialog();
            //this.Show();
        }

        private void btn_Agregar_Documento_Solicitud_Click(object sender, EventArgs e)
        {
            

           
        }

        private void btn_Descargar_Documento_Solicitud_Click(object sender, EventArgs e)
        {
            
        }

        public void ActualizarDatosSolicitud()
        {
            if (vSolicitudCambio != null && vSolicitudCambio != "" && Active_SolicitudCambio)
            {
                btn_Agregar_Solicitud_Cambio.Enabled = false;
                gb_Solicitud.Enabled = true;

                _solicitudCambio = _repositorySolicitud.Get_Solicitud(vSolicitudCambio);
                if (_solicitudCambio != null)
                {
                    nombre_solicitud = "Documento:" + _solicitudCambio.Nombre_Doc_Solicitud;
                }
                if (_solicitudCambio.Doc_Solicitud != null)
                {

                    Btn_Dowload.Enabled = true;
                }
            }
            else {
                btn_Agregar_Solicitud_Cambio.Enabled = true;
            }


            if (vSolicitudCambio != null && vSolicitudCambio != "")
            {
                lbl_numero_solicitud.Text ="#"+ vSolicitudCambio;
            }
            if (nombre_solicitud != null)
            {
                lbl_nom_doc_solicitud.Text = nombre_solicitud;
            }
            else
            {
                lbl_nom_doc_solicitud.Text = "Documento:--";
            }
           

        }

        private void btn_Agregar_Solicitud_Cambio_Click(object sender, EventArgs e)
        {
            if(Status == "RESUELTO")
            {
                Persistentes.Mensaje("No es posible esta accion");
            }
            else
            {
                if (_repositorySolicitud.Agregar_solicitud(Persistentes.Numero_Ticket))
                {
                    vSolicitudCambio = _repositorySolicitud.Get_Id_SolicitudCambio(Persistentes.Numero_Ticket);
                    ActualizarDatosSolicitud();
                }
            }
        }

        private void Btn_Dowload_Click(object sender, EventArgs e)
        {
            string pathDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folder = pathDirectory + "temp/";
            string fullfilepath = folder + "/" + _solicitudCambio.Nombre_Doc_Solicitud;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            _solicitudCambio.Doc_Solicitud = _repositorySolicitud.Actualizar_Doc_Solicitud(_solicitudCambio).Doc_Solicitud;

            if (!File.Exists(fullfilepath))
            {
                using (FileStream st = new FileStream(fullfilepath, FileMode.Create))
                {
                    st.Write(_solicitudCambio.Doc_Solicitud, 0, _solicitudCambio.Doc_Solicitud.Length);
                    st.Close();
                }
                //File.WriteAllBytes(fullfilepath, _solicitudCambio.Doc_Solicitud);
            }
            else
            {
                File.WriteAllBytes(fullfilepath, _solicitudCambio.Doc_Solicitud);
            }

            Process.Start(fullfilepath);
        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            string path_doc_solicitud = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path_doc_solicitud = openFileDialog.FileName;

                byte[] file = null;
                Stream st = openFileDialog.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    st.CopyTo(ms);
                    file = ms.ToArray();
                }
                var extension = Path.GetExtension(path_doc_solicitud);

                if (_repositorySolicitud.Agregar_Documento_Solicitud(_solicitudCambio.Id_Solicitud, "FO-SGI-25-SC(" + vSolicitudCambio + ")" + extension, file))
                {
                    if (!Btn_Dowload.Enabled)
                    {
                        Btn_Dowload.Enabled = true;
                    }
                    ActualizarDatosSolicitud();
                    Persistentes.Mensaje("Archivo guardado correctamente!");
                    CorreoResponse Seguimiento;
                    TicketRequest Ticket = new TicketRequest
                    {
                        Id_Ticket = _solicitudCambio.Id_Ticket
                    };
                    try
                    {
                        Seguimiento = TicketRepository.Mail_Seguimiento(Ticket);

                        Correo.Main_ActualizacionDocumentoSolicitud(Seguimiento, _solicitudCambio);
                    }
                    catch (Exception ex)
                    {
                        Persistentes.Mensaje("No se puedo enviar el correo.");
                    }
                }
            }
        }

        private void Btn_Upload_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(Btn_Upload,"Subir documento.");
        }

        private void Btn_Dowload_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(Btn_Dowload, "Descargar documento.");
        }

        private void Btn_Imagenes_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 1;
            Frm_Imagenes frm = new Frm_Imagenes(Persistentes.Numero_Ticket,0);
            frm.Size = new Size(806, 505);
            frm.ShowDialog();
        }

        private void gb_Solicitud_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_RecibirTicket_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Persistentes.Tipo_tree = 1;
            Frm_Comentarios frm = new Frm_Comentarios(5, IsAdmin);
            frm.Size = new Size(806, 505);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 1;
            Frm_Comentarios frm = new Frm_Comentarios(7, IsAdmin);
            frm.Size = new Size(806, 505);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                id_ticket = Persistentes.Numero_Ticket;
                ReporteRepository.GuardarFechas(new FechasRequest { Id_Ticket = id_ticket, Tipo = 1 });
                Btn_AbrirP.Enabled = false;
                Btn_CerrarP.Enabled = true;
                primerBotonClickeado = true;
                Persistentes.Mensaje("Se abrio el tiempo de proveedor");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //if (tipo == 3 && proveedor == "S")
            //{
            //    if (!primerBotonClickeado)
            //    {
            //        id_ticket = Persistentes.Numero_Ticket;
            //        ReporteRepository.GuardarFechas(new FechasRequest { Id_Ticket = id_ticket, Tipo = 1 });
            //        Btn_AbrirP.Enabled = false;
            //        Btn_CerrarP.Enabled = true;
            //        primerBotonClickeado = true;
            //        Persistentes.Mensaje("Se abrio el tiempo de proveedor");
            //        this.Close();
            //    }
            //}
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Persistentes.Tipo_tree = 1;
            Frm_Comentarios frm = new Frm_Comentarios(8, IsAdmin);
            frm.Size = new Size(806, 505);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                id_ticket = Persistentes.Numero_Ticket;
                ReporteRepository.GuardarFechas_Fin(new FechasRequest { Id_Ticket = id_ticket, Tipo = 3 });
                Btn_CerrarP.Enabled = false;
                primerBotonClickeado = false;
                Persistentes.Mensaje("Se cerro el tiempo de proveedor");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //if (tipo == 1 && proveedor == "S")
            //{
            //    id_ticket = Persistentes.Numero_Ticket;
            //    ReporteRepository.GuardarFechas_Fin(new FechasRequest { Id_Ticket = id_ticket,Tipo=3 });
            //    Btn_CerrarP.Enabled = false;
            //    primerBotonClickeado = false;
            //    Persistentes.Mensaje("Se cerro el tiempo de proveedor");
            //    this.Close();
            //}
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Frm_TicketCategoria _frm = new Frm_TicketCategoria(Persistentes.Id_Rubro);
            DialogResult dr = _frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //Listar_Rubros();
            }
            else
            {
                // this.Close();
            }
        }

        private void Lbl_Ticket_Click(object sender, EventArgs e)
        {

        }
    }
}
