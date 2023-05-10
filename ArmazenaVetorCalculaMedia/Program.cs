using System;

class ArmazenaVetorCalculaMedia
{

    /*
     
    o executar o programa, será exibida a mensagem "Digite a quantidade de números a serem lidos: ".
    O usuário deverá digitar a quantidade de números que deseja ler (por exemplo, 5). 
    Em seguida, o programa solicita que o usuário digite cada um dos números um por um, armazenando-os em um vetor. 
    Durante a leitura, o programa verifica qual é o maior número digitado e calcula a soma de todos eles para,
    ao final, calcular a média. Por fim, o programa exibe a média e o maior número.

     */

    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de números a serem lidos: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];
        int maior = int.MinValue;
        int soma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite o {0}º número: ", i + 1);
            vetor[i] = int.Parse(Console.ReadLine());

            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }

            soma += vetor[i];
        }

        double media = (double)soma / n;

        Console.WriteLine("A média dos números digitados é: {0:F2}", media);
        Console.WriteLine("O maior número digitado é: {0}", maior);
    }
}
