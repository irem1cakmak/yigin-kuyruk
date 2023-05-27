using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yigin_kuyruk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Node
        {
            public int sayi;
             public Node baglanti;

        }


        public Node ilk_yigin_dugum;
        private void btn_yigin_ekle_Click(object sender, EventArgs e)
        {
            Node yeni = new Node();
            yeni.sayi = Convert.ToInt32(txb_yigin_ekle.Text);
            yeni.baglanti = ilk_yigin_dugum;
            ilk_yigin_dugum = yeni;
            yiginGoster();

        }

        private void btn_yigin_cikar_Click(object sender, EventArgs e)
        {

            if (ilk_yigin_dugum == null)
            {
                MessageBox.Show("Yığın boş");
                return;
            }
            ilk_yigin_dugum = ilk_yigin_dugum.baglanti;
            yiginGoster();
        }
        int yiginBoyut = 0;
        private void yiginGoster()
        {
            yiginBoyut = 0;
            txb_yigin_durum.Text = null;
            if (ilk_yigin_dugum == null)
            {
                MessageBox.Show("Yığında Gösterilecek Eleman Bulunamadı");
                return;
            }
            else
            {
                Node gecici = ilk_yigin_dugum;
                while (gecici != null)
                {
                    yiginBoyut++;
                    txb_yigin_durum.Text += gecici.sayi + "\r\n";
                    gecici = gecici.baglanti;
                }
            }
            //MessageBox.Show(yiginBoyut.ToString());
        }
        public Node on_kuyruk = null, arka_kuyruk = null;
        private void btn_kuyruk_ekle_Click(object sender, EventArgs e)
        {
            tmr_kuyruk.Enabled = false;
            Node yeni = new Node();
            yeni.sayi = Convert.ToInt32(txb_kuyruk_ekle.Text);
            if (on_kuyruk == null)
            {
                on_kuyruk = yeni;
                arka_kuyruk = yeni;
            }
            else
            {
                arka_kuyruk.baglanti = yeni;
                arka_kuyruk = yeni;

            }
            kuyrukGoster();

        }

        private void btn_kuyruk_cikar_Click(object sender, EventArgs e)
        {
            tmr_kuyruk.Enabled = false;
            if (on_kuyruk == null)
            {
                MessageBox.Show("Kuyruk boş");
                return;
            }
            on_kuyruk = on_kuyruk.baglanti;
            kuyrukGoster();
        }

        private void tmr_kuyruk_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();                    
            Node yeni = new Node();
            yeni.sayi = rnd.Next(1, 100);
            if (on_kuyruk == null)
            {
                on_kuyruk = yeni;
                arka_kuyruk = yeni;
            }
            else
            {
                arka_kuyruk.baglanti = yeni;
                arka_kuyruk = yeni;

            }
            kuyrukGoster();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!tmr_kuyruk.Enabled)
            {
                tmr_kuyruk.Enabled = true;
                                
            }
            tmr_kuyruk.Interval = tmr_kuyruk.Interval - 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmr_kuyruk.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmr_kuyruk.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!tmr_kuyruk.Enabled)
            {
                tmr_kuyruk.Enabled = true;

            }
            tmr_kuyruk.Interval = tmr_kuyruk.Interval + 100;
        }

        private void kuyrukGoster()
        {
            txb_kuyruk_durum.Text = null;

            if (arka_kuyruk == null)
            {
                MessageBox.Show("Kuyrukta Gösterilecek Eleman Bulunamadı");
                return;
            }
            else
            {
                Node gecici = on_kuyruk;
                while (gecici != null)
                {
                    txb_kuyruk_durum.Text += gecici.sayi + "<--";
                    gecici = gecici.baglanti;
                }

            }
        }
    }
}
