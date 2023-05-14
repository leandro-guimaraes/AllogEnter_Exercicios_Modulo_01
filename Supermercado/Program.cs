using System;
using System.Collections.Generic;

// Classe que representa um produto
class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEstoque { get; set; }
}

// Classe que representa um item do pedido
class ItemPedido
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
}

// Classe que representa um pedido
class Pedido
{
    public List<ItemPedido> Itens { get; set; }
    public double Total
    {
        get
        {
            double total = 0;
            foreach (ItemPedido item in Itens)
            {
                total += item.Produto.Preco * item.Quantidade;
            }
            return total;
        }
    }
    public string FormaDePagamento { get; set; }
}

// Classe principal que simula o funcionamento do supermercado
class Supermercado
{
    static List<Produto> estoque = new List<Produto> {
        new Produto { Nome = "Arroz", Preco = 10.0, QuantidadeEstoque = 100 },
        new Produto { Nome = "Feijão", Preco = 5.0, QuantidadeEstoque = 50 },
        new Produto { Nome = "Macarrão", Preco = 3.0, QuantidadeEstoque = 200 },
        new Produto { Nome = "Farofa", Preco = 6.0, QuantidadeEstoque = 180 },
        new Produto { Nome = "Açucar", Preco = 4.0, QuantidadeEstoque = 150 },
        new Produto { Nome = "Trigo", Preco = 5.0, QuantidadeEstoque = 130 },
        new Produto { Nome = "Bolacha", Preco = 7.0, QuantidadeEstoque = 100 },
        new Produto { Nome = "Molho de tomate", Preco = 2.0, QuantidadeEstoque = 110 },
        new Produto { Nome = "Leite condensado", Preco = 4.0, QuantidadeEstoque = 45 },
        new Produto { Nome = "Trigo", Preco = 5.0, QuantidadeEstoque = 56 },
        new Produto { Nome = "Oleo de soja", Preco = 6.0, QuantidadeEstoque = 170 },
        new Produto { Nome = "Azeite de oliva", Preco = 22.0, QuantidadeEstoque = 160 },
        new Produto { Nome = "Sal", Preco = 3.0, QuantidadeEstoque = 115 },
        new Produto { Nome = "Fermento", Preco = 8.0, QuantidadeEstoque = 99 },
        new Produto { Nome = "Cerveja", Preco = 4.0, QuantidadeEstoque = 88 },
        new Produto { Nome = "Torrada", Preco = 3.0, QuantidadeEstoque = 78 },
        new Produto { Nome = "Leite", Preco = 3.50, QuantidadeEstoque = 120 },
        new Produto { Nome = "Pão de forma", Preco = 4.50, QuantidadeEstoque = 80 },
        new Produto { Nome = "Presunto", Preco = 12.00, QuantidadeEstoque = 50 },
        new Produto { Nome = "Queijo", Preco = 15.00, QuantidadeEstoque = 60 },
        new Produto { Nome = "Manteiga", Preco = 8.50, QuantidadeEstoque = 70 },
        new Produto { Nome = "Refrigerante", Preco = 5.00, QuantidadeEstoque = 100 },
        new Produto { Nome = "Água mineral", Preco = 2.50, QuantidadeEstoque = 150 },
        new Produto { Nome = "Suco de laranja", Preco = 6.00, QuantidadeEstoque = 40 },
        new Produto { Nome = "Café em pó", Preco = 10.00, QuantidadeEstoque = 90 },
        new Produto { Nome = "Chá", Preco = 3.00, QuantidadeEstoque = 120 },
        new Produto { Nome = "Iogurte", Preco = 4.00, QuantidadeEstoque = 80 },
        new Produto { Nome = "Achocolatado em pó", Preco = 7.00, QuantidadeEstoque = 50 },
        new Produto { Nome = "Mel", Preco = 12.00, QuantidadeEstoque = 60 },
        new Produto { Nome = "Granola", Preco = 9.00, QuantidadeEstoque = 70 },
        new Produto { Nome = "Geléia", Preco = 5.00, QuantidadeEstoque = 100 },
        new Produto { Nome = "Leite de coco", Preco = 3.50, QuantidadeEstoque = 150 },
        new Produto { Nome = "Óleo de coco", Preco = 12.50, QuantidadeEstoque = 40 },
        new Produto { Nome = "Azeitonas", Preco = 6.00, QuantidadeEstoque = 90 },
        new Produto { Nome = "Picles", Preco = 5.00, QuantidadeEstoque = 120 },
        new Produto { Nome = "Mostarda", Preco = 2.50, QuantidadeEstoque = 80 },
        new Produto { Nome = "Ketchup", Preco = 3.50, QuantidadeEstoque = 50 },
        new Produto { Nome = "Maionese", Preco = 4.50, QuantidadeEstoque = 60 },
        new Produto { Nome = "Tempero completo", Preco = 8.50, QuantidadeEstoque = 70 },
        new Produto { Nome = "Vinagre", Preco = 2.00, QuantidadeEstoque = 100 },
        new Produto { Nome = "Azeite de dendê", Preco = 20.00, QuantidadeEstoque = 150 },
        new Produto { Nome = "Amendoim", Preco = 3.50, QuantidadeEstoque = 40 },
        new Produto { Nome = "Castanha do Pará", Preco = 12.00, QuantidadeEstoque = 90 },
        new Produto { Nome = "Nozes", Preco = 15.00, QuantidadeEstoque = 120 },
    };

