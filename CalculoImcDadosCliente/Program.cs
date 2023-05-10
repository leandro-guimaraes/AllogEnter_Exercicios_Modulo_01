using System;
using System.IO;

namespace CalculoIMCDadosCliente
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("                                    ,#####, ");
            Console.WriteLine("                                    #_   _# ");
            Console.WriteLine("                                    |a` `a| ");
            Console.WriteLine("                                    |  u  | ");
            Console.WriteLine("                                    \\  =  / ");
            Console.WriteLine("                                    |\\___/| ");
            Console.WriteLine("                           ___ ____/:     :\\____ ___ ");
            Console.WriteLine("                         .'   `.-===-\\   /-===-.`   '. ");
            Console.WriteLine("                        /      .-\"\"\"\"\"-.\"\"\"\"\"-.      \\ ");
            Console.WriteLine("                       /'             =:=             '\\ ");
            Console.WriteLine("                     .'  ' .:    o   -=:=-   o    :. '  `. ");
            Console.WriteLine("                    (.'   /'. '-.....-'-.....-' .\\   '.)");
            Console.WriteLine("                    /' ._/   \".     --:--     .\"   \\_. '\\ ");
            Console.WriteLine("                   |  .'|      \".  ---:---  .\"      |'.  | ");
            Console.WriteLine("                   |  : |       |  ---:---  |       | :  | ");
            Console.WriteLine("                    \\ : |       |_____._____|       | : / ");
            Console.WriteLine("                    /   (       |----|------|       )   \\ ");
            Console.WriteLine("                   /... .|      |    |      |      |. ...\\ ");
            Console.WriteLine("                  |::::/''     /     |       \\     ''\\::::| ");
            Console.WriteLine("                  '\"\"\"\"       /'    .L_      `\\       \"\"\"\"' ");
            Console.WriteLine("                             /'-.,__/` \\__..-'\\ ");
            Console.WriteLine("                            ;      /     \\      ; ");
            Console.WriteLine("                            :     /       \\     | ");
            Console.WriteLine("                            |    /         \\.   | ");
            Console.WriteLine("                            |`../           |  ,/ ");
            Console.WriteLine("                            ( _ )           |  _) ");
            Console.WriteLine("                            |   |           |   | ");
            Console.WriteLine("                            |___|           \\___| ");
            Console.WriteLine("                            :===|            |==| ");
            Console.WriteLine("                             \\  /            |__| ");
            Console.WriteLine("                             /\\/\\           /\"\"\"`8.__ ");
            Console.WriteLine("                             |oo|           \\__.//___) ");
            Console.WriteLine("                             |==| ");
            Console.WriteLine("                             \\__/ ");







            Console.WriteLine("                  ##################################################");
            Console.WriteLine("                  #     Bem-vindo ao programa de cálculo de IMC!   #");
            Console.WriteLine("                  #                                                #");
            Console.WriteLine("                  ##################################################");
            // Solicita ao usuário se deseja cadastrar um novo usuário ou consultar os existentes
            Console.WriteLine("                  #     Deseja cadastrar um novo usuário (1)       #");
            Console.WriteLine("                  #                                                #");
            Console.WriteLine("                  #     Consultar usuarios existentes    (2)       #");
            Console.WriteLine("                  #                                                #");
            Console.WriteLine("                  ##################################################");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                // Solicita as informações do usuário
                Console.WriteLine("                    Informe o nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("                    Informe a idade:");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("                    Informe o peso (em kg):");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("                    Informe a altura (em metros):");
                double altura = double.Parse(Console.ReadLine());

                // Calcula o IMC
                double imc = peso / (altura * altura);

                // Grava os resultados em um arquivo de texto
                using (StreamWriter sw = File.AppendText("imc.txt"))
                {
                    sw.WriteLine("{0};{1};{2};{3};{4}", nome, idade, peso, altura, imc);
                }

                Console.WriteLine("                    Cadastro realizado com sucesso!");
            }
            else if (opcao == 2)
            {
                // Lê os dados do arquivo de texto e exibe na tela
                using (StreamReader sr = File.OpenText("imc.txt"))
                {
                    Console.WriteLine("                Dados cadastrados:");

                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        string[] dados = linha.Split(';');
                        Console.WriteLine("            Nome: {0}, Idade: {1}, Peso: {2}, Altura: {3}, IMC: {4}", dados[0], dados[1], dados[2], dados[3], dados[4]);
                    }
                }
            }
            else
            {
                Console.WriteLine("                    Opção inválida!");
            }
        }
    }
}
