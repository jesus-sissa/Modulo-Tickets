
namespace Modulo_Tickets
{
    partial class Frm_FiltroBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FiltroBusqueda));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Dat_FechaInicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Dat_FechaFin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Cmb_Status = new MaterialSkin.Controls.MaterialComboBox();
            this.Btn_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Chk_Todos = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 34);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(138, 24);
            this.bunifuCustomLabel1.TabIndex = 47;
            this.bunifuCustomLabel1.Text = "Fecha Inicio:";
            // 
            // Dat_FechaInicio
            // 
            this.Dat_FechaInicio.BackColor = System.Drawing.Color.SeaGreen;
            this.Dat_FechaInicio.BorderRadius = 0;
            this.Dat_FechaInicio.ForeColor = System.Drawing.Color.White;
            this.Dat_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Dat_FechaInicio.FormatCustom = null;
            this.Dat_FechaInicio.Location = new System.Drawing.Point(214, 25);
            this.Dat_FechaInicio.Name = "Dat_FechaInicio";
            this.Dat_FechaInicio.Size = new System.Drawing.Size(303, 49);
            this.Dat_FechaInicio.TabIndex = 48;
            this.Dat_FechaInicio.Value = new System.DateTime(2022, 8, 26, 0, 0, 0, 0);
            this.Dat_FechaInicio.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // Dat_FechaFin
            // 
            this.Dat_FechaFin.BackColor = System.Drawing.Color.SeaGreen;
            this.Dat_FechaFin.BorderRadius = 0;
            this.Dat_FechaFin.ForeColor = System.Drawing.Color.White;
            this.Dat_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Dat_FechaFin.FormatCustom = null;
            this.Dat_FechaFin.Location = new System.Drawing.Point(214, 80);
            this.Dat_FechaFin.Name = "Dat_FechaFin";
            this.Dat_FechaFin.Size = new System.Drawing.Size(303, 49);
            this.Dat_FechaFin.TabIndex = 50;
            this.Dat_FechaFin.Value = new System.DateTime(2022, 8, 26, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(80, 91);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(112, 24);
            this.bunifuCustomLabel2.TabIndex = 49;
            this.bunifuCustomLabel2.Text = "Fecha Fin:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(118, 145);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(74, 24);
            this.bunifuCustomLabel3.TabIndex = 51;
            this.bunifuCustomLabel3.Text = "Status:";
            // 
            // Cmb_Status
            // 
            this.Cmb_Status.AutoResize = false;
            this.Cmb_Status.BackColor = System.Drawing.Color.SeaGreen;
            this.Cmb_Status.Depth = 0;
            this.Cmb_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Cmb_Status.DropDownHeight = 174;
            this.Cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Status.DropDownWidth = 121;
            this.Cmb_Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Cmb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cmb_Status.FormattingEnabled = true;
            this.Cmb_Status.IntegralHeight = false;
            this.Cmb_Status.ItemHeight = 43;
            this.Cmb_Status.Items.AddRange(new object[] {
            "NUEVO",
            "ASIGNADO",
            "ACTUANDO",
            "RESUELTO",
            "CERRADO",
            "RECHAZADO"});
            this.Cmb_Status.Location = new System.Drawing.Point(214, 135);
            this.Cmb_Status.MaxDropDownItems = 4;
            this.Cmb_Status.MouseState = MaterialSkin.MouseState.OUT;
            this.Cmb_Status.Name = "Cmb_Status";
            this.Cmb_Status.Size = new System.Drawing.Size(303, 49);
            this.Cmb_Status.StartIndex = 0;
            this.Cmb_Status.TabIndex = 52;
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
            this.Btn_Guardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Iconimage")));
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
            this.Btn_Guardar.Location = new System.Drawing.Point(102, 233);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Guardar.selected = false;
            this.Btn_Guardar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Guardar.TabIndex = 54;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Textcolor = System.Drawing.Color.White;
            this.Btn_Guardar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(321, 233);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Cerrar.TabIndex = 53;
            this.Btn_Cerrar.Text = "Salir";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Textcolor = System.Drawing.Color.White;
            this.Btn_Cerrar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Chk_Todos
            // 
            this.Chk_Todos.AutoSize = true;
            this.Chk_Todos.Depth = 0;
            this.Chk_Todos.Location = new System.Drawing.Point(525, 143);
            this.Chk_Todos.Margin = new System.Windows.Forms.Padding(0);
            this.Chk_Todos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Chk_Todos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Chk_Todos.Name = "Chk_Todos";
            this.Chk_Todos.ReadOnly = false;
            this.Chk_Todos.Ripple = true;
            this.Chk_Todos.Size = new System.Drawing.Size(80, 37);
            this.Chk_Todos.TabIndex = 55;
            this.Chk_Todos.Text = "Todos";
            this.Chk_Todos.UseVisualStyleBackColor = true;
            this.Chk_Todos.CheckedChanged += new System.EventHandler(this.Chk_Todos_CheckedChanged);
            // 
            // Frm_FiltroBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 310);
            this.Controls.Add(this.Chk_Todos);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Cmb_Status);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Dat_FechaFin);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Dat_FechaInicio);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FiltroBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FiltroBusqueda";
            this.Load += new System.EventHandler(this.Frm_FiltroBusqueda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDatepicker Dat_FechaFin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker Dat_FechaInicio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MaterialSkin.Controls.MaterialComboBox Cmb_Status;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Guardar;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private MaterialSkin.Controls.MaterialCheckbox Chk_Todos;
    }
}