
namespace yigin_kuyruk
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_yigin_cikar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_yigin_durum = new System.Windows.Forms.TextBox();
            this.txb_yigin_ekle = new System.Windows.Forms.TextBox();
            this.btn_yigin_ekle = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.txb_kuyruk_durum = new System.Windows.Forms.TextBox();
            this.btn_kuyruk_cikar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_kuyruk_ekle = new System.Windows.Forms.TextBox();
            this.btn_kuyruk_ekle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tmr_kuyruk = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.txb_kuyruk_durum);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(934, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KUYRUK";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_yigin_cikar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txb_yigin_durum);
            this.tabPage2.Controls.Add(this.txb_yigin_ekle);
            this.tabPage2.Controls.Add(this.btn_yigin_ekle);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "YIĞIN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_yigin_cikar
            // 
            this.btn_yigin_cikar.Location = new System.Drawing.Point(512, 95);
            this.btn_yigin_cikar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_yigin_cikar.Name = "btn_yigin_cikar";
            this.btn_yigin_cikar.Size = new System.Drawing.Size(71, 55);
            this.btn_yigin_cikar.TabIndex = 18;
            this.btn_yigin_cikar.Text = "ÇIKAR";
            this.btn_yigin_cikar.UseVisualStyleBackColor = true;
            this.btn_yigin_cikar.Click += new System.EventHandler(this.btn_yigin_cikar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "YIĞIN DURUMU";
            // 
            // txb_yigin_durum
            // 
            this.txb_yigin_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_yigin_durum.Location = new System.Drawing.Point(383, 95);
            this.txb_yigin_durum.Margin = new System.Windows.Forms.Padding(2);
            this.txb_yigin_durum.Multiline = true;
            this.txb_yigin_durum.Name = "txb_yigin_durum";
            this.txb_yigin_durum.Size = new System.Drawing.Size(121, 225);
            this.txb_yigin_durum.TabIndex = 16;
            // 
            // txb_yigin_ekle
            // 
            this.txb_yigin_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_yigin_ekle.Location = new System.Drawing.Point(203, 95);
            this.txb_yigin_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.txb_yigin_ekle.Multiline = true;
            this.txb_yigin_ekle.Name = "txb_yigin_ekle";
            this.txb_yigin_ekle.Size = new System.Drawing.Size(87, 49);
            this.txb_yigin_ekle.TabIndex = 15;
            // 
            // btn_yigin_ekle
            // 
            this.btn_yigin_ekle.Location = new System.Drawing.Point(299, 95);
            this.btn_yigin_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_yigin_ekle.Name = "btn_yigin_ekle";
            this.btn_yigin_ekle.Size = new System.Drawing.Size(71, 55);
            this.btn_yigin_ekle.TabIndex = 14;
            this.btn_yigin_ekle.Text = "EKLE";
            this.btn_yigin_ekle.UseVisualStyleBackColor = true;
            this.btn_yigin_ekle.Click += new System.EventHandler(this.btn_yigin_ekle_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(525, 268);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(178, 66);
            this.button13.TabIndex = 29;
            this.button13.Text = "DOLDURMAYI HIZLANDIR";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // txb_kuyruk_durum
            // 
            this.txb_kuyruk_durum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txb_kuyruk_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_kuyruk_durum.Location = new System.Drawing.Point(3, 396);
            this.txb_kuyruk_durum.Margin = new System.Windows.Forms.Padding(2);
            this.txb_kuyruk_durum.Multiline = true;
            this.txb_kuyruk_durum.Name = "txb_kuyruk_durum";
            this.txb_kuyruk_durum.Size = new System.Drawing.Size(928, 62);
            this.txb_kuyruk_durum.TabIndex = 24;
            // 
            // btn_kuyruk_cikar
            // 
            this.btn_kuyruk_cikar.Location = new System.Drawing.Point(201, 24);
            this.btn_kuyruk_cikar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kuyruk_cikar.Name = "btn_kuyruk_cikar";
            this.btn_kuyruk_cikar.Size = new System.Drawing.Size(71, 47);
            this.btn_kuyruk_cikar.TabIndex = 26;
            this.btn_kuyruk_cikar.Text = "ÇIKAR";
            this.btn_kuyruk_cikar.UseVisualStyleBackColor = true;
            this.btn_kuyruk_cikar.Click += new System.EventHandler(this.btn_kuyruk_cikar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 374);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "ÖN";
            // 
            // txb_kuyruk_ekle
            // 
            this.txb_kuyruk_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_kuyruk_ekle.Location = new System.Drawing.Point(17, 24);
            this.txb_kuyruk_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.txb_kuyruk_ekle.Multiline = true;
            this.txb_kuyruk_ekle.Name = "txb_kuyruk_ekle";
            this.txb_kuyruk_ekle.Size = new System.Drawing.Size(87, 49);
            this.txb_kuyruk_ekle.TabIndex = 23;
            // 
            // btn_kuyruk_ekle
            // 
            this.btn_kuyruk_ekle.Location = new System.Drawing.Point(105, 24);
            this.btn_kuyruk_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kuyruk_ekle.Name = "btn_kuyruk_ekle";
            this.btn_kuyruk_ekle.Size = new System.Drawing.Size(71, 47);
            this.btn_kuyruk_ekle.TabIndex = 22;
            this.btn_kuyruk_ekle.Text = "EKLE";
            this.btn_kuyruk_ekle.UseVisualStyleBackColor = true;
            this.btn_kuyruk_ekle.Click += new System.EventHandler(this.btn_kuyruk_ekle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(879, 374);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "ARKA";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 374);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "KUYRUK DURUMU";
            // 
            // tmr_kuyruk
            // 
            this.tmr_kuyruk.Interval = 1000;
            this.tmr_kuyruk.Tick += new System.EventHandler(this.tmr_kuyruk_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 66);
            this.button1.TabIndex = 30;
            this.button1.Text = "KUYRUK OTOMATİK DOLDUR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 66);
            this.button2.TabIndex = 31;
            this.button2.Text = "OTOMATİK DOLDURMAYI DURDUR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(721, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 66);
            this.button3.TabIndex = 32;
            this.button3.Text = "DOLDURMAYI YAVAŞLAT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_kuyruk_ekle);
            this.groupBox1.Controls.Add(this.btn_kuyruk_ekle);
            this.groupBox1.Controls.Add(this.btn_kuyruk_cikar);
            this.groupBox1.Location = new System.Drawing.Point(253, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "manuel kuyruk doldurma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "VERİ YAPILARI DERSİ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_yigin_cikar;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txb_yigin_durum;
        private System.Windows.Forms.TextBox txb_yigin_ekle;
        private System.Windows.Forms.Button btn_yigin_ekle;
        private System.Windows.Forms.Button button13;
        public System.Windows.Forms.TextBox txb_kuyruk_durum;
        private System.Windows.Forms.Button btn_kuyruk_cikar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_kuyruk_ekle;
        private System.Windows.Forms.Button btn_kuyruk_ekle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer tmr_kuyruk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

