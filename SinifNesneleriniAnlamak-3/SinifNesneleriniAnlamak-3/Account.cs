using System;
using System.Collections.Generic;
using System.Text;

namespace SinifNesneleriniAnlamak_3
{
    class Account
    {
        public Account()   // Constructor (Yapici Metot) --> geri donusleri (void, int vs..) yoktur ve sinif adiyla=(Kutu) ayni adi alirlar
        {

        }
        public string GetAccount(string userName)
        {
            if (!string.IsNullOrEmpty(userName)) //username null ya da bos degilse
            {

            }
            if (!string.IsNullOrWhiteSpace(userName)) //username bosluk degilse
            {

            }
            return "BILINMIYOR";
        }
        public string GetAccount(int userId)
        {
            string result = string.Empty;

            if (userId > 0)
            {
                result = "Ali Kaya";
            }
            else
            {
                throw new Exception("Hata!");
            }
            return result;
        }
    }
}
