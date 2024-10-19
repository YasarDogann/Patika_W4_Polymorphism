# Patika+ Week4 Polymorphism Uygulaması
Merhaba,
Bu proje C# ile Patika+ 4.hafta Polymorphism için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Method kullanımı ve yapısını anlamak.
- Class yapısını anlamak
- Encapsulation yapısını öğrenmek
- Inheritance Method yapısını öğrenmek
- Polymorphism

## İstenilen Görev
Kare, Dikdörtgen, Dik Üçgen nesnelerinden oluşacak bir uygulamada alan hesaplaması yapmak istiyoruz.
Yukarıda bahsettiğimiz nesnelerin her birini üretebilmemiz için classlara ihtiyacımız var.
1- Kare
2- Dikdortgen
3- DikUcgen
Classlarımızı ortak bir çatı altında toplayarak BaseGeometrikSekil classından türetebiliriz.
BaseGeometrikSekil için Propertyler -> Genişlik ve Yükseklik
AlanHesapla() metodu tüm geometrik şekillerde bulanacağından Base Class içerisinde tanımlayabiliriz.

Burada dikkat etmemiz gereken durum: Kare ve Dikdortgen için Genişlik x Yükseklik şeklinde hesaplanan alanın Dik Üçgen için (Genişlik x Yükseklik ) / 2 olarak hesaplanması.
Polymorphism prensibini kullanarak ilgili uygulamayı kodlayınız. Her classtan bir örnek nesne oluşturarak Alan ölçülerini konsol ekranına yazdırınız.


## Kod
```csharp
 // Her bir geometrik şeklin ortak özelliklerini Yani kenar ve yüksekliklerini properties olarak alıyoruz abstract class olarak tanımla.
 public abstract class BaseGeometricShape
 {
     public double Height { get; set; }
     public double Width { get; set; }

     // virtual bir class olarak tanımladım diğer classlarda bunu override ederek tekrardan kullanabilir ve değişiklik yapabiliriz.
     public virtual void CalculateArea()
     {
         Console.WriteLine("Geometrik Şeklin Alanı");
     }
 }

 // Kare Sınıfı oluşturdum. BaseGeometricShape sınıfından base sınıftan miras aldı.
 public class Square : BaseGeometricShape
 {
     // Burada bir yapıcı method tanımladım. Özelliklerini base classtan çekiyoruz ve parametre giriyoruz
     public Square(double heightt, double width)
     {
         Height = heightt;
         Width = width;
     }
     public override void CalculateArea()  // virtual olarak base class'da tanımlanan methodu override ile tekrardan yazdık ve kare özelliklerine göre doldurdum.
     {
         double area = Height * Width;
         Console.WriteLine($"Karenin Alanı: {area}");
     }
 }

 public class Rentagle : BaseGeometricShape
 {
     public Rentagle(double height, double width)
     {
         Height= height;
         Width = width;
     }
     public override void CalculateArea()// virtual olarak base class'da tanımlanan methodu override ile tekrardan yazdık ve dikdörtgen özelliklerine göre doldurdum.
     {
         double area = Height * Width;
         Console.WriteLine($"Dikdörtgenin Alanı : {area}");
     }
 }

 public class RightTriangle : BaseGeometricShape
 {
     public RightTriangle(double height, double width)
     {
         Height= height;
         Width= width;
     }
     public override void CalculateArea()// virtual olarak base class'da tanımlanan methodu override ile tekrardan yazdık ve dik üçgen özelliklerine göre doldurdum.
     {
         double area = (Height * Width) / 2;
         Console.WriteLine($"Dik Üçgenin Alanı : {area}");
     }
 }
```
BaseGeometricShape sınıfı oluşturduk ve abstract olarak yaptık. Base classımız oldu. İçine 2 adet her geometrik şeklimizde kullanıcağımız ortak olan yükseklik ve genişlik özelliklerini kapsülleme ile tanımladık
Daha sonra bir virtual class oluşturduk ve içine bir çıktı verdik burdaki amaç diğer class'larda bunu override ederek ilgili classın özelliklerine göre çıktı vermek veye default olarak base class çıktısını vermek
Daha sonra kalıtım ile Kare, dikdörtgen ve dik üçgen classları tanımlandı. İçlerine bir yapıcu method tanımlandı. parametre olarak alınan değerleri özelliklere atandı. override ile methodu yazdık

```csharp
// Polymorphism ile nesne oluşturdum
BaseGeometricShape square = new Square(15,6);
square.CalculateArea();

Console.WriteLine("\r\n***************************************\r\n");

BaseGeometricShape rentagle = new Rentagle(20,15.3);
rentagle.CalculateArea();

Console.WriteLine("\r\n***************************************\r\n");

BaseGeometricShape rightTriangle = new RightTriangle(20, 6);
rightTriangle.CalculateArea();
```
Main method içinde sınıftan nesneler oluşturuldu ama nesneler polymorphism yapısına uygun olarak oluşturuldu



