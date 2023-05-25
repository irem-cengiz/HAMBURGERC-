namespace HAMBURGERCİ
{
    partial class SiparisOlusturma
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
            extraGrupBox = new GroupBox();
            label1 = new Label();
            cmbMenuler = new ComboBox();
            groupBox1 = new GroupBox();
            buyukRadioButton = new RadioButton();
            ortaRadioButton = new RadioButton();
            kucukRadioButton = new RadioButton();
            label2 = new Label();
            adetNumericUpDown = new NumericUpDown();
            btnSiparisEkle = new Button();
            BtnSiparisTamamla = new Button();
            lbxSiparisler = new ListBox();
            lbltutarBaslik = new Label();
            lblTutar = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adetNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // extraGrupBox
            // 
            extraGrupBox.Location = new Point(19, 247);
            extraGrupBox.Name = "extraGrupBox";
            extraGrupBox.Size = new Size(321, 372);
            extraGrupBox.TabIndex = 0;
            extraGrupBox.TabStop = false;
            extraGrupBox.Text = "Ekstra Malzemeler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 96);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Menü Seçiniz:";
            // 
            // cmbMenuler
            // 
            cmbMenuler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuler.FormattingEnabled = true;
            cmbMenuler.Location = new Point(105, 96);
            cmbMenuler.Name = "cmbMenuler";
            cmbMenuler.Size = new Size(235, 23);
            cmbMenuler.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buyukRadioButton);
            groupBox1.Controls.Add(ortaRadioButton);
            groupBox1.Controls.Add(kucukRadioButton);
            groupBox1.Location = new Point(19, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 102);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Boyut Seçiniz:";
            // 
            // buyukRadioButton
            // 
            buyukRadioButton.AutoSize = true;
            buyukRadioButton.Location = new Point(190, 41);
            buyukRadioButton.Name = "buyukRadioButton";
            buyukRadioButton.Size = new Size(58, 19);
            buyukRadioButton.TabIndex = 2;
            buyukRadioButton.TabStop = true;
            buyukRadioButton.Text = "Büyük";
            buyukRadioButton.UseVisualStyleBackColor = true;
            // 
            // ortaRadioButton
            // 
            ortaRadioButton.AutoSize = true;
            ortaRadioButton.Location = new Point(110, 41);
            ortaRadioButton.Name = "ortaRadioButton";
            ortaRadioButton.Size = new Size(48, 19);
            ortaRadioButton.TabIndex = 1;
            ortaRadioButton.TabStop = true;
            ortaRadioButton.Text = "Orta";
            ortaRadioButton.UseVisualStyleBackColor = true;
            // 
            // kucukRadioButton
            // 
            kucukRadioButton.AutoSize = true;
            kucukRadioButton.Location = new Point(14, 41);
            kucukRadioButton.Name = "kucukRadioButton";
            kucukRadioButton.Size = new Size(58, 19);
            kucukRadioButton.TabIndex = 0;
            kucukRadioButton.TabStop = true;
            kucukRadioButton.Text = "Küçük";
            kucukRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 32);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Adet:";
            // 
            // adetNumericUpDown
            // 
            adetNumericUpDown.Location = new Point(19, 60);
            adetNumericUpDown.Name = "adetNumericUpDown";
            adetNumericUpDown.Size = new Size(49, 23);
            adetNumericUpDown.TabIndex = 5;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.BackColor = Color.MediumAquamarine;
            btnSiparisEkle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparisEkle.Location = new Point(187, 644);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(153, 40);
            btnSiparisEkle.TabIndex = 6;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = false;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // BtnSiparisTamamla
            // 
            BtnSiparisTamamla.BackColor = Color.LightSeaGreen;
            BtnSiparisTamamla.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSiparisTamamla.Location = new Point(19, 644);
            BtnSiparisTamamla.Name = "BtnSiparisTamamla";
            BtnSiparisTamamla.Size = new Size(153, 40);
            BtnSiparisTamamla.TabIndex = 7;
            BtnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            BtnSiparisTamamla.UseVisualStyleBackColor = false;
            BtnSiparisTamamla.Click += btnSiparisTamamla_Click;
            // 
            // lbxSiparisler
            // 
            lbxSiparisler.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbxSiparisler.FormattingEnabled = true;
            lbxSiparisler.HorizontalExtent = 2000;
            lbxSiparisler.HorizontalScrollbar = true;
            lbxSiparisler.ItemHeight = 20;
            lbxSiparisler.Location = new Point(568, 60);
            lbxSiparisler.Name = "lbxSiparisler";
            lbxSiparisler.ScrollAlwaysVisible = true;
            lbxSiparisler.Size = new Size(525, 584);
            lbxSiparisler.TabIndex = 8;
            // 
            // lbltutarBaslik
            // 
            lbltutarBaslik.AutoSize = true;
            lbltutarBaslik.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbltutarBaslik.Location = new Point(568, 655);
            lbltutarBaslik.Name = "lbltutarBaslik";
            lbltutarBaslik.Size = new Size(118, 19);
            lbltutarBaslik.TabIndex = 9;
            lbltutarBaslik.Text = "TOPLAM TUTAR:";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTutar.ForeColor = Color.FromArgb(192, 0, 0);
            lblTutar.Location = new Point(692, 655);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(19, 21);
            lblTutar.TabIndex = 10;
            lblTutar.Text = "0";
            // 
            // SiparisOlusturma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 723);
            Controls.Add(lblTutar);
            Controls.Add(lbltutarBaslik);
            Controls.Add(lbxSiparisler);
            Controls.Add(BtnSiparisTamamla);
            Controls.Add(btnSiparisEkle);
            Controls.Add(adetNumericUpDown);
            Controls.Add(label2);
            Controls.Add(cmbMenuler);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(extraGrupBox);
            Name = "SiparisOlusturma";
            Text = "SiparisOlusturma";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adetNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox extraGrupBox;
        private Label label1;
        private ComboBox cmbMenuler;
        private GroupBox groupBox1;
        private RadioButton buyukRadioButton;
        private RadioButton ortaRadioButton;
        private RadioButton kucukRadioButton;
        private Label label2;
        private NumericUpDown adetNumericUpDown;
        private Button btnSiparisEkle;
        private Button BtnSiparisTamamla;
        private ListBox lbxSiparisler;
        private Label lbltutarBaslik;
        private Label lblTutar;
    }
}