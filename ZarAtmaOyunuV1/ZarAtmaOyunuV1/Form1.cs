using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// ////////////////////////////////////6.12.2021//////////////////////
/// 
/// </summary>
namespace ZarAtmaOyunuV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();// Randoom sayı 
        int _Oyuncu1Skor, _Oyuncu2Skor=0;// oyuncuların skorklarını tutan değişkenler
        int _Oyuncu1Zar, _Oyuncu2Zar; // oyuncuların attığı zarları tutan değişkenler
        int OyununBiteceğiSkor; // oyunu başlatan kişinin hangi skorda biteceğini tutan değişken

        private void Oyuncu1Zar() // oyuncu1 in attığı zarın fonksiyonu
        {


            _Oyuncu1Zar = random.Next(1, 7); // rasgele 0 ile 7 arasında random sayı üretiyoruz.
         

            //oyuncu 1
            if (_Oyuncu1Zar == 1) 
            {
                pictureBox_Oyuncu1.ImageLocation = "image\\1.png";
            }
            if (_Oyuncu1Zar == 2)
            {
                pictureBox_Oyuncu1.ImageLocation = "image\\2.png";
            }
            if (_Oyuncu1Zar == 3)
            {
                pictureBox_Oyuncu1.ImageLocation = "image\\3.png";
            }
            if (_Oyuncu1Zar == 4)
            {
                pictureBox_Oyuncu1.ImageLocation = "image\\4.png";
            }
            if (_Oyuncu1Zar == 5)
            {
                pictureBox_Oyuncu1.ImageLocation = "image\\5.png";
            }
            if (_Oyuncu1Zar == 6)
            {
                pictureBox_Oyuncu1.ImageLocation = "image\\6.png";
            }

        }
        private void  Oyuncu2Zar()// 2. oyuncunun zar fonksiyonu
        {
            // oyuncu 2

            _Oyuncu2Zar = random.Next(1, 7); // 0 ile 7 arasında rastgele sayı üretiyoruz.


            if (_Oyuncu2Zar == 1)
            {
                pictureBox_Oyuncu2.ImageLocation = "image\\1.png";
            }
            if (_Oyuncu2Zar == 2)
            {
                pictureBox_Oyuncu2.ImageLocation = "image\\2.png";
            }
            if (_Oyuncu2Zar == 3)
            {
                pictureBox_Oyuncu2.ImageLocation = "image\\3.png";
            }
            if (_Oyuncu2Zar == 4)
            {
                pictureBox_Oyuncu2.ImageLocation = "image\\4.png";
            }
            if (_Oyuncu2Zar == 5)
            {
                pictureBox_Oyuncu2.ImageLocation = "image\\5.png";
            }
            if (_Oyuncu2Zar == 6)
            {
                pictureBox_Oyuncu2.ImageLocation = "image\\6.png";
            }
        }


        private void OyunuKazanan() // oyunu kazananı belirleyen fonksiyon
        {
            
            
            if (_Oyuncu1Skor >= OyununBiteceğiSkor) // belirlenen skor 1. oyuncunun skoruna eşitse if bloğu
            {
                MessageBox.Show("1. Oyuncu Kazandı!!!!!!");
                buttonTekrar.Visible = true;
                buttonOyuncu1.Enabled = false;
                buttonOyuncu2.Enabled = false;
            }
            if (_Oyuncu2Skor >= OyununBiteceğiSkor)// belirlenen skor 2. oyuncunun skoruna eşitse if bloğu
            {
                MessageBox.Show("2. Oyuncu Kazandı!!!!!!"); 
                buttonTekrar.Visible = true;
                buttonOyuncu1.Enabled = false;
                buttonOyuncu2.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonOyuncu1_Click(object sender, EventArgs e) // 1. oyuncu zar atmak için tıkladığı buton
        {
            pictureBox_Oyuncu1.Visible = true;
            TextBoxSkor.Enabled = false;
            buttonOyuncu1.Enabled = false;
            buttonOyuncu2.Enabled = true;
            pictureBox_Oyuncu2.Visible = false;
            Oyuncu1Zar(); // fonksiyonu çağırıyoruz.
            pictureBox_Oyuncu1.Visible = true;
            _Oyuncu1Skor +=_Oyuncu1Zar; // oyuncunun attığı zarı skoruna ekliyoruz.
            labelOyuncu1Skor.Text = Convert.ToString(_Oyuncu1Skor);
            OyunuKazanan(); // fonksiyonu çağırıyoruz.
        }

        private void buttonBaşla_Click(object sender, EventArgs e) // oyunu başlatmak için kullandığımız buton
        {
            pictureBox_Oyuncu1.Visible = false;
            pictureBox_Oyuncu2.Visible = false;
            labelOyuncu1Skor.Visible = true;
            labelOyuncu2Skor.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            buttonOyuncu1.Visible = true;
            buttonOyuncu2.Visible = true;
            buttonOyuncu1.Enabled = true;
            OyununBiteceğiSkor = Convert.ToInt32(TextBoxSkor.Text); // textbox da yazan değeri değişkene atadık.
            buttonBaşla.Visible = false;
            label1.Visible = false;
            TextBoxSkor.Visible = false;
        }

        private void buttonOyuncu2_Click(object sender, EventArgs e) // 2. oyuncunun zarı atması için bastığımız buton
        {
          
            pictureBox_Oyuncu1.Visible = false;
            TextBoxSkor.Enabled = false;
            buttonOyuncu2.Enabled = false;
            buttonOyuncu1.Enabled = true;
            Oyuncu2Zar();// fonksiyonu çağırıyoruz
            pictureBox_Oyuncu2.Visible = true;
            _Oyuncu2Skor += _Oyuncu2Zar;
            labelOyuncu2Skor.Text = Convert.ToString(_Oyuncu2Skor); // skoru forma yazdıran kod satırı
            OyunuKazanan(); // fonksiyonu çağırıyoruz

        }

        private void button1_Click(object sender, EventArgs e) // oyunu yeniden başlatan button
        {
            pictureBox_Oyuncu1.Visible = false;
            pictureBox_Oyuncu2.Visible = false;
            labelOyuncu1Skor.Visible = false;
            labelOyuncu2Skor.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            buttonOyuncu1.Visible = false;
            buttonOyuncu2.Visible = false;
            _Oyuncu1Skor = 0; // skorları tekrardan sıfırlıyoruz
            _Oyuncu2Skor = 0; // skorları sıfırlıyoruz.
            labelOyuncu1Skor.Text = "0";
            labelOyuncu2Skor.Text = "0";
            buttonBaşla.Visible = true;
            label1.Visible = true;
            TextBoxSkor.Visible = true;
            TextBoxSkor.Enabled = true;


        }
    }
}
