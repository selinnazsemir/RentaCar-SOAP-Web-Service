namespace AracTakipOtomasyonu.Forms
{
    partial class CalisanAracKiralama
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
            this.dt_AracListele = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_AracKirala = new System.Windows.Forms.Button();
            this.cmb_FirmaSec = new System.Windows.Forms.ComboBox();
            this.cmb_MusSec = new System.Windows.Forms.ComboBox();
            this.lblMusteriSec = new System.Windows.Forms.Label();
            this.lblFirmaSec = new System.Windows.Forms.Label();
            this.lblKiralamaBaslangic = new System.Windows.Forms.Label();
            this.lblKiralamaBitis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_AracListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_AracListele
            // 
            this.dt_AracListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_AracListele.Location = new System.Drawing.Point(12, 12);
            this.dt_AracListele.Name = "dt_AracListele";
            this.dt_AracListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_AracListele.Size = new System.Drawing.Size(1400, 390);
            this.dt_AracListele.TabIndex = 0;
            this.dt_AracListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_AracListele_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 562);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(461, 619);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(295, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // btn_AracKirala
            // 
            this.btn_AracKirala.Location = new System.Drawing.Point(410, 703);
            this.btn_AracKirala.Name = "btn_AracKirala";
            this.btn_AracKirala.Size = new System.Drawing.Size(407, 53);
            this.btn_AracKirala.TabIndex = 10;
            this.btn_AracKirala.Text = "Araç Kirala";
            this.btn_AracKirala.UseVisualStyleBackColor = true;
            this.btn_AracKirala.Click += new System.EventHandler(this.btn_AracKirala_Click);
            // 
            // cmb_FirmaSec
            // 
            this.cmb_FirmaSec.FormattingEnabled = true;
            this.cmb_FirmaSec.Location = new System.Drawing.Point(461, 507);
            this.cmb_FirmaSec.Name = "cmb_FirmaSec";
            this.cmb_FirmaSec.Size = new System.Drawing.Size(295, 21);
            this.cmb_FirmaSec.TabIndex = 11;
            // 
            // cmb_MusSec
            // 
            this.cmb_MusSec.FormattingEnabled = true;
            this.cmb_MusSec.Location = new System.Drawing.Point(461, 456);
            this.cmb_MusSec.Name = "cmb_MusSec";
            this.cmb_MusSec.Size = new System.Drawing.Size(295, 21);
            this.cmb_MusSec.TabIndex = 12;
            // 
            // lblMusteriSec
            // 
            this.lblMusteriSec.AutoSize = true;
            this.lblMusteriSec.Location = new System.Drawing.Point(321, 464);
            this.lblMusteriSec.Name = "lblMusteriSec";
            this.lblMusteriSec.Size = new System.Drawing.Size(78, 13);
            this.lblMusteriSec.TabIndex = 13;
            this.lblMusteriSec.Text = "Müşteri Seçiniz";
            this.lblMusteriSec.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirmaSec
            // 
            this.lblFirmaSec.AutoSize = true;
            this.lblFirmaSec.Location = new System.Drawing.Point(321, 510);
            this.lblFirmaSec.Name = "lblFirmaSec";
            this.lblFirmaSec.Size = new System.Drawing.Size(69, 13);
            this.lblFirmaSec.TabIndex = 14;
            this.lblFirmaSec.Text = "Firma Seçiniz";
            // 
            // lblKiralamaBaslangic
            // 
            this.lblKiralamaBaslangic.AutoSize = true;
            this.lblKiralamaBaslangic.Location = new System.Drawing.Point(274, 568);
            this.lblKiralamaBaslangic.Name = "lblKiralamaBaslangic";
            this.lblKiralamaBaslangic.Size = new System.Drawing.Size(170, 13);
            this.lblKiralamaBaslangic.TabIndex = 15;
            this.lblKiralamaBaslangic.Text = "Kiralama Başlangıç Tarihini Seçiniz";
            // 
            // lblKiralamaBitis
            // 
            this.lblKiralamaBitis.AutoSize = true;
            this.lblKiralamaBitis.Location = new System.Drawing.Point(289, 625);
            this.lblKiralamaBitis.Name = "lblKiralamaBitis";
            this.lblKiralamaBitis.Size = new System.Drawing.Size(143, 13);
            this.lblKiralamaBitis.TabIndex = 16;
            this.lblKiralamaBitis.Text = "Kiralama Bitiş Tarihini Seçiniz";
            // 
            // CalisanAracKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 791);
            this.Controls.Add(this.lblKiralamaBitis);
            this.Controls.Add(this.lblKiralamaBaslangic);
            this.Controls.Add(this.lblFirmaSec);
            this.Controls.Add(this.lblMusteriSec);
            this.Controls.Add(this.cmb_MusSec);
            this.Controls.Add(this.cmb_FirmaSec);
            this.Controls.Add(this.btn_AracKirala);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dt_AracListele);
            this.Name = "CalisanAracKiralama";
            this.Text = "CalisanAracKiralama";
            this.Load += new System.EventHandler(this.CalisanAracKiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_AracListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_AracListele;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_AracKirala;
        private System.Windows.Forms.ComboBox cmb_FirmaSec;
        private System.Windows.Forms.ComboBox cmb_MusSec;
        private System.Windows.Forms.Label lblMusteriSec;
        private System.Windows.Forms.Label lblFirmaSec;
        private System.Windows.Forms.Label lblKiralamaBaslangic;
        private System.Windows.Forms.Label lblKiralamaBitis;
    }
}