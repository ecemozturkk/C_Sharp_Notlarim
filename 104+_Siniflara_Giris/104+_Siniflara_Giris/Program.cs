using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104__Siniflara_Giris
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager ecem = new CustomerManager();
            ecem.Add();
            ecem.Update();

            ProductManager ecem2 = new ProductManager();
            ecem2.Add();
            ecem2.Update();

            Customer Merve = new Customer();
            Merve.City = "Bursa";
            Merve.Id = 2;
            Merve.Firstname = "Merve";
            Merve.Lastname = "Yilmaz";  // bu sekilde deger verilince set blogu calisir.

            Customer Ata = new Customer
            {
                Id = 1,
                City="Van",
                Firstname="Ata",
                Lastname="Can"
            };
            Console.WriteLine(Ata.Lastname);

            Console.ReadLine();
            
        }
    }
    
    

}
