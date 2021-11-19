using System;
using System.Collections.Generic;
using System.Text;


//sinif icindeki nesneler varsayilan olarak disariya kapalidir. Bu nesneleri disari aktarmamiz icin izin vermemiz gerekir = 'erisim belirleyici'
//ERISIM BELIRLEYICI
/*
    Public              :         Her yerden erisilebilir.
    Private             :         Sadece tanimlandigi sinif icerisinden erisilebilir. Default olarak private atanir.
    Internal            :         Sadece bulundugu projede erisilebilir.
    Protected           :         Sadece tanimlandigi sinifta ya da o sinifi miras alan siniflardan erisilebilir.
    Protected Internal  :         Sadece tanimlandigi sinifta ya da o sinifi miras alan siniflardan erisilebilir. Ayrica tanimlamanin ayni proje icerisinde olma sarti yoktur. Protected'ten farki budur.

 */



namespace SinifNesneleriniAnlamak_1
{
    class Kutu
    {
        //Field (Alan) = class'in ici
        public double uzunluk;
        public double genislik;
        public double yukseklik;

        // Constructor (Yapici Metot) --> geri donusleri (void, int vs..) yoktur ve sinif adiyla=(Kutu) ayni adi alirlar
        public Kutu()
        {
             uzunluk = 9;
             Console.WriteLine("Nesne Kuruldu");   //once constructor'daki 'nesne kuruldu' yazisini yazdirir, ardindan program.cs'deki main'deki -k.uzunluk- degerini yazdirir

        }

        // CONSTRUCTOR OVERLOAD
        public Kutu(double yeniUzunluk, double yeniGenislik, double yeniYukseklik)
        {
            uzunluk = yeniUzunluk;
            genislik = yeniGenislik;
            yukseklik = yeniYukseklik;
        }
        

        
    }
}
