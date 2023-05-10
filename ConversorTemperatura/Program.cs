using System;

class ConversorCelsiusFahrenheit
{

    /*
     Pois bem iniciei com a classe ConversorCelsiusFahrenheit, dentro do metodo Main, pedi um valor em grau Celsius
    e armazenei na variavel celsius, em seguida realizo o calculo na variavel fahrenheit, atraves da formula e armazeno o resultado.
    Em seguida apresento o resultado da temperatura com a fromatação "F1" que pesquisei para apresentar com limite de casas decimais em uma.
     */
    static void Main(string[] args)
    {
        Console.Write("Informe a temperatura em graus Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (9 * celsius + 160) / 5;

        Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit.ToString("F1"));
    }
}
