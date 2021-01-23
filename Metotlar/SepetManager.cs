using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        // syntax
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) //Bu kullanım yönetilmesi zor ve doğru bir kullanımk değildir.
            /* metodu bu şekilde de tanımlayabiliriz ama özellikleri tek tek yazdığımız için yeni bir özellik eklemek istediğimiz zaman
             bütün alanlarda tek tek değeri manuel eklemek gerekir ama yukarıdaki gibi ürün sınıfı tipinde bir değişken tanımladığımızda bu
            değişkenin tüm özelliklerini bu classla verebiliyoruz. Dolayısıyla özelliklerin hepsini ürün classında encapsulation yapmış oluyoruz. 
             */
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urunAdi);
        }
        
    }
}
