namespace DövizUygulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDolaralis = new System.Windows.Forms.Label();
            this.lblEurosatis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEuroalis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDolarsatis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDövizal = new System.Windows.Forms.Button();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btndolaralis = new System.Windows.Forms.Button();
            this.btneuroalis = new System.Windows.Forms.Button();
            this.btndolarsatis = new System.Windows.Forms.Button();
            this.btneurosatis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // lblDolaralis
            // 
            this.lblDolaralis.AutoSize = true;
            this.lblDolaralis.Location = new System.Drawing.Point(137, 50);
            this.lblDolaralis.Name = "lblDolaralis";
            this.lblDolaralis.Size = new System.Drawing.Size(18, 20);
            this.lblDolaralis.TabIndex = 1;
            this.lblDolaralis.Text = "0";
            // 
            // lblEurosatis
            // 
            this.lblEurosatis.AutoSize = true;
            this.lblEurosatis.Location = new System.Drawing.Point(137, 182);
            this.lblEurosatis.Name = "lblEurosatis";
            this.lblEurosatis.Size = new System.Drawing.Size(18, 20);
            this.lblEurosatis.TabIndex = 3;
            this.lblEurosatis.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Euro Satış:";
            // 
            // lblEuroalis
            // 
            this.lblEuroalis.AutoSize = true;
            this.lblEuroalis.Location = new System.Drawing.Point(137, 137);
            this.lblEuroalis.Name = "lblEuroalis";
            this.lblEuroalis.Size = new System.Drawing.Size(18, 20);
            this.lblEuroalis.TabIndex = 5;
            this.lblEuroalis.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Euro Alış:";
            // 
            // lblDolarsatis
            // 
            this.lblDolarsatis.AutoSize = true;
            this.lblDolarsatis.Location = new System.Drawing.Point(137, 91);
            this.lblDolarsatis.Name = "lblDolarsatis";
            this.lblDolarsatis.Size = new System.Drawing.Size(18, 20);
            this.lblDolarsatis.TabIndex = 7;
            this.lblDolarsatis.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Dolar Satış:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnDövizal);
            this.groupBox1.Controls.Add(this.txtKalan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(374, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 318);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Paran Kadar Al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDövizal
            // 
            this.btnDövizal.Location = new System.Drawing.Point(58, 254);
            this.btnDövizal.Name = "btnDövizal";
            this.btnDövizal.Size = new System.Drawing.Size(77, 44);
            this.btnDövizal.TabIndex = 8;
            this.btnDövizal.Text = "Döviz Al";
            this.btnDövizal.UseVisualStyleBackColor = true;
            this.btnDövizal.Click += new System.EventHandler(this.btnDövizal_Click);
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(95, 205);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(220, 26);
            this.txtKalan.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kalan:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(95, 151);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(220, 26);
            this.txtTutar.TabIndex = 5;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(95, 97);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(220, 26);
            this.txtMiktar.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tutar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Miktar:";
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(95, 44);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(220, 26);
            this.txtKur.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kur:";
            // 
            // btndolaralis
            // 
            this.btndolaralis.Location = new System.Drawing.Point(193, 41);
            this.btndolaralis.Name = "btndolaralis";
            this.btndolaralis.Size = new System.Drawing.Size(57, 29);
            this.btndolaralis.TabIndex = 9;
            this.btndolaralis.Text = "AL";
            this.btndolaralis.UseVisualStyleBackColor = true;
            this.btndolaralis.Click += new System.EventHandler(this.btndolaralis_Click);
            // 
            // btneuroalis
            // 
            this.btneuroalis.Location = new System.Drawing.Point(193, 128);
            this.btneuroalis.Name = "btneuroalis";
            this.btneuroalis.Size = new System.Drawing.Size(57, 29);
            this.btneuroalis.TabIndex = 10;
            this.btneuroalis.Text = "AL";
            this.btneuroalis.UseVisualStyleBackColor = true;
            this.btneuroalis.Click += new System.EventHandler(this.btneuroalis_Click);
            // 
            // btndolarsatis
            // 
            this.btndolarsatis.Location = new System.Drawing.Point(193, 85);
            this.btndolarsatis.Name = "btndolarsatis";
            this.btndolarsatis.Size = new System.Drawing.Size(57, 29);
            this.btndolarsatis.TabIndex = 11;
            this.btndolarsatis.Text = "SAT";
            this.btndolarsatis.UseVisualStyleBackColor = true;
            this.btndolarsatis.Click += new System.EventHandler(this.btndolarsatis_Click);
            // 
            // btneurosatis
            // 
            this.btneurosatis.Location = new System.Drawing.Point(193, 173);
            this.btneurosatis.Name = "btneurosatis";
            this.btneurosatis.Size = new System.Drawing.Size(57, 29);
            this.btneurosatis.TabIndex = 12;
            this.btneurosatis.Text = "SAT";
            this.btneurosatis.UseVisualStyleBackColor = true;
            this.btneurosatis.Click += new System.EventHandler(this.btneurosatis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(998, 537);
            this.Controls.Add(this.btneurosatis);
            this.Controls.Add(this.btndolarsatis);
            this.Controls.Add(this.btneuroalis);
            this.Controls.Add(this.btndolaralis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDolarsatis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEuroalis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEurosatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDolaralis);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDolaralis;
        private System.Windows.Forms.Label lblEurosatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEuroalis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDolarsatis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDövizal;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.Button btndolaralis;
        private System.Windows.Forms.Button btneuroalis;
        private System.Windows.Forms.Button btndolarsatis;
        private System.Windows.Forms.Button btneurosatis;
    }
}

