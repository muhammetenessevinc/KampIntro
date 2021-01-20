using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            //type-safe  -- tip güvenli hangi tip ile çalıştığını program bilmek ister
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");



            }
            //cw yaz tab tab console.wrteline(); oluşturur
            Console.WriteLine("---------------------METOTLAR---------------------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut","Yeşil Armut",12);
            sepetManager.Ekle2("elma", "Yeşil elma", 12);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12);
        }
    }
}
