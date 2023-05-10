using System;

class DeterminaValoresIdenticosVetores
{
    /*
     Ao executar o programa, será exibida a mensagem "Digite o tamanho dos vetores (até 50): 
    ". O usuário deverá digitar o tamanho dos vetores (por exemplo, 5). 
    Em seguida, o programa irá solicitar que o usuário digite os valores de cada vetor (V1 e V2),um por um.
    Ao final do processo, o programa irá comparar os vetores para encontrar quantos valores idênticos eles possuem nas mesmas posições,
    e exibirá o resultado.
    
     */
    static void Main(string[] args)
    {
        const int MAX_COMPONENTES = 50;

        // Lê os vetores V1 e V2 do usuário
        Console.Write("Digite o tamanho dos vetores (até {0}): ", MAX_COMPONENTES);
        int n = int.Parse(Console.ReadLine());

        int[] v1 = new int[n];
        int[] v2 = new int[n];

        Console.WriteLine("Digite os valores do vetor V1:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("V1[{0}] = ", i);
            v1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os valores do vetor V2:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("V2[{0}] = ", i);
            v2[i] = int.Parse(Console.ReadLine());
        }

        // Compara os vetores V1 e V2 para encontrar valores idênticos nas mesmas posições
        int cont = 0;
        for (int i = 0; i < n; i++)
        {
            if (v1[i] == v2[i])
            {
                cont++;
            }
        }

        Console.WriteLine("Os vetores V1 e V2 possuem {0} valores idênticos nas mesmas posições.", cont);
    }
}