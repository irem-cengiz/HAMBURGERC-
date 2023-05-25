using HAMBURGERCİ.Class;
using HAMBURGERCİ.Enumlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAMBURGERCİ
{
    public partial class SiparisOlusturma : Form
    {
        decimal toplamTutar = 0;
        Siparis yeniSiparis;
        public static List<Siparis> siparisler = new List<Siparis>();

        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()//ekstra malzemeler sabit oldugu icin static yaptık.//static tanımlamamızın sebebi, bu listenin her zaman aynı olarak
          //kullanılması yani bu formdan oluşan nesnelere özgü değil, genele
          //özgü olduğu için.Dolayısıyla bu listeyi direkt sınıfın adıyla
          //çağırabiliriz. (static olduğu için)
        {
            new EkstraMalzeme{Ad="Ketçap",Fiyat=3 },
            new EkstraMalzeme{Ad="Mayonez",Fiyat=2.75M },
            new EkstraMalzeme{Ad="Hardal", Fiyat=3.25M},
            new EkstraMalzeme{Ad="BBQ",Fiyat=3.50M},
            new EkstraMalzeme{Ad="Ranch",Fiyat=2.25M},
            new EkstraMalzeme{Ad="Buffalo", Fiyat=4.00M}
        };

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{Ad="Super King",Fiyat=130 },
            new Menu{Ad="Super Queen",Fiyat=120 },
            new Menu{Ad="Mega Queen",Fiyat=155 },
            new Menu{Ad="Mega King",Fiyat=120 },
            new Menu{Ad="Big King",Fiyat=105 },

        };
        public SiparisOlusturma()
        {
            InitializeComponent();
            kucukRadioButton.Checked = true;

            //Her bir ekstra sos ekleyince siparis olusturma ektanında o sosa ait checkbox olusuyor ve seçebiliyoruz.
            int y = 72;
            foreach (var ekstra in ekstralar)
            {

                extraGrupBox.Controls.Add(new CheckBox() { Text = ekstra.Ad, Location = new Point { X = 26, Y = y }, Tag = ekstra });

                //buradaki tag menü oluştururken eklediğimiz ekstra malzeme bu tag ile taşınır..

                y += 25;
            }

            //menüleri cmb'ye ekle.
            cmbMenuler.Items.AddRange(menuler.ToArray());
            //menü listesinde ilk olanı seçili yap.
            cmbMenuler.SelectedIndex = 0;

        }
        public string ToplamTutar { get; private set; }
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();

            //menüsünü ata
            yeniSiparis.Menu = (Menu)cmbMenuler.SelectedItem;
            if (kucukRadioButton.Checked)
                yeniSiparis.Boyut = Boyut.Kucuk;
            else if (ortaRadioButton.Checked)
                yeniSiparis.Boyut = Boyut.Orta;
            else yeniSiparis.Boyut = Boyut.Buyuk;


            //ekstra malzeme varsa ata
            // chechboxlar içerisinde dön İŞARETLİ OLANLARI EKLE
            foreach (var item in extraGrupBox.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)

                    //ekstra malzeme ekle

                    yeniSiparis.EkstraMalzemeler.Add((EkstraMalzeme)((CheckBox)(item)).Tag);

                //burada ekstra malzemeleri kullanabilmek için new yaptık. siparis kısmında....
                //tag geçici olarak ekstra malzemeler listemdeki menü seçerkenki ekstra malzemeyi tag ile taşıyoruz. 
            }

            yeniSiparis.Adet = Convert.ToInt32(adetNumericUpDown.Value);
            toplamTutar+= yeniSiparis.Hesapla();  //hesapla içerisinde toplam tutar hesaplanıyor.

            lblTutar.Text = toplamTutar.ToString();    //tutar lbl sine tutarı hesapla metodunda hesaplanan tutarı yazdık. //listboxa siparisleri yazdırıyoruz

            lbxSiparisler.Items.Add(yeniSiparis); //listboxa siparisleri yazdırıyoruz
            siparisler.Add(yeniSiparis);
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult pencere = MessageBox.Show("Toplam Siparis Tutarı:" + ToplamTutar + Environment.NewLine + "Siparisi onaylamak istiyor musunuz?", "Sipariş bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (pencere == DialogResult.Yes)    //onaylanırsa
            {
                lbxSiparisler.Items.Clear();

                SiparisGoruntuleme goruntuleme = new SiparisGoruntuleme();
                goruntuleme.ShowDialog();
            }

            else
                MessageBox.Show("Sipariş Onaylanmadı");
        }
    }
}
