namespace HAMBURGERCİ
{
    partial class SiparisGoruntuleme
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
            label1 = new Label();
            lstOnaylananlar = new ListBox();
            label2 = new Label();
            lblCiro = new Label();
            lblGelen = new Label();
            lblToplamsiparis = new Label();
            label3 = new Label();
            lblEkstraMalzemeAdedi = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 38);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "ONAYLANAN SİPARİŞLER";
            // 
            // lstOnaylananlar
            // 
            lstOnaylananlar.FormattingEnabled = true;
            lstOnaylananlar.ItemHeight = 15;
            lstOnaylananlar.Location = new Point(60, 85);
            lstOnaylananlar.Name = "lstOnaylananlar";
            lstOnaylananlar.Size = new Size(280, 319);
            lstOnaylananlar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 85);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Ciro:";
            // 
            // lblCiro
            // 
            lblCiro.BorderStyle = BorderStyle.FixedSingle;
            lblCiro.Location = new Point(503, 77);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(269, 23);
            lblCiro.TabIndex = 3;
            // 
            // lblGelen
            // 
            lblGelen.BorderStyle = BorderStyle.FixedSingle;
            lblGelen.Location = new Point(503, 142);
            lblGelen.Name = "lblGelen";
            lblGelen.Size = new Size(269, 23);
            lblGelen.TabIndex = 4;
            // 
            // lblToplamsiparis
            // 
            lblToplamsiparis.AutoSize = true;
            lblToplamsiparis.Location = new Point(355, 150);
            lblToplamsiparis.Name = "lblToplamsiparis";
            lblToplamsiparis.Size = new Size(86, 15);
            lblToplamsiparis.TabIndex = 5;
            lblToplamsiparis.Text = "Toplam Sipariş:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 206);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 7;
            label3.Text = "Ekstra Malzeme Tutarı:";
            // 
            // lblEkstraMalzemeAdedi
            // 
            lblEkstraMalzemeAdedi.BorderStyle = BorderStyle.FixedSingle;
            lblEkstraMalzemeAdedi.Location = new Point(503, 198);
            lblEkstraMalzemeAdedi.Name = "lblEkstraMalzemeAdedi";
            lblEkstraMalzemeAdedi.Size = new Size(269, 23);
            lblEkstraMalzemeAdedi.TabIndex = 6;
            // 
            // SiparisGoruntuleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lblEkstraMalzemeAdedi);
            Controls.Add(lblToplamsiparis);
            Controls.Add(lblGelen);
            Controls.Add(lblCiro);
            Controls.Add(label2);
            Controls.Add(lstOnaylananlar);
            Controls.Add(label1);
            Name = "SiparisGoruntuleme";
            Text = "SiparisGoruntuleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstOnaylananlar;
        private Label label2;
        private Label lblCiro;
        private Label lblGelen;
        private Label lblToplamsiparis;
        private Label label3;
        private Label lblEkstraMalzemeAdedi;
    }
}