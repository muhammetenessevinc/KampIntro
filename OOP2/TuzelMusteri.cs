using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // coorporate _ ingilizcesi tüzelin

    class TuzelMusteri:Musteri   // bu olaya miras yada inheritance  tüzel musteri bir müşteridir demek oluyor 
                                 // gerçekle tüzeli aynı yere toplamak için yapılır   : Musteri yazısı
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
