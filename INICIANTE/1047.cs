using System;

namespace URI {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);
            //
            int Inicial = horaInicial * 60 + minutoInicial;
            int Final   = horaFinal * 60 + minutoFinal;
            int duracao;
            if (Inicial < Final) {
                duracao = Final - Inicial;
            }
            else {
                duracao = 24 * 60 - Inicial + Final;
            }
            Console.WriteLine("O JOGO DUROU " + duracao/60 + " HORA(S) E " + duracao % 60 + " MINUTO(S)");
        }
    }
}
