using System;

class CalculadoraCombustivelViagem
{
    /*
     Iniciei criando a class CalculadoraCombustivelViagem, em seguida peço o valor do tempo gasto em horas
    para armazenar na variavel tempo e limpo a tela com a função Console.Clear,
    logo depois peço a velocidade média do usuario para tambem armazenar em uma variavel velocidade.
    Em seguida tambem limpo a tela com a função Console.Clear
    Logo depois realizo o calculo da distância na variavel distacia, armazenando o resultado.
    Após realizo o calculo dos litros gastos com o resultado armazenado na variavel distancia dividido por doze, e armazeno na variavel
    litros.

    Apos todo esse processo informo:

    Velocidade média: 
    Tempo gasto: 
    Distância percorrida: 
    Litros de combustível utilizados: 
     */

    static void Main(string[] args)
    {
        Console.Write("Informe o tempo gasto na viagem em horas: ");
        double tempo = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Informe a velocidade média durante a viagem em Km/h: ");
        double velocidade = double.Parse(Console.ReadLine());
        Console.Clear();
        double distancia = tempo * velocidade;
        double litros = distancia / 12;

        Console.WriteLine("Velocidade média: " + velocidade + " Km/h");
        Console.WriteLine("Tempo gasto: " + tempo + " horas");
        Console.WriteLine("Distância percorrida: " + distancia.ToString("F2") + " Km");
        Console.WriteLine("Litros de combustível utilizados: " + litros.ToString("F2"));
    }
}
