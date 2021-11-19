using System;
using System.Collections.Generic;
using System.Text;

namespace SinifNesneleriniAnlamak_2
{
    class Kutu

    {
        // Field (Alan) disari kapali olmalidirlar. (private)
        private double uzunluk;
        private double genislik;
        private double yukseklik;
        
        
        // Constructor (Yapici Metot) --> geri donusleri (void, int vs..) yoktur ve sinif adiyla=(Kutu) ayni adi alirlar
        public Kutu()
        {
            //uzunluk = 9;
            //Console.WriteLine("Nesne Kuruldu");   //once constructor'daki 'nesne kuruldu' yazisini yazdirir, ardindan program.cs'deki main'deki -k.uzunluk- degerini yazdirir

        }

        //DESTRUCTOR (YIKICI METOT) nesnenin olmesi, program sonlanirken cok kisa sure icin gerceklesir.
        ~Kutu() //sadece sinifin adi yazilir
        {
            Console.WriteLine("Uygulama kapaniyor"); //kapanmadan kisa bir sure icin ekrana bunu yazacak
        }

        // CONSTRUCTOR OVERLOAD
        public Kutu(double yeniUzunluk, double yeniGenislik, double yeniYukseklik)
        {
            uzunluk = yeniUzunluk;
            genislik = yeniGenislik;
            yukseklik = yeniYukseklik;
        }
        //KAPSULLEME (ENCAPSULATION) = Iki yolu var : Getter&Setter ve Property
        #region Getter & Setter Methods
        public double GetUzunluk()
        {
            return uzunluk;
        }
        public void SetUzunluk(double uzunluk)
        {
            // this.uzunluk = uzunluk; // sonra gidip program.cs'ye k.SetUzunluk(100); dedik
            // DISARDAN GELEN -private double uzunluk- DEGISKENINI YONETMEK ICIN:
            if(uzunluk >= 2)
            {
                this.uzunluk = uzunluk;
            }
            else
            {
                this.uzunluk = 2;
            }
        }
        #endregion

        #region Property
        //public double Genislik
        //{
        //    get { return genislik; }
        //    set { genislik = value; } // Daha sonra Program.cs'ye k.Genislik=30 yaziyoruz
        //}
        public double Genislik
        {
            get  //eger sadece get'i yorum satiri haline getirirsek Program.cs'deki ConsoleWriteLine(k.Genislik); satirinin hata verdigini goruruz. Cunku get'i ekarte etmek demek degerini okuyamayacagimiz anlamina gelir.
            {
                return Genislik;
            }
            //set  // eger sadece veri alinabilmesini istiyor(get), herhangi bir deger atanamasin istiyorsak direkt set'i hic kullanmayiz... Set'i yorum satiri haline getirdikten sonra Program.cs'deki k.Genislik=30; satirinin hata verdigini goruruz cunku Set'i yorum satiri haline getirince deger atanmasini engellemis olduk.
            //{
            //    genislik = value;  
            //}
        }
        #endregion

    }
}
