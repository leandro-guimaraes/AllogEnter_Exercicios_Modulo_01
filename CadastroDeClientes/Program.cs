using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Cliente
{
    /*
     Linhas 1 a 16: Inclui as bibliotecas necessárias e define a classe Cliente, que possui as propriedades ID, Nome, Endereco, Telefone e Email.
     */
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

class CadastroCientes
{
    
    static void Main(string[] args)
    {
        string arquivo = "clientes.csv";
        int ultimoID = 0;
        List<Cliente> clientes = new List<Cliente>();

        // Carrega os dados do arquivo CSV
        if (File.Exists(arquivo))
        {
            using (StreamReader sr = new StreamReader(arquivo))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(',');
                    Cliente cliente = new Cliente
                    {
                        ID = int.Parse(campos[0]),
                        Nome = campos[1],
                        Endereco = campos[2],
                        Telefone = campos[3],
                        Email = campos[4]
                    };
                    clientes.Add(cliente);
                    ultimoID = cliente.ID;
                }
            }
        }

        // Menu de opções
        int opcao = 0;
        while (opcao != 5)
        {
            Console.WriteLine("##################################");
            Console.WriteLine("#   Escolha uma opção:           #");
            Console.WriteLine("#   1 - Cadastrar                #");
            Console.WriteLine("#   2 - Editar                   #");
            Console.WriteLine("#   3 - Excluir                  #");
            Console.WriteLine("#   4 - Listar todos             #");
            Console.WriteLine("#   5 - Sair                     #");
            Console.WriteLine("##################################");

            if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            switch (opcao)
            {
                case 1: // Cadastrar
                    Console.Clear();
                    Cliente novoCliente = LerDadosCliente(ultimoID + 1);
                    clientes.Add(novoCliente);
                    ultimoID++;
                    SalvarDadosCSV(clientes, arquivo);
                    Console.WriteLine("Cliente cadastrado com sucesso.");
                    break;

                case 2: // Editar
                    Console.Clear();
                    Console.Write("Informe o ID do cliente a ser editado: ");
                    if (!int.TryParse(Console.ReadLine(), out int idEditar) || !ClientesContainsID(clientes, idEditar))
                    {
                        Console.WriteLine("ID inválido. Tente novamente.");
                        continue;
                    }
                    Cliente clienteEditar = LerDadosCliente(idEditar);
                    clientes.RemoveAll(c => c.ID == idEditar);
                    clientes.Add(clienteEditar);
                    SalvarDadosCSV(clientes, arquivo);
                    Console.WriteLine("Cliente editado com sucesso.");
                    break;

                case 3: // Excluir
                    Console.Clear();
                    Console.Write("Informe o ID do cliente a ser excluído: ");
                    if (!int.TryParse(Console.ReadLine(), out int idExcluir) || !ClientesContainsID(clientes, idExcluir))
                    {
                        Console.WriteLine("ID inválido. Tente novamente.");
                        continue;
                    }
                    clientes.RemoveAll(c => c.ID == idExcluir);
                    SalvarDadosCSV(clientes, arquivo);
                    Console.WriteLine("Cliente excluído com sucesso.");
                    break;

                case 4: // Listar todos
                    Console.Clear();
                    Console.WriteLine("Lista de clientes cadastrados:");
                    foreach (Cliente cliente in clientes)
                    {
                        Console.WriteLine($"ID: {cliente.ID} - Nome: {cliente.Nome} - Endereço: {cliente.Endereco} - Telefone: {cliente.Telefone} - E-mail: {cliente.Email}");
                    }
                    break;
                case 5: // Sair
                    Console.Clear();
                    Console.WriteLine("Saindo do programa...");
                    break;
            }
        }
    }

    // Lê os dados do cliente digitados pelo usuário
    static Cliente LerDadosCliente(int id)
    {
        Cliente cliente = new Cliente { ID = id };

        Console.Write("Nome: ");
        cliente.Nome = Console.ReadLine();

        Console.Write("Endereço: ");
        cliente.Endereco = Console.ReadLine();

        Console.Write("Telefone: ");
        cliente.Telefone = Console.ReadLine();

        while (true) // Laço para validação de e-mail
        {
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            if (IsValidEmail(email))
            {
                cliente.Email = email;
                break;
            }
            Console.WriteLine("E-mail inválido. Tente novamente.");
        }

        return cliente;
    }

    // Verifica se o ID está presente na lista de clientes
    static bool ClientesContainsID(List<Cliente> clientes, int id)
    {
        return clientes.Exists(c => c.ID == id);
    }

    // Salva os dados dos clientes em um arquivo CSV
    static void SalvarDadosCSV(List<Cliente> clientes, string arquivo)
    {
        using (StreamWriter sw = new StreamWriter(arquivo))
        {
            foreach (Cliente cliente in clientes)
            {
                sw.WriteLine($"{cliente.ID},{cliente.Nome},{cliente.Endereco},{cliente.Telefone},{cliente.Email}");
            }
        }
    }

    // Verifica se o e-mail é válido utilizando expressão regular
    static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }
        try
        {
            // Utiliza a classe Regex para validar o e-mail
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }
}
