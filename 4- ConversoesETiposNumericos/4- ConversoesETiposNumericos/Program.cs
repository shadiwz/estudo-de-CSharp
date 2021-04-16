using System;

namespace _4__ConversoesETiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario = 1200.50;

            int salarioInt= (int)salario;

            Console.WriteLine("O salário, inteiro, é de: " + salarioInt);

            int idade= 3;

            if (idade > 0)
            {
                Console.WriteLine("sua idade é: "+ idade +" anos");
            }
            else
            {
                Console.WriteLine("erro insira outra idade");
            }

            float altura = 1.80f;

            Console.WriteLine(altura);

            //teste

            string testando = "opa";

            Console.WriteLine(testando);

            if (testando == "opa")
            {
                Console.WriteLine("deu certo!!");
            }
            else
            {
                Console.WriteLine("falhou, animal!");
            }

            Console.WriteLine("A execução chegou ao fim, tecle enter para continuar");
            Console.ReadLine();
        }
    }
}
