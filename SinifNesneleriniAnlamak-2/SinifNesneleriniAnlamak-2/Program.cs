using System;

namespace SinifNesneleriniAnlamak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Siniflar
            Kutu k = new Kutu();
            //k.uzunluk = -100;
            //Console.WriteLine(k.uzunluk);
            k.SetUzunluk(100);
            Console.WriteLine(k.GetUzunluk());
            k.Genislik = 30;
            Console.WriteLine(k.Genislik);
            
        }
    }
}
