using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
            double nota1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double nota2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double nota3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double nota4 = double.Parse(valores[3], CultureInfo.InvariantCulture);


            double notaExame, novaNota;

            double media = (nota1 * 2 + nota2 * 3 + nota3 * 4 + nota4) / 10;


            if (media >= 7.0) {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0 && media <= 6.9) {
                notaExame = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                novaNota = (media + notaExame) / 2;

                if (novaNota >= 5.0) {
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + (novaNota.ToString("F1", CultureInfo.InvariantCulture)));
                }
            }
            else {
                Console.WriteLine("Media: " + Math.Round(media,1));
                Console.WriteLine("Aluno reprovado.");
            }
    }

}