using System;

class Caracteres
{
    static void Main(string[] args)
    {
        Console.Write("Digite 2 caracteres: ");
        string entrada = Console.ReadLine();

        // Verifica se foram digitados exatamente dois caracteres
        if (entrada.Length != 2)
        {
            Console.WriteLine("Erro: digite exatamente 2 caracteres.");
            return;
        }

        char char1 = entrada[0];
        char char2 = entrada[1];

        // Verifica se os caracteres estão em ordem alfabética
        if (char1 >= char2)
        {
            Console.WriteLine("Erro: os caracteres não estão em ordem alfabética.");
            return;
        }

        // Calcula o número de caracteres existentes entre os dois
        int numChars = char2 - char1 - 1;

        Console.WriteLine("O número de caracteres entre {0} e {1} é: {2}", char1, char2, numChars);
    }
}

