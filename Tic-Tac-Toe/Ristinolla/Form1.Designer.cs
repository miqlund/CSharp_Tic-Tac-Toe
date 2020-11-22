namespace Ristinolla
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
            this.btnUusiPeli = new System.Windows.Forms.Button();
            this.btnTilastot = new System.Windows.Forms.Button();
            this.btnTietoja = new System.Windows.Forms.Button();
            this.btnPoistu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUusiPeli
            // 
            this.btnUusiPeli.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUusiPeli.Location = new System.Drawing.Point(200, 100);
            this.btnUusiPeli.MaximumSize = new System.Drawing.Size(100, 40);
            this.btnUusiPeli.MinimumSize = new System.Drawing.Size(100, 40);
            this.btnUusiPeli.Name = "btnUusiPeli";
            this.btnUusiPeli.Size = new System.Drawing.Size(100, 40);
            this.btnUusiPeli.TabIndex = 0;
            this.btnUusiPeli.Text = "Uusi Peli";
            this.btnUusiPeli.UseVisualStyleBackColor = false;
            this.btnUusiPeli.Click += new System.EventHandler(this.btnUusiPeli_Click);
            // 
            // btnTilastot
            // 
            this.btnTilastot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTilastot.Location = new System.Drawing.Point(200, 150);
            this.btnTilastot.MaximumSize = new System.Drawing.Size(100, 40);
            this.btnTilastot.MinimumSize = new System.Drawing.Size(100, 40);
            this.btnTilastot.Name = "btnTilastot";
            this.btnTilastot.Size = new System.Drawing.Size(100, 40);
            this.btnTilastot.TabIndex = 1;
            this.btnTilastot.Text = "Tilastot";
            this.btnTilastot.UseVisualStyleBackColor = false;
            this.btnTilastot.Click += new System.EventHandler(this.btnTilastot_Click);
            // 
            // btnTietoja
            // 
            this.btnTietoja.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTietoja.Location = new System.Drawing.Point(200, 200);
            this.btnTietoja.MaximumSize = new System.Drawing.Size(100, 40);
            this.btnTietoja.MinimumSize = new System.Drawing.Size(100, 40);
            this.btnTietoja.Name = "btnTietoja";
            this.btnTietoja.Size = new System.Drawing.Size(100, 40);
            this.btnTietoja.TabIndex = 2;
            this.btnTietoja.Text = "Tietoja";
            this.btnTietoja.UseVisualStyleBackColor = false;
            this.btnTietoja.Click += new System.EventHandler(this.btnTietoja_Click);
            // 
            // btnPoistu
            // 
            this.btnPoistu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPoistu.Location = new System.Drawing.Point(200, 250);
            this.btnPoistu.MaximumSize = new System.Drawing.Size(100, 40);
            this.btnPoistu.MinimumSize = new System.Drawing.Size(100, 40);
            this.btnPoistu.Name = "btnPoistu";
            this.btnPoistu.Size = new System.Drawing.Size(100, 40);
            this.btnPoistu.TabIndex = 3;
            this.btnPoistu.Text = "Poistu";
            this.btnPoistu.UseVisualStyleBackColor = false;
            this.btnPoistu.Click += new System.EventHandler(this.btnPoistu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btnPoistu);
            this.Controls.Add(this.btnTietoja);
            this.Controls.Add(this.btnTilastot);
            this.Controls.Add(this.btnUusiPeli);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ristinolla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUusiPeli;
        private System.Windows.Forms.Button btnTilastot;
        private System.Windows.Forms.Button btnTietoja;
        private System.Windows.Forms.Button btnPoistu;
    }
}