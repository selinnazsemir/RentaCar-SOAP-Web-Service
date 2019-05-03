namespace AracTakipOtomasyonu.Forms
{
    partial class AracOzellikGor
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
            this.dt_AracOzGor = new System.Windows.Forms.DataGridView();
            this.btn_AracOzListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_AracOzGor)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_AracOzGor
            // 
            this.dt_AracOzGor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_AracOzGor.Location = new System.Drawing.Point(38, 31);
            this.dt_AracOzGor.Name = "dt_AracOzGor";
            this.dt_AracOzGor.ReadOnly = true;
            this.dt_AracOzGor.Size = new System.Drawing.Size(679, 281);
            this.dt_AracOzGor.TabIndex = 0;
            // 
            // btn_AracOzListele
            // 
            this.btn_AracOzListele.Location = new System.Drawing.Point(212, 351);
            this.btn_AracOzListele.Name = "btn_AracOzListele";
            this.btn_AracOzListele.Size = new System.Drawing.Size(276, 23);
            this.btn_AracOzListele.TabIndex = 1;
            this.btn_AracOzListele.Text = "Arac Özelliklerini Listele";
            this.btn_AracOzListele.UseVisualStyleBackColor = true;
            this.btn_AracOzListele.Click += new System.EventHandler(this.btn_AracOzListele_Click);
            // 
            // AracOzellikGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AracOzListele);
            this.Controls.Add(this.dt_AracOzGor);
            this.Name = "AracOzellikGor";
            this.Text = "AracOzellikGor";
            ((System.ComponentModel.ISupportInitialize)(this.dt_AracOzGor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_AracOzGor;
        private System.Windows.Forms.Button btn_AracOzListele;
    }
}