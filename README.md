# YoutubeBlog - .NET Core 6 Blog Projesi

Bu proje, **.NET Core 6** kullanılarak geliştirilmiş, temel blog uygulaması işlevselliği sunan modern bir web uygulamasıdır. Youtube üzerinden eğitici bir içerik olarak hazırlanmış olup, kullanıcıların blog yazıları oluşturabileceği, düzenleyebileceği ve görüntüleyebileceği bir platform sağlar.

---

## 📌 Proje Özellikleri

* **.NET Core 6** ile geliştirilmiş güncel web uygulaması
* Katmanlı mimari (Layered Architecture) ile temiz ve sürdürülebilir kod yapısı
* CRUD işlemleri (Create, Read, Update, Delete) destekleyen blog yazısı yönetimi
* Kullanıcı dostu arayüz
* Entity Framework Core ile veritabanı yönetimi
* Responsive tasarım ile mobil uyumluluk
* Temel doğrulama ve hata yönetimi
* Youtube eğitim serisi kapsamında öğretici amaçlı hazırlanmıştır

---

## 🚀 Başlangıç

### Gereksinimler

* .NET 6 SDK ([İndir](https://dotnet.microsoft.com/en-us/download/dotnet/6.0))
* Visual Studio 2022 veya Visual Studio Code
* SQL Server (veya alternatif bir veritabanı)
* Git

### Kurulum

1. Depoyu klonlayın:

   ```bash
   git clone https://github.com/cemkeskin12/YoutubeBlog-.Net-Core-6-Blog-Projesi.git
   ```

2. Projeyi Visual Studio ile açın veya VS Code ile klasörü açın.

3. `appsettings.json` dosyasındaki veritabanı bağlantı stringini kendi ortamınıza göre düzenleyin.

4. Veritabanını oluşturmak için Entity Framework Core Migrations komutlarını kullanabilirsiniz:

   ```bash
   dotnet ef database update
   ```

5. Uygulamayı çalıştırın:

   * Visual Studio’da `F5` tuşuna basarak veya
   * Terminalde:

     ```bash
     dotnet run
     ```

6. Tarayıcıda `https://localhost:5001` (veya projenin dinlediği port) adresine gidin.

---

## 🛠️ Teknolojiler

* .NET Core 6
* ASP.NET Core MVC
* Entity Framework Core
* SQL Server
* Bootstrap 4 (veya 5)
* C#

---

## 📁 Proje Yapısı

* **Controllers**: HTTP isteklerini karşılayan ve yanıt veren denetleyiciler.
* **Models**: Veri yapıları ve Entity Framework Core için modeller.
* **Views**: Kullanıcı arayüzü dosyaları (Razor sayfaları).
* **Data**: Veritabanı işlemleri ve context sınıfı.
* **wwwroot**: Statik dosyalar (CSS, JS, resimler).

---

## ✍️ Kullanım

* Ana sayfada mevcut blog yazılarını listeleyebilirsiniz.
* Yeni yazı ekleyebilir, var olanları güncelleyebilir veya silebilirsiniz.
* Yazı başlığı, içeriği ve oluşturulma tarihi gibi bilgiler görüntülenir.

---

## 📖 Kaynaklar

* Proje Youtube eğitimi: [Cem Keskin Youtube Kanalı](https://www.youtube.com/@cemkeskin)
* .NET Core Resmi Dokümantasyon: [https://learn.microsoft.com/en-us/aspnet/core/](https://learn.microsoft.com/en-us/aspnet/core/)

---

## 📝 Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakabilirsiniz.

---

