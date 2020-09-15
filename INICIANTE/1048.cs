using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace URI {
    class Program {
        static void Main(string[] args) {
            double salFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double percentual;

            if (salFuncionario <= 400.0) {
                percentual = 15.0;
            } else if (salFuncionario <= 800.0) {
                percentual = 12.0;
            } else if (salFuncionario <= 1200.0) {
                percentual = 10.0;
            } else if (salFuncionario <= 2000.0) {
                percentual = 7.0;
            } else {
                percentual = 4.0;
            }

            double reajuste = (salFuncionario * percentual) / 100.0;
            double totalSalario = salFuncionario + reajuste;
            /**/
            Console.WriteLine("Novo salario: " + totalSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
    }
}
