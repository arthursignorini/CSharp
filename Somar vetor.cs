using System;

namespace SOMARVETOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor: ");
            int tam = int.Parse(Console.ReadLine());

            int[] vetor = new int [tam];
            int soma = 0;
            for(int i=0; i<tam; i++){
                Console.WriteLine("Digite um valor para o vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
                soma += vetor[i];
            }
            Console.WriteLine($"A soma dos numeros dentro do vetor é de {soma}");
        }
    }
}
