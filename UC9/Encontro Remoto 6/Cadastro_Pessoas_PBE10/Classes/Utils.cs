using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoas_PBE10.Classes
{
    static class Utils
    {
        public static void BarraCarregamento(string texto, int tempo, int quantidade)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.Write(texto);

            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }
            Console.ResetColor();
        }
    }
}