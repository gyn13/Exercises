using System.Reflection.Emit;

namespace Sequencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a) 1, 3, 5, 7, ___ -> 9
            //Números ímpares consecutivos
            Console.WriteLine("a) ");

            int seqA = 5;

            for (int i = 0; i < seqA; i++)
                Console.Write($" - {2 * i + 1}");


            //b) 2, 4, 8, 16, 32, 64, ____ -> 128
            //Cada número é o dobro do anterior
            Console.WriteLine("\nb) ");

            int seqB = 7;

            int numB = 2;

            for(int i = 0; i < seqB; i++)
            {
                Console.Write($" - {numB}");
                numB *= 2;
            }


            //c) 0, 1, 4, 9, 16, 25, 36, ____ -> 49
            //Quadrados da sequência de números naturais
            Console.WriteLine("\nc) ");

            int seqC = 8;

            int numC = 0;

            for(int i = 0; i < seqC; i++)
            {
                numC = i * i;
                Console.Write($" - {numC}");
            }


            //d) 4, 16, 36, 64, ____ -> 100
            //Quadrados da sequência de números pares
            Console.WriteLine("\nd) ");

            int seqD = 5;

            for(int i = 1; i <= seqD; i++)
            {
                int numPar = 2 * i;
                int quadrado = numPar * numPar;
                Console.Write($" - {quadrado}");
            }


            //e) 1, 1, 2, 3, 5, 8, ____ -> 13
            //Sequência de Fibonacci, o próximo número é a soma dos 2 anteriores
            Console.WriteLine("\ne) ");

            int seqE = 6;
            int a = 0;
            int b = 1;
            int fib = 0;

            for(int i = 0; i < seqE; i++)
            {
                fib = a + b;
                Console.Write($" - {fib}");
                a = b;
                b = fib;
            }

            Console.WriteLine();


            //f) 2,10, 12, 16, 17, 18, 19, ____ 
            //Números que começam com a letra 'd' em português

        }
    }
}
