namespace AracTakipOtomasyonu.Forms
{
    partial class CalisanMusteriGüncelle
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
            this.txt_MusteriTelNo = new System.Windows.Forms.TextBox();
            this.btn_MusteriGuncelle = new System.Windows.Forms.Button();
            this.txt_MusteriEhliyetNo = new System.Windows.Forms.TextBox();
            this.txt_MusteriSoyad = new System.Windows.Forms.TextBox();
            this.txt_MusteriAd = new System.Windows.Forms.TextBox();
            this.dt_MusterileriGor = new System.Windows.Forms.DataGridView();
            this.txt_MusteriEmail = new System.Windows.Forms.TextBox();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblEhliyetNo = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_MusterileriGor)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MusteriTelNo
            // 
            this.txt_MusteriTelNo.Location = new System.Drawing.Point(26, 182);
            this.txt_MusteriTelNo.Name = "txt_MusteriTelNo";
            this.txt_MusteriTelNo.Size = new System.Drawing.Size(271, 20);
            this.txt_MusteriTelNo.TabIndex = 18;
            // 
            // btn_MusteriGuncelle
            // 
            this.btn_MusteriGuncelle.Location = new System.Drawing.Point(57, 276);
            this.btn_MusteriGuncelle.Name = "btn_MusteriGuncelle";
            this.btn_MusteriGuncelle.Size = new System.Drawing.Size(202, 23);
            this.btn_MusteriGuncelle.TabIndex = 17;
            this.btn_MusteriGuncelle.Text = "Müşteri Bilgilerini Güncelle";
            this.btn_MusteriGuncelle.UseVisualStyleBackColor = true;
            this.btn_MusteriGuncelle.Click += new System.EventHandler(this.btn_MusteriGuncelle_Click);
            // 
            // txt_MusteriEhliyetNo
            // 
            this.txt_MusteriEhliyetNo.Location = new System.Drawing.Point(26, 136);
            this.txt_MusteriEhliyetNo.Name = "txt_MusteriEhliyetNo";
            this.txt_MusteriEhliyetNo.Size = new System.Drawing.Size(271, 20);
            this.txt_MusteriEhliyetNo.TabIndex = 15;
            // 
            // txt_MusteriSoyad
            // 
            this.txt_MusteriSoyad.Location = new System.Drawing.Point(26, 84);
            this.txt_MusteriSoyad.Name = "txt_MusteriSoyad";
            this.txt_MusteriSoyad.Size = new System.Drawing.Size(271, 20);
            this.txt_MusteriSoyad.TabIndex = 14;
            // 
            // txt_MusteriAd
            // 
            this.txt_MusteriAd.Location = new System.Drawing.Point(26, 32);
            this.txt_MusteriAd.Name = "txt_MusteriAd";
            this.txt_MusteriAd.Size = new System.Drawing.Size(271, 20);
            this.txt_MusteriAd.TabIndex = 13;
            // 
            // dt_MusterileriGor
            // 
            this.dt_MusterileriGor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_MusterileriGor.Location = new System.Drawing.Point(470, 12);
            this.dt_MusterileriGor.Name = "dt_MusterileriGor";
            this.dt_MusterileriGor.ReadOnly = true;
            this.dt_MusterileriGor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_MusterileriGor.Size = new System.Drawing.Size(304, 426);
            this.dt_MusterileriGor.TabIndex = 12;
            this.dt_MusterileriGor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_MusterileriGor_CellClick);
            // 
            // txt_MusteriEmail
            // 
            this.txt_MusteriEmail.Location = new System.Drawing.Point(26, 226);
            this.txt_MusteriEmail.Name = "txt_MusteriEmail";
            this.txt_MusteriEmail.Size = new System.Drawing.Size(271, 20);
            this.txt_MusteriEmail.TabIndex = 19;
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(352, 35);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(57, 13);
            this.lblMusteriAd.TabIndex = 20;
            this.lblMusteriAd.Text = "Müşteri Ad";
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Location = new System.Drawing.Point(352, 87);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(74, 13);
            this.lblMusteriSoyad.TabIndex = 21;
            this.lblMusteriSoyad.Text = "Müşteri Soyad";
            // 
            // lblEhliyetNo
            // 
            this.lblEhliyetNo.AutoSize = true;
            this.lblEhliyetNo.Location = new System.Drawing.Point(352, 139);
            this.lblEhliyetNo.Name = "lblEhliyetNo";
            this.lblEhliyetNo.Size = new System.Drawing.Size(55, 13);
            this.lblEhliyetNo.TabIndex = 22;
            this.lblEhliyetNo.Text = "Ehilyet No";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(352, 185);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(60, 13);
            this.lblTelNo.TabIndex = 23;
            this.lblTelNo.Text = "Telefon No";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(352, 229);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(36, 13);
            this.lblEMail.TabIndex = 24;
            this.lblEMail.Text = "E-Mail";
            // 
            // CalisanMusteriGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblEhliyetNo);
            this.Controls.Add(this.lblMusteriSoyad);
            this.Controls.Add(this.lblMusteriAd);
            this.Controls.Add(this.txt_MusteriEmail);
            this.Controls.Add(this.txt_MusteriTelNo);
            this.Controls.Add(this.btn_MusteriGuncelle);
            this.Controls.Add(this.txt_MusteriEhliyetNo);
            this.Controls.Add(this.txt_MusteriSoyad);
            this.Controls.Add(this.txt_MusteriAd);
            this.Controls.Add(this.dt_MusterileriGor);
            this.Name = "CalisanMusteriGüncelle";
            this.Text = "CalisanMusteriGüncelle";
            this.Load += new System.EventHandler(this.CalisanMusteriGüncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_MusterileriGor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MusteriTelNo;
        private System.Windows.Forms.Button btn_MusteriGuncelle;
        private System.Windows.Forms.TextBox txt_MusteriEhliyetNo;
        private System.Windows.Forms.TextBox txt_MusteriSoyad;
        private System.Windows.Forms.TextBox txt_MusteriAd;
        private System.Windows.Forms.DataGridView dt_MusterileriGor;
        private System.Windows.Forms.TextBox txt_MusteriEmail;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label lblEhliyetNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblEMail;
    }
}