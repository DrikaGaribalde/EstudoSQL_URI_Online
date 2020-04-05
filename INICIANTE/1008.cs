using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int numFuncionario, horasTrabalhadas;
            double valorHora, valorSalario;

            numFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            valorSalario = (horasTrabalhadas * valorHora);

            Console.WriteLine("NUMBER = " + numFuncionario);
            Console.WriteLine("SALARY = U$ " + valorSalario.ToString("F2",CultureInfo.InvariantCulture));

    }

}