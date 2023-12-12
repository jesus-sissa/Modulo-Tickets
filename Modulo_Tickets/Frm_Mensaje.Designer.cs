
namespace Modulo_Tickets
{
    partial class Frm_Mensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mensaje));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Btn_Imagen = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Txt_Mensaje = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Btn_Imagen
            // 
            this.Btn_Imagen.ActiveBorderThickness = 1;
            this.Btn_Imagen.ActiveCornerRadius = 20;
            this.Btn_Imagen.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Imagen.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Imagen.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Btn_Imagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Imagen.BackgroundImage")));
            this.Btn_Imagen.ButtonText = "Cerrar";
            this.Btn_Imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Imagen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imagen.ForeColor = System.Drawing.Color.SeaShell;
            this.Btn_Imagen.IdleBorderThickness = 1;
            this.Btn_Imagen.IdleCornerRadius = 20;
            this.Btn_Imagen.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Imagen.IdleForecolor = System.Drawing.Color.White;
            this.Btn_Imagen.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(95)))));
            this.Btn_Imagen.Location = new System.Drawing.Point(12, 118);
            this.Btn_Imagen.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Imagen.Name = "Btn_Imagen";
            this.Btn_Imagen.Size = new System.Drawing.Size(138, 41);
            this.Btn_Imagen.TabIndex = 42;
            this.Btn_Imagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Imagen.Click += new System.EventHandler(this.Btn_Imagen_Click);
            // 
            // Txt_Mensaje
            // 
            this.Txt_Mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Txt_Mensaje.BorderColor = System.Drawing.Color.LimeGreen;
            this.Txt_Mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Mensaje.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Txt_Mensaje.ForeColor = System.Drawing.Color.White;
            this.Txt_Mensaje.Location = new System.Drawing.Point(12, 12);
            this.Txt_Mensaje.Multiline = true;
            this.Txt_Mensaje.Name = "Txt_Mensaje";
            this.Txt_Mensaje.ReadOnly = true;
            this.Txt_Mensaje.Size = new System.Drawing.Size(471, 98);
            this.Txt_Mensaje.TabIndex = 43;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(504, 173);
            this.Controls.Add(this.Txt_Mensaje);
            this.Controls.Add(this.Btn_Imagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Mensaje";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Mensaje";
            this.Load += new System.EventHandler(this.Frm_Mensaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Imagen;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox Txt_Mensaje;
        private System.Windows.Forms.Timer timer1;
    }
}