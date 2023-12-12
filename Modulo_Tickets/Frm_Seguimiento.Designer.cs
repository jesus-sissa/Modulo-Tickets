
namespace Modulo_Tickets
{
    partial class Frm_Seguimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Seguimiento));
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Flow_Departamentos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 582);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 10);
            this.panel3.TabIndex = 43;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancelar.png");
            this.imageList1.Images.SetKeyName(1, "cheque.png");
            // 
            // Flow_Departamentos
            // 
            this.Flow_Departamentos.AutoScroll = true;
            this.Flow_Departamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow_Departamentos.Location = new System.Drawing.Point(0, 0);
            this.Flow_Departamentos.Name = "Flow_Departamentos";
            this.Flow_Departamentos.Size = new System.Drawing.Size(800, 582);
            this.Flow_Departamentos.TabIndex = 44;
            // 
            // Frm_Seguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.Flow_Departamentos);
            this.Controls.Add(this.panel3);
            this.Name = "Frm_Seguimiento";
            this.Text = "Frm_Seguimiento";
            this.Load += new System.EventHandler(this.Frm_Seguimiento_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel Flow_Departamentos;
    }
}