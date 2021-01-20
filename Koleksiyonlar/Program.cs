using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);



            // bu kısatma toplu şekilde yorum satırına alır ctrl+ k - ctrl+ c
            //isimler[4] = "İlker"; // burada böyle bir yer yok bunu yapamazsın
            //Console.WriteLine(isimler[4]); //burada hata verecektir

            //isimler = new string[5];
            //isimler[4] 0 "İlker";  // burası çalışır ancak yeni bir isimler 
            //dizisi açmak gibi olur ve diğerleri silinir
            // diziler daha sonra genişletilemez bu sebeple koleksiyonlar geliştirlmiştir.

            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");            // burada sonradan eleman ekleme gibi bir özellik vardır
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);  



        }
    }
}
