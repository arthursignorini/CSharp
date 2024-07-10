using System;

namespace SomarVetor {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Digite o tamanho do vetor: ");
            int tam = int.Parse(Console.ReadLine());

            int[] vetor = new int[tam];

            int soma = 0;
            for (int i = 0; i < tam; i++) {
                Console.Write($"Digite um valor para a posicao {i}: ");
                vetor[i] = int.Parse(Console.ReadLine());
                soma += vetor[i];
            }
            Console.WriteLine($"A soma dos elementos do vetor é {soma}");
        }
    }
}
