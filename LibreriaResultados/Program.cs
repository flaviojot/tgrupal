using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER1._1
{
    internal class LibreriaResultados
    {
        // Método estático para mostrar texto en consola con color
        public static void EscribirConColor(string texto, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
}