    static void Main()
    {
        // Mostrando o estoque de produtos disponíveis
        Console.WriteLine("Produtos disponíveis:");
        for (int i = 0; i < estoque.Count; i++)
        {
            Console.WriteLine((i + 1) + " - " + estoque[i].Nome + " (R$ " + estoque[i].Preco + ")");
        }

        // Selecionando os produtos
        Pedido pedido = new Pedido();
        pedido.Itens = new List<ItemPedido>();
        while (true)
        {
            Console.Write("Digite o número do produto desejado (ou 0 para finalizar): ");
            int numProduto = int.Parse(Console.ReadLine());
            if (numProduto == 0)
            {
                break;
            }
            Console.Write("Digite a quantidade desejada: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = estoque[numProduto - 1];
            if (quantidade > produto.QuantidadeEstoque)
            {
                Console.WriteLine("Não há estoque suficiente para esse produto!");
            }
            else
            {
                ItemPedido item = new ItemPedido { Produto = produto, Quantidade = quantidade };
                pedido.Itens.Add(item);
            }
        }

        // Selecionando a forma de pagamento
        while (true)
        {
            Console.Write("Digite a forma de pagamento (Dinheiro, Cheque ou Cartão): ");
            string formaDePagamento = Console.ReadLine();
            if (formaDePagamento == "Dinheiro" || formaDePagamento == "Cheque" || formaDePagamento == "Cartão")
            {
                pedido.FormaDePagamento = formaDePagamento;
                break;
            }
            else
            {
                Console.WriteLine("Forma de pagamento inválida!");
            }
        }

        // Realizando o pagamento
        if (pedido.FormaDePagamento == "Dinheiro")
        {
            Console.WriteLine("Pagamento em dinheiro. Total: R$ " + pedido.Total);
        }
        else if (pedido.FormaDePagamento == "Cheque")
        {
            Console.WriteLine("Pagamento em cheque. Total: R$ " + pedido.Total);
        }
        else if (pedido.FormaDePagamento == "Cartão")
        {
            Console.Write("Digite o número do cartão: ");
            string numeroCartao = Console.ReadLine();
            Console.WriteLine("Pagamento em cartão. Total: R$ " + pedido.Total);
        }

        // Atualizando o estoque
        foreach (ItemPedido item in pedido.Itens)
        {
            item.Produto.QuantidadeEstoque -= item.Quantidade;
        }
        Console.WriteLine("Estoque atualizado:");
        for (int i = 0; i < estoque.Count; i++)
        {
            Console.WriteLine(estoque[i].Nome + " - " + estoque[i].QuantidadeEstoque + " unidades");
        }
    }
}
