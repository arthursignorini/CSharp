using System;

namespace SOMARMATRIZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas linhas você quer para a sua matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite quantas colunas você quer para a sua matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            int soma = 0;
            for(int i = 0; i < linhas; i++)
            {
                for(int j = 0; j < colunas; j++)
                {
                    Console.Write($"Digite um valor para a matriz[{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    soma += matriz[i, j];
                }
            }
            Console.WriteLine($"A soma dessa matriz é {soma}");
        }
    }
}
