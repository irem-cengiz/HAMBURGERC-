using HAMBURGERCİ.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAMBURGERCİ
{
    public partial class MenuEkleme : Form
    {
        public MenuEkleme()
        {
            InitializeComponent();
        }
        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            //STATİC OLAN MENÜ LİSTESİNE yeni menüyü ekle

            SiparisOlusturma.menuler.Add(new Menu
            {
                Ad = txtMenu.Text,
                Fiyat = menuNud.Value
            });

            MessageBox.Show("Menü başarıyla eklenmiştir.");
        }
    }
}
