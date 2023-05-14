using System;
using System.Collections.Generic;
using System.IO;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        while (true)
        {
            Console.WriteLine("Digite o nome da pessoa (ou 'sair' para encerrar):");
            string nome = Console.ReadLine();

            if (nome == "sair")
            {
                break;
            }

            Console.WriteLine("Digite a idade da pessoa:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o e-mail da pessoa:");
            string email = Console.ReadLine();

            pessoas.Add(new Pessoa { Nome = nome, Idade = idade, Email = email });
        }

        using (StreamWriter writer = new StreamWriter("pessoas.csv"))
        {
            foreach (Pessoa pessoa in pessoas)
            {
                writer.WriteLine($"{pessoa.Nome},{pessoa.Idade},{pessoa.Email}");
            }
        }
    }
}

