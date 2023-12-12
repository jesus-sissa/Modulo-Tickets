
namespace Modulo_Tickets
{
    partial class Frm_SoporteD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SoporteD));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_Solicitud = new System.Windows.Forms.GroupBox();
            this.Btn_Upload = new System.Windows.Forms.PictureBox();
            this.Btn_Dowload = new System.Windows.Forms.PictureBox();
            this.lbl_nom_doc_solicitud = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_numero_solicitud = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_NumeroTicket = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_Ticket = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Btn_Imagenes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Avances = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Avance = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Txt_Descripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_CerrarP = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_AbrirP = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Salir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_RecibirTicket = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Agregar_Solicitud_Cambio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Regresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_CerrarTicket = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Enviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.gb_Solicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Upload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Dowload)).BeginInit();
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
            this.panel1.Controls.Add(this.gb_Solicitud);
            this.panel1.Controls.Add(this.Btn_Imagenes);
            this.panel1.Controls.Add(this.Btn_Avances);
            this.panel1.Controls.Add(this.Btn_Avance);
            this.panel1.Controls.Add(this.Txt_Descripcion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 376);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gb_Solicitud
            // 
            this.gb_Solicitud.Controls.Add(this.Btn_Upload);
            this.gb_Solicitud.Controls.Add(this.Btn_Dowload);
            this.gb_Solicitud.Controls.Add(this.lbl_nom_doc_solicitud);
            this.gb_Solicitud.Controls.Add(this.lbl_numero_solicitud);
            this.gb_Solicitud.Controls.Add(this.Lbl_NumeroTicket);
            this.gb_Solicitud.Controls.Add(this.Lbl_Ticket);
            this.gb_Solicitud.Enabled = false;
            this.gb_Solicitud.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.gb_Solicitud.Location = new System.Drawing.Point(20, 9);
            this.gb_Solicitud.Name = "gb_Solicitud";
            this.gb_Solicitud.Size = new System.Drawing.Size(768, 61);
            this.gb_Solicitud.TabIndex = 47;
            this.gb_Solicitud.TabStop = false;
            this.gb_Solicitud.Text = "General";
            this.gb_Solicitud.Enter += new System.EventHandler(this.gb_Solicitud_Enter);
            // 
            // Btn_Upload
            // 
            this.Btn_Upload.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Upload.Image")));
            this.Btn_Upload.Location = new System.Drawing.Point(656, 22);
            this.Btn_Upload.Name = "Btn_Upload";
            this.Btn_Upload.Size = new System.Drawing.Size(52, 34);
            this.Btn_Upload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Upload.TabIndex = 51;
            this.Btn_Upload.TabStop = false;
            this.Btn_Upload.Click += new System.EventHandler(this.Btn_Upload_Click);
            this.Btn_Upload.MouseHover += new System.EventHandler(this.Btn_Upload_MouseHover);
            // 
            // Btn_Dowload
            // 
            this.Btn_Dowload.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Dowload.Image")));
            this.Btn_Dowload.Location = new System.Drawing.Point(714, 22);
            this.Btn_Dowload.Name = "Btn_Dowload";
            this.Btn_Dowload.Size = new System.Drawing.Size(48, 34);
            this.Btn_Dowload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Dowload.TabIndex = 50;
            this.Btn_Dowload.TabStop = false;
            this.Btn_Dowload.Click += new System.EventHandler(this.Btn_Dowload_Click);
            this.Btn_Dowload.MouseHover += new System.EventHandler(this.Btn_Dowload_MouseHover);
            // 
            // lbl_nom_doc_solicitud
            // 
            this.lbl_nom_doc_solicitud.AutoSize = true;
            this.lbl_nom_doc_solicitud.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_doc_solicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lbl_nom_doc_solicitud.Location = new System.Drawing.Point(312, 26);
            this.lbl_nom_doc_solicitud.Name = "lbl_nom_doc_solicitud";
            this.lbl_nom_doc_solicitud.Size = new System.Drawing.Size(16, 17);
            this.lbl_nom_doc_solicitud.TabIndex = 44;
            this.lbl_nom_doc_solicitud.Text = "--";
            this.lbl_nom_doc_solicitud.Visible = false;
            // 
            // lbl_numero_solicitud
            // 
            this.lbl_numero_solicitud.AutoSize = true;
            this.lbl_numero_solicitud.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_solicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lbl_numero_solicitud.Location = new System.Drawing.Point(202, 22);
            this.lbl_numero_solicitud.Name = "lbl_numero_solicitud";
            this.lbl_numero_solicitud.Size = new System.Drawing.Size(22, 21);
            this.lbl_numero_solicitud.TabIndex = 43;
            this.lbl_numero_solicitud.Text = "--";
            // 
            // Lbl_NumeroTicket
            // 
            this.Lbl_NumeroTicket.AutoSize = true;
            this.Lbl_NumeroTicket.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_NumeroTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_NumeroTicket.Location = new System.Drawing.Point(96, 22);
            this.Lbl_NumeroTicket.Name = "Lbl_NumeroTicket";
            this.Lbl_NumeroTicket.Size = new System.Drawing.Size(45, 24);
            this.Lbl_NumeroTicket.TabIndex = 50;
            this.Lbl_NumeroTicket.Text = "S/N";
            // 
            // Lbl_Ticket
            // 
            this.Lbl_Ticket.AutoSize = true;
            this.Lbl_Ticket.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Ticket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Ticket.Location = new System.Drawing.Point(13, 22);
            this.Lbl_Ticket.Name = "Lbl_Ticket";
            this.Lbl_Ticket.Size = new System.Drawing.Size(87, 24);
            this.Lbl_Ticket.TabIndex = 42;
            this.Lbl_Ticket.Text = "#Ticket:";
            this.Lbl_Ticket.Click += new System.EventHandler(this.Lbl_Ticket_Click);
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
            this.Btn_Imagenes.ButtonText = "Ver documento";
            this.Btn_Imagenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Imagenes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imagenes.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagenes.IdleBorderThickness = 1;
            this.Btn_Imagenes.IdleCornerRadius = 20;
            this.Btn_Imagenes.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Imagenes.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagenes.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagenes.Location = new System.Drawing.Point(439, 330);
            this.Btn_Imagenes.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Imagenes.Name = "Btn_Imagenes";
            this.Btn_Imagenes.Size = new System.Drawing.Size(196, 41);
            this.Btn_Imagenes.TabIndex = 61;
            this.Btn_Imagenes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Imagenes.Click += new System.EventHandler(this.Btn_Imagenes_Click);
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
            this.Btn_Avances.Location = new System.Drawing.Point(226, 330);
            this.Btn_Avances.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Avances.Name = "Btn_Avances";
            this.Btn_Avances.Size = new System.Drawing.Size(190, 41);
            this.Btn_Avances.TabIndex = 57;
            this.Btn_Avances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Avances.Click += new System.EventHandler(this.Btn_Avances_Click);
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
            this.Btn_Avance.ButtonText = "Nuevo avance";
            this.Btn_Avance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Avance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Avance.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avance.IdleBorderThickness = 1;
            this.Btn_Avance.IdleCornerRadius = 20;
            this.Btn_Avance.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Avance.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Avance.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Avance.Location = new System.Drawing.Point(20, 330);
            this.Btn_Avance.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Avance.Name = "Btn_Avance";
            this.Btn_Avance.Size = new System.Drawing.Size(188, 41);
            this.Btn_Avance.TabIndex = 53;
            this.Btn_Avance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Avance.Click += new System.EventHandler(this.Btn_Avance_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.Txt_Descripcion.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Descripcion.Location = new System.Drawing.Point(20, 75);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.ReadOnly = true;
            this.Txt_Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Descripcion.Size = new System.Drawing.Size(768, 252);
            this.Txt_Descripcion.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_CerrarP);
            this.panel2.Controls.Add(this.Btn_AbrirP);
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.Btn_RecibirTicket);
            this.panel2.Controls.Add(this.btn_Agregar_Solicitud_Cambio);
            this.panel2.Controls.Add(this.Btn_Regresar);
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.Btn_CerrarTicket);
            this.panel2.Controls.Add(this.Btn_Cerrar);
            this.panel2.Controls.Add(this.Btn_Enviar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 505);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Btn_CerrarP
            // 
            this.Btn_CerrarP.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerrarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerrarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_CerrarP.BorderRadius = 0;
            this.Btn_CerrarP.ButtonText = "Cerrar proveedor";
            this.Btn_CerrarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CerrarP.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_CerrarP.Enabled = false;
            this.Btn_CerrarP.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_CerrarP.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_CerrarP.Iconimage")));
            this.Btn_CerrarP.Iconimage_right = null;
            this.Btn_CerrarP.Iconimage_right_Selected = null;
            this.Btn_CerrarP.Iconimage_Selected = null;
            this.Btn_CerrarP.IconMarginLeft = 0;
            this.Btn_CerrarP.IconMarginRight = 0;
            this.Btn_CerrarP.IconRightVisible = true;
            this.Btn_CerrarP.IconRightZoom = 0D;
            this.Btn_CerrarP.IconVisible = true;
            this.Btn_CerrarP.IconZoom = 90D;
            this.Btn_CerrarP.IsTab = true;
            this.Btn_CerrarP.Location = new System.Drawing.Point(445, 445);
            this.Btn_CerrarP.Name = "Btn_CerrarP";
            this.Btn_CerrarP.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerrarP.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_CerrarP.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_CerrarP.selected = false;
            this.Btn_CerrarP.Size = new System.Drawing.Size(167, 48);
            this.Btn_CerrarP.TabIndex = 77;
            this.Btn_CerrarP.Text = "Cerrar proveedor";
            this.Btn_CerrarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CerrarP.Textcolor = System.Drawing.Color.White;
            this.Btn_CerrarP.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CerrarP.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // Btn_AbrirP
            // 
            this.Btn_AbrirP.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_AbrirP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_AbrirP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_AbrirP.BorderRadius = 0;
            this.Btn_AbrirP.ButtonText = "Abrir proveedor";
            this.Btn_AbrirP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AbrirP.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_AbrirP.Enabled = false;
            this.Btn_AbrirP.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_AbrirP.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_AbrirP.Iconimage")));
            this.Btn_AbrirP.Iconimage_right = null;
            this.Btn_AbrirP.Iconimage_right_Selected = null;
            this.Btn_AbrirP.Iconimage_Selected = null;
            this.Btn_AbrirP.IconMarginLeft = 0;
            this.Btn_AbrirP.IconMarginRight = 0;
            this.Btn_AbrirP.IconRightVisible = true;
            this.Btn_AbrirP.IconRightZoom = 0D;
            this.Btn_AbrirP.IconVisible = true;
            this.Btn_AbrirP.IconZoom = 90D;
            this.Btn_AbrirP.IsTab = true;
            this.Btn_AbrirP.Location = new System.Drawing.Point(445, 391);
            this.Btn_AbrirP.Name = "Btn_AbrirP";
            this.Btn_AbrirP.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_AbrirP.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_AbrirP.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_AbrirP.selected = false;
            this.Btn_AbrirP.Size = new System.Drawing.Size(167, 48);
            this.Btn_AbrirP.TabIndex = 77;
            this.Btn_AbrirP.Text = "Abrir proveedor";
            this.Btn_AbrirP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AbrirP.Textcolor = System.Drawing.Color.White;
            this.Btn_AbrirP.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AbrirP.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.BorderRadius = 0;
            this.Btn_Salir.ButtonText = "Salir";
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Salir.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Salir.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Iconimage")));
            this.Btn_Salir.Iconimage_right = null;
            this.Btn_Salir.Iconimage_right_Selected = null;
            this.Btn_Salir.Iconimage_Selected = null;
            this.Btn_Salir.IconMarginLeft = 0;
            this.Btn_Salir.IconMarginRight = 0;
            this.Btn_Salir.IconRightVisible = true;
            this.Btn_Salir.IconRightZoom = 0D;
            this.Btn_Salir.IconVisible = true;
            this.Btn_Salir.IconZoom = 90D;
            this.Btn_Salir.IsTab = true;
            this.Btn_Salir.Location = new System.Drawing.Point(627, 445);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Salir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Salir.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Salir.selected = false;
            this.Btn_Salir.Size = new System.Drawing.Size(167, 48);
            this.Btn_Salir.TabIndex = 44;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.Textcolor = System.Drawing.Color.White;
            this.Btn_Salir.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Resuelto";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(308, 228);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(164, 48);
            this.bunifuFlatButton1.TabIndex = 48;
            this.bunifuFlatButton1.Text = "Resuelto";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_RecibirTicket
            // 
            this.Btn_RecibirTicket.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_RecibirTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_RecibirTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_RecibirTicket.BorderRadius = 0;
            this.Btn_RecibirTicket.ButtonText = "Recibir ";
            this.Btn_RecibirTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RecibirTicket.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_RecibirTicket.Enabled = false;
            this.Btn_RecibirTicket.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_RecibirTicket.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_RecibirTicket.Iconimage")));
            this.Btn_RecibirTicket.Iconimage_right = null;
            this.Btn_RecibirTicket.Iconimage_right_Selected = null;
            this.Btn_RecibirTicket.Iconimage_Selected = null;
            this.Btn_RecibirTicket.IconMarginLeft = 0;
            this.Btn_RecibirTicket.IconMarginRight = 0;
            this.Btn_RecibirTicket.IconRightVisible = true;
            this.Btn_RecibirTicket.IconRightZoom = 0D;
            this.Btn_RecibirTicket.IconVisible = true;
            this.Btn_RecibirTicket.IconZoom = 90D;
            this.Btn_RecibirTicket.IsTab = true;
            this.Btn_RecibirTicket.Location = new System.Drawing.Point(12, 391);
            this.Btn_RecibirTicket.Name = "Btn_RecibirTicket";
            this.Btn_RecibirTicket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_RecibirTicket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_RecibirTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_RecibirTicket.selected = false;
            this.Btn_RecibirTicket.Size = new System.Drawing.Size(190, 48);
            this.Btn_RecibirTicket.TabIndex = 47;
            this.Btn_RecibirTicket.Text = "Recibir ";
            this.Btn_RecibirTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_RecibirTicket.Textcolor = System.Drawing.Color.White;
            this.Btn_RecibirTicket.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RecibirTicket.Click += new System.EventHandler(this.Btn_RecibirTicket_Click);
            // 
            // btn_Agregar_Solicitud_Cambio
            // 
            this.btn_Agregar_Solicitud_Cambio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Agregar_Solicitud_Cambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Agregar_Solicitud_Cambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Agregar_Solicitud_Cambio.BorderRadius = 0;
            this.btn_Agregar_Solicitud_Cambio.ButtonText = "Solicitud de Cambio";
            this.btn_Agregar_Solicitud_Cambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar_Solicitud_Cambio.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Agregar_Solicitud_Cambio.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Agregar_Solicitud_Cambio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar_Solicitud_Cambio.Iconimage")));
            this.btn_Agregar_Solicitud_Cambio.Iconimage_right = null;
            this.btn_Agregar_Solicitud_Cambio.Iconimage_right_Selected = null;
            this.btn_Agregar_Solicitud_Cambio.Iconimage_Selected = null;
            this.btn_Agregar_Solicitud_Cambio.IconMarginLeft = 0;
            this.btn_Agregar_Solicitud_Cambio.IconMarginRight = 0;
            this.btn_Agregar_Solicitud_Cambio.IconRightVisible = true;
            this.btn_Agregar_Solicitud_Cambio.IconRightZoom = 0D;
            this.btn_Agregar_Solicitud_Cambio.IconVisible = true;
            this.btn_Agregar_Solicitud_Cambio.IconZoom = 90D;
            this.btn_Agregar_Solicitud_Cambio.IsTab = true;
            this.btn_Agregar_Solicitud_Cambio.Location = new System.Drawing.Point(226, 445);
            this.btn_Agregar_Solicitud_Cambio.Name = "btn_Agregar_Solicitud_Cambio";
            this.btn_Agregar_Solicitud_Cambio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Agregar_Solicitud_Cambio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Agregar_Solicitud_Cambio.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Agregar_Solicitud_Cambio.selected = false;
            this.btn_Agregar_Solicitud_Cambio.Size = new System.Drawing.Size(190, 48);
            this.btn_Agregar_Solicitud_Cambio.TabIndex = 46;
            this.btn_Agregar_Solicitud_Cambio.Text = "Solicitud de Cambio";
            this.btn_Agregar_Solicitud_Cambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar_Solicitud_Cambio.Textcolor = System.Drawing.Color.White;
            this.btn_Agregar_Solicitud_Cambio.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar_Solicitud_Cambio.Click += new System.EventHandler(this.btn_Agregar_Solicitud_Cambio_Click);
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Regresar.BorderRadius = 0;
            this.Btn_Regresar.ButtonText = "Regresar ";
            this.Btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Regresar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Regresar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Regresar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Iconimage")));
            this.Btn_Regresar.Iconimage_right = null;
            this.Btn_Regresar.Iconimage_right_Selected = null;
            this.Btn_Regresar.Iconimage_Selected = null;
            this.Btn_Regresar.IconMarginLeft = 0;
            this.Btn_Regresar.IconMarginRight = 0;
            this.Btn_Regresar.IconRightVisible = true;
            this.Btn_Regresar.IconRightZoom = 0D;
            this.Btn_Regresar.IconVisible = true;
            this.Btn_Regresar.IconZoom = 90D;
            this.Btn_Regresar.IsTab = true;
            this.Btn_Regresar.Location = new System.Drawing.Point(12, 445);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Regresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Regresar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Regresar.selected = false;
            this.Btn_Regresar.Size = new System.Drawing.Size(190, 48);
            this.Btn_Regresar.TabIndex = 45;
            this.Btn_Regresar.Text = "Regresar ";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Regresar.Textcolor = System.Drawing.Color.White;
            this.Btn_Regresar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Recategorizar";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(627, 391);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(167, 48);
            this.bunifuFlatButton2.TabIndex = 41;
            this.bunifuFlatButton2.Text = "Recategorizar";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // Btn_CerrarTicket
            // 
            this.Btn_CerrarTicket.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerrarTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerrarTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_CerrarTicket.BorderRadius = 0;
            this.Btn_CerrarTicket.ButtonText = "Resuelto";
            this.Btn_CerrarTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CerrarTicket.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_CerrarTicket.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_CerrarTicket.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_CerrarTicket.Iconimage")));
            this.Btn_CerrarTicket.Iconimage_right = null;
            this.Btn_CerrarTicket.Iconimage_right_Selected = null;
            this.Btn_CerrarTicket.Iconimage_Selected = null;
            this.Btn_CerrarTicket.IconMarginLeft = 0;
            this.Btn_CerrarTicket.IconMarginRight = 0;
            this.Btn_CerrarTicket.IconRightVisible = true;
            this.Btn_CerrarTicket.IconRightZoom = 0D;
            this.Btn_CerrarTicket.IconVisible = true;
            this.Btn_CerrarTicket.IconZoom = 90D;
            this.Btn_CerrarTicket.IsTab = true;
            this.Btn_CerrarTicket.Location = new System.Drawing.Point(226, 391);
            this.Btn_CerrarTicket.Name = "Btn_CerrarTicket";
            this.Btn_CerrarTicket.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_CerrarTicket.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_CerrarTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_CerrarTicket.selected = false;
            this.Btn_CerrarTicket.Size = new System.Drawing.Size(190, 48);
            this.Btn_CerrarTicket.TabIndex = 43;
            this.Btn_CerrarTicket.Text = "Resuelto";
            this.Btn_CerrarTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CerrarTicket.Textcolor = System.Drawing.Color.White;
            this.Btn_CerrarTicket.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CerrarTicket.Click += new System.EventHandler(this.Btn_CerrarTicket_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cerrar.BorderRadius = 0;
            this.Btn_Cerrar.ButtonText = "Cerrar";
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(407, 31);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Cerrar.TabIndex = 42;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Textcolor = System.Drawing.Color.White;
            this.Btn_Cerrar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Enviar.BorderRadius = 0;
            this.Btn_Enviar.ButtonText = "Asignar";
            this.Btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Enviar.DisabledColor = System.Drawing.Color.Gray;
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
            this.Btn_Enviar.Location = new System.Drawing.Point(192, 31);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Enviar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Enviar.selected = false;
            this.Btn_Enviar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Enviar.TabIndex = 41;
            this.Btn_Enviar.Text = "Asignar";
            this.Btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Enviar.Textcolor = System.Drawing.Color.White;
            this.Btn_Enviar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Frm_SoporteD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SoporteD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SoporteD";
            this.Load += new System.EventHandler(this.Frm_SoporteD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Solicitud.ResumeLayout(false);
            this.gb_Solicitud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Upload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Dowload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_NumeroTicket;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Descripcion;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_Ticket;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Enviar;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Avance;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Regresar;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Avances;
        private System.Windows.Forms.GroupBox gb_Solicitud;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_nom_doc_solicitud;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl_numero_solicitud;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Agregar_Solicitud_Cambio;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox Btn_Dowload;
        private System.Windows.Forms.PictureBox Btn_Upload;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Imagenes;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_RecibirTicket;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_CerrarTicket;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Salir;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_AbrirP;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_CerrarP;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}