
namespace Modulo_Tickets
{
    partial class Frm_DetalleTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DetalleTicket));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Lbl_Ticket = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_Descripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Lbl_Status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_numero_solicitud = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gb_Solicitud = new System.Windows.Forms.GroupBox();
            this.Btn_Upload = new System.Windows.Forms.PictureBox();
            this.Btn_Dowload = new System.Windows.Forms.PictureBox();
            this.lbl_nom_doc_solicitud = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tp_descargar = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_Avances = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Enviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Captura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_RegresarTicket = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gb_Solicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Upload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Dowload)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Lbl_Ticket
            // 
            this.Lbl_Ticket.AutoSize = true;
            this.Lbl_Ticket.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Ticket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Ticket.Location = new System.Drawing.Point(95, 26);
            this.Lbl_Ticket.Name = "Lbl_Ticket";
            this.Lbl_Ticket.Size = new System.Drawing.Size(87, 24);
            this.Lbl_Ticket.TabIndex = 25;
            this.Lbl_Ticket.Text = "#Ticket:";
            this.Lbl_Ticket.Click += new System.EventHandler(this.Lbl_Ticket_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(48, 95);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(134, 24);
            this.bunifuCustomLabel2.TabIndex = 26;
            this.bunifuCustomLabel2.Text = "Descripcion:";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.Txt_Descripcion.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Enabled = false;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Descripcion.Location = new System.Drawing.Point(52, 122);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(724, 248);
            this.Txt_Descripcion.TabIndex = 27;
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Status.Location = new System.Drawing.Point(108, 62);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(74, 24);
            this.Lbl_Status.TabIndex = 31;
            this.Lbl_Status.Text = "Status:";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Salir";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(621, 388);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(155, 48);
            this.bunifuFlatButton1.TabIndex = 29;
            this.bunifuFlatButton1.Text = "Salir";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // lbl_numero_solicitud
            // 
            this.lbl_numero_solicitud.AutoSize = true;
            this.lbl_numero_solicitud.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbl_numero_solicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lbl_numero_solicitud.Location = new System.Drawing.Point(17, 27);
            this.lbl_numero_solicitud.Name = "lbl_numero_solicitud";
            this.lbl_numero_solicitud.Size = new System.Drawing.Size(108, 24);
            this.lbl_numero_solicitud.TabIndex = 32;
            this.lbl_numero_solicitud.Text = "#Solicitud";
            // 
            // gb_Solicitud
            // 
            this.gb_Solicitud.Controls.Add(this.Btn_Upload);
            this.gb_Solicitud.Controls.Add(this.Btn_Dowload);
            this.gb_Solicitud.Controls.Add(this.lbl_nom_doc_solicitud);
            this.gb_Solicitud.Controls.Add(this.lbl_numero_solicitud);
            this.gb_Solicitud.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Solicitud.Location = new System.Drawing.Point(356, 12);
            this.gb_Solicitud.Name = "gb_Solicitud";
            this.gb_Solicitud.Size = new System.Drawing.Size(420, 100);
            this.gb_Solicitud.TabIndex = 33;
            this.gb_Solicitud.TabStop = false;
            this.gb_Solicitud.Text = "Solicitud de Cambio";
            this.gb_Solicitud.Visible = false;
            // 
            // Btn_Upload
            // 
            this.Btn_Upload.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Upload.Image")));
            this.Btn_Upload.Location = new System.Drawing.Point(362, 27);
            this.Btn_Upload.Name = "Btn_Upload";
            this.Btn_Upload.Size = new System.Drawing.Size(52, 40);
            this.Btn_Upload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Upload.TabIndex = 37;
            this.Btn_Upload.TabStop = false;
            this.Btn_Upload.Click += new System.EventHandler(this.Btn_Upload_Click);
            this.Btn_Upload.MouseHover += new System.EventHandler(this.Btn_Upload_MouseHover);
            // 
            // Btn_Dowload
            // 
            this.Btn_Dowload.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Dowload.Image")));
            this.Btn_Dowload.Location = new System.Drawing.Point(308, 27);
            this.Btn_Dowload.Name = "Btn_Dowload";
            this.Btn_Dowload.Size = new System.Drawing.Size(48, 40);
            this.Btn_Dowload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Dowload.TabIndex = 36;
            this.Btn_Dowload.TabStop = false;
            this.Btn_Dowload.Click += new System.EventHandler(this.Btn_Dowload_Click);
            this.Btn_Dowload.MouseHover += new System.EventHandler(this.Btn_Dowload_MouseHover);
            this.Btn_Dowload.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Dowload_MouseMove);
            // 
            // lbl_nom_doc_solicitud
            // 
            this.lbl_nom_doc_solicitud.AutoSize = true;
            this.lbl_nom_doc_solicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_doc_solicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lbl_nom_doc_solicitud.Location = new System.Drawing.Point(18, 73);
            this.lbl_nom_doc_solicitud.Name = "lbl_nom_doc_solicitud";
            this.lbl_nom_doc_solicitud.Size = new System.Drawing.Size(144, 21);
            this.lbl_nom_doc_solicitud.TabIndex = 34;
            this.lbl_nom_doc_solicitud.Text = "NomDocSolicitud";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
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
            this.Btn_Avances.Location = new System.Drawing.Point(52, 388);
            this.Btn_Avances.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Avances.Name = "Btn_Avances";
            this.Btn_Avances.Size = new System.Drawing.Size(146, 48);
            this.Btn_Avances.TabIndex = 59;
            this.Btn_Avances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Avances.Click += new System.EventHandler(this.Btn_Avances_Click);
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Enviar.BorderRadius = 0;
            this.Btn_Enviar.ButtonText = "Cerrar";
            this.Btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Enviar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Enviar.Enabled = false;
            this.Btn_Enviar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Enviar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Enviar.Iconimage")));
            this.Btn_Enviar.Iconimage_right = null;
            this.Btn_Enviar.Iconimage_right_Selected = null;
            this.Btn_Enviar.Iconimage_Selected = null;
            this.Btn_Enviar.IconMarginLeft = 0;
            this.Btn_Enviar.IconMarginRight = 0;
            this.Btn_Enviar.IconRightVisible = true;
            this.Btn_Enviar.IconRightZoom = 0D;
            this.Btn_Enviar.IconVisible = true;
            this.Btn_Enviar.IconZoom = 90D;
            this.Btn_Enviar.IsTab = true;
            this.Btn_Enviar.Location = new System.Drawing.Point(419, 388);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Enviar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Enviar.selected = false;
            this.Btn_Enviar.Size = new System.Drawing.Size(167, 48);
            this.Btn_Enviar.TabIndex = 28;
            this.Btn_Enviar.Text = "Cerrar";
            this.Btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Enviar.Textcolor = System.Drawing.Color.White;
            this.Btn_Enviar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // btn_Captura
            // 
            this.btn_Captura.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Captura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Captura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Captura.BorderRadius = 0;
            this.btn_Captura.ButtonText = "Adjuntar archivo";
            this.btn_Captura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Captura.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Captura.Enabled = false;
            this.btn_Captura.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Captura.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Captura.Iconimage")));
            this.btn_Captura.Iconimage_right = null;
            this.btn_Captura.Iconimage_right_Selected = null;
            this.btn_Captura.Iconimage_Selected = null;
            this.btn_Captura.IconMarginLeft = 0;
            this.btn_Captura.IconMarginRight = 0;
            this.btn_Captura.IconRightVisible = true;
            this.btn_Captura.IconRightZoom = 0D;
            this.btn_Captura.IconVisible = true;
            this.btn_Captura.IconZoom = 90D;
            this.btn_Captura.IsTab = true;
            this.btn_Captura.Location = new System.Drawing.Point(226, 388);
            this.btn_Captura.Name = "btn_Captura";
            this.btn_Captura.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Captura.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Captura.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Captura.selected = false;
            this.btn_Captura.Size = new System.Drawing.Size(160, 48);
            this.btn_Captura.TabIndex = 76;
            this.btn_Captura.Text = "Adjuntar archivo";
            this.btn_Captura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Captura.Textcolor = System.Drawing.Color.White;
            this.btn_Captura.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Captura.Visible = false;
            this.btn_Captura.Click += new System.EventHandler(this.btn_Captura_Click);
            // 
            // btn_RegresarTicket
            // 
            this.btn_RegresarTicket.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_RegresarTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_RegresarTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RegresarTicket.BorderRadius = 0;
            this.btn_RegresarTicket.ButtonText = "Regresar ticket ";
            this.btn_RegresarTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegresarTicket.DisabledColor = System.Drawing.Color.Gray;
            this.btn_RegresarTicket.Enabled = false;
            this.btn_RegresarTicket.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_RegresarTicket.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_RegresarTicket.Iconimage")));
            this.btn_RegresarTicket.Iconimage_right = null;
            this.btn_RegresarTicket.Iconimage_right_Selected = null;
            this.btn_RegresarTicket.Iconimage_Selected = null;
            this.btn_RegresarTicket.IconMarginLeft = 0;
            this.btn_RegresarTicket.IconMarginRight = 0;
            this.btn_RegresarTicket.IconRightVisible = true;
            this.btn_RegresarTicket.IconRightZoom = 0D;
            this.btn_RegresarTicket.IconVisible = true;
            this.btn_RegresarTicket.IconZoom = 90D;
            this.btn_RegresarTicket.IsTab = true;
            this.btn_RegresarTicket.Location = new System.Drawing.Point(226, 388);
            this.btn_RegresarTicket.Name = "btn_RegresarTicket";
            this.btn_RegresarTicket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_RegresarTicket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_RegresarTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_RegresarTicket.selected = false;
            this.btn_RegresarTicket.Size = new System.Drawing.Size(160, 48);
            this.btn_RegresarTicket.TabIndex = 77;
            this.btn_RegresarTicket.Text = "Regresar ticket ";
            this.btn_RegresarTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegresarTicket.Textcolor = System.Drawing.Color.White;
            this.btn_RegresarTicket.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegresarTicket.Visible = false;
            this.btn_RegresarTicket.Click += new System.EventHandler(this.btn_RegresarTicket_Click);
            // 
            // Frm_DetalleTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_RegresarTicket);
            this.Controls.Add(this.btn_Captura);
            this.Controls.Add(this.Btn_Avances);
            this.Controls.Add(this.gb_Solicitud);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Lbl_Ticket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DetalleTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DetalleTicket";
            this.Load += new System.EventHandler(this.Frm_DetalleTicket_Load);
            this.gb_Solicitud.ResumeLayout(false);
            this.gb_Solicitud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Upload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Dowload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Descripcion;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_Ticket;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_Status;
        private System.Windows.Forms.GroupBox gb_Solicitud;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_numero_solicitud;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_nom_doc_solicitud;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip tp_descargar;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Avances;
        private System.Windows.Forms.PictureBox Btn_Upload;
        private System.Windows.Forms.PictureBox Btn_Dowload;
        public Bunifu.Framework.UI.BunifuFlatButton Btn_Enviar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Captura;
        private Bunifu.Framework.UI.BunifuFlatButton btn_RegresarTicket;
    }
}