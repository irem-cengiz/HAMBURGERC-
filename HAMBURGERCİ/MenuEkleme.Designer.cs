namespace HAMBURGERCİ
{
    partial class MenuEkleme
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
            btnMenuEkle = new Button();
            menuNud = new NumericUpDown();
            label3 = new Label();
            txtMenu = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)menuNud).BeginInit();
            SuspendLayout();
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.Location = new Point(211, 212);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(145, 46);
            btnMenuEkle.TabIndex = 11;
            btnMenuEkle.Text = "MENÜ EKLE";
            btnMenuEkle.UseVisualStyleBackColor = true;
            btnMenuEkle.Click += btnMenuEkle_Click;
            // 
            // menuNud
            // 
            menuNud.Location = new Point(204, 143);
            menuNud.Name = "menuNud";
            menuNud.Size = new Size(152, 23);
            menuNud.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 147);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 9;
            label3.Text = "Fiyatı:";
            // 
            // txtMenu
            // 
            txtMenu.Location = new Point(206, 91);
            txtMenu.Name = "txtMenu";
            txtMenu.Size = new Size(150, 23);
            txtMenu.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 95);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 7;
            label2.Text = "Menü Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSeaGreen;
            label1.Font = new Font("Franklin Gothic Medium", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 30);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 6;
            label1.Text = "MENÜ BÖLÜMÜ";
            // 
            // MenuEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 307);
            Controls.Add(btnMenuEkle);
            Controls.Add(menuNud);
            Controls.Add(label3);
            Controls.Add(txtMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuEkleme";
            Text = "MenuEkleme";
            ((System.ComponentModel.ISupportInitialize)menuNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenuEkle;
        private NumericUpDown menuNud;
        private Label label3;
        private TextBox txtMenu;
        private Label label2;
        private Label label1;
    }
}