namespace TelefonRehberi
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
            this.numaraEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewNumaralar = new System.Windows.Forms.DataGridView();
            this.C_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Numara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seciliNumarayiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seciliNumarayiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumaralar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numaraEkleToolStripMenuItem,
            this.seciliNumarayiSilToolStripMenuItem,
            this.seciliNumarayiGuncelleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // numaraEkleToolStripMenuItem
            // 
            this.numaraEkleToolStripMenuItem.Name = "numaraEkleToolStripMenuItem";
            this.numaraEkleToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.numaraEkleToolStripMenuItem.Text = "Numara Ekle";
            this.numaraEkleToolStripMenuItem.Click += new System.EventHandler(this.numaraEkleToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewNumaralar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 681);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlı Numaralar";
            // 
            // dataGridViewNumaralar
            // 
            this.dataGridViewNumaralar.AllowUserToAddRows = false;
            this.dataGridViewNumaralar.AllowUserToDeleteRows = false;
            this.dataGridViewNumaralar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNumaralar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumaralar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Id,
            this.C_AdSoyad,
            this.c_Email,
            this.c_Numara});
            this.dataGridViewNumaralar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNumaralar.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNumaralar.Name = "dataGridViewNumaralar";
            this.dataGridViewNumaralar.ReadOnly = true;
            this.dataGridViewNumaralar.Size = new System.Drawing.Size(1009, 662);
            this.dataGridViewNumaralar.TabIndex = 0;
            // 
            // C_Id
            // 
            this.C_Id.HeaderText = "Id";
            this.C_Id.Name = "C_Id";
            this.C_Id.ReadOnly = true;
            this.C_Id.Visible = false;
            // 
            // C_AdSoyad
            // 
            this.C_AdSoyad.HeaderText = "Ad Soyad";
            this.C_AdSoyad.Name = "C_AdSoyad";
            this.C_AdSoyad.ReadOnly = true;
            // 
            // c_Email
            // 
            this.c_Email.HeaderText = "Mail";
            this.c_Email.Name = "c_Email";
            this.c_Email.ReadOnly = true;
            // 
            // c_Numara
            // 
            this.c_Numara.HeaderText = "Telefon Numarası";
            this.c_Numara.Name = "c_Numara";
            this.c_Numara.ReadOnly = true;
            // 
            // seciliNumarayiSilToolStripMenuItem
            // 
            this.seciliNumarayiSilToolStripMenuItem.Name = "seciliNumarayiSilToolStripMenuItem";
            this.seciliNumarayiSilToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.seciliNumarayiSilToolStripMenuItem.Text = "Seçili Numarayı Sil";
            this.seciliNumarayiSilToolStripMenuItem.Click += new System.EventHandler(this.seciliNumarayiSilToolStripMenuItem_Click);
            // 
            // seciliNumarayiGuncelleToolStripMenuItem
            // 
            this.seciliNumarayiGuncelleToolStripMenuItem.Name = "seciliNumarayiGuncelleToolStripMenuItem";
            this.seciliNumarayiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.seciliNumarayiGuncelleToolStripMenuItem.Text = "Seçili Numarayı Güncelle";
            this.seciliNumarayiGuncelleToolStripMenuItem.Click += new System.EventHandler(this.seciliNumarayiGuncelleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 705);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumaralar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem numaraEkleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewNumaralar;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Numara;
        private System.Windows.Forms.ToolStripMenuItem seciliNumarayiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seciliNumarayiGuncelleToolStripMenuItem;
    }
}

