using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //İLK ÖNCE AŞAĞIDAKİ AÇIKLAM KISMINI OKU
            // burada ise önece aşağıda belirlemiş olduğumuz kurs class ı nı içine veri girilebilir 
            // bir hale sokuyoruz bunuda aşağıdaki ilk kod satırı gibi yapıyoruz.
            // aslında burası kolay aynı string yazıp yanına değer giriliyormuş gibi sadece bunu
            // alt başlık halinde içine yazıyormuşuz gibi düşün.
            // daha sonra bunları ekrana yazdırma kısmına gelindiğinde ise aynı normal bir değeri
            // yazdırı gibi yazıyoruz sadece burada hangi alt başlığı seçmek istiyorsak onu yazıyoruz
            // ve içinde buluna özel bir değer yazılmak isteyorsa onuda ekliyoruz. burası en sade kısım 
            // bu alt başlıklarda sadece bir tane değil bunlarıda bir dizi içine almamız ve for döngüsü 
            //ile kolayca ekrana yazdırmamız gerekmekte. bunuda önce bir dizi oluşturarak başlıyoruz.
            //belirli yazım kuralları içerisinde dizi oluşturulduktan sonra sıra yazdırma işlemine geliyor.
            // burada dizileri yazdırmada kolaylık sağlayan FOREACH döngüsü kullanılması işleri normal
            // for döngüsüne göre biraz daha kolay bir hale sokuyor.foreach döngüsünüde yine diziler verilen 
            // isim girilecek şekilde yazılıp döngünün içine klasik consol yazdırma metodu ile istenilen 
            //değer ve onun içindeki özel bir veri yazdırılıyor.
            //İŞTE CLASS BY ŞEKİLDE TANIMLANABİLİR...



            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " "+ kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3}; // DİZİ KISMI YUKARIDA BAHSEDİLEN

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " : "+ kurs.Egitmen+ " - "+ kurs.IzlenmeOrani);
            }
        }
    }

    // öncelikle ilk başlar da öğrenmiş olduğumuz str ve int gibi değerler sadece bir tek veriyi
    // tutmak için kullanılmaktaydı. ve o şekilde tek tek yazdırmak zorundaydık for 
    // döngüsü kullanılsa bile tek bir veri tipi kullanılarak yazılmaktaydı daha sonra yine veri
    // tipleriyle bir dizi oluşturuldu ve birçok veri bir arada tutuldu ancak buradada sadece tek
    // bir veri tipi ile ilerleniyordu birden fazla veri tipini kullanmak ve gerek direk konsolla
    // gerekse for döngüsü yardımıyla yazdırmak için class kullanılmaktaydı. bir class açıp içine 
    // girilecek değerler yazıalrak hazırlmaktaydır. aslında burada sadece başlıklar belirlenir
    // ve iiçine girlen veriler başka bir class altında yapılmaktadır. bunu class yazıp tab tab 
    // yap ve kurs adı belirle süslü parantez içine gir buradada propyaz ve yine tab tab tuşuna bas
    // açılan satırda public kısmına dokunma sonraki kısma veri türünü belirle ve yan tarafa 
    // girilecek ismi belirle. Buradan sonraki kısım üst tarafda anlatılmaktadır.
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
