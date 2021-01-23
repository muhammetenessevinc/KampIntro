using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {// method injection
        public void BasvuruYap(IKrediManager kreediManager,ILoggerService loggerService)
        {
            kreediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) // listedeki her bir kredinni hesabını yap
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
