namespace AracTakipOtomasyonu.Forms
{
    partial class MusteriEkle
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
            this.txt_MusAd = new System.Windows.Forms.TextBox();
            this.txt_MusSoyAd = new System.Windows.Forms.TextBox();
            this.txt_MusEhliyetNo = new System.Windows.Forms.TextBox();
            this.txt_TcNo = new System.Windows.Forms.TextBox();
            this.txt_MusEmail = new System.Windows.Forms.TextBox();
            this.txt_MusTel = new System.Windows.Forms.TextBox();
            this.btn_MusEkle = new System.Windows.Forms.Button();
            this.lblMusAd = new System.Windows.Forms.Label();
            this.lblMusEhliyetNo = new System.Windows.Forms.Label();
            this.lblMusSoyad = new System.Windows.Forms.Label();
            this.lblMusEMail = new System.Windows.Forms.Label();
            this.lblMusTCNo = new System.Windows.Forms.Label();
            this.lblMusTelNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_MusAd
            // 
            this.txt_MusAd.Location = new System.Drawing.Point(256, 56);
            this.txt_MusAd.Name = "txt_MusAd";
            this.txt_MusAd.Size = new System.Drawing.Size(294, 20);
            this.txt_MusAd.TabIndex = 0;
            // 
            // txt_MusSoyAd
            // 
            this.txt_MusSoyAd.Location = new System.Drawing.Point(256, 103);
            this.txt_MusSoyAd.Name = "txt_MusSoyAd";
            this.txt_MusSoyAd.Size = new System.Drawing.Size(294, 20);
            this.txt_MusSoyAd.TabIndex = 1;
            // 
            // txt_MusEhliyetNo
            // 
            this.txt_MusEhliyetNo.Location = new System.Drawing.Point(256, 148);
            this.txt_MusEhliyetNo.Name = "txt_MusEhliyetNo";
            this.txt_MusEhliyetNo.Size = new System.Drawing.Size(294, 20);
            this.txt_MusEhliyetNo.TabIndex = 2;
            // 
            // txt_TcNo
            // 
            this.txt_TcNo.Location = new System.Drawing.Point(256, 197);
            this.txt_TcNo.Name = "txt_TcNo";
            this.txt_TcNo.Size = new System.Drawing.Size(294, 20);
            this.txt_TcNo.TabIndex = 3;
            // 
            // txt_MusEmail
            // 
            this.txt_MusEmail.Location = new System.Drawing.Point(256, 284);
            this.txt_MusEmail.Name = "txt_MusEmail";
            this.txt_MusEmail.Size = new System.Drawing.Size(294, 20);
            this.txt_MusEmail.TabIndex = 4;
            // 
            // txt_MusTel
            // 
            this.txt_MusTel.Location = new System.Drawing.Point(256, 240);
            this.txt_MusTel.Name = "txt_MusTel";
            this.txt_MusTel.Size = new System.Drawing.Size(294, 20);
            this.txt_MusTel.TabIndex = 5;
            // 
            // btn_MusEkle
            // 
            this.btn_MusEkle.Location = new System.Drawing.Point(297, 332);
            this.btn_MusEkle.Name = "btn_MusEkle";
            this.btn_MusEkle.Size = new System.Drawing.Size(218, 23);
            this.btn_MusEkle.TabIndex = 6;
            this.btn_MusEkle.Text = "Müşteri Ekle";
            this.btn_MusEkle.UseVisualStyleBackColor = true;
            this.btn_MusEkle.Click += new System.EventHandler(this.btn_MusEkle_Click);
            // 
            // lblMusAd
            // 
            this.lblMusAd.AutoSize = true;
            this.lblMusAd.Location = new System.Drawing.Point(71, 59);
            this.lblMusAd.Name = "lblMusAd";
            this.lblMusAd.Size = new System.Drawing.Size(98, 13);
            this.lblMusAd.TabIndex = 7;
            this.lblMusAd.Text = "Müşteri Adını Giriniz";
            // 
            // lblMusEhliyetNo
            // 
            this.lblMusEhliyetNo.AutoSize = true;
            this.lblMusEhliyetNo.Location = new System.Drawing.Point(71, 151);
            this.lblMusEhliyetNo.Name = "lblMusEhliyetNo";
            this.lblMusEhliyetNo.Size = new System.Drawing.Size(161, 13);
            this.lblMusEhliyetNo.TabIndex = 8;
            this.lblMusEhliyetNo.Text = "Müşteri Ehliyet Numarasını Giriniz";
            // 
            // lblMusSoyad
            // 
            this.lblMusSoyad.AutoSize = true;
            this.lblMusSoyad.Location = new System.Drawing.Point(71, 106);
            this.lblMusSoyad.Name = "lblMusSoyad";
            this.lblMusSoyad.Size = new System.Drawing.Size(115, 13);
            this.lblMusSoyad.TabIndex = 9;
            this.lblMusSoyad.Text = "Müşteri Soyadını Giriniz";
            // 
            // lblMusEMail
            // 
            this.lblMusEMail.AutoSize = true;
            this.lblMusEMail.Location = new System.Drawing.Point(71, 287);
            this.lblMusEMail.Name = "lblMusEMail";
            this.lblMusEMail.Size = new System.Drawing.Size(104, 13);
            this.lblMusEMail.TabIndex = 10;
            this.lblMusEMail.Text = "Müşteri E-Mail Giriniz";
            // 
            // lblMusTCNo
            // 
            this.lblMusTCNo.AutoSize = true;
            this.lblMusTCNo.Location = new System.Drawing.Point(71, 200);
            this.lblMusTCNo.Name = "lblMusTCNo";
            this.lblMusTCNo.Size = new System.Drawing.Size(106, 13);
            this.lblMusTCNo.TabIndex = 11;
            this.lblMusTCNo.Text = "Müşteri TC No Giriniz";
            // 
            // lblMusTelNo
            // 
            this.lblMusTelNo.AutoSize = true;
            this.lblMusTelNo.Location = new System.Drawing.Point(71, 243);
            this.lblMusTelNo.Name = "lblMusTelNo";
            this.lblMusTelNo.Size = new System.Drawing.Size(166, 13);
            this.lblMusTelNo.TabIndex = 12;
            this.lblMusTelNo.Text = "Müşteri Telefon Numarasını Giriniz";
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMusTelNo);
            this.Controls.Add(this.lblMusTCNo);
            this.Controls.Add(this.lblMusEMail);
            this.Controls.Add(this.lblMusSoyad);
            this.Controls.Add(this.lblMusEhliyetNo);
            this.Controls.Add(this.lblMusAd);
            this.Controls.Add(this.btn_MusEkle);
            this.Controls.Add(this.txt_MusTel);
            this.Controls.Add(this.txt_MusEmail);
            this.Controls.Add(this.txt_TcNo);
            this.Controls.Add(this.txt_MusEhliyetNo);
            this.Controls.Add(this.txt_MusSoyAd);
            this.Controls.Add(this.txt_MusAd);
            this.Name = "MusteriEkle";
            this.Text = "MusteriEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MusAd;
        private System.Windows.Forms.TextBox txt_MusSoyAd;
        private System.Windows.Forms.TextBox txt_MusEhliyetNo;
        private System.Windows.Forms.TextBox txt_TcNo;
        private System.Windows.Forms.TextBox txt_MusEmail;
        private System.Windows.Forms.TextBox txt_MusTel;
        private System.Windows.Forms.Button btn_MusEkle;
        private System.Windows.Forms.Label lblMusAd;
        private System.Windows.Forms.Label lblMusEhliyetNo;
        private System.Windows.Forms.Label lblMusSoyad;
        private System.Windows.Forms.Label lblMusEMail;
        private System.Windows.Forms.Label lblMusTCNo;
        private System.Windows.Forms.Label lblMusTelNo;
    }
}