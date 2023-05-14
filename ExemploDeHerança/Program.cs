using System;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

public class Cliente : Pessoa
{
    public string Email { get; set; }
}

public class Funcionario : Pessoa
{
    public decimal Salario { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Cliente
        var cliente = new Cliente();
        cliente.Nome = "João";
        cliente.Idade = 30;
        cliente.Email = "joao@email.com";

        // Criando um objeto Funcionario
        var funcionario = new Funcionario();
        funcionario.Nome = "Maria";
        funcionario.Idade = 40;
        funcionario.Salario = 5000;

        // Imprimindo as informações do Cliente e do Funcionario
        Console.WriteLine("Cliente: " + cliente.Nome + " (" + cliente.Idade + ") - " + cliente.Email);
        Console.WriteLine("Funcionário: " + funcionario.Nome + " (" + funcionario.Idade + ") - Salário: " + funcionario.Salario);
    }
}
/*
 Nesse exemplo, a classe Pessoa é a classe base, que contém as propriedades Nome e Idade. 
A classe Cliente herda de Pessoa e adiciona a propriedade Email. 
A classe Funcionario também herda de Pessoa, mas adiciona a propriedade Salario. 
No método Main, são criados objetos Cliente e Funcionario, e suas propriedades são definidas.
Em seguida, as informações são impressas na tela.
Como você pode ver, a classe Cliente e a classe Funcionario compartilham as propriedades de Pessoa,
mas também adicionam suas próprias propriedades exclusivas.
 
 
 */