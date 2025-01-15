# Teknoloji Mağazası Ürün Yönetimi

Bu proje, bir teknoloji mağazasında telefon ve bilgisayar kayıtlarının yönetimini sağlayan bir konsol uygulamasıdır. Proje kapsamında OOP (Nesne Yönelimli Programlama) prensipleri uygulanmıştır.

## Proje Özellikleri

- **Telefon ve Bilgisayar Kayıtları:** 
  - Telefon: Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, Lisans Durumu
  - Bilgisayar: Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, USB Giriş Sayısı, Bluetooth Durumu
- **Base Class:** Telefon ve Bilgisayar sınıflarının türetildiği `BaseMakine` sınıfı.
- **Encapsulation:** USB giriş sayısı sadece 2 veya 4 olabilir, aksi durumda -1 atanır.
- **Polymorphism:** `Bilgi` metodu override edilerek her sınıf için özelleştirilmiştir.
- **Abstraction:** `UrunAdiGetir` abstract metodu her sınıf için ayrı mesajlar üretir.
- **Dinamik Kullanıcı Etkileşimi:** Kullanıcıdan ürün bilgileri konsol üzerinden alınır ve doğrulama yapılır.

## Uygulama Akışı

1. Konsol ekranında, kullanıcıdan bir telefon veya bilgisayar üretmek için seçim yapması istenir.
2. Kullanıcıdan seçilen ürün türüne göre bilgileri girmesi istenir.
3. Ürün başarıyla oluşturulduğunda detaylar konsola yazdırılır.
4. Kullanıcıya başka bir ürün üretmek isteyip istemediği sorulur.
5. Kullanıcı "Hayır" dediğinde uygulama sonlandırılır.

