using System;

class ImprimeVogais
{
    /*
     Ao executar o programa, será exibida a mensagem "Digite uma frase: ". O usuário deverá digitar uma frase qualquer.
    Em seguida, o programa irá percorrer cada caractere da frase e verificar se é uma vogal (tanto maiúscula quanto minúscula).
    Se for uma vogal, o caractere é adicionado à string vogais. Ao final do processo, o programa exibe as vogais encontradas na frase.

    Por exemplo, se o usuário digitar a frase "O rato roeu a roupa do rei de Roma", 
    o programa irá imprimir "O a o e a oua o ei e oa".
     
     
     
     */


    static void Main(string[] args)
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        // Percorre cada caractere da frase e verifica se é uma vogal
        string vogais = "";
        for (int i = 0; i < frase.Length; i++)
        {
            char vogal = frase[i];
            if (vogal == 'a' || vogal == 'e' || vogal == 'i' || vogal == 'o' || vogal == 'u' ||
                vogal == 'A' || vogal == 'E' || vogal == 'I' || vogal == 'O' || vogal == 'U')
            {
                vogais += vogal;
            }
        }

        Console.WriteLine("As vogais na frase são: {0}", vogais);
    }
}
