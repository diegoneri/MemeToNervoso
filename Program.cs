using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string opiniao;

            Console.WriteLine("Usuário, qual sua opinião sobre mim? Estou curioso.");
            Console.WriteLine();

            Console.Write("Digite sua opinião: ");
            opiniao = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Interessante seu ponto, mas sabe quem se importa?");
            Console.ReadKey();
            Console.WriteLine("Eu mesmo, achou que ia falar outra coisa?");
        }
    }
}
