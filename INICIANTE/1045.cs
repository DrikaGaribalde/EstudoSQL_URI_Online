using System;
using System.Globalization;

namespace URI {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double maior, lados;

            if (A < (B + C) && B < (A + C) && C < (A + B)) {
                if (A > B && A > C) {
                    maior = Math.Pow(A, 2);
                    lados = Math.Pow(B, 2) + Math.Pow(C, 2);
                }
                else if (B > C) {
                    maior = Math.Pow(B, 2);
                    lados = Math.Pow(A, 2) + Math.Pow(C, 2);
                }
                else {
                    maior = Math.Pow(C, 2);
                    lados = Math.Pow(A, 2) + Math.Pow(B, 2);
                }
                if (maior == lados)
                    Console.WriteLine("TRIANGULO RETANGULO");
                else if (maior > lados)
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                else
                    Console.WriteLine("TRIANGULO ACUTANGULO");

                if(A == B && A == C)
                    Console.WriteLine("TRIANGULO EQUILATERO");
                else if(A == B || A == C || B == C)
                    Console.WriteLine("TRIANGULO ISOSCELES");
            }
            else
                Console.WriteLine("NAO FORMA TRIANGULO");
        }
    }
}
