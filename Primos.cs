using System;

namespace PRIMOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            int cont = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                Console.WriteLine("Esse é um numero primo");
            }
            else
            {
                Console.WriteLine("Esse não é um numero primo");
            }

            Console.ReadKey(); // Manter o console aberto após a execução
        }
    }
}
