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

        // ***********************************************        DEVOLOPED BY : CANER24         *********************************************** // 


        // Değişkenlerin Tanıtılması.

        int genel = 0;
        int sayac = 0;
        int sonuca = 0;
        int sayi;

        private void button1_Click(object sender, EventArgs e)
        {



            //1.Kullanıcı 4 kart çekme hakkı , Bilgisayarın da 4 kart çekme hakkı yani toplam 8 hak olduğu için genel değişkeni oluşturuldu.
            genel++;
            //Bu 8 hak tamamlanınca if işlemleri ile butonların enable özelliğini false yapma, kazanma/kaybetme durumunu ekrana yazdırma ve kullanıcının message box da ok tuşuna basması sonrası oyunun sıfırlanması yani baştan başlanması işlemleri yapıldı.


            // Sayac mantığının buradaki kullanımı ise 1 oyuncunun 4 kart çekme hakkı olduğu için hakları sayac olarak bildirildi.
            sayac++;
         
            // Random methodu kullanılarak rastgele iskambil kağıdı numarası elde etme aşaması
            Random üret = new Random();
            sayi = üret.Next(1, 11);


            // Eğer 1. haktaysa yani 1. picture boxda kart çektiyse orası içinde işlem yapılıyor.2. çekince 2.picturebox'a resim geliyor.Bu işlem son pictrebox'a kadar devam ediyor.

            if (sayac == 1)
            {
                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 1)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 2)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 3)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 4)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 5)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 6)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 7)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 8)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 9)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 10)
                {
                    label22.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox7.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }
            }

            // Yani eğer 2. haktaysa yani 2. picture boxda kart çektiyse orası içinde işlem yapılıyor.2. çekince 2.picturebox'a resim geliyor.Bu işlem son pictrebox'a kadar devam ediyor.

            if (sayac == 2)
            {

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 1)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 2)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 3)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 4)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 5)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 6)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 7)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 8)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 9)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 10)
                {
                    label23.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox8.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }

            }

            // Yani eğer 3. haktaysa yani 3. picture boxda kart çektiyse orası içinde işlem yapılıyor.2. çekince 2.picturebox'a resim geliyor.Bu işlem son pictrebox'a kadar devam ediyor.

            if (sayac == 3)
            {

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 1)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 2)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 3)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 4)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 5)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 6)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 7)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 8)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 9)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 10)
                {
                    label24.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox9.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }

            }

            // Yani eğer 4. haktaysa yani 4. picture boxda kart çektiyse orası içinde işlem yapılıyor.2. çekince 2.picturebox'a resim geliyor.Bu işlem son pictrebox'a kadar devam ediyor.

            if (sayac == 4)
            {

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 1)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 2)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 3)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 4)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 5)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 6)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 7)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 8)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 9)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();
                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın geldiği değere göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayi == 10)
                {
                    label25.Text = sayi.ToString();
                    sonuca = sonuca + sayi;
                    label10.Text = sonuca.ToString();
                    label16.Text = sonuca.ToString();

                    pictureBox10.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }

                // 4.Defa kart çekme hakkımız olduğu için 5. defa kart çekilmemesi için buttonun enable özelliğini false yapıldı.

                button1.Enabled = false;
            }

            // Oyunu 2 kişi oynadığı için 4 hak 1. oyuncuda 4 hak da bilgisayarda yani toplam 8 hakkımız var.Eğer genel hakkmımız 8 oluyor ise o zaman kazanma/kaybetme durumunu ve kazanılan/kaybedilen bahis miktarı kullanıcıya yazdırılıyor.Kullanıcı verilen mesajda ok a basarak oyunu tekrar baştan başlatabilir.

            if (genel == 8)
            {
                if (Int32.Parse(label16.Text.ToString()) > Int32.Parse(label17.Text.ToString()))
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

                // Oyunu 2 kişi oynadığı için 4 hak 1. oyuncuda 4 hak da bilgisayarda yani toplam 8 hakkımız var.Eğer genel hakkmımız 8 oluyor ise o zaman kazanma/kaybetme durumunu ve kazanılan/kaybedilen bahis miktarı kullanıcıya yazdırılıyor.Kullanıcı verilen mesajda ok a basarak oyunu tekrar baştan başlatabilir.

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

                // Oyunu 2 kişi oynadığı için 4 hak 1. oyuncuda 4 hak da bilgisayarda yani toplam 8 hakkımız var.Eğer genel hakkmımız 8 oluyor ise o zaman kazanma/kaybetme durumunu ve kazanılan/kaybedilen bahis miktarı kullanıcıya yazdırılıyor.Kullanıcı verilen mesajda ok a basarak oyunu tekrar baştan başlatabilir.

                else if (Int32.Parse(label16.Text.ToString()) == Int32.Parse(label17.Text.ToString()))
                {
                    genel = 0;
                    MessageBox.Show("OYUN BİTTİ  BERABAERE ------ !!!!!! " + "  Bahisiniz :" + bahis.ToString());
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

                // Picture box ' da ressimlerin gözükmesi için gerekli olan lokasyonların tanıtılması.

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
           // Kayan yazı etkin olması için timer'ı aktifleştirildi.

            timer1.Enabled = true;

            // Bahis miktarını seçmeden oyuna başlanmamasını için kart çekme işlemini yapıcağımız butonların enable özelliğini false yapıldı.

            button1.Enabled = false; 
            button2.Enabled = false;
        }

        int sayas = 0;

        // Çekilen kartların toplamını bulmak için sonuc değişkeni oluşturuldu.

        int sonuc = 0;
        int sayim;
        private void button2_Click(object sender, EventArgs e)
        {

            //1.Kullanıcı 4 kart çekme hakkı , Bilgisayarın da 4 kart çekme hakkı yani toplam 8 hak olduğu için genel değişkeni oluşturuldu.
            genel++;
            //Bu 8 hak tamamlanınca if işlemleri ile butonların enable özelliğini false yapma, kazanma/kaybetme durumunu ekrana yazdırma ve kullanıcının message box da ok tuşuna basması sonrası oyunun sıfırlanması yani baştan başlanması işlemleri yapıldı.

            // Sayac mantığının buradaki kullanımı ise 1 oyuncunun 4 kart çekme hakkı olduğu için hakları sayas değişkeni oluşturularak  bildirildi.
            sayas++;
            // Yani eğer 1. hakdaysa yani 1. picture boxda kart çektiyse orası içinde işlem yapılıyor.2. çekince 2.picturebox'a resim geliyor.Bu işlem son pictrebox'a kadar devam ediyor.

            // Random methodu kullanılarak rastgele iskambil kağıdı numarası elde etme aşaması
            Random üreti = new Random();
            sayim = üreti.Next(1, 11);

            // Eğer 1. haktaysa yani 1. picture boxda kart çektiyse orası içinde işlem yapılıyor.2. çekince 2.picturebox'a resim geliyor.Bu işlem son pictrebox'a kadar devam ediyor.

            if (sayas == 1)
            {
                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 1)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 2)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 3)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 4)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 5)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 6)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 7)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 8)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 9)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 10)
                {
                    label18.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox11.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }
            }

            // Eğer 2. haktaysa yani 2. picture boxda kart çektiyse orası içinde işlem yapılıyor.2. çekince 2.picturebox'a resim geliyor.Bu işlem son pictrebox'a kadar devam ediyor.

            if (sayas == 2)
            {
                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 1)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 2)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 3)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 4)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 5)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 6)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 7)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 8)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 9)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 10)
                {
                    label19.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox12.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }

            }

            // Eğer 3. haktaysa yani 3. picture boxda kart çektiyse orası içinde işlem yapılıyor.2. çekince 2.picturebox'a resim geliyor.Bu işlem son pictrebox'a kadar devam ediyor.

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

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 2)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 3)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 4)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 5)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 6)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 7)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 8)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 9)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 10)
                {
                    label20.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox13.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }
            }

            // Eğer 4. haktaysa yani 4. picture boxda kart çektiyse orası içinde işlem yapılıyor.2. çekince 2.picturebox'a resim geliyor.Bu işlem son pictrebox'a kadar devam ediyor.

            if (sayas == 4)
            {

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 1)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-as-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 2)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-2-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 3)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-3-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 4)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-4-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 5)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-5-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 6)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\kupa-6-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 7)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-7-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 8)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-8-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 9)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-9-iskambil-karti-www.falderyasi.com.png";
                }

                // Random gelen sayılarımızın gelme durumuna göre ressimlerini çekme işlemi ve sonuc değişkenimize değerin eklenmesi işlemleri yapıldı

                if (sayim == 10)
                {
                    label21.Text = sayim.ToString();
                    sonuc = sonuc + sayim;
                    label11.Text = sonuc.ToString();
                    label17.Text = sonuc.ToString();
                    pictureBox14.ImageLocation = "C:\\Users\\cnr24\\source\\repos\\BlackJack21\\BlackJack21\\Res\\karo-10-iskambil-karti-www.falderyasi.com.png";
                }
                // 4.Defa kart çekme hakkımız olduğu için 5. defa kart çekilmemesi için buttonun enable özelliğini false yapıldı.
                button2.Enabled = false;
            }

            // Oyunu 2 kişi oynadığı için 4 hak 1. oyuncuda 4 hak da bilgisayarda yani toplam 8 hakkımız var.Eğer genel hakkmımız 8 oluyor ise o zaman kazanma/kaybetme durumunu ve kazanılan/kaybedilen bahis miktarı kullanıcıya yazdırılıyor.

            if (genel == 8)
            {
                if (Int32.Parse(label16.Text.ToString()) > Int32.Parse(label17.Text.ToString()))
                {
                    genel = 0;
                    MessageBox.Show("OYUN BİTTİ  KAZANDİNİZZ :))))) !!!!!! " + " + + + Bahisiniz + + + :" + bahis.ToString());
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

                // Oyunu 2 kişi oynadığı için 4 hak 1. oyuncuda 4 hak da bilgisayarda yani toplam 8 hakkımız var.Eğer genel hakkmımız 8 oluyor ise o zaman kazanma/kaybetme durumunu ve kazanılan/kaybedilen bahis miktarı kullanıcıya yazdırılıyor.

                else if (Int32.Parse(label16.Text.ToString()) < Int32.Parse(label17.Text.ToString()))
                {
                    genel = 0;
                    MessageBox.Show("OYUN BİTTİ  KAYBETTİNİZ :(((( !!!!!! " + " ---- Bahisiniz ---:" + bahis.ToString());
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

                // Oyunu 2 kişi oynadığı için 4 hak 1. oyuncuda 4 hak da bilgisayarda yani toplam 8 hakkımız var.Eğer genel hakkmımız 8 oluyor ise o zaman kazanma/kaybetme durumunu ve kazanılan/kaybedilen bahis miktarı kullanıcıya yazdırılıyor.

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

                // Picture box ' da ressimlerin gözükmesi için gerekli olan lokasyonların tanıtılması.

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

        // Kullanıcının seçmiş olduğu miktarın kayıt edilmesi.
        int bahis = 0;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Bahis miktarının ilgili picture box 'a basılınca değişkende tutulması.

            bahis = bahis + 5;
            label8.Text = bahis.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Bahis miktarının ilgili picture box 'a basılınca değişkende tutulması.

            bahis = bahis + 10;
            label8.Text = bahis.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Bahis miktarının ilgili picture box 'a basılınca değişkende tutulması.

            bahis = bahis + 15;
            label8.Text = bahis.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Bahis miktarının ilgili picture box 'a basılınca değişkende tutulması.

            bahis = bahis + 30;
            label8.Text = bahis.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Bahis miktarının ilgili picture box 'a basılınca değişkende tutulması.

            bahis = bahis + 50;
            label8.Text = bahis.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Bahis miktarının ilgili picture box 'a basılınca değişkende tutulması.

            bahis = bahis + 100;
            label8.Text = bahis.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Kullanıcı bahis miktarını seçmeden oyuna başlayamaz.Bahis miktarını seçtikten sonra oyuna başlaması için gerekli olan buttonlar aktifleştiriliyor.

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
            // Kayan yazı için substring özelliğinden yararlanıldı.

            label27.Text = label27.Text.Substring(1) + label27.Text.Substring(0, 1);
        }
    }
}
