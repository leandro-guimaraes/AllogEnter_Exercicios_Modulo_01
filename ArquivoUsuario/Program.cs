using System;
using System.IO;

class Usuario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string RG { get; set; }
}

class Program
{
    /*
    Neste código, a classe Usuario contém os atributos Nome, Email, Telefone e RG. 
    O método GravarUsuario recebe um objeto Usuario e grava as informações em um arquivo de texto chamado usuarios.txt, 
    separando cada informação por linha. O método LerUsuarios lê o arquivo usuarios.txt e exibe as informações na tela.
    O método Main é responsável por solicitar as informações do usuário, gravá-las e exibi-las na tela.

     */
    static void Main(string[] args)
    {
        Usuario usuario = new Usuario();

        Console.WriteLine("Digite seu nome:");
        usuario.Nome = Console.ReadLine();

        Console.WriteLine("Digite seu e-mail:");
        usuario.Email = Console.ReadLine();

        Console.WriteLine("Digite seu telefone:");
        usuario.Telefone = Console.ReadLine();

        Console.WriteLine("Digite seu RG:");
        usuario.RG = Console.ReadLine();

        GravarUsuario(usuario);

        Console.WriteLine("\nUsuário gravado com sucesso!");

        Console.WriteLine("\nLendo usuários gravados:");

        LerUsuarios();
    }

    static void GravarUsuario(Usuario usuario)
    {
        using (StreamWriter writer = new StreamWriter("usuarios.txt", true))
        {
            writer.WriteLine("Nome: " + usuario.Nome);
            writer.WriteLine("E-mail: " + usuario.Email);
            writer.WriteLine("Telefone: " + usuario.Telefone);
            writer.WriteLine("RG: " + usuario.RG);
            writer.WriteLine();
        }
    }

    static void LerUsuarios()
    {
        if (File.Exists("usuarios.txt"))
        {
            using (StreamReader reader = new StreamReader("usuarios.txt"))
            {
                string linha;

                while ((linha = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        else
        {
            Console.WriteLine("Nenhum usuário encontrado!");
        }
    }
}