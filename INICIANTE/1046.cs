using System;
using System.Globalization;

namespace URI {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0], CultureInfo.InvariantCulture);
            int horaFinal   = int.Parse(valores[1], CultureInfo.InvariantCulture);
            int duracao;

            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
