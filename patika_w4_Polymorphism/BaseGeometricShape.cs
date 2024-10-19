using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_Polymorphism
{
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
}
