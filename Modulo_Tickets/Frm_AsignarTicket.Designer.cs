
namespace Modulo_Tickets
{
    partial class Frm_AsignarTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AsignarTicket));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Imagenes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_numero_Solicitud = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_text_solicitud = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Btn_Avance = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Avances = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Lbl_NumeroTicket = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_AsignacionN = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_Asignadoa = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_Descripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Lbl_Ticket = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Siguiente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Reasignar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Rechazar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Finalizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_CerraTicket = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Traspaso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Asignar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Imagenes);
            this.panel1.Controls.Add(this.lbl_numero_Solicitud);
            this.panel1.Controls.Add(this.lbl_text_solicitud);
            this.panel1.Controls.Add(this.Btn_Avance);
            this.panel1.Controls.Add(this.Btn_Avances);
            this.panel1.Controls.Add(this.Lbl_NumeroTicket);
            this.panel1.Controls.Add(this.Lbl_AsignacionN);
            this.panel1.Controls.Add(this.Lbl_Asignadoa);
            this.panel1.Controls.Add(this.Txt_Descripcion);
            this.panel1.Controls.Add(this.Lbl_Ticket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 326);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Imagenes
            // 
            this.Btn_Imagenes.ActiveBorderThickness = 1;
            this.Btn_Imagenes.ActiveCornerRadius = 20;
            this.Btn_Imagenes.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagenes.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Imagenes.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagenes.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Imagenes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Imagenes.BackgroundImage")));
            this.Btn_Imagenes.ButtonText = "Ver documentos";
            this.Btn_Imagenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Imagenes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imagenes.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagenes.IdleBorderThickness = 1;
            this.Btn_Imagenes.IdleCornerRadius = 20;
            this.Btn_Imagenes.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Imagenes.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagenes.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagenes.Location = new System.Drawing.Point(466, 280);
            this.Btn_Imagenes.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Imagenes.Name = "Btn_Imagenes";
            this.Btn_Imagenes.Size = new System.Drawing.Size(196, 41);
            this.Btn_Imagenes.TabIndex = 60;
            this.Btn_Imagenes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Imagenes.Click += new System.EventHandler(this.Btn_Imagenes_Click);
            // 
            // lbl_numero_Solicitud
            // 
            this.lbl_numero_Solicitud.AutoSize = true;
            this.lbl_numero_Solicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_Solicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lbl_numero_Solicitud.Location = new System.Drawing.Point(571, 30);
            this.lbl_numero_Solicitud.Name = "lbl_numero_Solicitud";
            this.lbl_numero_Solicitud.Size = new System.Drawing.Size(20, 21);
            this.lbl_numero_Solicitud.TabIndex = 59;
            this.lbl_numero_Solicitud.Text = "--";
            this.lbl_numero_Solicitud.Visible = false;
            // 
            // lbl_text_solicitud
            // 
            this.lbl_text_solicitud.AutoSize = true;
            this.lbl_text_solicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text_solicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lbl_text_solicitud.Location = new System.Drawing.Point(571, 9);
            this.lbl_text_solicitud.Name = "lbl_text_solicitud";
            this.lbl_text_solicitud.Size = new System.Drawing.Size(183, 21);
            this.lbl_text_solicitud.TabIndex = 58;
            this.lbl_text_solicitud.Text = "#Solicitud de Cambio:";
            this.lbl_text_solicitud.Visible = false;
            // 
            // Btn_Avance
            // 
            this.Btn_Avance.ActiveBorderThickness = 1;
            this.Btn_Avance.ActiveCornerRadius = 20;
            this.Btn_Avance.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avance.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Avance.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avance.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Avance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Avance.BackgroundImage")));
            this.Btn_Avance.ButtonText = "Nuevo comentario";
            this.Btn_Avance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Avance.Enabled = false;
            this.Btn_Avance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Avance.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avance.IdleBorderThickness = 1;
            this.Btn_Avance.IdleCornerRadius = 20;
            this.Btn_Avance.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Avance.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Avance.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avance.Location = new System.Drawing.Point(27, 280);
            this.Btn_Avance.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Avance.Name = "Btn_Avance";
            this.Btn_Avance.Size = new System.Drawing.Size(183, 41);
            this.Btn_Avance.TabIndex = 57;
            this.Btn_Avance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Avance.Click += new System.EventHandler(this.Btn_Avance_Click);
            // 
            // Btn_Avances
            // 
            this.Btn_Avances.ActiveBorderThickness = 1;
            this.Btn_Avances.ActiveCornerRadius = 20;
            this.Btn_Avances.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avances.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Avances.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avances.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Avances.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Avances.BackgroundImage")));
            this.Btn_Avances.ButtonText = "Ver historial";
            this.Btn_Avances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Avances.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Avances.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avances.IdleBorderThickness = 1;
            this.Btn_Avances.IdleCornerRadius = 20;
            this.Btn_Avances.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Avances.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Avances.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avances.Location = new System.Drawing.Point(239, 280);
            this.Btn_Avances.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Avances.Name = "Btn_Avances";
            this.Btn_Avances.Size = new System.Drawing.Size(196, 41);
            this.Btn_Avances.TabIndex = 56;
            this.Btn_Avances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Avances.Click += new System.EventHandler(this.Btn_Avances_Click);
            // 
            // Lbl_NumeroTicket
            // 
            this.Lbl_NumeroTicket.AutoSize = true;
            this.Lbl_NumeroTicket.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_NumeroTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_NumeroTicket.Location = new System.Drawing.Point(112, 11);
            this.Lbl_NumeroTicket.Name = "Lbl_NumeroTicket";
            this.Lbl_NumeroTicket.Size = new System.Drawing.Size(45, 24);
            this.Lbl_NumeroTicket.TabIndex = 50;
            this.Lbl_NumeroTicket.Text = "S/N";
            this.Lbl_NumeroTicket.Click += new System.EventHandler(this.Lbl_NumeroTicket_Click);
            // 
            // Lbl_AsignacionN
            // 
            this.Lbl_AsignacionN.AutoSize = true;
            this.Lbl_AsignacionN.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_AsignacionN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_AsignacionN.Location = new System.Drawing.Point(166, 43);
            this.Lbl_AsignacionN.Name = "Lbl_AsignacionN";
            this.Lbl_AsignacionN.Size = new System.Drawing.Size(44, 24);
            this.Lbl_AsignacionN.TabIndex = 49;
            this.Lbl_AsignacionN.Text = "S/A";
            // 
            // Lbl_Asignadoa
            // 
            this.Lbl_Asignadoa.AutoSize = true;
            this.Lbl_Asignadoa.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Asignadoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Asignadoa.Location = new System.Drawing.Point(19, 43);
            this.Lbl_Asignadoa.Name = "Lbl_Asignadoa";
            this.Lbl_Asignadoa.Size = new System.Drawing.Size(130, 24);
            this.Lbl_Asignadoa.TabIndex = 48;
            this.Lbl_Asignadoa.Text = "Asignado a:";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.Txt_Descripcion.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Descripcion.Location = new System.Drawing.Point(23, 70);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.ReadOnly = true;
            this.Txt_Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Descripcion.Size = new System.Drawing.Size(746, 210);
            this.Txt_Descripcion.TabIndex = 43;
            // 
            // Lbl_Ticket
            // 
            this.Lbl_Ticket.AutoSize = true;
            this.Lbl_Ticket.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Ticket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Ticket.Location = new System.Drawing.Point(19, 11);
            this.Lbl_Ticket.Name = "Lbl_Ticket";
            this.Lbl_Ticket.Size = new System.Drawing.Size(87, 24);
            this.Lbl_Ticket.TabIndex = 42;
            this.Lbl_Ticket.Text = "#Ticket:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Siguiente);
            this.panel2.Controls.Add(this.Btn_Reasignar);
            this.panel2.Controls.Add(this.Btn_Rechazar);
            this.panel2.Controls.Add(this.Btn_Finalizar);
            this.panel2.Controls.Add(this.Btn_CerraTicket);
            this.panel2.Controls.Add(this.Btn_Traspaso);
            this.panel2.Controls.Add(this.Btn_Cerrar);
            this.panel2.Controls.Add(this.Btn_Asignar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 124);
            this.panel2.TabIndex = 1;
            // 
            // Btn_Siguiente
            // 
            this.Btn_Siguiente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Siguiente.BorderRadius = 0;
            this.Btn_Siguiente.ButtonText = "Siguiente>";
            this.Btn_Siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Siguiente.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Siguiente.Enabled = false;
            this.Btn_Siguiente.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Siguiente.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Siguiente.Iconimage")));
            this.Btn_Siguiente.Iconimage_right = null;
            this.Btn_Siguiente.Iconimage_right_Selected = null;
            this.Btn_Siguiente.Iconimage_Selected = null;
            this.Btn_Siguiente.IconMarginLeft = 0;
            this.Btn_Siguiente.IconMarginRight = 0;
            this.Btn_Siguiente.IconRightVisible = true;
            this.Btn_Siguiente.IconRightZoom = 0D;
            this.Btn_Siguiente.IconVisible = true;
            this.Btn_Siguiente.IconZoom = 90D;
            this.Btn_Siguiente.IsTab = true;
            this.Btn_Siguiente.Location = new System.Drawing.Point(546, 10);
            this.Btn_Siguiente.Name = "Btn_Siguiente";
            this.Btn_Siguiente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Siguiente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Siguiente.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Siguiente.selected = false;
            this.Btn_Siguiente.Size = new System.Drawing.Size(156, 48);
            this.Btn_Siguiente.TabIndex = 50;
            this.Btn_Siguiente.Text = "Siguiente>";
            this.Btn_Siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Siguiente.Textcolor = System.Drawing.Color.White;
            this.Btn_Siguiente.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Siguiente.Click += new System.EventHandler(this.Btn_Siguiente_Click);
            // 
            // Btn_Reasignar
            // 
            this.Btn_Reasignar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Reasignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Reasignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Reasignar.BorderRadius = 0;
            this.Btn_Reasignar.ButtonText = "Reasignar";
            this.Btn_Reasignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Reasignar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Reasignar.Enabled = false;
            this.Btn_Reasignar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Reasignar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Reasignar.Iconimage")));
            this.Btn_Reasignar.Iconimage_right = null;
            this.Btn_Reasignar.Iconimage_right_Selected = null;
            this.Btn_Reasignar.Iconimage_Selected = null;
            this.Btn_Reasignar.IconMarginLeft = 0;
            this.Btn_Reasignar.IconMarginRight = 0;
            this.Btn_Reasignar.IconRightVisible = true;
            this.Btn_Reasignar.IconRightZoom = 0D;
            this.Btn_Reasignar.IconVisible = true;
            this.Btn_Reasignar.IconZoom = 90D;
            this.Btn_Reasignar.IsTab = true;
            this.Btn_Reasignar.Location = new System.Drawing.Point(200, 10);
            this.Btn_Reasignar.Name = "Btn_Reasignar";
            this.Btn_Reasignar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Reasignar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Reasignar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Reasignar.selected = false;
            this.Btn_Reasignar.Size = new System.Drawing.Size(156, 48);
            this.Btn_Reasignar.TabIndex = 49;
            this.Btn_Reasignar.Text = "Reasignar";
            this.Btn_Reasignar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reasignar.Textcolor = System.Drawing.Color.White;
            this.Btn_Reasignar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reasignar.Click += new System.EventHandler(this.Btn_Reasignar_Click);
            // 
            // Btn_Rechazar
            // 
            this.Btn_Rechazar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Rechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Rechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Rechazar.BorderRadius = 0;
            this.Btn_Rechazar.ButtonText = "Rechazar";
            this.Btn_Rechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Rechazar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Rechazar.Enabled = false;
            this.Btn_Rechazar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Rechazar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Rechazar.Iconimage")));
            this.Btn_Rechazar.Iconimage_right = null;
            this.Btn_Rechazar.Iconimage_right_Selected = null;
            this.Btn_Rechazar.Iconimage_Selected = null;
            this.Btn_Rechazar.IconMarginLeft = 0;
            this.Btn_Rechazar.IconMarginRight = 0;
            this.Btn_Rechazar.IconRightVisible = true;
            this.Btn_Rechazar.IconRightZoom = 0D;
            this.Btn_Rechazar.IconVisible = true;
            this.Btn_Rechazar.IconZoom = 90D;
            this.Btn_Rechazar.IsTab = true;
            this.Btn_Rechazar.Location = new System.Drawing.Point(373, 9);
            this.Btn_Rechazar.Name = "Btn_Rechazar";
            this.Btn_Rechazar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Rechazar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Rechazar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Rechazar.selected = false;
            this.Btn_Rechazar.Size = new System.Drawing.Size(156, 48);
            this.Btn_Rechazar.TabIndex = 48;
            this.Btn_Rechazar.Text = "Rechazar";
            this.Btn_Rechazar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Rechazar.Textcolor = System.Drawing.Color.White;
            this.Btn_Rechazar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rechazar.Click += new System.EventHandler(this.Btn_Rechazar_Click);
            // 
            // Btn_Finalizar
            // 
            this.Btn_Finalizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Finalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Finalizar.BorderRadius = 0;
            this.Btn_Finalizar.ButtonText = "Resuelto";
            this.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Finalizar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Finalizar.Enabled = false;
            this.Btn_Finalizar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Finalizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Finalizar.Iconimage")));
            this.Btn_Finalizar.Iconimage_right = null;
            this.Btn_Finalizar.Iconimage_right_Selected = null;
            this.Btn_Finalizar.Iconimage_Selected = null;
            this.Btn_Finalizar.IconMarginLeft = 0;
            this.Btn_Finalizar.IconMarginRight = 0;
            this.Btn_Finalizar.IconRightVisible = true;
            this.Btn_Finalizar.IconRightZoom = 0D;
            this.Btn_Finalizar.IconVisible = true;
            this.Btn_Finalizar.IconZoom = 90D;
            this.Btn_Finalizar.IsTab = true;
            this.Btn_Finalizar.Location = new System.Drawing.Point(27, 63);
            this.Btn_Finalizar.Name = "Btn_Finalizar";
            this.Btn_Finalizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Finalizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Finalizar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Finalizar.selected = false;
            this.Btn_Finalizar.Size = new System.Drawing.Size(156, 48);
            this.Btn_Finalizar.TabIndex = 47;
            this.Btn_Finalizar.Text = "Resuelto";
            this.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Finalizar.Textcolor = System.Drawing.Color.White;
            this.Btn_Finalizar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Finalizar.Click += new System.EventHandler(this.Btn_Finalizar_Click);
            // 
            // Btn_CerraTicket
            // 
            this.Btn_CerraTicket.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerraTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerraTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_CerraTicket.BorderRadius = 0;
            this.Btn_CerraTicket.ButtonText = "Cerrar";
            this.Btn_CerraTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CerraTicket.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_CerraTicket.Enabled = false;
            this.Btn_CerraTicket.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_CerraTicket.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_CerraTicket.Iconimage")));
            this.Btn_CerraTicket.Iconimage_right = null;
            this.Btn_CerraTicket.Iconimage_right_Selected = null;
            this.Btn_CerraTicket.Iconimage_Selected = null;
            this.Btn_CerraTicket.IconMarginLeft = 0;
            this.Btn_CerraTicket.IconMarginRight = 0;
            this.Btn_CerraTicket.IconRightVisible = true;
            this.Btn_CerraTicket.IconRightZoom = 0D;
            this.Btn_CerraTicket.IconVisible = true;
            this.Btn_CerraTicket.IconZoom = 90D;
            this.Btn_CerraTicket.IsTab = true;
            this.Btn_CerraTicket.Location = new System.Drawing.Point(200, 64);
            this.Btn_CerraTicket.Name = "Btn_CerraTicket";
            this.Btn_CerraTicket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerraTicket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_CerraTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_CerraTicket.selected = false;
            this.Btn_CerraTicket.Size = new System.Drawing.Size(156, 48);
            this.Btn_CerraTicket.TabIndex = 44;
            this.Btn_CerraTicket.Text = "Cerrar";
            this.Btn_CerraTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CerraTicket.Textcolor = System.Drawing.Color.White;
            this.Btn_CerraTicket.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CerraTicket.Click += new System.EventHandler(this.Btn_CerraTicket_Click);
            // 
            // Btn_Traspaso
            // 
            this.Btn_Traspaso.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Traspaso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Traspaso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Traspaso.BorderRadius = 0;
            this.Btn_Traspaso.ButtonText = "Reasignar Rubro";
            this.Btn_Traspaso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Traspaso.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Traspaso.Enabled = false;
            this.Btn_Traspaso.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Traspaso.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Traspaso.Iconimage")));
            this.Btn_Traspaso.Iconimage_right = null;
            this.Btn_Traspaso.Iconimage_right_Selected = null;
            this.Btn_Traspaso.Iconimage_Selected = null;
            this.Btn_Traspaso.IconMarginLeft = 0;
            this.Btn_Traspaso.IconMarginRight = 0;
            this.Btn_Traspaso.IconRightVisible = true;
            this.Btn_Traspaso.IconRightZoom = 0D;
            this.Btn_Traspaso.IconVisible = true;
            this.Btn_Traspaso.IconZoom = 90D;
            this.Btn_Traspaso.IsTab = true;
            this.Btn_Traspaso.Location = new System.Drawing.Point(373, 64);
            this.Btn_Traspaso.Name = "Btn_Traspaso";
            this.Btn_Traspaso.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Traspaso.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Traspaso.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Traspaso.selected = false;
            this.Btn_Traspaso.Size = new System.Drawing.Size(156, 48);
            this.Btn_Traspaso.TabIndex = 43;
            this.Btn_Traspaso.Text = "Reasignar Rubro";
            this.Btn_Traspaso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Traspaso.Textcolor = System.Drawing.Color.White;
            this.Btn_Traspaso.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Traspaso.Click += new System.EventHandler(this.Btn_Atender_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cerrar.BorderRadius = 0;
            this.Btn_Cerrar.ButtonText = "Salir";
            this.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cerrar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Cerrar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Iconimage")));
            this.Btn_Cerrar.Iconimage_right = null;
            this.Btn_Cerrar.Iconimage_right_Selected = null;
            this.Btn_Cerrar.Iconimage_Selected = null;
            this.Btn_Cerrar.IconMarginLeft = 0;
            this.Btn_Cerrar.IconMarginRight = 0;
            this.Btn_Cerrar.IconRightVisible = true;
            this.Btn_Cerrar.IconRightZoom = 0D;
            this.Btn_Cerrar.IconVisible = true;
            this.Btn_Cerrar.IconZoom = 90D;
            this.Btn_Cerrar.IsTab = true;
            this.Btn_Cerrar.Location = new System.Drawing.Point(546, 64);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(156, 48);
            this.Btn_Cerrar.TabIndex = 42;
            this.Btn_Cerrar.Text = "Salir";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Textcolor = System.Drawing.Color.White;
            this.Btn_Cerrar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Asignar
            // 
            this.Btn_Asignar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Asignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Asignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Asignar.BorderRadius = 0;
            this.Btn_Asignar.ButtonText = "Asignar";
            this.Btn_Asignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Asignar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Asignar.Enabled = false;
            this.Btn_Asignar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Asignar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Asignar.Iconimage")));
            this.Btn_Asignar.Iconimage_right = null;
            this.Btn_Asignar.Iconimage_right_Selected = null;
            this.Btn_Asignar.Iconimage_Selected = null;
            this.Btn_Asignar.IconMarginLeft = 0;
            this.Btn_Asignar.IconMarginRight = 0;
            this.Btn_Asignar.IconRightVisible = true;
            this.Btn_Asignar.IconRightZoom = 0D;
            this.Btn_Asignar.IconVisible = true;
            this.Btn_Asignar.IconZoom = 90D;
            this.Btn_Asignar.IsTab = true;
            this.Btn_Asignar.Location = new System.Drawing.Point(27, 9);
            this.Btn_Asignar.Name = "Btn_Asignar";
            this.Btn_Asignar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Asignar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Asignar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Asignar.selected = false;
            this.Btn_Asignar.Size = new System.Drawing.Size(156, 48);
            this.Btn_Asignar.TabIndex = 41;
            this.Btn_Asignar.Text = "Asignar";
            this.Btn_Asignar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Asignar.Textcolor = System.Drawing.Color.White;
            this.Btn_Asignar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Asignar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Frm_AsignarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AsignarTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AsignarTicket";
            this.Load += new System.EventHandler(this.Frm_AsignarTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Descripcion;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_Ticket;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_Asignadoa;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_AsignacionN;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_NumeroTicket;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Avances;
        public Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        public Bunifu.Framework.UI.BunifuFlatButton Btn_Traspaso;
        public Bunifu.Framework.UI.BunifuFlatButton Btn_CerraTicket;
        public Bunifu.Framework.UI.BunifuFlatButton Btn_Rechazar;
        public Bunifu.Framework.UI.BunifuFlatButton Btn_Finalizar;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Avance;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_numero_Solicitud;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_text_solicitud;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Imagenes;
        public Bunifu.Framework.UI.BunifuFlatButton Btn_Reasignar;
        public Bunifu.Framework.UI.BunifuFlatButton Btn_Siguiente;
        public Bunifu.Framework.UI.BunifuFlatButton Btn_Asignar;
    }
}