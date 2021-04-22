using System;

namespace _6__calculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");

            double ValorInvestido = 1000;
            int x = 1;
            

            while (x <= 12)
            {
                ValorInvestido = ValorInvestido + ValorInvestido * 0.0036;
                x += 1;
            }

            Console.WriteLine("Apos 12 meses terá:  " + ValorInvestido);
            Console.WriteLine("Execução finalizada, tecle enter para continuar");
            Console.ReadLine();
        }
    }
}
