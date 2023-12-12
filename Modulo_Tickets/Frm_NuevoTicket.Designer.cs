
namespace Modulo_Tickets
{
    partial class Frm_NuevoTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevoTicket));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Lbl_Alerta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FLow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Lbl_Alerta
            // 
            this.Lbl_Alerta.AutoSize = true;
            this.Lbl_Alerta.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Alerta.Location = new System.Drawing.Point(87, 355);
            this.Lbl_Alerta.Name = "Lbl_Alerta";
            this.Lbl_Alerta.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Alerta.TabIndex = 28;
            this.Lbl_Alerta.Click += new System.EventHandler(this.Lbl_Alerta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(276, 5);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Cerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(1)))));
            this.Btn_Cerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cerrar.selected = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(196, 48);
            this.Btn_Cerrar.TabIndex = 32;
            this.Btn_Cerrar.Text = "Salir";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cerrar.Textcolor = System.Drawing.Color.White;
            this.Btn_Cerrar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // FLow
            // 
            this.FLow.AutoScroll = true;
            this.FLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLow.Location = new System.Drawing.Point(0, 0);
            this.FLow.Name = "FLow";
            this.FLow.Size = new System.Drawing.Size(800, 385);
            this.FLow.TabIndex = 34;
            this.FLow.UseWaitCursor = true;
            this.FLow.Paint += new System.Windows.Forms.PaintEventHandler(this.FLow_Paint);
            // 
            // Frm_NuevoTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.FLow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_Alerta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Frm_NuevoTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_NuevoTicket_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Alerta;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cerrar;
        private System.Windows.Forms.FlowLayoutPanel FLow;
    }
}