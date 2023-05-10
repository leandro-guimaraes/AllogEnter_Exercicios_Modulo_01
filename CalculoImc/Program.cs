using System;

class CalculoIMC
{
    /*
     Ok iniciei  com a definição da class CalculoIMC, em seguida no método Main,
    peço o valor do peso em Kg e armazeno na variavel peso, apos uso a função  Console.Clear
    para limpar a tela, depois peço o valor da altura e armazeno na variavel altura, e limpando a tela depois.

    Na variavel imc realizo o calculo e armazeno o resultado para informar em seguida formatado com duas casas decimais com "F2",
    logo depois tenho condicionais IF e ELSE IF para determinar conforme o resultado a informação a ser exebida.
     */
    static void Main(string[] args)
    {
        Console.Write("Informe o peso em kg: ");
        double peso = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Informe a altura em metros: ");
        double altura = double.Parse(Console.ReadLine());
        Console.Clear();

        double imc = peso / (altura * altura);

        Console.WriteLine("O seu IMC é: " + imc.ToString("F2"));

        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (imc < 35)
        {
            Console.WriteLine("Obesidade grau I");
        }
        else if (imc < 40)
        {
            Console.WriteLine("Obesidade grau II (severa)");
        }
        else
        {
            Console.WriteLine("Obesidade grau III (mórbida)");
        }
    }
}
