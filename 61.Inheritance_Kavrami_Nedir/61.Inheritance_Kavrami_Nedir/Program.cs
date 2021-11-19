using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.Inheritance_Kavrami_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance (Kalitim/miras)

            

            A a = new A();
            a.PropA = 3;

            B b = new B();
            b.PropB = 5;
            b.PropA = 8; //--class B : A-- sayesinde artik b.PropA yazabiliyoruz

            C c = new C();
            c.PropC = 1;
            c.PropA = 7; // C, B'den miras aldi. B de A'dan miras almis oldugu icin C direkt olarak A'dan da miras almis sayildi


            IkiBoyut iki = new IkiBoyut();
            iki.Genislik = 10;
            iki.Yukseklik = 20;
            iki.Goster();

            Console.WriteLine("****************************");

            Ucgen ucgen = new Ucgen();
            ucgen.Genislik = 20;
            ucgen.Yukseklik = 50;
            ucgen.Stil = "Ucgen";
            ucgen.Goster();
            ucgen.StilGoster();
            Console.WriteLine("Alan: " + ucgen.AlanHesapla());

            Console.ReadLine();

        }
    }
    class A  //Base (Temel Sinif) olsun
    {
        public int PropA { get; set; }
    }
    class B : A // B, A'dan miras aldi
    {
        public int PropB { get; set; }
    }
    class C:B 
    {
        public int PropC { get; set; }
    }
}
