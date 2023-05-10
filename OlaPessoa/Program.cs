using System;

class OlaPessoa
{
    /*
     Neste programa iniciei com o nome da class OlaPessoa,
     em seguida dentro do metodo Main, peço que o usuario insira um nome e esse valor é 
     armazenado na variavel nome, tenho em seguida a variavel mensagem que recebe o vaor retornado do metodo
    GerarMensagem e com o valor da variavel nome como parametro.
    Abaixo então é  declarado o método "GerarMensagem", 
    que recebe um parâmetro "nome" do tipo string e retorna a frase
    "Olá meu nome é: " concatenada com o valor da variável "nome". 
    a mensagem é exibida na tela com  Console.WriteLine
    passando a variável "mensagem" como parâmetro.
     */


    static void Main(string[] args)
    {
        Console.WriteLine("Insira um nome: ");
        string nome = Convert.ToString(Console.ReadLine());
        string mensagem = GerarMensagem(nome);
        Console.WriteLine(mensagem);
    }

    static string GerarMensagem(string nome)
    {
        return "Olá meu nome é: " + nome;
    }
}
