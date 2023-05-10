using System;

class ConversorDolarReal
{
    static void Main(string[] args)
    {
                /* 
         No codigo informei o nome da class ConversorDolarReal, em seguida no método Main são lidos dois valores
        informados pelo  usuario, que seriam a cotação atual do dolar e o valor em dolares a ser convertido.
        Estes dois valores são guardados nas variaveis cotacao e valorDolar, a operação de conversão é feita 
        e o resultado é armazenado na variavel valorReal, que em seguida é apresentado no Console.WriteLine 
        formatado com o especificador "C"  que formata de acordo com a cultura (país ou região) configurada no pc.
         */

        Console.Write("Informe a cotação do dólar: ");
        double cotacao = double.Parse(Console.ReadLine());

        Console.Write("Informe o valor em dólares a ser convertido: ");
        double valorDolar = double.Parse(Console.ReadLine());

        double valorReal = valorDolar * cotacao;

        Console.WriteLine("O valor em real é: " + valorReal.ToString("C"));
    }
}
