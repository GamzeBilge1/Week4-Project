using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Project
{
    public class Telefon : BaseMakine
    {
        public string Lisans { get; set; }

        public override void Bilgi() //base classtaki bilgi metodu override edilerek eklemeler yapılıyor.
        {
            Console.WriteLine("-------BİLGİ-------------");

            base.Bilgi();

            Console.WriteLine("Lisans durumu: " + Lisans);
        }

        public override void UrunAdiGetir() // base classtaki UrunAdıGetir metodu override edilerek ürün adı yazdırılıyor.
        {
            Console.WriteLine("Telefonunuzun adı: " + Ad);
        }
    }
}
