namespace LetraA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma palavra: ");
            string palavra = Console.ReadLine();
            int contadorMa = 0;
            int contadorMi = 0;
            int contadorGeral = 0;

            if(palavra.Contains("A") || palavra.Contains("a"))
            {
                foreach(char a in palavra)
                {
                    if(a == 'a')
                        contadorMi += 1;
                    else if(a == 'A')
                        contadorMa += 1;
                }

                contadorGeral = contadorMa + contadorMi;

                Console.WriteLine($"Há {contadorGeral} letras 'A' na palavra {palavra}");
                Console.WriteLine($"Com {contadorMa} maiúsculos e {contadorMi} minúsculos");

            }
            else
                Console.WriteLine($"A palavra {palavra} não contém a letra A");

        }
    }
}
