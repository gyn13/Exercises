namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 12;
            int soma = 0;
            int K = 1;

            while(K < indice)
            {
                K = K + 1;
                soma = soma + K;
            }

            Console.WriteLine(soma); //o valor será -> 77

        }
    }
}
