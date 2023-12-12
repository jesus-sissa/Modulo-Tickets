
namespace Modulo_Tickets
{
    partial class Frm_FlujoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FlujoNuevo));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Txt_Descripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Alerta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_Externo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Captura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Enviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.Txt_Descripcion.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Descripcion.Location = new System.Drawing.Point(24, 73);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(758, 293);
            this.Txt_Descripcion.TabIndex = 111;
            this.Txt_Descripcion.Text = "Agregue aqui una descripción . . .";
            this.Txt_Descripcion.TextChanged += new System.EventHandler(this.Txt_Descripcion_TextChanged);
            this.Txt_Descripcion.Enter += new System.EventHandler(this.Txt_Descripcion_Enter);
            this.Txt_Descripcion.Leave += new System.EventHandler(this.Txt_Descripcion_Leave);
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Nombre.Location = new System.Drawing.Point(18, 14);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(123, 32);
            this.Lbl_Nombre.TabIndex = 107;
            this.Lbl_Nombre.Text = "Solicitud";
            this.Lbl_Nombre.Click += new System.EventHandler(this.Lbl_Nombre_Click);
            // 
            // Lbl_Alerta
            // 
            this.Lbl_Alerta.AutoSize = true;
            this.Lbl_Alerta.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Alerta.Location = new System.Drawing.Point(64, 357);
            this.Lbl_Alerta.Name = "Lbl_Alerta";
            this.Lbl_Alerta.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Alerta.TabIndex = 105;
            this.Lbl_Alerta.Click += new System.EventHandler(this.Lbl_Alerta_Click);
            // 
            // Lbl_Externo
            // 
            this.Lbl_Externo.AutoSize = true;
            this.Lbl_Externo.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Externo.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Externo.Location = new System.Drawing.Point(20, 46);
            this.Lbl_Externo.Name = "Lbl_Externo";
            this.Lbl_Externo.Size = new System.Drawing.Size(0, 30);
            this.Lbl_Externo.TabIndex = 102;
            this.Lbl_Externo.Click += new System.EventHandler(this.Lbl_Externo_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.ReadOnlyChecked = true;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 112;
            this.label1.Text = "Archivo Adjunto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btn_Captura.Location = new System.Drawing.Point(24, 387);
            this.btn_Captura.Name = "btn_Captura";
            this.btn_Captura.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Captura.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Captura.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Captura.selected = false;
            this.btn_Captura.Size = new System.Drawing.Size(160, 48);
            this.btn_Captura.TabIndex = 108;
            this.btn_Captura.Text = "Adjuntar archivo";
            this.btn_Captura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Captura.Textcolor = System.Drawing.Color.White;
            this.btn_Captura.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Captura.Click += new System.EventHandler(this.btn_Captura_Click);
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(628, 387);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(154, 48);
            this.Btn_Cerrar.TabIndex = 104;
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
            this.Btn_Enviar.Location = new System.Drawing.Point(276, 387);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Enviar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Enviar.selected = false;
            this.Btn_Enviar.Size = new System.Drawing.Size(141, 48);
            this.Btn_Enviar.TabIndex = 103;
            this.Btn_Enviar.Text = "Enviar";
            this.Btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Enviar.Textcolor = System.Drawing.Color.White;
            this.Btn_Enviar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Frm_FlujoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_Alerta);
            this.Controls.Add(this.Lbl_Externo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Captura);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Enviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FlujoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FlujoNuevo";
            this.Load += new System.EventHandler(this.Frm_FlujoNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Descripcion;
        private System.Windows.Forms.Label Lbl_Nombre;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Alerta;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Externo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Captura;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Enviar;
    }
}