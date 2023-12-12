
namespace Modulo_Tickets
{
    partial class Frm_StatusActivos
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_NomSol = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Chk_Status = new MaterialSkin.Controls.MaterialCheckbox();
            this.Lbl_Status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Chk_Porcentaje = new MaterialSkin.Controls.MaterialCheckbox();
            this.Lbl_Porcentaje = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Chk_Autorizacion = new MaterialSkin.Controls.MaterialCheckbox();
            this.Lbl_Autorizo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FLow = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_Formularios = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Lbl_Nombre);
            this.panel1.Controls.Add(this.Lbl_NomSol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 68);
            this.panel1.TabIndex = 48;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Nombre.Location = new System.Drawing.Point(35, 25);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(252, 39);
            this.Lbl_Nombre.TabIndex = 72;
            this.Lbl_Nombre.Text = "Configuracion:";
            // 
            // Lbl_NomSol
            // 
            this.Lbl_NomSol.AutoSize = true;
            this.Lbl_NomSol.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.Lbl_NomSol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_NomSol.Location = new System.Drawing.Point(278, 25);
            this.Lbl_NomSol.Name = "Lbl_NomSol";
            this.Lbl_NomSol.Size = new System.Drawing.Size(372, 39);
            this.Lbl_NomSol.TabIndex = 50;
            this.Lbl_NomSol.Text = "Nombre de la Solicitud";
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Cerrar);
            this.panel2.Controls.Add(this.Btn_Guardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 68);
            this.panel2.TabIndex = 49;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.Btn_Cerrar.Iconimage = null;
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(300, 8);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Cerrar.TabIndex = 41;
            this.Btn_Cerrar.Text = "Salir";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Textcolor = System.Drawing.Color.White;
            this.Btn_Cerrar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Guardar.BorderRadius = 0;
            this.Btn_Guardar.ButtonText = "Guardar";
            this.Btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Guardar.Iconimage = null;
            this.Btn_Guardar.Iconimage_right = null;
            this.Btn_Guardar.Iconimage_right_Selected = null;
            this.Btn_Guardar.Iconimage_Selected = null;
            this.Btn_Guardar.IconMarginLeft = 0;
            this.Btn_Guardar.IconMarginRight = 0;
            this.Btn_Guardar.IconRightVisible = true;
            this.Btn_Guardar.IconRightZoom = 0D;
            this.Btn_Guardar.IconVisible = true;
            this.Btn_Guardar.IconZoom = 90D;
            this.Btn_Guardar.IsTab = true;
            this.Btn_Guardar.Location = new System.Drawing.Point(39, 8);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Guardar.selected = false;
            this.Btn_Guardar.Size = new System.Drawing.Size(221, 48);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Textcolor = System.Drawing.Color.White;
            this.Btn_Guardar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Chk_Status
            // 
            this.Chk_Status.AutoSize = true;
            this.Chk_Status.Checked = true;
            this.Chk_Status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_Status.Depth = 0;
            this.Chk_Status.Location = new System.Drawing.Point(93, 23);
            this.Chk_Status.Margin = new System.Windows.Forms.Padding(0);
            this.Chk_Status.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Chk_Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.Chk_Status.Name = "Chk_Status";
            this.Chk_Status.ReadOnly = false;
            this.Chk_Status.Ripple = true;
            this.Chk_Status.Size = new System.Drawing.Size(35, 37);
            this.Chk_Status.TabIndex = 52;
            this.Chk_Status.UseVisualStyleBackColor = true;
            this.Chk_Status.CheckedChanged += new System.EventHandler(this.Chk_Status_CheckedChanged);
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Status.Location = new System.Drawing.Point(20, 27);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(74, 24);
            this.Lbl_Status.TabIndex = 51;
            this.Lbl_Status.Text = "Status:";
            // 
            // Chk_Porcentaje
            // 
            this.Chk_Porcentaje.AutoSize = true;
            this.Chk_Porcentaje.Checked = true;
            this.Chk_Porcentaje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_Porcentaje.Depth = 0;
            this.Chk_Porcentaje.Location = new System.Drawing.Point(324, 23);
            this.Chk_Porcentaje.Margin = new System.Windows.Forms.Padding(0);
            this.Chk_Porcentaje.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Chk_Porcentaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.Chk_Porcentaje.Name = "Chk_Porcentaje";
            this.Chk_Porcentaje.ReadOnly = false;
            this.Chk_Porcentaje.Ripple = true;
            this.Chk_Porcentaje.Size = new System.Drawing.Size(35, 37);
            this.Chk_Porcentaje.TabIndex = 54;
            this.Chk_Porcentaje.UseVisualStyleBackColor = true;
            this.Chk_Porcentaje.CheckedChanged += new System.EventHandler(this.Chk_Porcentaje_CheckedChanged);
            // 
            // Lbl_Porcentaje
            // 
            this.Lbl_Porcentaje.AutoSize = true;
            this.Lbl_Porcentaje.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Porcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Porcentaje.Location = new System.Drawing.Point(195, 27);
            this.Lbl_Porcentaje.Name = "Lbl_Porcentaje";
            this.Lbl_Porcentaje.Size = new System.Drawing.Size(126, 24);
            this.Lbl_Porcentaje.TabIndex = 53;
            this.Lbl_Porcentaje.Text = "Porcentaje:";
            this.Lbl_Porcentaje.Click += new System.EventHandler(this.Lbl_Porcentaje_Click);
            // 
            // Chk_Autorizacion
            // 
            this.Chk_Autorizacion.AutoSize = true;
            this.Chk_Autorizacion.Checked = true;
            this.Chk_Autorizacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_Autorizacion.Depth = 0;
            this.Chk_Autorizacion.Location = new System.Drawing.Point(567, 23);
            this.Chk_Autorizacion.Margin = new System.Windows.Forms.Padding(0);
            this.Chk_Autorizacion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Chk_Autorizacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.Chk_Autorizacion.Name = "Chk_Autorizacion";
            this.Chk_Autorizacion.ReadOnly = false;
            this.Chk_Autorizacion.Ripple = true;
            this.Chk_Autorizacion.Size = new System.Drawing.Size(35, 37);
            this.Chk_Autorizacion.TabIndex = 56;
            this.Chk_Autorizacion.UseVisualStyleBackColor = true;
            this.Chk_Autorizacion.CheckedChanged += new System.EventHandler(this.Chk_Autorizacion_CheckedChanged);
            // 
            // Lbl_Autorizo
            // 
            this.Lbl_Autorizo.AutoSize = true;
            this.Lbl_Autorizo.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Lbl_Autorizo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Lbl_Autorizo.Location = new System.Drawing.Point(424, 27);
            this.Lbl_Autorizo.Name = "Lbl_Autorizo";
            this.Lbl_Autorizo.Size = new System.Drawing.Size(140, 24);
            this.Lbl_Autorizo.TabIndex = 55;
            this.Lbl_Autorizo.Text = "Autorización:";
            // 
            // FLow
            // 
            this.FLow.AutoScroll = true;
            this.FLow.BackColor = System.Drawing.SystemColors.Control;
            this.FLow.Location = new System.Drawing.Point(6, 10);
            this.FLow.Name = "FLow";
            this.FLow.Size = new System.Drawing.Size(680, 154);
            this.FLow.TabIndex = 57;
            this.FLow.Paint += new System.Windows.Forms.PaintEventHandler(this.FLow_Paint);
            // 
            // Lbl_Formularios
            // 
            this.Lbl_Formularios.AutoSize = true;
            this.Lbl_Formularios.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Formularios.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Formularios.Location = new System.Drawing.Point(35, 151);
            this.Lbl_Formularios.Name = "Lbl_Formularios";
            this.Lbl_Formularios.Size = new System.Drawing.Size(191, 39);
            this.Lbl_Formularios.TabIndex = 73;
            this.Lbl_Formularios.Text = "Formularios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_Status);
            this.groupBox1.Controls.Add(this.Chk_Status);
            this.groupBox1.Controls.Add(this.Lbl_Porcentaje);
            this.groupBox1.Controls.Add(this.Chk_Autorizacion);
            this.groupBox1.Controls.Add(this.Chk_Porcentaje);
            this.groupBox1.Controls.Add(this.Lbl_Autorizo);
            this.groupBox1.Location = new System.Drawing.Point(39, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 74);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FLow);
            this.groupBox2.Location = new System.Drawing.Point(42, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 170);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Frm_StatusActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl_Formularios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_StatusActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_StatusActivos";
            this.Load += new System.EventHandler(this.Frm_StatusActivos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Guardar;
        public MaterialSkin.Controls.MaterialCheckbox Chk_Status;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Status;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_NomSol;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        public MaterialSkin.Controls.MaterialCheckbox Chk_Autorizacion;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Autorizo;
        public MaterialSkin.Controls.MaterialCheckbox Chk_Porcentaje;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Porcentaje;
        private System.Windows.Forms.FlowLayoutPanel FLow;
        private System.Windows.Forms.Label Lbl_Formularios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}