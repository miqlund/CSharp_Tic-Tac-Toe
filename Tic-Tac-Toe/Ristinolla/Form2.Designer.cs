namespace Ristinolla
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmenuUusiPeli = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmenuTilastot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmenuTietoja = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmenuPoistu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 605);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolmenuUusiPeli,
            this.toolmenuTilastot,
            this.toolmenuTietoja,
            this.toolmenuPoistu});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.menuToolStripMenuItem.Text = "Valikko";
            // 
            // toolmenuUusiPeli
            // 
            this.toolmenuUusiPeli.Name = "toolmenuUusiPeli";
            this.toolmenuUusiPeli.Size = new System.Drawing.Size(180, 22);
            this.toolmenuUusiPeli.Text = "Uusi Peli";
            this.toolmenuUusiPeli.Click += new System.EventHandler(this.toolmenuUusiPeli_Click);
            // 
            // toolmenuTilastot
            // 
            this.toolmenuTilastot.Name = "toolmenuTilastot";
            this.toolmenuTilastot.Size = new System.Drawing.Size(180, 22);
            this.toolmenuTilastot.Text = "Tilastot";
            this.toolmenuTilastot.Click += new System.EventHandler(this.toolmenuTilastot_Click);
            // 
            // toolmenuTietoja
            // 
            this.toolmenuTietoja.Name = "toolmenuTietoja";
            this.toolmenuTietoja.Size = new System.Drawing.Size(180, 22);
            this.toolmenuTietoja.Text = "Tietoja";
            this.toolmenuTietoja.Click += new System.EventHandler(this.toolmenuTietoja_Click);
            // 
            // toolmenuPoistu
            // 
            this.toolmenuPoistu.Name = "toolmenuPoistu";
            this.toolmenuPoistu.Size = new System.Drawing.Size(180, 22);
            this.toolmenuPoistu.Text = "Poistu";
            this.toolmenuPoistu.Click += new System.EventHandler(this.toolmenuPoistu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Italianate", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(200, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 34);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 800);
            this.MinimumSize = new System.Drawing.Size(620, 800);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ristinolla";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolmenuUusiPeli;
        private System.Windows.Forms.ToolStripMenuItem toolmenuTilastot;
        private System.Windows.Forms.ToolStripMenuItem toolmenuTietoja;
        private System.Windows.Forms.ToolStripMenuItem toolmenuPoistu;
        private System.Windows.Forms.Label label1;
    }
}

