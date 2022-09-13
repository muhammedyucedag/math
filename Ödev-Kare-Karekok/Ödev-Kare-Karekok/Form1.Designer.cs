namespace Ödev_Kare_Karekok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnKarekök = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblKaresi = new System.Windows.Forms.Label();
            this.btnKare = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSonuç = new System.Windows.Forms.TextBox();
            this.txtÜs = new System.Windows.Forms.TextBox();
            this.txtTaban = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(845, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(269, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matematik Sözlüğü";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 124);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnKarekök);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtSonuç);
            this.groupBox1.Controls.Add(this.LblKaresi);
            this.groupBox1.Controls.Add(this.txtÜs);
            this.groupBox1.Controls.Add(this.txtTaban);
            this.groupBox1.Controls.Add(this.btnKare);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(14, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 250);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayının Karesi ve Karekökü";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHesapla.Location = new System.Drawing.Point(843, 107);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(97, 29);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnKarekök
            // 
            this.btnKarekök.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKarekök.ForeColor = System.Drawing.Color.White;
            this.btnKarekök.Location = new System.Drawing.Point(447, 157);
            this.btnKarekök.Name = "btnKarekök";
            this.btnKarekök.Size = new System.Drawing.Size(127, 26);
            this.btnKarekök.TabIndex = 7;
            this.btnKarekök.Text = "Karekökünü Al";
            this.btnKarekök.UseVisualStyleBackColor = false;
            this.btnKarekök.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 26);
            this.textBox2.TabIndex = 6;
            // 
            // LblKaresi
            // 
            this.LblKaresi.AutoSize = true;
            this.LblKaresi.Location = new System.Drawing.Point(23, 74);
            this.LblKaresi.Name = "LblKaresi";
            this.LblKaresi.Size = new System.Drawing.Size(282, 18);
            this.LblKaresi.TabIndex = 4;
            this.LblKaresi.Text = "Karesini Almak İstediğiniz Sayıyı Giriniz:";
            // 
            // btnKare
            // 
            this.btnKare.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKare.ForeColor = System.Drawing.Color.White;
            this.btnKare.Location = new System.Drawing.Point(421, 71);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(104, 26);
            this.btnKare.TabIndex = 3;
            this.btnKare.Text = "Karesini Al";
            this.btnKare.UseVisualStyleBackColor = false;
            this.btnKare.Click += new System.EventHandler(this.BtnKare_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(23, 160);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(310, 18);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "KareKökünü Almak İstediğiniz Sayıyı Giriniz:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(607, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sonuç:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(632, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Üs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(609, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Taban:";
            // 
            // txtSonuç
            // 
            this.txtSonuç.Location = new System.Drawing.Point(672, 169);
            this.txtSonuç.Name = "txtSonuç";
            this.txtSonuç.Size = new System.Drawing.Size(140, 26);
            this.txtSonuç.TabIndex = 16;
            // 
            // txtÜs
            // 
            this.txtÜs.Location = new System.Drawing.Point(672, 110);
            this.txtÜs.Name = "txtÜs";
            this.txtÜs.Size = new System.Drawing.Size(140, 26);
            this.txtÜs.TabIndex = 15;
            // 
            // txtTaban
            // 
            this.txtTaban.Location = new System.Drawing.Point(672, 51);
            this.txtTaban.Name = "txtTaban";
            this.txtTaban.Size = new System.Drawing.Size(140, 26);
            this.txtTaban.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKarekök;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblKaresi;
        private System.Windows.Forms.Button btnKare;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSonuç;
        private System.Windows.Forms.TextBox txtÜs;
        private System.Windows.Forms.TextBox txtTaban;
    }
}

