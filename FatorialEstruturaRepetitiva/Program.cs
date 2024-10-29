//Utilizando estrutura repetitiva For:
//Problema "fatorial" (adaptado de URI 1153)
//Fazer um programa para ler um número natural N (valor máximo: 15), e depois calcular e mostrar o fatorial de N. 

namespace FatorealEstruturaRepetitiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, fatorial;

            fatorial = 1;

            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"FATORIAL = {fatorial}");
        }
    }
}
