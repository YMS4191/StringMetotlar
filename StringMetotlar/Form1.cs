using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
 * Sahip oldugunuz metinsel degerlerin ozelliklerini degistirmek icin kullanilan metotlardir. Ornegin, kelimeleri parcalamak, eklemek, harflerin yerlerini degistirmek, bosluk temizlemek vs...
 */
        }


        string ornekMetin = "";

        #region Örnek 1
        private void btnCOMPARETO_Click(object sender, EventArgs e)
        {
            //CompareTo => Metodu kullandiginiz string degerle metoda verdiginiz parametredeki string degeri sozluk mantigiyla karsilastirir... Eger sozlukte ayni lokasyonlardasa 0, parametredeki deger, ana degerimizden sozlukte onceyse -1; sonraysa 1 degerini dondurur...

            ornekMetin = txtGirisAlani.Text;
            int result = ornekMetin.CompareTo("araba");
            string mesaj = "";
            switch (result)
            {
                case -1:
                    mesaj = "Kelime, diğer kelime ile eşleşmemektedir, eksik karakter mevcut";
                    break;
                case 0:
                    mesaj = "Kelime, diğer kelime ile eşleşmektedir";
                    break;
                case 1:
                    mesaj = "Kelime, diğer kelime ile eşleşmemektedir, fazla karakter mevcut";
                    break;
                default:
                    break;
            }
            MessageBox.Show(mesaj);
        }

        #endregion

        #region Örnek 2
        private void btnCONTAINS_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            bool result = ornekMetin.Contains("adam");
            MessageBox.Show($"Aradığınız kelime metin içerisinde geçme{(result ? "" : "me")}ktedir");
        }
        #endregion

        #region Örnek 3
        private void btnSTARTSWITH_Click(object sender, EventArgs e)
        {
            //StartsWith => Kelimenizin parametrede gonderdiginiz degerle baslayip baslamadigini size "bool" olarak dondurur...

            ornekMetin = txtGirisAlani.Text;
            bool result = ornekMetin.StartsWith("bil");

            MessageBox.Show($"Metin parametrede gönderdiğiniz anahtar kelime ile başlama{(result ? "" : "ma")}ktadır");
        }
        #endregion

        #region Örnek 4
        private void btnENDSWITH_Click(object sender, EventArgs e)
        {
            //EndsWith => Kelimenizin parametrede gonderdiginiz degerle bitip bitmedigini size "bool" olarak dondurur...

            ornekMetin = txtGirisAlani.Text;
            bool result = ornekMetin.EndsWith("dam");

            MessageBox.Show($"Kelime parametrede gönderdiğiniz değer ile bitme{(result ? "" : "me")}ktedir");
        }
        #endregion

        #region Örnek 5
        private void btnINDEXOF_Click(object sender, EventArgs e)
        {
            //IndexOf => Dizilerde gordugumuz metodun ayni prensibleriyle calisir. Eger harf varsa harfin indexini, yoksa -1 degerini, harf birden fazla var ise ilk harfin indexini dondurur...


            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.IndexOf('@');

            MessageBox.Show(index > -1 ? "Aradığınız karakterin metin içerisindeki index değeri : " + index : "Metin içerisinde aradığınız parametre yer almamaktadır");
        }
        #endregion

        #region Örnek 6
        private void btnLASTINDEXOF_Click(object sender, EventArgs e)
        {
            //LastIndexOf => Dizilerde gordugumuz metodun ayni prensibiyle calisir. Eger harf varsa harfin indexini, yoksa - 1 degerini, harf birden fazla varsa son harfin indexini dondurur...

            ornekMetin = txtGirisAlani.Text;
            int index = ornekMetin.LastIndexOf('a');

            MessageBox.Show(index > -1 ? "Aradığınız karakterin metin içerisindeki index değeri : " + index : "Metin içerisinde aradığınız parametre yer almamaktadır");
        }
        #endregion

        #region Örnek 7
        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            //NOT => Bir string uzerinde yaptiginiz degisiklikler o string'i degistirmez, size yeni bir kopyasini teslim eder...

            ornekMetin = txtGirisAlani.Text;

            // ornekMetin = ornekMetin.Remove(5); // verdiğiniz index değeri dahil olmak üzere kalan tüm karakterleri siler
            ornekMetin = ornekMetin.Remove(3, 2);
            // 1. Parametre, başlangın index değeri
            // 2. Parametre, silinecek eleman sayısı
            MessageBox.Show(ornekMetin);
        }
        #endregion

        #region Örnek 8
        private void btnREPLACE_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Replace("adam", "hatun");


            // ş s ı i  ğ g ü u ç c ö o
            // Ş S i I  Ğ G Ü U Ç C Ö O

            ornekMetin = ornekMetin
                .Replace('ş', 's')
                .Replace('ç', 'c')
                .Replace('ğ', 'g');


            MessageBox.Show(ornekMetin);
        }
        #endregion

        #region Örnek 9
        private void btnSPLIT_Click(object sender, EventArgs e)
        {
            string[] mailAdresler = txtGirisAlani.Text.Split(',', ';', '.', '+');
            foreach (string mail in mailAdresler)
            {
                MessageBox.Show(mail);
            }

            // kullanıcın girdiği dataları (; , . + ) gibi gördüğü yerden ayırıp mb içerisinde gösteriniz
        }
        #endregion

        #region Örnek 10
        private void btnINSERT_Click(object sender, EventArgs e)
        {
            //Insert => Bir metinsel degerin herhangi bir pozisyonuna (index) yeni bir degeri ilistirmek istiyorsaniz bu metodu kullanabilirsiniz. İlk parameterde kacinci indexten sonra ekleyecegini, ikinci parametrede ise hangi metni ekleyecegini sorar...

            ornekMetin = txtGirisAlani.Text;
            ornekMetin = ornekMetin.Insert(5, "cik");
            MessageBox.Show(ornekMetin);
        }
        #endregion

        #region Örnek 11
        private void btnTOLOWERTOUPPER_Click(object sender, EventArgs e)
        {
            //ToLower => İlgili metnin tamamını küçük harfe çevirmenize olanak saglar..
            //ToUpper => İlgili metnin tamamini buyuk harfe cevirmenize olanak saglar..
            this.Text = txtGirisAlani.Text.ToLower();
            MessageBox.Show(txtGirisAlani.Text.ToUpper());
        }
        #endregion

        #region Örnek 12
        private void btnSUBSTRING_Click(object sender, EventArgs e)
        {
            //Substring (1.Kullanım) => Metninizden, parametrede gonderdiginiz indexten baslayarak, geri kalan kismi cekip almaniza olanak saglar...
            //Substring (2.Kullanım) => Metninizden, ilk parametrede verdiginiz indexten baslayip, ikinci parametrede verdiginiz deger kadarlik kismi cekip almaniza olanak saglar..

            // Remove (5)   => "bilge adam" => "bilge"
            // Substring(5) => "bilge adam" => " adam"

            ornekMetin = txtGirisAlani.Text;
            // ornekMetin = ornekMetin.Substring(5);

            // Remove(3,2)    => "bilge adam" => "bil adam"
            // Substring(3,2) => "bilge adam" => "ge"
            ornekMetin = ornekMetin.Substring(3, 2);
            MessageBox.Show(ornekMetin);
        }
        #endregion

        #region Örnek 13
        private void btnTOCHARARRAY_Click(object sender, EventArgs e)
        {
            //ToCharArray => Stringinizi charlarina ayirarak size char[] olarak teslim eder...
            ornekMetin = txtGirisAlani.Text;
            char[] karakterler = ornekMetin.ToCharArray();

            //ORNEK: disaridan girilen metindeki her bir karakterin ASCII degerleri toplami kactir?

            int toplam = 0;
            foreach (char karakter in karakterler)
            {
                toplam += karakter;
            }
            MessageBox.Show(toplam.ToString());
        }
        #endregion

        #region Örnek 14
        private void btnTRIM_Click(object sender, EventArgs e)
        {
            //Trim => Metninizin saginda ya da solundaki tum bosluklari temizlemenize olanak saglayan metottur...

            ornekMetin = txtGirisAlani.Text;
            //int l1 = ornekMetin.Length;
            //ornekMetin = ornekMetin.Trim();
            //int l2 = ornekMetin.Length;

            //MessageBox.Show($"Metin boşluklar dahil toplamda {l1} karakterden oluşmaktadır!\nMetin boşluklar silinerek toplamda {l2} karakterden oluşmaktadır");

            //"".TrimEnd()   => metnin sonundaki boşlukları siler
            //"".TrimStart() => metnin başındaki boşlukları siler

            MessageBox.Show(ornekMetin.Trim('b', 'm'));

        } 
        #endregion
    }
}





