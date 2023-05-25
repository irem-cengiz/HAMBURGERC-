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
    public partial class AnaForm : Form
    {
        private decimal ciro;
        public AnaForm()
        {
            InitializeComponent();
        }

        //amacım bir formun açılıp ana menünün sabit durması. ama baska bir form açtıgımızda diğer bir önceki açılan form varsa onun kapanmasını istiyoruz. ana form açılacak her formun arkasında açık olacak...bununla ilgili metot yazmalıyız.

        public void PencereGoster(Form gonderilenForm)  //içine form gönderiyorum.
        {

            bool durum = false; //basta cocugu yok false yaptık..
            //anaformun cocukları içerisinde döngüyle gezelim. sonra da parametre olarak verilen formu aç diğerlerini de kapat dememiz gerek.
            //formumuzun ilk program açıldığı anda hic çocugu yok. dolayısıyla foreache deger girmez.

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == gonderilenForm.Text)
                {
                    durum = true; // buraya girdiyse cocugu vardır.cocugu gösterir.
                    form.Activate();
                }
                else
                {
                    form.Close();
                }

            }

            if (!durum) //cocugu yoksa
            {
                gonderilenForm.MdiParent = this;
                gonderilenForm.Show();
            }
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PencereGoster(new SiparisOlusturma());

        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PencereGoster(new SiparisGoruntuleme());
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PencereGoster(new MenuEkleme());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PencereGoster(new EkstraEkleme());
        }
    }
}
