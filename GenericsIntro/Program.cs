using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {// peki LİSTEME OLMASAYDI BİZ KENDİMİZ YAPANİLİRMİYDİK ONUN BİR ÖRNEĞİ BURADA YAPILIYOR
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
        }
    }
}
