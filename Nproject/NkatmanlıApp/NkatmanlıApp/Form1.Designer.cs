namespace NkatmanlıApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Btn_Listele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Gorev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Sehir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Maas = new System.Windows.Forms.TextBox();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.Btn_Güncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID: ";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(55, 13);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(100, 20);
            this.Txt_Id.TabIndex = 2;
            // 
            // Btn_Listele
            // 
            this.Btn_Listele.Location = new System.Drawing.Point(333, 9);
            this.Btn_Listele.Name = "Btn_Listele";
            this.Btn_Listele.Size = new System.Drawing.Size(182, 24);
            this.Btn_Listele.TabIndex = 3;
            this.Btn_Listele.Text = "LİSTELE";
            this.Btn_Listele.UseVisualStyleBackColor = true;
            this.Btn_Listele.Click += new System.EventHandler(this.Btn_Listele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD: ";
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.Location = new System.Drawing.Point(55, 39);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Size = new System.Drawing.Size(100, 20);
            this.Txt_Ad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SOYAD: ";
            // 
            // Txt_Soyad
            // 
            this.Txt_Soyad.Location = new System.Drawing.Point(55, 65);
            this.Txt_Soyad.Name = "Txt_Soyad";
            this.Txt_Soyad.Size = new System.Drawing.Size(100, 20);
            this.Txt_Soyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "GÖREV :";
            // 
            // Txt_Gorev
            // 
            this.Txt_Gorev.Location = new System.Drawing.Point(227, 12);
            this.Txt_Gorev.Name = "Txt_Gorev";
            this.Txt_Gorev.Size = new System.Drawing.Size(100, 20);
            this.Txt_Gorev.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ŞEHİR :";
            // 
            // Txt_Sehir
            // 
            this.Txt_Sehir.Location = new System.Drawing.Point(227, 39);
            this.Txt_Sehir.Name = "Txt_Sehir";
            this.Txt_Sehir.Size = new System.Drawing.Size(100, 20);
            this.Txt_Sehir.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "MAAŞ :";
            // 
            // Txt_Maas
            // 
            this.Txt_Maas.Location = new System.Drawing.Point(227, 65);
            this.Txt_Maas.Name = "Txt_Maas";
            this.Txt_Maas.Size = new System.Drawing.Size(100, 20);
            this.Txt_Maas.TabIndex = 2;
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Location = new System.Drawing.Point(333, 52);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(182, 24);
            this.Btn_Ekle.TabIndex = 3;
            this.Btn_Ekle.Text = "EKLE";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Btn_Güncelle
            // 
            this.Btn_Güncelle.Location = new System.Drawing.Point(333, 109);
            this.Btn_Güncelle.Name = "Btn_Güncelle";
            this.Btn_Güncelle.Size = new System.Drawing.Size(182, 24);
            this.Btn_Güncelle.TabIndex = 3;
            this.Btn_Güncelle.Text = "GÜNCELLE";
            this.Btn_Güncelle.UseVisualStyleBackColor = true;
            this.Btn_Güncelle.Click += new System.EventHandler(this.Btn_Güncelle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Güncelle);
            this.Controls.Add(this.Btn_Ekle);
            this.Controls.Add(this.Btn_Listele);
            this.Controls.Add(this.Txt_Maas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Sehir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Gorev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Button Btn_Listele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Gorev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Sehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Maas;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.Button Btn_Güncelle;
        private System.Windows.Forms.Button button1;
    }
}

