🐍 Snake Game
Bu proje, klasik yılan oyununun C# programlama dili kullanılarak Windows Forms (WinForms) platformunda geliştirilmiş basit bir masaüstü uygulamasıdır. Projenin amacı, temel oyun döngüsü, kullanıcı etkileşimi ve nesne yönelimli programlama prensiplerinin uygulanmasını içeren bir yapıyı ortaya koymaktır.

🔧 Teknolojiler
Programlama Dili: C#

Geliştirme Ortamı: Visual Studio 2022

Arayüz: Windows Forms (WinForms)

Hedef Platform: .NET Framework (Windows)

📦 Kurulum ve Çalıştırma
Proje dizinini klonlayın:

bash
Kopyala
Düzenle
git clone https://github.com/kullaniciadi/snake-game.git
Visual Studio 2022 üzerinden Snake.sln dosyasını açın.

Gerekli .NET Framework bileşenlerinin yüklü olduğundan emin olun.

Projeyi derleyin ve çalıştırmak için "Start" butonuna tıklayın.

🎮 Oyun Özellikleri
Oyuncu yılanı yön tuşlarıyla kontrol eder.

Her yem toplandığında yılan uzar ve puan artar.

Yılan, kendisine veya duvara çarptığında oyun sona erer.

Skor takibi yapılmaktadır.

📁 Proje Yapısı
bash
Kopyala
Düzenle
SnakeGame/
├── Program.cs         # Uygulamanın giriş noktası
├── GameForm.cs        # Oyun arayüzü ve oyun döngüsü
├── Coord.cs           # Koordinat sınıfı
├── Direction.cs       # Hareket yönleri için enum tanımı
├── README.md
🎯 Öğrenim Çıktıları
Bu proje kapsamında aşağıdaki konular pratiğe dökülmüştür:

Zamanlayıcı kullanımı ve oyun döngüsü yönetimi

Klavye olayları ile kullanıcı etkileşimi

Sınıf ve enum yapılarıyla oyun verisinin modellenmesi

Basit oyun mekaniği tasarımı ve hata kontrolü
