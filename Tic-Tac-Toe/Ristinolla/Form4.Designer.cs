namespace Ristinolla
{
    partial class Form4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSeuraava = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSV = new System.Windows.Forms.TextBox();
            this.txtSK = new System.Windows.Forms.TextBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.txtSuku = new System.Windows.Forms.TextBox();
            this.txtEtu = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 550);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSeuraava);
            this.tabPage1.Controls.Add(this.btnPoista);
            this.tabPage1.Controls.Add(this.btnMuokkaa);
            this.tabPage1.Controls.Add(this.btnLisaa);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pelaajat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.Location = new System.Drawing.Point(394, 475);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(75, 40);
            this.btnSeuraava.TabIndex = 4;
            this.btnSeuraava.Text = "Seuraava";
            this.btnSeuraava.UseVisualStyleBackColor = true;
            this.btnSeuraava.Click += new System.EventHandler(this.btnSeuraava_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(168, 475);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 40);
            this.btnPoista.TabIndex = 3;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(87, 475);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 40);
            this.btnMuokkaa.TabIndex = 2;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(6, 475);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 40);
            this.btnLisaa.TabIndex = 1;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 442);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSV);
            this.tabPage2.Controls.Add(this.txtSK);
            this.tabPage2.Controls.Add(this.btnTallenna);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtSP);
            this.tabPage2.Controls.Add(this.txtSuku);
            this.tabPage2.Controls.Add(this.txtEtu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uusi Pelaaja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSV
            // 
            this.txtSV.Location = new System.Drawing.Point(238, 103);
            this.txtSV.Name = "txtSV";
            this.txtSV.Size = new System.Drawing.Size(60, 20);
            this.txtSV.TabIndex = 8;
            // 
            // txtSK
            // 
            this.txtSK.Location = new System.Drawing.Point(192, 103);
            this.txtSK.Name = "txtSK";
            this.txtSK.Size = new System.Drawing.Size(40, 20);
            this.txtSK.TabIndex = 7;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(391, 475);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(75, 40);
            this.btnTallenna.TabIndex = 6;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Syntymäaika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sukunimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Etunimi";
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(146, 103);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(40, 20);
            this.txtSP.TabIndex = 2;
            // 
            // txtSuku
            // 
            this.txtSuku.Location = new System.Drawing.Point(146, 61);
            this.txtSuku.Name = "txtSuku";
            this.txtSuku.Size = new System.Drawing.Size(150, 20);
            this.txtSuku.TabIndex = 1;
            // 
            // txtEtu
            // 
            this.txtEtu.Location = new System.Drawing.Point(146, 20);
            this.txtEtu.Name = "txtEtu";
            this.txtEtu.Size = new System.Drawing.Size(150, 20);
            this.txtEtu.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelaajien tiedot";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSeuraava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.TextBox txtSuku;
        private System.Windows.Forms.TextBox txtEtu;
        private System.Windows.Forms.TextBox txtSV;
        private System.Windows.Forms.TextBox txtSK;
        private System.Windows.Forms.Button btnTallenna;
    }
}