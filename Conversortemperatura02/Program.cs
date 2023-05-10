using System;

class ConversorFahrenheitCelsius
{

    /*
     Pois bem iniciei com a classe ConversorFahrenheitCelsius, dentro do metodo Main, pedi um valor em grau Fahrenheit
    e armazenei na variavel Fahrenheit, em seguida realizo o calculo na variavel celsius, atraves da formula e armazeno o resultado.
    Em seguida apresento o resultado da temperatura em Celsius.
     */
    static void Main(string[] args)
    {
        Console.Write("Informe a temperatura em graus fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5/9;

        Console.WriteLine("A temperatura em graus Celsius é: " + celsius);
    }
}
