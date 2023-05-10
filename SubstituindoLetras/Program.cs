using System;

class SubstituirLetras
{
    /*
     Comecei informando a class SubstituirLetras, em seguida peço ao usuario para digitar uma frase e armazeno na variavel frase.
    logo em seguida crio uma nova variavel chamada novaFrase, que posteriormente vai armazenar a frase com letras trocadas.
    Logo depois inicio um loop foreach que percorre cada caracter e busca o caracter especificado na variavel letra para substituí-lo de
    acordo com o que esta especificado tambem no condicional IF.
    Logo depois exibo o resultado.
    Em caso da palavra nao ter o caractere especificado a nova frase é exibida sem alteraçoes.  
     
     */

    static void Main(string[] args)
    {
        Console.Write("Digite uma frase que tenha a letra 'a' : ");
        string frase = Console.ReadLine();

        string novaFrase = "";
        foreach (char letra in frase)
        {
            if (letra == 'A' || letra == 'a')
            {
                novaFrase += '&';
            }
            else
            {
                novaFrase += letra;
            }
        }

        Console.WriteLine("Nova frase: " + novaFrase);
    }
}
