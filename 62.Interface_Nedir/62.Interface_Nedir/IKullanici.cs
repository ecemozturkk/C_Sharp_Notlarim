using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.Interface_Nedir
{
    interface IKullanici
    {
        //ozetler kullanilir (void Ekle'nin icine {} acip govde yazilamaz.)
        void Ekle(string kullaniciAd, string email, string sifre);
        void Guncelle(string kullaniciId, string kullaniciAd, string email, string sifre);
        void Sil(int kullaniciId);
        KullaniciInfo Getir(int kullaniciId);
        List<KullaniciInfo> KullanicilariGetir();
        void Aktif(int kullaniciId);
        void Pasif(int kullaniciId);
        bool Giris(string email, string sifre);


    }
}
