using System;

class ListaInversa
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de números: ");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];

        Console.WriteLine("Digite os números:");

        for (int i = 0; i < n; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sequência inversa:");

        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
