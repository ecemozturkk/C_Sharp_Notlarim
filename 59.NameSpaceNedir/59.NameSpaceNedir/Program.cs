using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA.TeamA; //MAIN ICINDE YAZMAK YERINE DIREKT BURAYA DA YAZABILIRIZ
using PR_A_TE_B = ProjectB.TeamA; // IKI TANE FARKLI TeamA OLDUGU ICIN KARISTIRILMAMASI ADINA KISA BIR ISIM DE VERILEBILIR

namespace _59.NameSpaceNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // // NAMESPACE  (en yukarida using ProjectA.TeamA; kullandigimiz icin alttaki 2 satiri kullanmamiza gerek kalmadi)
            // ProjectA.TeamA.ClassA sinif1 = new ProjectA.TeamA.ClassA(); // Once sadece static olarak tanimladigimiz icin goremedi, sonra public void Yaz() tanimladik.
            // sinif1.Yaz();


            ClassA sinif2 = new ClassA();
            sinif2.Yaz();

            Console.ReadLine();



        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
       class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeA, TeamA,ClassA,Print()");
            }
            public void Yaz()
            {
                Console.WriteLine("ProjeA, TeamA,ClassA,Yaz()");
            }
        }
    }
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeA, TeamB,ClassA,Print()");
            }
        }
    }
}
namespace ProjectB
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("ProjeB,TeamA,ClassA,Print()");
            }
        }

    }
}
