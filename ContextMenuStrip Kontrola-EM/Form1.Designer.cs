namespace ContextMenuStrip_Kontrola_EM
{
    partial class Form1
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
            this.textBoxDesno = new System.Windows.Forms.TextBox();
            this.textBoxLijevo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sDesnaNaLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sLijevaNaDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDesno
            // 
            this.textBoxDesno.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxDesno.Location = new System.Drawing.Point(555, 127);
            this.textBoxDesno.Name = "textBoxDesno";
            this.textBoxDesno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDesno.Size = new System.Drawing.Size(100, 22);
            this.textBoxDesno.TabIndex = 0;
            // 
            // textBoxLijevo
            // 
            this.textBoxLijevo.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxLijevo.Location = new System.Drawing.Point(120, 127);
            this.textBoxLijevo.Name = "textBoxLijevo";
            this.textBoxLijevo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxLijevo.Size = new System.Drawing.Size(100, 22);
            this.textBoxLijevo.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sDesnaNaLijevoToolStripMenuItem,
            this.sLijevaNaDesnoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 52);
            // 
            // sDesnaNaLijevoToolStripMenuItem
            // 
            this.sDesnaNaLijevoToolStripMenuItem.Name = "sDesnaNaLijevoToolStripMenuItem";
            this.sDesnaNaLijevoToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.sDesnaNaLijevoToolStripMenuItem.Text = "S desna na lijevo";
            this.sDesnaNaLijevoToolStripMenuItem.Click += new System.EventHandler(this.sDesnaNaLijevoToolStripMenuItem_Click);
            // 
            // sLijevaNaDesnoToolStripMenuItem
            // 
            this.sLijevaNaDesnoToolStripMenuItem.Name = "sLijevaNaDesnoToolStripMenuItem";
            this.sLijevaNaDesnoToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.sLijevaNaDesnoToolStripMenuItem.Text = "s lijeva na desno";
            this.sLijevaNaDesnoToolStripMenuItem.Click += new System.EventHandler(this.sLijevaNaDesnoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLijevo);
            this.Controls.Add(this.textBoxDesno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDesno;
        private System.Windows.Forms.TextBox textBoxLijevo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sDesnaNaLijevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sLijevaNaDesnoToolStripMenuItem;
    }
}

