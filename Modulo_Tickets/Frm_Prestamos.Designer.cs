
namespace Modulo_Tickets
{
    partial class Frm_Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Prestamos));
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_empleados = new MaterialSkin.Controls.MaterialComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_nomina = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_fechaingreso = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_puntodeservicio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_cantidadsolicitada = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_finalidadprestamo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_prestamosenelaño = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_fechaultimoprestamo = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Nombre.Location = new System.Drawing.Point(236, 3);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(352, 39);
            this.Lbl_Nombre.TabIndex = 73;
            this.Lbl_Nombre.Text = "Solicitud de Prestamo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Lbl_Nombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 45);
            this.panel1.TabIndex = 13;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(146, 26);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(122, 24);
            this.bunifuCustomLabel2.TabIndex = 54;
            this.bunifuCustomLabel2.Text = "Empleado:";
            // 
            // cmb_empleados
            // 
            this.cmb_empleados.AutoResize = false;
            this.cmb_empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_empleados.Depth = 0;
            this.cmb_empleados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_empleados.DropDownHeight = 260;
            this.cmb_empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empleados.DropDownWidth = 121;
            this.cmb_empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_empleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_empleados.FormattingEnabled = true;
            this.cmb_empleados.IntegralHeight = false;
            this.cmb_empleados.ItemHeight = 43;
            this.cmb_empleados.Location = new System.Drawing.Point(274, 16);
            this.cmb_empleados.MaxDropDownItems = 6;
            this.cmb_empleados.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_empleados.Name = "cmb_empleados";
            this.cmb_empleados.Size = new System.Drawing.Size(449, 49);
            this.cmb_empleados.StartIndex = 0;
            this.cmb_empleados.TabIndex = 55;
            this.cmb_empleados.SelectedIndexChanged += new System.EventHandler(this.cmb_empleados_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(235, 81);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(157, 24);
            this.bunifuCustomLabel1.TabIndex = 56;
            this.bunifuCustomLabel1.Text = "Num. Nomina:";
            // 
            // txt_nomina
            // 
            this.txt_nomina.BackColor = System.Drawing.Color.White;
            this.txt_nomina.BorderColor = System.Drawing.Color.LimeGreen;
            this.txt_nomina.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txt_nomina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_nomina.Location = new System.Drawing.Point(398, 71);
            this.txt_nomina.Multiline = true;
            this.txt_nomina.Name = "txt_nomina";
            this.txt_nomina.ReadOnly = true;
            this.txt_nomina.Size = new System.Drawing.Size(158, 31);
            this.txt_nomina.TabIndex = 57;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(232, 118);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(160, 24);
            this.bunifuCustomLabel3.TabIndex = 58;
            this.bunifuCustomLabel3.Text = "Fecha Ingreso:";
            // 
            // txt_fechaingreso
            // 
            this.txt_fechaingreso.BackColor = System.Drawing.Color.White;
            this.txt_fechaingreso.BorderColor = System.Drawing.Color.LimeGreen;
            this.txt_fechaingreso.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txt_fechaingreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_fechaingreso.Location = new System.Drawing.Point(398, 108);
            this.txt_fechaingreso.Multiline = true;
            this.txt_fechaingreso.Name = "txt_fechaingreso";
            this.txt_fechaingreso.ReadOnly = true;
            this.txt_fechaingreso.Size = new System.Drawing.Size(158, 31);
            this.txt_fechaingreso.TabIndex = 59;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(177, 185);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(215, 24);
            this.bunifuCustomLabel4.TabIndex = 60;
            this.bunifuCustomLabel4.Text = "Cantidad Solicitada:";
            // 
            // txt_puntodeservicio
            // 
            this.txt_puntodeservicio.BackColor = System.Drawing.Color.White;
            this.txt_puntodeservicio.BorderColor = System.Drawing.Color.LimeGreen;
            this.txt_puntodeservicio.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txt_puntodeservicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_puntodeservicio.Location = new System.Drawing.Point(398, 145);
            this.txt_puntodeservicio.Multiline = true;
            this.txt_puntodeservicio.Name = "txt_puntodeservicio";
            this.txt_puntodeservicio.ReadOnly = true;
            this.txt_puntodeservicio.Size = new System.Drawing.Size(156, 31);
            this.txt_puntodeservicio.TabIndex = 61;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(52, 298);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(339, 24);
            this.bunifuCustomLabel5.TabIndex = 62;
            this.bunifuCustomLabel5.Text = "Motivo y Finalidad del Prestamo:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(200, 148);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(191, 24);
            this.bunifuCustomLabel6.TabIndex = 64;
            this.bunifuCustomLabel6.Text = "Punto de Servicio:";
            // 
            // txt_cantidadsolicitada
            // 
            this.txt_cantidadsolicitada.BackColor = System.Drawing.Color.White;
            this.txt_cantidadsolicitada.BorderColor = System.Drawing.Color.LimeGreen;
            this.txt_cantidadsolicitada.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txt_cantidadsolicitada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_cantidadsolicitada.Location = new System.Drawing.Point(398, 182);
            this.txt_cantidadsolicitada.Multiline = true;
            this.txt_cantidadsolicitada.Name = "txt_cantidadsolicitada";
            this.txt_cantidadsolicitada.Size = new System.Drawing.Size(156, 31);
            this.txt_cantidadsolicitada.TabIndex = 65;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(52, 261);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(340, 24);
            this.bunifuCustomLabel7.TabIndex = 66;
            this.bunifuCustomLabel7.Text = "Prestamos Otorgados en el Año:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_finalidadprestamo);
            this.groupBox2.Controls.Add(this.txt_prestamosenelaño);
            this.groupBox2.Controls.Add(this.txt_fechaultimoprestamo);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox2.Controls.Add(this.txt_cantidadsolicitada);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox2.Controls.Add(this.txt_puntodeservicio);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox2.Controls.Add(this.txt_fechaingreso);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox2.Controls.Add(this.txt_nomina);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox2.Controls.Add(this.cmb_empleados);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 354);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_finalidadprestamo
            // 
            this.txt_finalidadprestamo.BackColor = System.Drawing.Color.White;
            this.txt_finalidadprestamo.BorderColor = System.Drawing.Color.LimeGreen;
            this.txt_finalidadprestamo.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txt_finalidadprestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_finalidadprestamo.Location = new System.Drawing.Point(398, 295);
            this.txt_finalidadprestamo.Multiline = true;
            this.txt_finalidadprestamo.Name = "txt_finalidadprestamo";
            this.txt_finalidadprestamo.Size = new System.Drawing.Size(325, 31);
            this.txt_finalidadprestamo.TabIndex = 71;
            // 
            // txt_prestamosenelaño
            // 
            this.txt_prestamosenelaño.BackColor = System.Drawing.Color.White;
            this.txt_prestamosenelaño.BorderColor = System.Drawing.Color.LimeGreen;
            this.txt_prestamosenelaño.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txt_prestamosenelaño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_prestamosenelaño.Location = new System.Drawing.Point(398, 258);
            this.txt_prestamosenelaño.Multiline = true;
            this.txt_prestamosenelaño.Name = "txt_prestamosenelaño";
            this.txt_prestamosenelaño.Size = new System.Drawing.Size(160, 31);
            this.txt_prestamosenelaño.TabIndex = 70;
            // 
            // txt_fechaultimoprestamo
            // 
            this.txt_fechaultimoprestamo.BackColor = System.Drawing.Color.White;
            this.txt_fechaultimoprestamo.BorderColor = System.Drawing.Color.LimeGreen;
            this.txt_fechaultimoprestamo.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txt_fechaultimoprestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_fechaultimoprestamo.Location = new System.Drawing.Point(398, 218);
            this.txt_fechaultimoprestamo.Multiline = true;
            this.txt_fechaultimoprestamo.Name = "txt_fechaultimoprestamo";
            this.txt_fechaultimoprestamo.Size = new System.Drawing.Size(160, 31);
            this.txt_fechaultimoprestamo.TabIndex = 69;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(101, 221);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(290, 24);
            this.bunifuCustomLabel8.TabIndex = 68;
            this.bunifuCustomLabel8.Text = "Fecha del Ultimo Prestamo:";
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(392, 8);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Cerrar.TabIndex = 42;
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
            this.Btn_Guardar.Location = new System.Drawing.Point(97, 8);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Guardar.selected = false;
            this.Btn_Guardar.Size = new System.Drawing.Size(221, 48);
            this.Btn_Guardar.TabIndex = 43;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Textcolor = System.Drawing.Color.White;
            this.Btn_Guardar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Guardar);
            this.panel2.Controls.Add(this.Btn_Cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 69);
            this.panel2.TabIndex = 57;
            // 
            // Frm_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 474);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Prestamos";
            this.Load += new System.EventHandler(this.Frm_Prestamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmb_empleados;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_nomina;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_fechaingreso;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_puntodeservicio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_cantidadsolicitada;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Guardar;
        private System.Windows.Forms.Panel panel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_fechaultimoprestamo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_finalidadprestamo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_prestamosenelaño;
    }
}