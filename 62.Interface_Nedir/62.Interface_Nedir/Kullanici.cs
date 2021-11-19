using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.Interface_Nedir
{
    class Kullanici : IKullanici //Kalitim uygulandi
    {
        public void Aktif(int kullaniciId)
        {

            // C# + SQL sorgulari
            throw new NotImplementedException();
        }

        public void Ekle(string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public KullaniciInfo Getir(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public bool Giris(string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(string kullaniciId, string kullaniciAd, string email, string sifre)
        {
            throw new NotImplementedException();
        }

        public List<KullaniciInfo> KullanicilariGetir()
        {
            throw new NotImplementedException();
        }

        public void Pasif(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public void Sil(int kullaniciId)
        {
            throw new NotImplementedException();
        }
    }
}
