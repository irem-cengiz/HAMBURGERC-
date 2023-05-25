namespace HAMBURGERCİ
{
    partial class EkstraEkleme
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
            label2 = new Label();
            txtEkstraAd = new TextBox();
            label3 = new Label();
            nudEkstra = new NumericUpDown();
            btnEkstraEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)nudEkstra).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSeaGreen;
            label1.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 22);
            label1.Name = "label1";
            label1.Size = new Size(250, 23);
            label1.TabIndex = 0;
            label1.Text = "EKSTRA MALZEME BÖLÜMÜ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(132, 19);
            label2.TabIndex = 1;
            label2.Text = "Ekstra Malzeme Adı:";
            // 
            // txtEkstraAd
            // 
            txtEkstraAd.Location = new Point(175, 75);
            txtEkstraAd.Name = "txtEkstraAd";
            txtEkstraAd.Size = new Size(150, 23);
            txtEkstraAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 3;
            label3.Text = "Fiyatı:";
            // 
            // nudEkstra
            // 
            nudEkstra.Location = new Point(173, 127);
            nudEkstra.Name = "nudEkstra";
            nudEkstra.Size = new Size(152, 23);
            nudEkstra.TabIndex = 4;
            // 
            // btnEkstraEkle
            // 
            btnEkstraEkle.Location = new Point(180, 196);
            btnEkstraEkle.Name = "btnEkstraEkle";
            btnEkstraEkle.Size = new Size(145, 46);
            btnEkstraEkle.TabIndex = 5;
            btnEkstraEkle.Text = "EKSTRA MALZEME EKLE";
            btnEkstraEkle.UseVisualStyleBackColor = true;
            btnEkstraEkle.Click += btnEkstraEkle_Click;
            // 
            // EkstraEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 288);
            Controls.Add(btnEkstraEkle);
            Controls.Add(nudEkstra);
            Controls.Add(label3);
            Controls.Add(txtEkstraAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EkstraEkleme";
            Text = "EkstraEkleme";
            ((System.ComponentModel.ISupportInitialize)nudEkstra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEkstraAd;
        private Label label3;
        private NumericUpDown nudEkstra;
        private Button btnEkstraEkle;
    }
}