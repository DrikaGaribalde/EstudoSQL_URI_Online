using System;
using System.Globalization;

namespace URI {
    class Program {
        static void Main(string[] args) {
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (A + B > C && B + C > A && A + C > B) {
                double perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1",CultureInfo.InvariantCulture));
            }
            else {
                double area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1",CultureInfo.InvariantCulture));
            }
        }
    }
}
