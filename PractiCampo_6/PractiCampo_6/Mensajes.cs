using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiCampo_6
{
    internal class Mensajes
    {
        // Recibe costo y genera un mensaje
        public static string CrearMensaje(double costo)
        {
            return $"El costo total del viaje es: {costo} dólares.";
        }

    }
}
