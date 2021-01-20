using System;

namespace Dongular
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici yetiştirme kursu";
            string kurs2 = "Programlamaya başlanıgıç temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] 
            { "Yazılım Geliştirici yetiştirme kursu", "Programlamaya başlanıgıç temel kurs", "Java", "python","C++"};


            for (int i = 0; i < kurslar.Length; i++) // yada i+=2 şeklindede arttırılabilir.
                // yukarıdaki kurslar.length kurslar boyutunca anlamına gelir oraya herhangi bir 
                // sayı verseydik dinamik bir program olamayacaktı programa dinamizim katmak için 
                // yazılan bie koddur. Artık yukarıya hangi kursu eklenirse başka bir kod
                // değiştirmeden kullanılabilir
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("**********************************************************");
            // Farklı bir for yazımı

            foreach (string kurs in kurslar) // dizi temelli yapıları tek tek dönmeye yarar
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("SAYFA SONU");
        }
    }
}
