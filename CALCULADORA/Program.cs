using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Essa é a minha primeira calculadora!");
            Console.WriteLine("Digite qual operação você quer fazer: 1) Adição 2) Subtração 3) Divisão 4) Multiplicação");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;
        
            if (x == 1)
            {
                result = num1 + num2;
            }
            else if (x == 2)
            {
                result = num1 - num2;
            }
            else if (x == 3)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero.");
                }
            }
            else if (x == 4)
            {
                result = num1 * num2;
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }

            Console.WriteLine($"O resultado dessa conta é {result}");

            Console.ReadKey(); // Manter o console aberto após a execução
        }
    }
}
