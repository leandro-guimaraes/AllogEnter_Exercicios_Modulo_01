using System;

class ReajusteSalarial
{
    /*
     Iniciei definindo a class ReajusteSalarial, em seguida tenho no metodo Main, 
    a definição da variavel novoSalario, depois peço o valor do salario para o usuario, guardo na variavel salario e limpo atela com Console.Clear
    tenho uma estrutura de decisão if para o salrio receber reajuste de 320 se for menor que 1850, e reajuste de 180 se for maior que
    1850. A partir dai imprimo em tela o novo valor.
     */



    static void Main(string[] args)
    {
        double novoSalario;
        Console.Write("Informe o salário atual: R$ ");
        double salario = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        
        if (salario < 1850)
        {
            novoSalario = salario +  320.00; 
        }
        else
        {
            novoSalario = salario + 180.00;
        }

        

        Console.WriteLine("O novo salário é: " + novoSalario.ToString("C"));
    }
}
