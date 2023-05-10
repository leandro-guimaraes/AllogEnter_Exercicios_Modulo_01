using System;

class CarregaVetorListaVetorMostraNumerosImparesEPares
{
    static int[] vetor = new int[50];
    static int n;

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("################################################################################################");
            Console.WriteLine("#             Escolha uma opção:                                                               #");
            Console.WriteLine("#             1 - Carregar vetor                                                               #");
            Console.WriteLine("#             2 - Listar vetor                                                                 #");
            Console.WriteLine("#             3 - Exibir apenas os números pares do vetor                                      #");
            Console.WriteLine("#             4 - Exibir apenas os números ímpares do vetor                                    #");
            Console.WriteLine("#             5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor   #");
            Console.WriteLine("#             6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor   #");
            Console.WriteLine("#             7 - Sair                                                                         #");
            Console.WriteLine("#                                                                                              #");
            Console.WriteLine("################################################################################################");
            Console.Write("              Opção escolhida: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CarregarVetor();
                    break;
                case 2:
                    ListarVetor();
                    break;
                case 3:
                    ExibirNumerosPares();
                    break;
                case 4:
                    ExibirNumerosImpares();
                    break;
                case 5:
                    ExibirQuantidadeParesPosicoesImpares();
                    break;
                case 6:
                    ExibirQuantidadeImparesPosicoesPares();
                    break;
                case 7:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 7);
    }

    static void CarregarVetor()
    {
        Console.Write("Digite a quantidade de números a serem lidos: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite o {0}º número: ", i + 1);
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vetor carregado!");
    }

    static void ListarVetor()
    {
        Console.WriteLine("Vetor:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(vetor[i]);
        }
    }

    static void ExibirNumerosPares()
    {
        Console.WriteLine("Números pares:");
        for (int i = 0; i < n; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }

    static void ExibirNumerosImpares()
    {
        Console.WriteLine("Números ímpares:");
        for (int i = 0; i < n; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }

    static void ExibirQuantidadeParesPosicoesImpares()
    {
        int quantidade = 0;

        for (int i = 1; i < n; i += 2)
        {
            if (vetor[i] % 2 == 0)
            {
                quantidade++;
            }
        }

        Console.WriteLine("Quantidade de números pares nas posições ímpares: {0}", quantidade);
    }

    static void ExibirQuantidadeImparesPosicoesPares()
    {
        int quantidade = 0;

        for (int i = 0; i < n; i += 2)
        {
            if (vetor[i] % 2 != 0)
            {
                quantidade++;
            }
        }

        Console.WriteLine("Quantidade de números ímpares nas posições pares: {0}", quantidade);
    }
}


