using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {// prop yazıp tab tab  tuşuna basınca kendisi tamamlamasına snippet denir
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        //public int Myproperty { get; set; }
        public int UnitsInStock { get; set; }

        // eklemek yada silmek gibi olaylara CRUD Denir

    }
}
