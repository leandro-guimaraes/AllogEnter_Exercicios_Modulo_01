using System;
using System.IO;

class CalculoIMC
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("###################################");
            Console.WriteLine("#   Bem-vindo ao sistema de IMC   #");
            Console.WriteLine("###################################");
            Console.WriteLine("#                                 #");
            Console.WriteLine("# Selecione uma opção:            #");
            Console.WriteLine("# 1 - Novo cadastro               #");
            Console.WriteLine("# 2 - Consultar cadastros         #");
            Console.WriteLine("# 3 - Sair                        #");
            Console.WriteLine("#                                 #");
            Console.WriteLine("###################################");
           

            // loop para exibir  animação
            for (int i = 0; i < 1; i++)
            {
            Console.WriteLine("###################################");
                System.Threading.Thread.Sleep(200);
            }
            Console.WriteLine("###################################");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("######         ####################");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("######   ###########  #######  ####");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("######   #########               ##");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("######   ###########  #######  ####");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("######   ###########  #######  ####");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("######   #########               ##");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("######         #####  #######  ####");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("###################################");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("###################################");
            System.Threading.Thread.Sleep(200);

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe a idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o peso (kg): ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a altura (m): ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double imc = peso / (altura * altura);

                string resultado = $"{nome} | Idade: {idade} | Peso: {peso}kg | Altura: {altura}m | IMC: {imc:F2}";

                StreamWriter sw = File.AppendText("cadastros.txt");
                sw.WriteLine(resultado);
                sw.Close();

                Console.WriteLine("Cadastro realizado com sucesso!");

            }
            else if (opcao == 2)
            {
                StreamReader sr = new StreamReader("cadastros.txt");

                Console.WriteLine("Cadastros:");

                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    Console.WriteLine(linha);
                }

                sr.Close();
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine();
        }
    }
}
