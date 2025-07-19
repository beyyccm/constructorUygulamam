# Bebek Sınıfı – Constructor Pratiği

Bu proje, C# dilinde yazılmış bir sınıf oluşturma ve constructor kullanımı pratiğidir. Uygulamada bir `Bebek` sınıfı tanımlanmış ve bu sınıf için iki farklı yapıcı metot (constructor) kullanılmıştır.

## 🎯 Amaç

- Sınıf oluşturma pratiği yapmak
- Constructor (yapıcı metot) kavramını öğrenmek
- Nesne oluşturulurken veri atama işlemlerini pekiştirmek

## 🛠️ Özellikler

- `Bebek` sınıfı aşağıdaki property’leri içerir:
  - `Ad`
  - `Soyad`
  - `DogumTarihi`
- İki adet constructor tanımlanmıştır:
  1. **Parametresiz constructor**: Nesne oluşturulduğunda `DogumTarihi` otomatik olarak o anki zaman (`DateTime.Now`) olarak atanır ve konsola `"Ingaaaa"` yazdırılır.
  2. **Parametreli constructor**: `Ad` ve `Soyad` bilgilerini alır. Diğer constructor ile aynı şekilde `"Ingaaaa"` yazdırılır ve `DogumTarihi` atanır.

## 🧪 Örnek Kullanım

```csharp
// Parametresiz constructor
Bebek bebek1 = new Bebek();
bebek1.Ad = "Elif";
bebek1.Soyad = "Yıldız";

// Parametreli constructor
Bebek bebek2 = new Bebek("Mert", "Kaya");
