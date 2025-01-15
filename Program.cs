using Week4_Project;

bool devamEt = true;   // Kullanıcı başka bir ürün üretmek isterse döngüyü devam ettirir

while (devamEt == true)
{


    int secim;

    do
    {

        Console.WriteLine("Telefon üretmek için 1 , bilgisayar üretmek için 2 ye basınız."); // Kullanıcıdan ürün türü seçimi isteniyor

        secim = Convert.ToInt32(Console.ReadLine());
        if (secim == 1 || secim == 2)
        {
            Console.WriteLine("Doğru giriş yaptınız!");
            break; // Geçerli seçim yapıldı, döngüden çık
        }
        else
        {
            Console.WriteLine("Yanlış giriş yaptınız! Lütfen tekrar deneyin.");

        }
    } while (true);


    if (secim == 1) // Telefon üretimi
    {
        Telefon telefon = new Telefon(); //Telefon nesnesi üretiliyor

        // Telefon için kullanıcıdan bilgiler alınıyor
        Console.WriteLine("Telefonunuzun adını giriniz.");
        telefon.Ad = Console.ReadLine();

        Console.WriteLine("Seri no giriniz:");
        telefon.SeriNo = Console.ReadLine();

        Console.WriteLine("Açıklama giriniz:");
        telefon.Aciklama = Console.ReadLine();

        Console.WriteLine("İşletim sistemini giriniz:");
        telefon.IsletimSistemi = Console.ReadLine();

        Console.WriteLine("Lisans durumunu giriniz:");
        telefon.Lisans = Console.ReadLine();

        // Telefon bilgileri yazdırılıyor

        telefon.Bilgi();
        telefon.UrunAdiGetir();

    }
    if (secim == 2) // Bilgisayar üretimi
    {
        Bilgisayar bilgisayar = new Bilgisayar(); //bilgisayar  nesnesi üretiliyor

        // Bilgisayar için kullanıcıdan bilgiler alınıyor

        Console.WriteLine("Bilgisayarın adını giriniz.");
        bilgisayar.Ad = Console.ReadLine();

        Console.WriteLine("Seri no giriniz:");
        bilgisayar.SeriNo = Console.ReadLine();

        Console.WriteLine("Açıklama giriniz:");
        bilgisayar.Aciklama = Console.ReadLine();

        Console.WriteLine("İşletim sistemini giriniz:");
        bilgisayar.IsletimSistemi = Console.ReadLine();

        Console.WriteLine("USB giriş sayısını giriniz: ( 2 ya da 4)");
        bilgisayar.Usb = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bluetooth olup olmama durumunu giriniz.");
        bilgisayar.Bluetooth = Console.ReadLine();

        // Bilgisayar bilgileri yazdırılıyor
        bilgisayar.Bilgi();
        bilgisayar.UrunAdiGetir();
    }

    // Kullanıcıya tekrar ürün üretmek isteyip istemediği soruluyor

    Console.WriteLine("Ürün başarıyla üretildi. Başka bir ürün üretmek ister misiniz? (Evet/Hayır)");
    string cevap = Console.ReadLine().ToLower();

    if (cevap == "hayır") // Program sonlandırma kontrolü
    {
        devamEt = false;
        Console.WriteLine("İyi günler! Program sonlandırılıyor.");
    }

}