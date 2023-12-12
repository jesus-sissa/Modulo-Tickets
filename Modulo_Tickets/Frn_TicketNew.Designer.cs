
namespace Modulo_Tickets
{
    partial class Frn_TicketNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frn_TicketNew));
            this.div_Divider = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Lbl_Externo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_Alerta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Btn_Externo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Captura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Enviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Rubro = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // div_Divider
            // 
            this.div_Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.div_Divider.Depth = 0;
            this.div_Divider.Location = new System.Drawing.Point(554, 75);
            this.div_Divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.div_Divider.Name = "div_Divider";
            this.div_Divider.Size = new System.Drawing.Size(10, 293);
            this.div_Divider.TabIndex = 77;
            this.div_Divider.Text = "materialDivider1";
            this.div_Divider.Visible = false;
            this.div_Divider.Click += new System.EventHandler(this.div_Divider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 101;
            this.label1.Text = "Archivo Adjunto";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.ReadOnlyChecked = true;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Lbl_Externo
            // 
            this.Lbl_Externo.AutoSize = true;
            this.Lbl_Externo.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Externo.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Externo.Location = new System.Drawing.Point(14, 48);
            this.Lbl_Externo.Name = "Lbl_Externo";
            this.Lbl_Externo.Size = new System.Drawing.Size(0, 30);
            this.Lbl_Externo.TabIndex = 28;
            this.Lbl_Externo.Click += new System.EventHandler(this.Lbl_Externo_Click);
            // 
            // Lbl_Alerta
            // 
            this.Lbl_Alerta.AutoSize = true;
            this.Lbl_Alerta.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Alerta.Location = new System.Drawing.Point(58, 359);
            this.Lbl_Alerta.Name = "Lbl_Alerta";
            this.Lbl_Alerta.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Alerta.TabIndex = 32;
            this.Lbl_Alerta.Click += new System.EventHandler(this.Lbl_Alerta_Click);
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Nombre.Location = new System.Drawing.Point(12, 16);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(205, 32);
            this.Lbl_Nombre.TabIndex = 74;
            this.Lbl_Nombre.Text = "Departamento";
            this.Lbl_Nombre.Click += new System.EventHandler(this.Lbl_Nombre_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.Txt_Descripcion.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Descripcion.Location = new System.Drawing.Point(18, 75);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(758, 293);
            this.Txt_Descripcion.TabIndex = 100;
            this.Txt_Descripcion.Text = "Agregue aqui una descripción . . .";
            this.Txt_Descripcion.TextChanged += new System.EventHandler(this.Txt_Descripcion_TextChanged);
            this.Txt_Descripcion.Enter += new System.EventHandler(this.Txt_Descripcion_Enter);
            this.Txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Descripcion_KeyPress);
            this.Txt_Descripcion.Leave += new System.EventHandler(this.Txt_Descripcion_Leave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Btn_Externo
            // 
            this.Btn_Externo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Externo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Externo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Externo.BorderRadius = 0;
            this.Btn_Externo.ButtonText = "Externo";
            this.Btn_Externo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Externo.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Externo.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Externo.Iconimage = global::Modulo_Tickets.Properties.Resources.btn_ConsultaUsuarios;
            this.Btn_Externo.Iconimage_right = null;
            this.Btn_Externo.Iconimage_right_Selected = null;
            this.Btn_Externo.Iconimage_Selected = null;
            this.Btn_Externo.IconMarginLeft = 0;
            this.Btn_Externo.IconMarginRight = 0;
            this.Btn_Externo.IconRightVisible = true;
            this.Btn_Externo.IconRightZoom = 0D;
            this.Btn_Externo.IconVisible = true;
            this.Btn_Externo.IconZoom = 90D;
            this.Btn_Externo.IsTab = true;
            this.Btn_Externo.Location = new System.Drawing.Point(18, 390);
            this.Btn_Externo.Name = "Btn_Externo";
            this.Btn_Externo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Externo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Externo.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Externo.selected = false;
            this.Btn_Externo.Size = new System.Drawing.Size(168, 48);
            this.Btn_Externo.TabIndex = 79;
            this.Btn_Externo.Text = "Externo";
            this.Btn_Externo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Externo.Textcolor = System.Drawing.Color.White;
            this.Btn_Externo.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Externo.Visible = false;
            this.Btn_Externo.Click += new System.EventHandler(this.Btn_Externo_Click);
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
            this.btn_Captura.Location = new System.Drawing.Point(231, 390);
            this.btn_Captura.Name = "btn_Captura";
            this.btn_Captura.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Captura.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Captura.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Captura.selected = false;
            this.btn_Captura.Size = new System.Drawing.Size(160, 48);
            this.btn_Captura.TabIndex = 75;
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(622, 390);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(154, 48);
            this.Btn_Cerrar.TabIndex = 31;
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
            this.Btn_Enviar.Location = new System.Drawing.Point(434, 390);
            this.Btn_Enviar.Name = "Btn_Enviar";
            this.Btn_Enviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Enviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Enviar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Enviar.selected = false;
            this.Btn_Enviar.Size = new System.Drawing.Size(141, 48);
            this.Btn_Enviar.TabIndex = 30;
            this.Btn_Enviar.Text = "Enviar";
            this.Btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Enviar.Textcolor = System.Drawing.Color.White;
            this.Btn_Enviar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enviar.Click += new System.EventHandler(this.Btn_Enviar_Click);
            // 
            // Btn_Rubro
            // 
            this.Btn_Rubro.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Rubro.color = System.Drawing.Color.SeaGreen;
            this.Btn_Rubro.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Rubro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Rubro.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Btn_Rubro.ForeColor = System.Drawing.Color.White;
            this.Btn_Rubro.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Rubro.Image")));
            this.Btn_Rubro.ImagePosition = 10;
            this.Btn_Rubro.ImageZoom = 70;
            this.Btn_Rubro.LabelPosition = 0;
            this.Btn_Rubro.LabelText = "";
            this.Btn_Rubro.Location = new System.Drawing.Point(42, 100);
            this.Btn_Rubro.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Rubro.Name = "Btn_Rubro";
            this.Btn_Rubro.Size = new System.Drawing.Size(144, 129);
            this.Btn_Rubro.TabIndex = 35;
            this.Btn_Rubro.Visible = false;
            this.Btn_Rubro.Click += new System.EventHandler(this.Btn_Rubro_Click_1);
            // 
            // Frn_TicketNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Externo);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.div_Divider);
            this.Controls.Add(this.btn_Captura);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_Alerta);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Lbl_Externo);
            this.Controls.Add(this.Btn_Enviar);
            this.Controls.Add(this.Btn_Rubro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frn_TicketNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frn_TicketNew";
            this.Load += new System.EventHandler(this.Frn_TicketNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuTileButton Btn_Rubro;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Enviar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Captura;
        private MaterialSkin.Controls.MaterialDivider div_Divider;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Externo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Externo;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Alerta;
        private System.Windows.Forms.Label Lbl_Nombre;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Descripcion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}