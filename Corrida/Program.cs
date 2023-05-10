using System;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("                     ___________                        ");
        Console.WriteLine("                                              __..--\"\"\"\"           \"\"\"\"--..__              ");
        Console.WriteLine("                                          _.-\"\"\"\"\"\"\"\"\"\"\"-----...      ______ `.            ");
        Console.WriteLine("                                       .-\"                      l ,-\"    \\ \"-.`.          ");
        Console.WriteLine("                                    .-\"                         ; ;        ;   \\ \"--.._   ");
        Console.WriteLine("                                  .'                           : :         |    ;      .l  ");
        Console.WriteLine("                            _.._.'                             ; ;  ___    |    ;    .' :  ");
        Console.WriteLine("                           (  .'                              : :  :   \".  :..-'   .'    ; ");
        Console.WriteLine("                            )'                                | ;  ; __.'-\"(     .'  .--.: ");
        Console.WriteLine("                    ___...-'\"\"\"\"----....____          ______.-' :-/.'       \\_.-'  .' .-.\\l");
        Console.WriteLine("            __..--\"\"                        \"\"\"\"\"\"          /\\\"          ;    /   .gs./\\;");
        Console.WriteLine("        _.-\"                                                   /  ;          |   . d$P\"Tb  ");
        Console.WriteLine("     .-\"\"-,                       ____                        /   |          :   ;:$$   $; ");
        Console.WriteLine("   .'     ;                    ,\"\"    \"\"--..__               /    :          |   $$$;   :$ ");
        Console.WriteLine("  /\"-._  /                     ;       ____..-'    .-\"\"\"-.  /     :          ;  _$$$;   :$ ");
        Console.WriteLine(" :     \"\"--.._          ___....+---\"\"\"\"          .'  _._  \\/      |         _:-\" $$$;   :$ ");
        Console.WriteLine(" ;                                              /  .d$$$b./       ;      .-\".'   :$$$   $P ");
        Console.WriteLine(":            .----...____                      :  dP' `T$P        |   .-\" .' _.gd$$$$b_d$' ");
        Console.WriteLine(";    __...---|    bug    |----....____         | :$     $b        : .'   (.-\"  `T$$$$$$P'  ");
        Console.WriteLine(";  .';       '----...____;       /    \"-.      ; $;     :$;_____..-\"  .-\"                  ");
        Console.WriteLine(": /  :                          /        \\__..-':$       $$ ;-.    .-\"                     ");
        Console.WriteLine(" Y    ;                        /          ;     $;       :$;|  `.-\"                           ");
        Console.WriteLine(" :    :                       /           |     $$       $$;:.-\"                              ");
        Console.WriteLine(" '$$$ggggp...____            /            :     :$;     :$$                                     ");
        Console.WriteLine("  $$$$$$$$$$$$   \"\"\"\"----...:________....gggg$$$$$$     $$;                                ");
        Console.WriteLine("  'T$$$$$$$$P'                           T$$$$$$$$$b._.d$P                                 ");
        Console.WriteLine("    `T$$$$P'                              T$$$$$$$$$$$$$P                                  ");
        Console.WriteLine("                                           `T$$$$$$$$$P'                                    ");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        Console.Write("                               Digite o número de voltas: ");
        int numVoltas = int.Parse(Console.ReadLine());

        int[] tempos = new int[numVoltas];

        // Lê os tempos das voltas
        for (int i = 0; i < numVoltas; i++)
        {
            Console.Write($"                               Tempo da volta {i + 1}: ");
            tempos[i] = int.Parse(Console.ReadLine());
        }

        // Encontra o melhor tempo e a volta em que ocorreu
        int melhorTempo = tempos[0];
        int voltaMelhorTempo = 1;
        for (int i = 1; i < numVoltas; i++)
        {
            if (tempos[i] < melhorTempo)
            {
                melhorTempo = tempos[i];
                voltaMelhorTempo = i + 1;
            }
        }

        // Calcula o tempo médio
        int somaTempos = 0;
        for (int i = 0; i < numVoltas; i++)
        {
            somaTempos += tempos[i];
        }
        double tempoMedio = (double)somaTempos / numVoltas;

        // Exibe os resultados
        Console.WriteLine($"                               Melhor tempo: {melhorTempo}");
        Console.WriteLine($"                               Volta do melhor tempo: {voltaMelhorTempo}");
        Console.WriteLine($"                               Tempo médio: {tempoMedio:F2}");
    }
}