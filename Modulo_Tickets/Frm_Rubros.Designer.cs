
namespace Modulo_Tickets
{
    partial class Frm_Rubros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rubros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_NuevoRubro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FLow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_NuevoRubro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // Btn_NuevoRubro
            // 
            this.Btn_NuevoRubro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_NuevoRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_NuevoRubro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_NuevoRubro.BorderRadius = 0;
            this.Btn_NuevoRubro.ButtonText = "Nuevo Rubro";
            this.Btn_NuevoRubro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NuevoRubro.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_NuevoRubro.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_NuevoRubro.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_NuevoRubro.Iconimage")));
            this.Btn_NuevoRubro.Iconimage_right = null;
            this.Btn_NuevoRubro.Iconimage_right_Selected = null;
            this.Btn_NuevoRubro.Iconimage_Selected = null;
            this.Btn_NuevoRubro.IconMarginLeft = 0;
            this.Btn_NuevoRubro.IconMarginRight = 0;
            this.Btn_NuevoRubro.IconRightVisible = true;
            this.Btn_NuevoRubro.IconRightZoom = 0D;
            this.Btn_NuevoRubro.IconVisible = true;
            this.Btn_NuevoRubro.IconZoom = 90D;
            this.Btn_NuevoRubro.IsTab = true;
            this.Btn_NuevoRubro.Location = new System.Drawing.Point(39, 21);
            this.Btn_NuevoRubro.Name = "Btn_NuevoRubro";
            this.Btn_NuevoRubro.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_NuevoRubro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_NuevoRubro.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_NuevoRubro.selected = false;
            this.Btn_NuevoRubro.Size = new System.Drawing.Size(221, 48);
            this.Btn_NuevoRubro.TabIndex = 3;
            this.Btn_NuevoRubro.Text = "Nuevo Rubro";
            this.Btn_NuevoRubro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_NuevoRubro.Textcolor = System.Drawing.Color.White;
            this.Btn_NuevoRubro.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NuevoRubro.Click += new System.EventHandler(this.Btn_NuevoRubro_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FLow
            // 
            this.FLow.AutoScroll = true;
            this.FLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLow.Location = new System.Drawing.Point(0, 100);
            this.FLow.Name = "FLow";
            this.FLow.Size = new System.Drawing.Size(800, 399);
            this.FLow.TabIndex = 2;
            this.FLow.Paint += new System.Windows.Forms.PaintEventHandler(this.FLow_Paint);
            // 
            // Frm_Rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.FLow);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Rubros";
            this.Text = "Frm_Rubros";
            this.Load += new System.EventHandler(this.Frm_Rubros_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_NuevoRubro;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.FlowLayoutPanel FLow;
    }
}