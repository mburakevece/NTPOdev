namespace denemeodev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtsoyad = new TextBox();
            txtad = new TextBox();
            txtno = new TextBox();
            cboxsınıf = new ComboBox();
            lblNo = new Label();
            lblsınıf = new Label();
            lblsoyad = new Label();
            lblad = new Label();
            btnkaydet = new Button();
            btnguncelle = new Button();
            btnbul = new Button();
            btnderssec = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtsoyad);
            groupBox1.Controls.Add(txtad);
            groupBox1.Controls.Add(txtno);
            groupBox1.Controls.Add(cboxsınıf);
            groupBox1.Controls.Add(lblNo);
            groupBox1.Controls.Add(lblsınıf);
            groupBox1.Controls.Add(lblsoyad);
            groupBox1.Controls.Add(lblad);
            groupBox1.Location = new Point(278, 80);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(239, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ogrenci Kaydet";
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(71, 137);
            txtsoyad.Margin = new Padding(3, 4, 3, 4);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(113, 27);
            txtsoyad.TabIndex = 7;
            // 
            // txtad
            // 
            txtad.Location = new Point(71, 99);
            txtad.Margin = new Padding(3, 4, 3, 4);
            txtad.Name = "txtad";
            txtad.Size = new Size(113, 27);
            txtad.TabIndex = 6;
            // 
            // txtno
            // 
            txtno.Location = new Point(71, 177);
            txtno.Margin = new Padding(3, 4, 3, 4);
            txtno.Name = "txtno";
            txtno.Size = new Size(113, 27);
            txtno.TabIndex = 5;
            // 
            // cboxsınıf
            // 
            cboxsınıf.FormattingEnabled = true;
            cboxsınıf.Location = new Point(71, 216);
            cboxsınıf.Margin = new Padding(3, 4, 3, 4);
            cboxsınıf.Name = "cboxsınıf";
            cboxsınıf.Size = new Size(113, 28);
            cboxsınıf.TabIndex = 4;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(29, 181);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(32, 20);
            lblNo.TabIndex = 3;
            lblNo.Text = "No:";
            // 
            // lblsınıf
            // 
            lblsınıf.AutoSize = true;
            lblsınıf.Location = new Point(21, 223);
            lblsınıf.Name = "lblsınıf";
            lblsınıf.Size = new Size(41, 20);
            lblsınıf.TabIndex = 2;
            lblsınıf.Text = "Sınıf:";
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Location = new Point(16, 141);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(53, 20);
            lblsoyad.TabIndex = 1;
            lblsoyad.Text = "Soyad:";
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Location = new Point(30, 103);
            lblad.Name = "lblad";
            lblad.Size = new Size(31, 20);
            lblad.TabIndex = 0;
            lblad.Text = "Ad:";
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(345, 416);
            btnkaydet.Margin = new Padding(3, 4, 3, 4);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(103, 47);
            btnkaydet.TabIndex = 1;
            btnkaydet.Text = "kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.Location = new Point(236, 416);
            btnguncelle.Margin = new Padding(3, 4, 3, 4);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(103, 47);
            btnguncelle.TabIndex = 2;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnbul
            // 
            btnbul.Location = new Point(454, 416);
            btnbul.Margin = new Padding(3, 4, 3, 4);
            btnbul.Name = "btnbul";
            btnbul.Size = new Size(103, 47);
            btnbul.TabIndex = 3;
            btnbul.Text = "Bul";
            btnbul.UseVisualStyleBackColor = true;
            btnbul.Click += btnbul_Click;
            // 
            // btnderssec
            // 
            btnderssec.Location = new Point(305, 471);
            btnderssec.Margin = new Padding(3, 4, 3, 4);
            btnderssec.Name = "btnderssec";
            btnderssec.Size = new Size(189, 47);
            btnderssec.TabIndex = 4;
            btnderssec.Text = "Ders Seç";
            btnderssec.UseVisualStyleBackColor = true;
            btnderssec.Click += btnderssec_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 584);
            Controls.Add(btnderssec);
            Controls.Add(btnbul);
            Controls.Add(btnguncelle);
            Controls.Add(btnkaydet);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnkaydet;
        private Button btnguncelle;
        private Button btnbul;
        private Button btnderssec;
        private Label lblNo;
        private Label lblsınıf;
        private Label lblsoyad;
        private Label lblad;
        private ComboBox cboxsınıf;
        private TextBox txtsoyad;
        private TextBox txtad;
        private TextBox txtno;
    }
}
