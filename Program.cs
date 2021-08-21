using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string resposta = "- E sabe o que eu penso de você?\nVocê é muito sem graça!";

            Console.WriteLine("Usuário, qual sua opinião sobre mim? Estou curioso.");
            Console.WriteLine();

            Console.Write("Digite sua opinião: ");
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(resposta.Remove(43).Insert(43, "... NÃO, PERA.\nTô nervoso"));
        }
    }
}
