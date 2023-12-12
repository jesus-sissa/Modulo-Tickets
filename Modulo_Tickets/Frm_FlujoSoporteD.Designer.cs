
namespace Modulo_Tickets
{
    partial class Frm_FlujoSoporteD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FlujoSoporteD));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gb_Solicitud = new System.Windows.Forms.GroupBox();
            this.Lbl_NumeroTicket = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_Ticket = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Imagenes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Avances = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Avance = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Txt_Descripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Rechazado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Aceptado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Salir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Resuelto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Enviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gb_Solicitud.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // gb_Solicitud
            // 
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
            // 
            // Lbl_NumeroTicket
            // 
            this.Lbl_NumeroTicket.AutoSize = true;
            this.Lbl_NumeroTicket.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_NumeroTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_NumeroTicket.Location = new System.Drawing.Point(138, 22);
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
            this.Lbl_Ticket.Size = new System.Drawing.Size(119, 24);
            this.Lbl_Ticket.TabIndex = 42;
            this.Lbl_Ticket.Text = "#Solicitud: ";
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
            this.panel1.Size = new System.Drawing.Size(803, 376);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.Btn_Imagenes.Location = new System.Drawing.Point(462, 330);
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
            this.Btn_Avances.Location = new System.Drawing.Point(242, 330);
            this.Btn_Avances.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Avances.Name = "Btn_Avances";
            this.Btn_Avances.Size = new System.Drawing.Size(190, 41);
            this.Btn_Avances.TabIndex = 57;
            this.Btn_Avances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Avances.Click += new System.EventHandler(this.Btn_Avances_Click_1);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Rechazado);
            this.panel2.Controls.Add(this.Btn_Aceptado);
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.Btn_Resuelto);
            this.panel2.Controls.Add(this.Btn_Cerrar);
            this.panel2.Controls.Add(this.Btn_Enviar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 455);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Btn_Rechazado
            // 
            this.Btn_Rechazado.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Rechazado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Rechazado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Rechazado.BorderRadius = 0;
            this.Btn_Rechazado.ButtonText = "Rechazado";
            this.Btn_Rechazado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Rechazado.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Rechazado.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Rechazado.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Rechazado.Iconimage")));
            this.Btn_Rechazado.Iconimage_right = null;
            this.Btn_Rechazado.Iconimage_right_Selected = null;
            this.Btn_Rechazado.Iconimage_Selected = null;
            this.Btn_Rechazado.IconMarginLeft = 0;
            this.Btn_Rechazado.IconMarginRight = 0;
            this.Btn_Rechazado.IconRightVisible = true;
            this.Btn_Rechazado.IconRightZoom = 0D;
            this.Btn_Rechazado.IconVisible = true;
            this.Btn_Rechazado.IconZoom = 90D;
            this.Btn_Rechazado.IsTab = true;
            this.Btn_Rechazado.Location = new System.Drawing.Point(589, 379);
            this.Btn_Rechazado.Name = "Btn_Rechazado";
            this.Btn_Rechazado.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Rechazado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Rechazado.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Rechazado.selected = false;
            this.Btn_Rechazado.Size = new System.Drawing.Size(171, 51);
            this.Btn_Rechazado.TabIndex = 50;
            this.Btn_Rechazado.Text = "Rechazado";
            this.Btn_Rechazado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Rechazado.Textcolor = System.Drawing.Color.White;
            this.Btn_Rechazado.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rechazado.Visible = false;
            this.Btn_Rechazado.Click += new System.EventHandler(this.Btn_Rechazado_Click);
            // 
            // Btn_Aceptado
            // 
            this.Btn_Aceptado.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Aceptado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Aceptado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Aceptado.BorderRadius = 0;
            this.Btn_Aceptado.ButtonText = "Aprobado";
            this.Btn_Aceptado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Aceptado.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Aceptado.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Aceptado.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Aceptado.Iconimage")));
            this.Btn_Aceptado.Iconimage_right = null;
            this.Btn_Aceptado.Iconimage_right_Selected = null;
            this.Btn_Aceptado.Iconimage_Selected = null;
            this.Btn_Aceptado.IconMarginLeft = 0;
            this.Btn_Aceptado.IconMarginRight = 0;
            this.Btn_Aceptado.IconRightVisible = true;
            this.Btn_Aceptado.IconRightZoom = 0D;
            this.Btn_Aceptado.IconVisible = true;
            this.Btn_Aceptado.IconZoom = 90D;
            this.Btn_Aceptado.IsTab = true;
            this.Btn_Aceptado.Location = new System.Drawing.Point(407, 382);
            this.Btn_Aceptado.Name = "Btn_Aceptado";
            this.Btn_Aceptado.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Aceptado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Aceptado.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Aceptado.selected = false;
            this.Btn_Aceptado.Size = new System.Drawing.Size(164, 48);
            this.Btn_Aceptado.TabIndex = 49;
            this.Btn_Aceptado.Text = "Aprobado";
            this.Btn_Aceptado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aceptado.Textcolor = System.Drawing.Color.White;
            this.Btn_Aceptado.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptado.Visible = false;
            this.Btn_Aceptado.Click += new System.EventHandler(this.Btn_Aceptado_Click);
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
            this.Btn_Salir.Location = new System.Drawing.Point(221, 382);
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
            // Btn_Resuelto
            // 
            this.Btn_Resuelto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Resuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Resuelto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Resuelto.BorderRadius = 0;
            this.Btn_Resuelto.ButtonText = "Resuelto";
            this.Btn_Resuelto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Resuelto.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Resuelto.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Resuelto.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Resuelto.Iconimage")));
            this.Btn_Resuelto.Iconimage_right = null;
            this.Btn_Resuelto.Iconimage_right_Selected = null;
            this.Btn_Resuelto.Iconimage_Selected = null;
            this.Btn_Resuelto.IconMarginLeft = 0;
            this.Btn_Resuelto.IconMarginRight = 0;
            this.Btn_Resuelto.IconRightVisible = true;
            this.Btn_Resuelto.IconRightZoom = 0D;
            this.Btn_Resuelto.IconVisible = true;
            this.Btn_Resuelto.IconZoom = 90D;
            this.Btn_Resuelto.IsTab = true;
            this.Btn_Resuelto.Location = new System.Drawing.Point(20, 382);
            this.Btn_Resuelto.Name = "Btn_Resuelto";
            this.Btn_Resuelto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Resuelto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Resuelto.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Resuelto.selected = false;
            this.Btn_Resuelto.Size = new System.Drawing.Size(188, 48);
            this.Btn_Resuelto.TabIndex = 43;
            this.Btn_Resuelto.Text = "Resuelto";
            this.Btn_Resuelto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Resuelto.Textcolor = System.Drawing.Color.White;
            this.Btn_Resuelto.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Resuelto.Click += new System.EventHandler(this.Btn_Resuelto_Click);
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
            // Frm_FlujoSoporteD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FlujoSoporteD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FlujoSoporteD";
            this.Load += new System.EventHandler(this.Frm_FlujoSoporteD_Load);
            this.gb_Solicitud.ResumeLayout(false);
            this.gb_Solicitud.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Resuelto;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private System.Windows.Forms.GroupBox gb_Solicitud;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_NumeroTicket;
        public Bunifu.Framework.UI.BunifuCustomLabel Lbl_Ticket;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Salir;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Imagenes;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Avances;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Avance;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Enviar;
        private System.Windows.Forms.Panel panel1;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Descripcion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Rechazado;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Aceptado;
    }
}