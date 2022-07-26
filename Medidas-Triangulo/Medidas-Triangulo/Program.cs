using System;
using System.Globalization;

namespace Medidas_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x  = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Medidas do triangulo X");
            x.A= double.Parse(Console.ReadLine());
            x.B=double.Parse(Console.ReadLine());
            x.C=double.Parse(Console.ReadLine());

            double AreaX = x.Area();

            Console.WriteLine("Medidas do triangulo y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double AreaY = y.Area();

            Console.WriteLine("Area do triangulo X " + AreaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do triangulo X " + AreaX.ToString("F4", CultureInfo.InvariantCulture));



            Console.ReadKey();

        }
    }
}
