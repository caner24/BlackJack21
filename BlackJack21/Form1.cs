using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int genel = 0;
        int sayac = 0;
        int sonuca = 0; 
        int sayi;

        private void button1_Click(object sender, EventArgs e)
        {

            genel++;
            sayac++;
           
            
            Random üret = new Random();
            sayi = üret.Next(1, 11);
            if (sayac==1)
            {
                
                if (sayi==1)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 2)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 3)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 4)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 5)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 6)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 7)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 8)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 9)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 10)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }
            }
            if (sayac == 2)
            {
             
                if (sayi == 1)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 2)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 3)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 4)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 5)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 6)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 7)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 8)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 9)
                {
                    label23.Text = sayi.ToString();
                     sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 10)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }

            }
            if (sayac == 3)
            {
             
                if (sayi == 1)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 2)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 3)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 4)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 5)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 6)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 7)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 8)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 9)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 10)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }

            }
            if (sayac == 4)
            {
                
                if (sayi == 1)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 2)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 3)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 4)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 5)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 6)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 7)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 8)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 9)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayi == 10)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();

                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }
                button1.Enabled = false;
            }
            if (genel==8)
            {
                if (Int32.Parse(label16.Text.ToString())> Int32.Parse(label17.Text.ToString()))
                {
                    genel = 0;
                    MessageBox.Show("OYUN BİTTİ  KAZANDİNİZZ :))))) !!!!!! " + " + + + Bahisiniz + + + :" + bahis.ToString());
                    sayi = 0;
                    sonuca = 0;
                    sayac = 0;
                    sayim = 0;
                    sayas = 0;
                    sonuc = 0;
                    bahis = 0;
                    label8.Text = "";
                    label22.Text = "";
                    label23.Text = "";
                    label24.Text = "";
                    label25.Text = "";
                    label10.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    label8.Text = "";
                    label18.Text = "";
                    label19.Text = "";
                    label20.Text = "";
                    label21.Text = "";
                    label11.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    button8.Enabled = true;

                }
                else if (Int32.Parse(label16.Text.ToString()) < Int32.Parse(label17.Text.ToString()))
                {
                    genel = 0;
                    MessageBox.Show("OYUN BİTTİ  KAYBETTİNİZ :(((( !!!!!! " + " ---- Bahisiniz ---:" + bahis.ToString());
                    sayi = 0;
                    sonuca = 0;
                    sayac = 0;
                    sayim = 0;
                    sayas = 0;
                    sonuc = 0;
                    bahis = 0;
                    label8.Text = "";
                    label22.Text = "";
                    label23.Text = "";
                    label24.Text = "";
                    label25.Text = "";
                    label10.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    label8.Text = "";
                    label18.Text = "";
                    label19.Text = "";
                    label20.Text = "";
                    label21.Text = "";
                    label11.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    button8.Enabled = true;
                }
               else if (Int32.Parse(label16.Text.ToString()) == Int32.Parse(label17.Text.ToString()))
                {
                    genel = 0;
                    MessageBox.Show("OYUN BİTTİ  BERABAERE ------ !!!!!! " + "  Bahisiniz :" + bahis.ToString() );
                    sayi = 0;
                    sonuca = 0;
                    sayac = 0;
                    sayim = 0;
                    sayas = 0;
                    sonuc = 0;
                    bahis = 0;
                    label8.Text = "";
                    label22.Text = "";
                    label23.Text = "";
                    label24.Text = "";
                    label25.Text = "";
                    label10.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    label8.Text = "";
                    label18.Text = "";
                    label19.Text = "";
                    label20.Text = "";
                    label21.Text = "";
                    label11.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    button8.Enabled = true;
                }

              



                pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
        }
        int sayas = 0;
        int sonuc=0; 
        int sayim;
        private void button2_Click(object sender, EventArgs e)
        {

            genel++;
            sayas++;
            
           
            
            Random üreti = new Random();
            sayim = üreti.Next(1, 11);
            if (sayas == 1)
            {
                if (sayim == 1)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 2)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 3)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 4)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 5)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 6)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 7)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 8)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 9)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 10)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }
            }
            if (sayas == 2)
            {
                if (sayim == 1)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 2)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 3)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 4)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 5)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 6)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 7)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 8)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 9)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 10)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }

            }
            if (sayas == 3)
            {
                if (sayim == 1)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 2)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 3)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 4)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 5)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 6)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 7)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 8)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 9)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 10)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }

            }
            if (sayas == 4)
            {
                if (sayim == 1)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 2)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 3)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 4)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 5)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 6)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 7)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 8)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 9)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }
                if (sayim == 10)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }
                button2.Enabled = false;
            }
            if (genel == 8)
            {
                if (Int32.Parse(label16.Text.ToString()) > Int32.Parse(label17.Text.ToString()))
                {
                    genel = 0;
                    MessageBox.Show("OYUN BİTTİ  KAZANDİNİZZ :))))) !!!!!! " + " + + + Bahisiniz + + + :" + bahis.ToString() );
                    sayim = 0;
                    sayas = 0;
                    sonuc = 0;
                    sayi = 0;
                    sonuca = 0;
                    sayac = 0;
                    bahis = 0;
                    label8.Text = "";
                    label18.Text = "";
                    label19.Text = "";
                    label20.Text = "";
                    label21.Text = "";
                    label11.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    label8.Text = "";
                    label22.Text = "";
                    label23.Text = "";
                    label24.Text = "";
                    label25.Text = "";
                    label10.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    button8.Enabled = true;





                }
                else if (Int32.Parse(label16.Text.ToString()) < Int32.Parse(label17.Text.ToString()))
                {
                    genel = 0;
                    MessageBox.Show("OYUN BİTTİ  KAYBETTİNİZ :(((( !!!!!! " + " ---- Bahisiniz ---:" + bahis.ToString() );
                    sayim = 0;
                    sayas = 0;
                    sonuc = 0;
                    sayi = 0;
                    sonuca = 0;
                    sayac = 0;
                    bahis = 0;
                    label8.Text = "";
                    label18.Text = "";
                    label19.Text = "";
                    label20.Text = "";
                    label21.Text = "";
                    label11.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    label8.Text = "";
                    label22.Text = "";
                    label23.Text = "";
                    label24.Text = "";
                    label25.Text = "";
                    label10.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    button8.Enabled = true;
                }
                else if (Int32.Parse(label16.Text.ToString()) == Int32.Parse(label17.Text.ToString()))
                {
                    genel = 0;
                    MessageBox.Show("OYUN BİTTİ  BERABAERE ------ !!!!!! " + "  Bahisiniz :" + bahis.ToString());
                    sayim = 0;
                    sayas = 0;
                    sonuc = 0;
                    sayi = 0;
                    sonuca = 0;
                    sayac = 0;
                    bahis = 0;
                    label8.Text = "";
                    label18.Text = "";
                    label19.Text = "";
                    label20.Text = "";
                    label21.Text = "";
                    label11.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    label8.Text = "";
                    label22.Text = "";
                    label23.Text = "";
                    label24.Text = "";
                    label25.Text = "";
                    label10.Text = "";
                    label16.Text = "";
                    label17.Text = "";
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    button8.Enabled = true;
                }


                pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
                pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\9637261017138.jpg";
            }
        }
        int bahis=0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bahis = bahis + 5;
            label8.Text = bahis.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bahis = bahis + 10;
            label8.Text = bahis.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bahis = bahis + 15;
            label8.Text = bahis.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bahis = bahis + 30;
            label8.Text = bahis.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            bahis = bahis + 50;
            label8.Text = bahis.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            bahis = bahis + 100;
            label8.Text = bahis.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            button8.Enabled = false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label27.Text = label27.Text.Substring(1) + label27.Text.Substring(0,1);
        }
    }
}
