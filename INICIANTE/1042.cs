using System; 

class URI {

    static void Main(string[] args) { 

          string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);
           
            if (a < b && a < c) {
                if (b < c) {
                    Console.WriteLine("{0}\n{1}\n{2}", a, b, c);
                }
                else {
                    Console.WriteLine("{0}\n{1}\n{2}", a, c, b);
                }
            }
            else if (b < a && b < c) {
                if (a < c) {
                    Console.WriteLine("{0}\n{1}\n{2}", b, a, c);
                }
                else {
                    Console.WriteLine("{0}\n{1}\n{2}", b, c, a);
                }
            }
            else if (c < b && c < a) {
                if (b < a) {
                    Console.WriteLine("{0}\n{1}\n{2}", c, b, a);
                }
                else {
                    Console.WriteLine("{0}\n{1}\n{2}", c, a, b);
                }
            }
           
            Console.WriteLine("\n{0}\n{1}\n{2}", a, b, c);

    }

}