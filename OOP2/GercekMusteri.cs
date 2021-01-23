using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri: Musteri  // bu olaya miras yada inheritance  tüzel musteri bir müşteridir demek oluyor 
                                  // gerçekle tüzeli aynı yere toplamak için yapılır : Musteri yazısı
    {
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        
    }
}
