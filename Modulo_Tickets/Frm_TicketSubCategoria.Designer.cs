
namespace Modulo_Tickets
{
    partial class Frm_TicketSubCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TicketSubCategoria));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FLow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Regresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FLow
            // 
            this.FLow.AutoScroll = true;
            this.FLow.BackColor = System.Drawing.SystemColors.Control;
            this.FLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLow.Location = new System.Drawing.Point(0, 100);
            this.FLow.Name = "FLow";
            this.FLow.Size = new System.Drawing.Size(800, 336);
            this.FLow.TabIndex = 11;
            this.FLow.Paint += new System.Windows.Forms.PaintEventHandler(this.FLow_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Lbl_Nombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Nombre.Location = new System.Drawing.Point(35, 25);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(481, 39);
            this.Lbl_Nombre.TabIndex = 73;
            this.Lbl_Nombre.Text = "Seleeciona una subcategoria";
            this.Lbl_Nombre.Click += new System.EventHandler(this.Lbl_Nombre_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Regresar);
            this.panel2.Controls.Add(this.Btn_Cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 68);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.btn_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Regresar.BorderRadius = 0;
            this.btn_Regresar.ButtonText = "<< Regresar";
            this.btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Regresar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Regresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Regresar.Iconimage = null;
            this.btn_Regresar.Iconimage_right = null;
            this.btn_Regresar.Iconimage_right_Selected = null;
            this.btn_Regresar.Iconimage_Selected = null;
            this.btn_Regresar.IconMarginLeft = 0;
            this.btn_Regresar.IconMarginRight = 0;
            this.btn_Regresar.IconRightVisible = true;
            this.btn_Regresar.IconRightZoom = 0D;
            this.btn_Regresar.IconVisible = true;
            this.btn_Regresar.IconZoom = 90D;
            this.btn_Regresar.IsTab = true;
            this.btn_Regresar.Location = new System.Drawing.Point(42, 8);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.btn_Regresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.btn_Regresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Regresar.selected = false;
            this.btn_Regresar.Size = new System.Drawing.Size(196, 48);
            this.btn_Regresar.TabIndex = 43;
            this.btn_Regresar.Text = "<< Regresar";
            this.btn_Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Regresar.Textcolor = System.Drawing.Color.White;
            this.btn_Regresar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
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
            // Frm_TicketSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.FLow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_TicketSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_TicketSubCategoria";
            this.Load += new System.EventHandler(this.Frm_TicketSubCategoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.FlowLayoutPanel FLow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Regresar;
    }
}