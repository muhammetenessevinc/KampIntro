using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety : tip güvenliği yani başına string yada int olduğunu belirtmek gerekir
            // Do not repeat yoursekf - kendini tekrarlama ÖNEMLİ

            // değer tutucu kategori etiketi
            string KategoriEtiketi = "Kategori";
            int ogrencisayisi = 32000;
            double faizorani = 1.45;
            bool sistemegirisyapmismi = true;

            double dolardun = 7.55;
            double dolarbugun = 7.55;

            //ŞART BLOKLARI

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("Dolar düşüş oku");
            }
            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("Dolar yükseliş oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }



            if (sistemegirisyapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }





            Console.WriteLine(KategoriEtiketi);
            




        }
    }
}
