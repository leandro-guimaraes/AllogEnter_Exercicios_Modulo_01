using System;
using System.Collections.Generic;

class Midia
{
    public int codigo;
    public string titulo;
    public int ano;
    public float valor;
    public string categoria;

    public Midia(int codigo, string titulo, int ano, float valor, string categoria)
    {
        this.codigo = codigo;
        this.titulo = titulo;
        this.ano = ano;
        this.valor = valor;
        this.categoria = categoria;
    }

    public void Listar()
    {
        Console.WriteLine("Código: {0}", codigo);
        Console.WriteLine("Título: {0}", titulo);
        Console.WriteLine("Ano: {0}", ano);
        Console.WriteLine("Valor: R${0:F2}", valor);
        Console.WriteLine("Categoria: {0}", categoria);
    }

    public bool Pesquisar(string termo)
    {
        return titulo.ToLower().Contains(termo.ToLower()) ||
            categoria.ToLower().Contains(termo.ToLower());
    }

    public void Cadastrar()
    {
        Console.Write("Código: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Título: ");
        titulo = Console.ReadLine();

        Console.Write("Ano: ");
        ano = int.Parse(Console.ReadLine());

        Console.Write("Valor: R$");
        valor = float.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();
    }

    public void Alterar()
    {
        Console.Write("Título: ");
        titulo = Console.ReadLine();

        Console.Write("Ano: ");
        ano = int.Parse(Console.ReadLine());

        Console.Write("Valor: R$");
        valor = float.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();
    }
}

class DVD : Midia
{
    public string produtor;
    public string diretor;

    public DVD(int codigo, string titulo, int ano, float valor, string categoria,
        string produtor, string diretor) : base(codigo, titulo, ano, valor, categoria)
    {
        this.produtor = produtor;
        this.diretor = diretor;
    }

    public new void Listar()
    {
        base.Listar();
        Console.WriteLine("Produtor: {0}", produtor);
        Console.WriteLine("Diretor: {0}", diretor);
    }
}

class Livro : Midia
{
    public string autor;
    public string isbn;

    public Livro(int codigo, string titulo, int ano, float valor, string categoria,
        string autor, string isbn) : base(codigo, titulo, ano, valor, categoria)
    {
        this.autor = autor;
        this.isbn = isbn;
    }

    public new void Listar()
    {
        base.Listar();
        Console.WriteLine("Autor: {0}", autor);
        Console.WriteLine("ISBN: {0}", isbn);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Midia> midias = new List<Midia>();

        while (true)
        {
            Console.WriteLine("1 - Listar midias");
            Console.WriteLine("2 - Pesquisar midias");
            Console.WriteLine("3 - Cadastrar midia");
            Console.WriteLine("4 - Alterar midia");
            Console.WriteLine("5 - Sair");

            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    foreach (Midia midia in midias)
                    {
                        midia.Listar();
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.Write("Termo de pesquisa: ");
                    string termo = Console.ReadLine();

                    bool encontrou = false;
                    foreach (Midia midia in midias)
                    {
                        if (midia.Pesquisar(termo))
                        {
                            midia.Listar();
                            Console.WriteLine();
                            encontrou = true;
                        }
                    }

                    if (!encontrou)
                    {
                        Console.WriteLine("Nenhuma mídia encontrada para o termo '{0}'", termo);
                    }
                    break;

                case 3:
                    Console.WriteLine("1 - DVD");
                    Console.WriteLine("2 - Livro");

                    Console.Write("Opção: ");
                    int opcaoMidia = int.Parse(Console.ReadLine());

                    Console.Write("Código: ");
                    int codigo = int.Parse(Console.ReadLine());

                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Ano: ");
                    int ano = int.Parse(Console.ReadLine());

                    Console.Write("Valor: R$");
                    float valor = float.Parse(Console.ReadLine());

                    Console.Write("Categoria: ");
                    string categoria = Console.ReadLine();

                    switch (opcaoMidia)
                    {
                        case 1:
                            Console.Write("Produtor: ");
                            string produtor = Console.ReadLine();

                            Console.Write("Diretor: ");
                            string diretor = Console.ReadLine();

                            midias.Add(new DVD(codigo, titulo, ano, valor, categoria, produtor, diretor));
                            break;

                        case 2:
                            Console.Write("Autor: ");
                            string autor = Console.ReadLine();

                            Console.Write("ISBN: ");
                            string isbn = Console.ReadLine();

                            midias.Add(new Livro(codigo, titulo, ano, valor, categoria, autor, isbn));
                            break;
                    }
                    break;

                case 4:
                    Console.Write("Código da mídia a ser alterada: ");
                    int codigoAlterar = int.Parse(Console.ReadLine());

                    bool encontrouAlterar = false;
                    foreach (Midia midia in midias)
                    {
                        if (midia.codigo == codigoAlterar)
                        {
                            midia.Alterar();
                            encontrouAlterar = true;
                            break;
                        }
                    }

                    if (!encontrouAlterar)
                    {
                        Console.WriteLine("Mídia não encontrada");
                    }
                    break;

                case 5:
                    return;
            }
        }
    }
}