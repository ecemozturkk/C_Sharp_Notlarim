using System;

namespace SinifNesneleriniAnlamak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            var result = acc.GetAccount(3);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
