
namespace homework2_1
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
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.mtbPersonelNo = new System.Windows.Forms.MaskedTextBox();
            this.mtbTcKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.btnPersonelCikart = new System.Windows.Forms.Button();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.lvlPersonelListele = new System.Windows.Forms.ListView();
            this.lblTcKimlikNoCikart = new System.Windows.Forms.Label();
            this.mtbTcKimlikNoCikart = new System.Windows.Forms.MaskedTextBox();
            this.gbPersonelCikartma = new System.Windows.Forms.GroupBox();
            this.gbPersonelEkleme = new System.Windows.Forms.GroupBox();
            this.gbPersonelCikartma.SuspendLayout();
            this.gbPersonelEkleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Location = new System.Drawing.Point(20, 33);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(95, 20);
            this.lblPersonelNo.TabIndex = 0;
            this.lblPersonelNo.Text = "Personel No";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(86, 68);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(29, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(62, 111);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(54, 20);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(161, 154);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(250, 26);
            this.txtBirim.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(161, 108);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(250, 26);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(161, 68);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(250, 26);
            this.txtAd.TabIndex = 7;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(161, 308);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(250, 32);
            this.btnPersonelEkle.TabIndex = 8;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Location = new System.Drawing.Point(51, 450);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(927, 31);
            this.btnPersonelListele.TabIndex = 9;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(19, 197);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(97, 20);
            this.lblTcKimlikNo.TabIndex = 10;
            this.lblTcKimlikNo.Text = "TC Kimlik No";
            // 
            // mtbPersonelNo
            // 
            this.mtbPersonelNo.Location = new System.Drawing.Point(161, 33);
            this.mtbPersonelNo.Mask = "0000000000000";
            this.mtbPersonelNo.Name = "mtbPersonelNo";
            this.mtbPersonelNo.Size = new System.Drawing.Size(250, 26);
            this.mtbPersonelNo.TabIndex = 11;
            // 
            // mtbTcKimlikNo
            // 
            this.mtbTcKimlikNo.Location = new System.Drawing.Point(161, 197);
            this.mtbTcKimlikNo.Mask = "00000000000";
            this.mtbTcKimlikNo.Name = "mtbTcKimlikNo";
            this.mtbTcKimlikNo.Size = new System.Drawing.Size(250, 26);
            this.mtbTcKimlikNo.TabIndex = 14;
            // 
            // btnPersonelCikart
            // 
            this.btnPersonelCikart.Location = new System.Drawing.Point(81, 143);
            this.btnPersonelCikart.Name = "btnPersonelCikart";
            this.btnPersonelCikart.Size = new System.Drawing.Size(250, 32);
            this.btnPersonelCikart.TabIndex = 17;
            this.btnPersonelCikart.Text = "Personel Cikart";
            this.btnPersonelCikart.UseVisualStyleBackColor = true;
            this.btnPersonelCikart.Click += new System.EventHandler(this.btnPersonelCikart_Click);
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(72, 154);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(44, 20);
            this.lblBirim.TabIndex = 19;
            this.lblBirim.Text = "Birim";
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Location = new System.Drawing.Point(24, 240);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(93, 20);
            this.lblDogumYeri.TabIndex = 21;
            this.lblDogumYeri.Text = "Dogum Yeri";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(161, 240);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(250, 26);
            this.txtDogumYeri.TabIndex = 23;
            // 
            // lvlPersonelListele
            // 
            this.lvlPersonelListele.HideSelection = false;
            this.lvlPersonelListele.Location = new System.Drawing.Point(50, 497);
            this.lvlPersonelListele.Name = "lvlPersonelListele";
            this.lvlPersonelListele.Size = new System.Drawing.Size(928, 325);
            this.lvlPersonelListele.TabIndex = 18;
            this.lvlPersonelListele.UseCompatibleStateImageBehavior = false;
            this.lvlPersonelListele.View = System.Windows.Forms.View.List;
            // 
            // lblTcKimlikNoCikart
            // 
            this.lblTcKimlikNoCikart.AutoSize = true;
            this.lblTcKimlikNoCikart.Location = new System.Drawing.Point(31, 99);
            this.lblTcKimlikNoCikart.Name = "lblTcKimlikNoCikart";
            this.lblTcKimlikNoCikart.Size = new System.Drawing.Size(97, 20);
            this.lblTcKimlikNoCikart.TabIndex = 25;
            this.lblTcKimlikNoCikart.Text = "TC Kimlik No";
            // 
            // mtbTcKimlikNoCikart
            // 
            this.mtbTcKimlikNoCikart.Location = new System.Drawing.Point(156, 96);
            this.mtbTcKimlikNoCikart.Mask = "00000000000";
            this.mtbTcKimlikNoCikart.Name = "mtbTcKimlikNoCikart";
            this.mtbTcKimlikNoCikart.Size = new System.Drawing.Size(248, 26);
            this.mtbTcKimlikNoCikart.TabIndex = 26;
            // 
            // gbPersonelCikartma
            // 
            this.gbPersonelCikartma.Controls.Add(this.btnPersonelCikart);
            this.gbPersonelCikartma.Controls.Add(this.lblTcKimlikNoCikart);
            this.gbPersonelCikartma.Controls.Add(this.mtbTcKimlikNoCikart);
            this.gbPersonelCikartma.Location = new System.Drawing.Point(550, 58);
            this.gbPersonelCikartma.Name = "gbPersonelCikartma";
            this.gbPersonelCikartma.Size = new System.Drawing.Size(429, 193);
            this.gbPersonelCikartma.TabIndex = 27;
            this.gbPersonelCikartma.TabStop = false;
            this.gbPersonelCikartma.Text = "Personel Cikartma Islemi";
            // 
            // gbPersonelEkleme
            // 
            this.gbPersonelEkleme.Controls.Add(this.lblAd);
            this.gbPersonelEkleme.Controls.Add(this.lblSoyad);
            this.gbPersonelEkleme.Controls.Add(this.txtDogumYeri);
            this.gbPersonelEkleme.Controls.Add(this.lblTcKimlikNo);
            this.gbPersonelEkleme.Controls.Add(this.lblDogumYeri);
            this.gbPersonelEkleme.Controls.Add(this.mtbTcKimlikNo);
            this.gbPersonelEkleme.Controls.Add(this.lblBirim);
            this.gbPersonelEkleme.Controls.Add(this.mtbPersonelNo);
            this.gbPersonelEkleme.Controls.Add(this.txtBirim);
            this.gbPersonelEkleme.Controls.Add(this.txtSoyad);
            this.gbPersonelEkleme.Controls.Add(this.txtAd);
            this.gbPersonelEkleme.Controls.Add(this.btnPersonelEkle);
            this.gbPersonelEkleme.Controls.Add(this.lblPersonelNo);
            this.gbPersonelEkleme.Location = new System.Drawing.Point(51, 58);
            this.gbPersonelEkleme.Name = "gbPersonelEkleme";
            this.gbPersonelEkleme.Size = new System.Drawing.Size(448, 357);
            this.gbPersonelEkleme.TabIndex = 28;
            this.gbPersonelEkleme.TabStop = false;
            this.gbPersonelEkleme.Text = "Personel Ekleme Islemi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1019, 840);
            this.Controls.Add(this.gbPersonelEkleme);
            this.Controls.Add(this.gbPersonelCikartma);
            this.Controls.Add(this.lvlPersonelListele);
            this.Controls.Add(this.btnPersonelListele);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrika Uygulamasi";
            this.gbPersonelCikartma.ResumeLayout(false);
            this.gbPersonelCikartma.PerformLayout();
            this.gbPersonelEkleme.ResumeLayout(false);
            this.gbPersonelEkleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.MaskedTextBox mtbPersonelNo;
        private System.Windows.Forms.MaskedTextBox mtbTcKimlikNo;
        private System.Windows.Forms.Button btnPersonelCikart;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.ListView lvlPersonelListele;
        private System.Windows.Forms.Label lblTcKimlikNoCikart;
        private System.Windows.Forms.MaskedTextBox mtbTcKimlikNoCikart;
        private System.Windows.Forms.GroupBox gbPersonelCikartma;
        private System.Windows.Forms.GroupBox gbPersonelEkleme;
    }
}

