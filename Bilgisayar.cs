using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Project
{
    public class Bilgisayar : BaseMakine //BaseMakine den miras alıyor.
    {
        private int _usb; // field

        public string Bluetooth { get; set; }
        public int Usb
        {
            get
            {
                return _usb;
            }

            set
            {
                if (value == 2 || value == 4)
                {
                    _usb = value; // usb girişi 2 yada 4 atanabilir.

                }
                else
                {
                    Console.WriteLine("usb girişi 2 veya 4 dışında bir değer olamaz");
                    _usb = -1; // eğer 2 ya da 4 dışında değer verilmezse -1 atanır.
                }
            }
        }

        public override void Bilgi()  //base classtaki bilgi metodu override edilerek eklemeler yapılıyor.
        {
            Console.WriteLine("-------BİLGİ-------------");
            base.Bilgi();

            Console.WriteLine("USB girişi sayısı: " + _usb);
            Console.WriteLine("Bluethoot var mı? " + Bluetooth);
        }

        public override void UrunAdiGetir()  // base classtaki UrunAdıGetir metodu override edilerek ürün adı yazdırılıyor.
        {
            Console.WriteLine("Bilgisayarınızın adı: " + Ad);
        }
    }
}
