# Dependency Injection - ASP.NET Core Web API Örneği

Bu proje, **Dependency Injection (Bağımlılıkların Enjekte Edilmesi)** ilkesinin ASP.NET Core Web API'de nasıl uygulanacağını gösteren basit bir örnektir.

## 📌 Amaç

- `Interface` kullanımıyla sınıflar arasında gevşek bağlılık (loose coupling) sağlamak
- `Constructor Injection` ile bağımlılıkların dışarıdan enjekte edilmesini sağlamak
- Web API üzerinden öğretmen bilgisini dış dünyaya sunmak

## 📦 Temel Yapı

- `ITeacher`: Öğretmen arayüzü
- `Teacher`: Öğretmenin adı ve soyadını döndüren sınıf
- `ClassRoom`: Öğretmen nesnesini DI yoluyla alır ve bilgi verir
- `DependenciesController`: API endpoint sağlar
- `Program.cs`: `ITeacher` için `Teacher` sınıfını DI container'a kaydeder

## ▶️ Çalıştırma

Aşağıdaki endpoint'e GET isteği göndererek öğretmen bilgisine erişebilirsin:
/api/dependencies/teacher
