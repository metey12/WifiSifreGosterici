# WiFi Şifre Görüntüleyici

Bu uygulama, bilgisayarınızda kayıtlı olan Wi-Fi ağlarının şifrelerini görüntülemek için tasarlanmış basit bir WinForms programıdır. `netsh wlan` komutunu kullanarak ağ profillerini ve şifrelerini alır ve kullanıcı dostu bir arayüzde gösterir.

## Özellikler

* **Ağları Listeleme**: Sisteminizde daha önce bağlanmış olduğunuz tüm Wi-Fi ağlarını gösterir.
* **Şifreyi Gösterme**: Seçtiğiniz bir ağ profilinin şifresini düz metin olarak görüntüler.
* **Karakter Desteği**: Türkçe karakter sorunlarını çözmek için ek kodlama desteği (Code Page 857) içerir.

## Nasıl Kullanılır?

1.  Uygulamayı çalıştırın.
2.  **"Ağları Yükle"** butonuna tıklayarak kayıtlı Wi-Fi ağlarının listesini getirin.
3.  Listeden şifresini öğrenmek istediğiniz ağı seçin.
4.  **"Şifreyi Göster"** butonuna tıkladığınızda şifre, alt kısımdaki metin kutusunda belirecektir.

## Kodu Anlama

Uygulama, temel olarak iki `netsh` komutunu çalıştırır:

1.  `netsh wlan show profiles`: Bu komut, cihazda kayıtlı tüm ağ profillerinin bir listesini verir. Program bu çıktıyı okuyarak ağ adlarını listeler.
2.  `netsh wlan show profile name="[AĞ ADI]" key=clear`: Bu komut, seçilen ağın tüm detaylarını, şifresini de içerecek şekilde düz metin olarak gösterir. Program, bu çıktıda **"Anahtar İçeriği"** satırını bularak şifreyi alır.

## Sorumluluk Reddi

Bu program sadece eğitim amaçlı ve kişisel kullanım için geliştirilmiştir. Lütfen bu kodu yalnızca kendi cihazlarınızda ve erişim izniniz olan ağlarda kullanın. Başkalarının izni olmadan bu tür bilgilere erişim sağlamak etik dışı ve yasalara aykırı olabilir. Programın kötüye kullanımından geliştirici sorumlu tutulamaz.
