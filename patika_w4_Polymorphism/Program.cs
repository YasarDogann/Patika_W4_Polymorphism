namespace patika_w4_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism ile nesne oluşturdum
            BaseGeometricShape square = new Square(15,6);
            square.CalculateArea();

            Console.WriteLine("\r\n***************************************\r\n");

            BaseGeometricShape rentagle = new Rentagle(20,15.3);
            rentagle.CalculateArea();

            Console.WriteLine("\r\n***************************************\r\n");

            BaseGeometricShape rightTriangle = new RightTriangle(20, 6);
            rightTriangle.CalculateArea();
        }
    }
}
