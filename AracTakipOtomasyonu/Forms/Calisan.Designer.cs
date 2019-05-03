namespace AracTakipOtomasyonu
{
    partial class Calisan
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
            this.lbl_KiralananAraclarListesi = new System.Windows.Forms.Label();
            this.lbl_MusteriListesi = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriÖzlükBilgileriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgileriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçKiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniAraçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniAraçEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_AracListesi = new System.Windows.Forms.Label();
            this.btn_AracListele = new System.Windows.Forms.Button();
            this.btn_MusteriListele = new System.Windows.Forms.Button();
            this.btn_KiralananAraclar = new System.Windows.Forms.Button();
            this.dt_AracListele = new System.Windows.Forms.DataGridView();
            this.dt_MusteriListele = new System.Windows.Forms.DataGridView();
            this.dt_KiralananAraclar = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_AracListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_MusteriListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KiralananAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_KiralananAraclarListesi
            // 
            this.lbl_KiralananAraclarListesi.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KiralananAraclarListesi.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_KiralananAraclarListesi.Location = new System.Drawing.Point(12, 417);
            this.lbl_KiralananAraclarListesi.Name = "lbl_KiralananAraclarListesi";
            this.lbl_KiralananAraclarListesi.Size = new System.Drawing.Size(250, 26);
            this.lbl_KiralananAraclarListesi.TabIndex = 1;
            this.lbl_KiralananAraclarListesi.Text = "Kiralanan Araçlar:";
            // 
            // lbl_MusteriListesi
            // 
            this.lbl_MusteriListesi.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_MusteriListesi.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_MusteriListesi.Location = new System.Drawing.Point(684, 109);
            this.lbl_MusteriListesi.Name = "lbl_MusteriListesi";
            this.lbl_MusteriListesi.Size = new System.Drawing.Size(250, 26);
            this.lbl_MusteriListesi.TabIndex = 1;
            this.lbl_MusteriListesi.Text = "Müşteriler Listesi:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriÖzlükBilgileriEkleToolStripMenuItem,
            this.araçKiralamaToolStripMenuItem,
            this.yeniAraçEkleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1398, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriÖzlükBilgileriEkleToolStripMenuItem
            // 
            this.müşteriÖzlükBilgileriEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriEkleToolStripMenuItem,
            this.müşteriBilgileriGüncelleToolStripMenuItem});
            this.müşteriÖzlükBilgileriEkleToolStripMenuItem.Name = "müşteriÖzlükBilgileriEkleToolStripMenuItem";
            this.müşteriÖzlükBilgileriEkleToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.müşteriÖzlükBilgileriEkleToolStripMenuItem.Text = "Müşteri Özlük Bilgileri Ekle";
            // 
            // yeniMüşteriEkleToolStripMenuItem
            // 
            this.yeniMüşteriEkleToolStripMenuItem.Name = "yeniMüşteriEkleToolStripMenuItem";
            this.yeniMüşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.yeniMüşteriEkleToolStripMenuItem.Text = "Yeni Müşteri Ekle";
            this.yeniMüşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniMüşteriEkleToolStripMenuItem_Click);
            // 
            // müşteriBilgileriGüncelleToolStripMenuItem
            // 
            this.müşteriBilgileriGüncelleToolStripMenuItem.Name = "müşteriBilgileriGüncelleToolStripMenuItem";
            this.müşteriBilgileriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.müşteriBilgileriGüncelleToolStripMenuItem.Text = "Müşteri Bilgileri Güncelle";
            this.müşteriBilgileriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.müşteriBilgileriGüncelleToolStripMenuItem_Click);
            // 
            // araçKiralamaToolStripMenuItem
            // 
            this.araçKiralamaToolStripMenuItem.Name = "araçKiralamaToolStripMenuItem";
            this.araçKiralamaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.araçKiralamaToolStripMenuItem.Text = "Araç Kiralama";
            this.araçKiralamaToolStripMenuItem.Click += new System.EventHandler(this.araçKiralamaToolStripMenuItem_Click);
            // 
            // yeniAraçEkleToolStripMenuItem
            // 
            this.yeniAraçEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniAraçEkleToolStripMenuItem1});
            this.yeniAraçEkleToolStripMenuItem.Name = "yeniAraçEkleToolStripMenuItem";
            this.yeniAraçEkleToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.yeniAraçEkleToolStripMenuItem.Text = "Yeni Araç";
            // 
            // yeniAraçEkleToolStripMenuItem1
            // 
            this.yeniAraçEkleToolStripMenuItem1.Name = "yeniAraçEkleToolStripMenuItem1";
            this.yeniAraçEkleToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.yeniAraçEkleToolStripMenuItem1.Text = "Yeni Araç Ekle";
            this.yeniAraçEkleToolStripMenuItem1.Click += new System.EventHandler(this.yeniAraçEkleToolStripMenuItem1_Click);
            // 
            // lbl_AracListesi
            // 
            this.lbl_AracListesi.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AracListesi.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_AracListesi.Location = new System.Drawing.Point(12, 109);
            this.lbl_AracListesi.Name = "lbl_AracListesi";
            this.lbl_AracListesi.Size = new System.Drawing.Size(250, 26);
            this.lbl_AracListesi.TabIndex = 1;
            this.lbl_AracListesi.Text = "Araç Listesi:";
            // 
            // btn_AracListele
            // 
            this.btn_AracListele.Location = new System.Drawing.Point(187, 109);
            this.btn_AracListele.Name = "btn_AracListele";
            this.btn_AracListele.Size = new System.Drawing.Size(359, 23);
            this.btn_AracListele.TabIndex = 5;
            this.btn_AracListele.Text = "Araç Listele";
            this.btn_AracListele.UseVisualStyleBackColor = true;
            this.btn_AracListele.Click += new System.EventHandler(this.btn_AracListele_Click);
            // 
            // btn_MusteriListele
            // 
            this.btn_MusteriListele.Location = new System.Drawing.Point(865, 109);
            this.btn_MusteriListele.Name = "btn_MusteriListele";
            this.btn_MusteriListele.Size = new System.Drawing.Size(359, 23);
            this.btn_MusteriListele.TabIndex = 6;
            this.btn_MusteriListele.Text = "Müşteri Listele";
            this.btn_MusteriListele.UseVisualStyleBackColor = true;
            this.btn_MusteriListele.Click += new System.EventHandler(this.btn_MusteriListele_Click);
            // 
            // btn_KiralananAraclar
            // 
            this.btn_KiralananAraclar.Location = new System.Drawing.Point(205, 419);
            this.btn_KiralananAraclar.Name = "btn_KiralananAraclar";
            this.btn_KiralananAraclar.Size = new System.Drawing.Size(359, 23);
            this.btn_KiralananAraclar.TabIndex = 7;
            this.btn_KiralananAraclar.Text = "Kiralık Araçları Listele";
            this.btn_KiralananAraclar.UseVisualStyleBackColor = true;
            this.btn_KiralananAraclar.Click += new System.EventHandler(this.btn_KiralananAraclar_Click);
            // 
            // dt_AracListele
            // 
            this.dt_AracListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_AracListele.Location = new System.Drawing.Point(12, 149);
            this.dt_AracListele.Name = "dt_AracListele";
            this.dt_AracListele.ReadOnly = true;
            this.dt_AracListele.Size = new System.Drawing.Size(613, 237);
            this.dt_AracListele.TabIndex = 8;
            // 
            // dt_MusteriListele
            // 
            this.dt_MusteriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_MusteriListele.Location = new System.Drawing.Point(688, 149);
            this.dt_MusteriListele.Name = "dt_MusteriListele";
            this.dt_MusteriListele.ReadOnly = true;
            this.dt_MusteriListele.Size = new System.Drawing.Size(649, 237);
            this.dt_MusteriListele.TabIndex = 9;
            // 
            // dt_KiralananAraclar
            // 
            this.dt_KiralananAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_KiralananAraclar.Location = new System.Drawing.Point(12, 464);
            this.dt_KiralananAraclar.Name = "dt_KiralananAraclar";
            this.dt_KiralananAraclar.ReadOnly = true;
            this.dt_KiralananAraclar.Size = new System.Drawing.Size(632, 266);
            this.dt_KiralananAraclar.TabIndex = 10;
            // 
            // Calisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 789);
            this.Controls.Add(this.dt_KiralananAraclar);
            this.Controls.Add(this.dt_MusteriListele);
            this.Controls.Add(this.dt_AracListele);
            this.Controls.Add(this.btn_KiralananAraclar);
            this.Controls.Add(this.btn_MusteriListele);
            this.Controls.Add(this.btn_AracListele);
            this.Controls.Add(this.lbl_AracListesi);
            this.Controls.Add(this.lbl_MusteriListesi);
            this.Controls.Add(this.lbl_KiralananAraclarListesi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calisan";
            this.Text = "Calisan";
            this.Load += new System.EventHandler(this.Calisan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_AracListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_MusteriListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KiralananAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KiralananAraclarListesi;
        private System.Windows.Forms.Label lbl_MusteriListesi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriÖzlükBilgileriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçKiralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniAraçEkleToolStripMenuItem;
        private System.Windows.Forms.Label lbl_AracListesi;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniAraçEkleToolStripMenuItem1;
        private System.Windows.Forms.Button btn_AracListele;
        private System.Windows.Forms.Button btn_MusteriListele;
        private System.Windows.Forms.Button btn_KiralananAraclar;
        private System.Windows.Forms.DataGridView dt_AracListele;
        private System.Windows.Forms.DataGridView dt_MusteriListele;
        private System.Windows.Forms.DataGridView dt_KiralananAraclar;
    }
}