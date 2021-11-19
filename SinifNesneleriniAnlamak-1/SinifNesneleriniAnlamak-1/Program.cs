using System;

namespace SinifNesneleriniAnlamak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // SINIFLAR

            Kutu k = new Kutu(5,6,7);    // () konmasinin sebebi constructor methods (yapici metot)
            Console.WriteLine(k.uzunluk);
        }
    }
}
