namespace Interruptor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vamos chamar os interruptores de 1, 2 e 3, e as salas de A, B e C.
            //Eu ligo o interruptor 1 durante 5 minutos, depois desligo e ligo o 2

            //Vou até a sala A.
            //Se a luz estiver acessa o interruptor 2 é da sala A.

            //Se estiver apagada e quente o interruptor 1 é da sala A.

            //Se estiver apagada e fria o interruptor 3 é da sala A.

            //.....

            //A pergunta faria sentido se eu pudesse ir 2 vezes até 2 salas diferentes
            //Eu ligo o interruptor 1 durante 5 minutos, depois desligo e ligo o 2

            //Vou até a sala A

            //Se a luz estiver acessa o interruptor 2 é da sala A.
            //Volto e vou até a sala B.
            //Se estiver apagada e quente o interruptor 1 é da sala B. E consequentemente o 3 é da sala C.
            //Mas se estiver apagada e fria, o interruptor 1 é da sala C. E sobra o 3 para a sala B.

            //Se a luz estivesse apagada e quente o interruptor 1 é da sala A.
            //Volto e vou até a sala B.
            //Se estiver acesso, o interruptor 2 é da sala B. E o 3 é da sala C.
            //Se estiver apagada e fria, o interruptor 2 é da sala C. E o 3 é da sala B.

            //Por último se a luz estivesse apagada e fria o interruptor 3 é da sala A.
            //Volto e vou até a sala B.
            //Se estiver acesso o interruptor 2 é da sala B. E o 1 é da sala C.
            //Mas se estiver apagada e quente o interruptor 1 é da sala B. E o 2 é da sala C.

            //Com apenas 2 idas há 1 das sala não é possível saber qual interruptor acende qual lâmpada



        }
    }
}
