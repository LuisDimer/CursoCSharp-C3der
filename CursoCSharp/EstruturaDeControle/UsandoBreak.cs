﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}.", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o numero que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break; // Nesse caso o break sai do FOR nao do IF, portanto quando ele encontra o numero aleatorio ele sai do for e finaliza execucao
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}