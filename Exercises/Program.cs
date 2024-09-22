namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            string input = Console.ReadLine();
            int num;

            if(int.TryParse(input, out num))
            {
                if (PertenceFibonacci(num))
                    Console.WriteLine($"O número {num} pertence a sequência Fibonacci");
                else
                    Console.WriteLine($"O número {num} NÃO pertence a sequência Fibonacci");
            }
            else
                Console.WriteLine("Informe um NÚMERO!");

        }

        static bool PertenceFibonacci(int num)
        {
            int a = 0;
            int b = 1;

            if(num == a || num == b)
                return true;

            int c = a + b;

            while(c <= num)
            {
                if(c == num)
                    return true;

                a = b;
                b = c;
                c = a + b;
            }

            return false;

        }

    }
}
