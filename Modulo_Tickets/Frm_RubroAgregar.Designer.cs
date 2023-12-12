
namespace Modulo_Tickets
{
    partial class Frm_RubroAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RubroAgregar));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_Mail = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Txt_Extension = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Txt_Nombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.cb_Tickets = new System.Windows.Forms.CheckBox();
            this.cb_SolicitudCambio = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Btn_Categorias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Depto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Imagen = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Pic_Rubros = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Enviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Rubros)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(68, 105);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(56, 24);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "Mail:";
            // 
            // Txt_Mail
            // 
            this.Txt_Mail.BackColor = System.Drawing.Color.White;
            this.Txt_Mail.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Mail.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Mail.Location = new System.Drawing.Point(72, 132);
            this.Txt_Mail.Multiline = true;
            this.Txt_Mail.Name = "Txt_Mail";
            this.Txt_Mail.Size = new System.Drawing.Size(410, 63);
            this.Txt_Mail.TabIndex = 36;
            this.Txt_Mail.TextChanged += new System.EventHandler(this.Txt_Mail_TextChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(68, 200);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(108, 24);
            this.bunifuCustomLabel3.TabIndex = 37;
            this.bunifuCustomLabel3.Text = "Extension:";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // Txt_Extension
            // 
            this.Txt_Extension.BackColor = System.Drawing.Color.White;
            this.Txt_Extension.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Extension.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Extension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Extension.Location = new System.Drawing.Point(72, 227);
            this.Txt_Extension.Multiline = true;
            this.Txt_Extension.Name = "Txt_Extension";
            this.Txt_Extension.Size = new System.Drawing.Size(410, 31);
            this.Txt_Extension.TabIndex = 37;
            this.Txt_Extension.TextChanged += new System.EventHandler(this.Txt_Extension_TextChanged);
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.AcceptsReturn = true;
            this.Txt_Nombre.BackColor = System.Drawing.Color.White;
            this.Txt_Nombre.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Nombre.Enabled = false;
            this.Txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Nombre.Location = new System.Drawing.Point(72, 71);
            this.Txt_Nombre.Multiline = true;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(410, 31);
            this.Txt_Nombre.TabIndex = 44;
            this.Txt_Nombre.TextChanged += new System.EventHandler(this.Txt_Nombre_TextChanged);
            // 
            // cb_Tickets
            // 
            this.cb_Tickets.AutoSize = true;
            this.cb_Tickets.Checked = true;
            this.cb_Tickets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Tickets.Enabled = false;
            this.cb_Tickets.Location = new System.Drawing.Point(44, 35);
            this.cb_Tickets.Name = "cb_Tickets";
            this.cb_Tickets.Size = new System.Drawing.Size(88, 26);
            this.cb_Tickets.TabIndex = 46;
            this.cb_Tickets.Text = "Tickets";
            this.cb_Tickets.UseVisualStyleBackColor = true;
            this.cb_Tickets.CheckedChanged += new System.EventHandler(this.cb_Tickets_CheckedChanged);
            // 
            // cb_SolicitudCambio
            // 
            this.cb_SolicitudCambio.AutoSize = true;
            this.cb_SolicitudCambio.Location = new System.Drawing.Point(148, 35);
            this.cb_SolicitudCambio.Name = "cb_SolicitudCambio";
            this.cb_SolicitudCambio.Size = new System.Drawing.Size(80, 26);
            this.cb_SolicitudCambio.TabIndex = 47;
            this.cb_SolicitudCambio.Text = "SDCTI";
            this.cb_SolicitudCambio.UseVisualStyleBackColor = true;
            this.cb_SolicitudCambio.CheckedChanged += new System.EventHandler(this.cb_SolicitudCambio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.bunifuCustomTextbox1);
            this.groupBox1.Controls.Add(this.cb_Tickets);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.cb_SolicitudCambio);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(72, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 71);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion de Rubro";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(234, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 26);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "Proveedor";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.LimeGreen;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(513, 26);
            this.bunifuCustomTextbox1.Multiline = true;
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(26, 30);
            this.bunifuCustomTextbox1.TabIndex = 52;
            this.bunifuCustomTextbox1.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(366, 34);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(141, 22);
            this.bunifuCustomLabel1.TabIndex = 51;
            this.bunifuCustomLabel1.Text = "Num archivos:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // Btn_Categorias
            // 
            this.Btn_Categorias.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Categorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Categorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Categorias.BorderRadius = 0;
            this.Btn_Categorias.ButtonText = "Categorias ...";
            this.Btn_Categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Categorias.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Categorias.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Categorias.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Categorias.Iconimage")));
            this.Btn_Categorias.Iconimage_right = null;
            this.Btn_Categorias.Iconimage_right_Selected = null;
            this.Btn_Categorias.Iconimage_Selected = null;
            this.Btn_Categorias.IconMarginLeft = 0;
            this.Btn_Categorias.IconMarginRight = 0;
            this.Btn_Categorias.IconRightVisible = true;
            this.Btn_Categorias.IconRightZoom = 0D;
            this.Btn_Categorias.IconVisible = true;
            this.Btn_Categorias.IconZoom = 90D;
            this.Btn_Categorias.IsTab = true;
            this.Btn_Categorias.Location = new System.Drawing.Point(286, 364);
            this.Btn_Categorias.Name = "Btn_Categorias";
            this.Btn_Categorias.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Categorias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Categorias.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Categorias.selected = false;
            this.Btn_Categorias.Size = new System.Drawing.Size(196, 48);
            this.Btn_Categorias.TabIndex = 49;
            this.Btn_Categorias.Text = "Categorias ...";
            this.Btn_Categorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Categorias.Textcolor = System.Drawing.Color.White;
            this.Btn_Categorias.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Categorias.Click += new System.EventHandler(this.Btn_Categorias_Click);
            // 
            // Btn_Depto
            // 
            this.Btn_Depto.ActiveBorderThickness = 1;
            this.Btn_Depto.ActiveCornerRadius = 20;
            this.Btn_Depto.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_Depto.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Depto.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Depto.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Depto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Depto.BackgroundImage")));
            this.Btn_Depto.ButtonText = "Departamento";
            this.Btn_Depto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Depto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Depto.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Depto.IdleBorderThickness = 1;
            this.Btn_Depto.IdleCornerRadius = 20;
            this.Btn_Depto.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Depto.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Depto.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Depto.Location = new System.Drawing.Point(72, 22);
            this.Btn_Depto.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Depto.Name = "Btn_Depto";
            this.Btn_Depto.Size = new System.Drawing.Size(236, 41);
            this.Btn_Depto.TabIndex = 45;
            this.Btn_Depto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Depto.Click += new System.EventHandler(this.Btn_Depto_Click);
            // 
            // Btn_Imagen
            // 
            this.Btn_Imagen.ActiveBorderThickness = 1;
            this.Btn_Imagen.ActiveCornerRadius = 20;
            this.Btn_Imagen.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagen.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Imagen.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagen.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Imagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Imagen.BackgroundImage")));
            this.Btn_Imagen.ButtonText = "Foto";
            this.Btn_Imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Imagen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imagen.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagen.IdleBorderThickness = 1;
            this.Btn_Imagen.IdleCornerRadius = 20;
            this.Btn_Imagen.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Imagen.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagen.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Imagen.Location = new System.Drawing.Point(512, 217);
            this.Btn_Imagen.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Imagen.Name = "Btn_Imagen";
            this.Btn_Imagen.Size = new System.Drawing.Size(138, 41);
            this.Btn_Imagen.TabIndex = 38;
            this.Btn_Imagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Imagen.Click += new System.EventHandler(this.Btn_Imagen_Click);
            // 
            // Pic_Rubros
            // 
            this.Pic_Rubros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_Rubros.Location = new System.Drawing.Point(512, 71);
            this.Pic_Rubros.Name = "Pic_Rubros";
            this.Pic_Rubros.Size = new System.Drawing.Size(138, 144);
            this.Pic_Rubros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Rubros.TabIndex = 39;
            this.Pic_Rubros.TabStop = false;
            this.Pic_Rubros.Click += new System.EventHandler(this.Pic_Rubros_Click);
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(500, 364);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Cerrar.TabIndex = 40;
            this.Btn_Cerrar.Text = "Salir";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Textcolor = System.Drawing.Color.White;
            this.Btn_Cerrar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Enviar
            // 
            this.Btn_Enviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Enviar.BorderRadius = 0;
            this.Btn_Enviar.ButtonText = "Enviar";
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
            this.Btn_Enviar.Location = new System.Drawing.Point(72, 364);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Enviar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Enviar.selected = false;
            this.Btn_Enviar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Enviar.TabIndex = 39;
            this.Btn_Enviar.Text = "Enviar";
            this.Btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Enviar.Textcolor = System.Drawing.Color.White;
            this.Btn_Enviar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Frm_RubroAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.Btn_Categorias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Depto);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Btn_Imagen);
            this.Controls.Add(this.Pic_Rubros);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Txt_Extension);
            this.Controls.Add(this.Txt_Mail);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_RubroAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_RubroAgregar";
            this.Load += new System.EventHandler(this.Frm_RubroAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Rubros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Enviar;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Imagen;
        private System.Windows.Forms.PictureBox Pic_Rubros;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Extension;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Mail;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Nombre;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Depto;
        private System.Windows.Forms.CheckBox cb_SolicitudCambio;
        private System.Windows.Forms.CheckBox cb_Tickets;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Categorias;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}