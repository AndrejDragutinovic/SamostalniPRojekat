
namespace SamostalniPRojekat
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sirarnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toBeComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sirarnikToolStripMenuItem,
            this.toBeComToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sirarnikToolStripMenuItem
            // 
            this.sirarnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniToolStripMenuItem,
            this.proizvodiToolStripMenuItem,
            this.kupciToolStripMenuItem});
            this.sirarnikToolStripMenuItem.Name = "sirarnikToolStripMenuItem";
            this.sirarnikToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sirarnikToolStripMenuItem.Text = "Sirarnik";
            // 
            // zaposleniToolStripMenuItem
            // 
            this.zaposleniToolStripMenuItem.Name = "zaposleniToolStripMenuItem";
            this.zaposleniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zaposleniToolStripMenuItem.Text = "Zaposleni";
            this.zaposleniToolStripMenuItem.Click += new System.EventHandler(this.zaposleniToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            this.proizvodiToolStripMenuItem.Click += new System.EventHandler(this.proizvodiToolStripMenuItem_Click);
            // 
            // kupciToolStripMenuItem
            // 
            this.kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            this.kupciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kupciToolStripMenuItem.Text = "Kupci";
            this.kupciToolStripMenuItem.Click += new System.EventHandler(this.kupciToolStripMenuItem_Click);
            // 
            // toBeComToolStripMenuItem
            // 
            this.toBeComToolStripMenuItem.Name = "toBeComToolStripMenuItem";
            this.toBeComToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.toBeComToolStripMenuItem.Text = "ToBeContinued";
            this.toBeComToolStripMenuItem.Click += new System.EventHandler(this.toBeComToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sirarnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toBeComToolStripMenuItem;
    }
}

