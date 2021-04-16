using System;

namespace _2_criandoVariavel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2 - criando variaveis");

            int idade;

            idade = 32;

            Console.WriteLine(idade);

            idade = 10;

            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            if (idade >= 40)
            {
                Console.WriteLine("sua dade é " + idade + " tá velho");
            }
            else
            {
                Console.WriteLine("tá novin novin");
            }
            Console.WriteLine("Execução finalizada, tecle enter para continuar.");
            Console.ReadLine();
        }
    }
}
