using System;

namespace _7__calculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11");

            double ValorInvestido = 1000;

            
            for(int ContadorMes = 1; ContadorMes <= 12; ContadorMes += 1)
            {
                ValorInvestido = ValorInvestido + ValorInvestido * 0.0036;
            }

            Console.WriteLine("Apos 12 meses você terá:  " + ValorInvestido);

            Console.WriteLine("Execução finalizada, tecle enter para continuar");
            Console.ReadLine();
        }
    }
}
