using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.Inheritance_Kavrami_Nedir
{
    class Ucgen : IkiBoyut
    {
        public string Stil { get; set; }

        public void StilGoster()
        {
            Console.WriteLine("Stil : " + Stil);
        }
        public double AlanHesapla()
        {
            return Genislik * Yukseklik / 2;
        }
    }
}
