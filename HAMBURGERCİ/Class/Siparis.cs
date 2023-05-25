using HAMBURGERCİ.Enumlar;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAMBURGERCİ.Class
{
    public class Siparis
    {
        public Menu Menu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; } =new List<EkstraMalzeme>();//newlememiz gerekiyor kullanmak için.
        public Boyut Boyut { get; set; }

        public int Adet { get; set; }

        public decimal ToplamTutar { get; set; } = 0;

        public decimal Hesapla()
        {
            /* ToplamTutar = 0; */ //decimal defaultu 0 dır.
            ToplamTutar += Menu.Fiyat;

            if (Boyut == Boyut.Orta)
                ToplamTutar += ToplamTutar * 0.5M;
            else if (Boyut == Boyut.Buyuk)
                ToplamTutar += ToplamTutar * 0.75M;

            //ekstralar??

            //ToplamTutar += EkstraMalzeme.Sum(x => x.Fiyat);   ekstra malzemelerin fiyatlarının toplamı.....


            foreach (var ekstra in EkstraMalzemeler)
            
                ToplamTutar += ekstra.Fiyat;
                ToplamTutar = ToplamTutar * Adet;
             return ToplamTutar;    

        }
       public override string ToString()
        {
           StringBuilder sb = new StringBuilder();

            sb.AppendLine(Adet + "adet siparis");  //ekle alt satıra geç...

            sb.AppendLine("Menü:" + Menu.Ad);

            sb.AppendLine("Ekstra malzemeler:");   //liste oldugu icin foreach gerek duyduk.
                foreach (var item in EkstraMalzemeler)

            {
                sb.AppendLine(item.Ad);
            }                     

            sb.AppendLine("Toplam tutar:"+ToplamTutar.ToString()+"TL");

             return sb.ToString();   
        }

    }
}
