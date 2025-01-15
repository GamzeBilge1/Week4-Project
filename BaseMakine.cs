using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Project
{
    public abstract class BaseMakine //Temel sınıf oluşturuldu. 
    {
        //bilgisayar ve telefona ait ortak propertyler oluşturuldu
        public DateTime UretimTarihi { get; set; }
        public string SeriNo { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public virtual void Bilgi()  // Ortak özellikleri yazdıran bir virtual metod tanımlandı
        {
            UretimTarihi = DateTime.Now; // üretim tarihi nesne oluşturulduğu anda otomatik alınıyor.

            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Seri No: " + SeriNo);
            Console.WriteLine("Açıklama: " + Aciklama);
            Console.WriteLine("İşletim Sistemi: " + IsletimSistemi);
            Console.WriteLine("Üretim Tarihi: " + UretimTarihi);
        }

        public abstract void UrunAdiGetir(); // iki nesne içinde urun adını belirleyebilecekleri ortak abstract metod tanımlandı




    }
}
