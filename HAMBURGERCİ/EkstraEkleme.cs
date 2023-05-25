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
    public partial class EkstraEkleme : Form
    {
        public EkstraEkleme()
        {
            InitializeComponent();
        }
        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {

            SiparisOlusturma.ekstralar.Add(new EkstraMalzeme
            {
                Ad = txtEkstraAd.Text,
                Fiyat = nudEkstra.Value
            });

            MessageBox.Show("Ekstra malzeme başarıyla eklenmiştir.");
        }
    }
}
