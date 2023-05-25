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
    public partial class SiparisGoruntuleme : Form
    {
        public SiparisGoruntuleme()
        {
            decimal ciro = 0;
            decimal ekstraMalzemeTutar = 0;
            int toplamSiparisAdedi = 0;

            InitializeComponent();

            foreach (var item in SiparisOlusturma.siparisler)
            {
                ciro += item.ToplamTutar;
                lblCiro.Text = ciro.ToString();
                lblEkstraMalzemeAdedi.Text = ekstraMalzemeTutar.ToString();
                lblGelen.Text = toplamSiparisAdedi.ToString();
                foreach (var ekstra in item.EkstraMalzemeler)
                {
                    ekstraMalzemeTutar += ekstra.Fiyat;
                }

                toplamSiparisAdedi += item.Adet;
            }
            

            lstOnaylananlar.Items.AddRange(SiparisOlusturma.siparisler.ToArray());
        }
    }
}
