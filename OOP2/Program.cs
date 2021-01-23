using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //gerçek için
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "enes";
            musteri1.Soyadi = "sevinç";
            musteri1.TcNo = "5432114";

            //tüzel için


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "987";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";



            Musteri musteri3 = new GercekMusteri(); // musteri hem tüzel kişinin hemde tüzel kişinin referansını tutuyor
            Musteri musteri4 = new TuzelMusteri();

        }
    }
}
