using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61.Inheritance_Kavrami_Nedir
{
    class IkiBoyut
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public void Goster()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Genislik : " + Genislik);
            builder.Append(Environment.NewLine);
            builder.Append("Yukseklik : " + Yukseklik);
            builder.Append(Environment.NewLine);
            Console.WriteLine(builder.ToString());


        }
    }
}
