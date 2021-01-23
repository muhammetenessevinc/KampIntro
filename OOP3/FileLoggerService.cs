using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }

    // class kısa yolu clasın altına istediğini yaz class baslığına bir kez tıkla yandaki alpulden en üsttekine bas 
    // otomatik yeni class oluşturcak ve yazdıllarını yeni clasın içine atacaktır.
}
