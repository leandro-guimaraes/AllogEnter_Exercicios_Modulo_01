using System;

public class ContaBancaria
{
    private decimal saldo;

    public void Depositar(decimal valor)
    {
        saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }
    }

    public decimal ObterSaldo()
    {
        return saldo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var conta = new ContaBancaria();
        conta.Depositar(1000);

        Console.WriteLine("Saldo: " + conta.ObterSaldo());

        conta.Sacar(500);
        Console.WriteLine("Saldo: " + conta.ObterSaldo());

        conta.Sacar(700);
        Console.WriteLine("Saldo: " + conta.ObterSaldo());
    }
}


/*
 Nesse exemplo, a classe ContaBancaria possui um campo privado saldo, 
que só pode ser acessado dentro da própria classe. Os métodos públicos Depositar,
Sacar e ObterSaldo são responsáveis por manipular e obter o valor do saldo, 
respectivamente. No método Main,
um objeto ContaBancaria é criado e uma operação de depósito é realizada.
Em seguida, o saldo é obtido e uma operação de saque é realizada. 
Por fim, o saldo é obtido novamente após a operação de saque. 
Como você pode ver, o saldo é manipulado apenas através dos métodos públicos, 
e não diretamente pelo código que utiliza a classe ContaBancaria.
Isso é um exemplo de encapsulamento, 
onde os dados e comportamentos da classe são protegidos e só podem ser acessados de acordo com as regras definidas pela própria classe.
 */

