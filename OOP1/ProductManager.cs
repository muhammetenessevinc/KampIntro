using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // ürünle ilgili operrasyonlar vardır ProductMnager dosylarının içinde eklem silme güncelleme gibi


        // int, double, bool değer tip - herşey değeri üzerinden olur ayrıntı için deftere bak
        //diziler class, bastract, interface referas tip
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+ "Eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi");
        }


    }
}
