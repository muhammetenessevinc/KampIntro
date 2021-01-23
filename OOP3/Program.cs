using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManger ihtiyacKrediMananger = new IhtiyacKrediManger();
            //ihtiyacKrediMananger.Hesapla();


            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //ya da  aşağıdaki gibi de uygulanabilmektedir




            //IKrediManager ihtiyacKrediMananger = new IhtiyacKrediManger();
            //ihtiyacKrediMananger.Hesapla();


            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();





            IKrediManager ihtiyacKrediMananger = new IhtiyacKrediManger();
            IKrediManager tasitKrediManager = new TasitKrediManager();         
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();





            // aşağıdaki loglama derside buarada gösterilmiştir.
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, new FileLoggerService());// burada file dersek dosyaya, database 
            //dersek veri tabanına loglanmakatadır.


           //basvuruManager.BasvuruYap(tasitKrediManager); // nunlardan hangisini yazarsan o yazılır yani müşteri hangisini
            // seçtiyse omu yazdırmış olur gerçekte
            //basvuruManager.BasvuruYap(konutKrediManager);






            // burada kullanıcı istediği kredi türünü seçip ona göre hesap yapılabilir. ister tek ister2 isterse hepsini
            // seçip yazdırabilir.
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediMananger, tasitKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
