using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

       double a, b, c, pi = 3.14159;
            double area1, area2, area3, area4, area5;

            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            area1 = (a * c) / 2; //triângulo retângulo;
            area2 = (pi * c * c); //círculo;
            area3 = ((a + b) * c) / 2; //trapézio;
            area4 = (b * b); // quadrado;
            area5 = (a * b); //retângulo;

            Console.WriteLine("TRIANGULO: " + area1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + area2.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + area3.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + area4.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + area5.ToString("F3", CultureInfo.InvariantCulture));


    }

}