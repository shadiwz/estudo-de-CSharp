using System;

namespace _5__CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5");

            char primeraletra = 'a';
            Console.WriteLine(primeraletra);

            //char com numeros procura o digito correspondente ao codigo 65 = A. ascii table

            primeraletra = (char) 65;
            Console.WriteLine(primeraletra);

            primeraletra = (char)(primeraletra +1);
            Console.WriteLine(primeraletra);

            string titulo = "essa é a primeira string " + 2021;
            Console.WriteLine(titulo);

            string comprimentos = @"-milímetro 
                -centímtro 
                -metro 
                -quilometro ";
            Console.WriteLine(comprimentos);


            Console.WriteLine("Fim da execução, tecle enter para fechar");
            Console.ReadLine();
        }
    }
}
