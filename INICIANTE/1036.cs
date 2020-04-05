using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

       double a, b, c;                   
            
            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0],CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;  

            if (delta < 0 || a == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + x1.ToString("F5",CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }

    }

}