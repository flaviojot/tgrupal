using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiCampo_6
{
    internal class Viajes
    {
        // Recibe el nombre del pasajero y el mensaje del costo
        public static string ConfirmarViaje(string pasajero, string mensaje)
        {
            return $"Pasajero: {pasajero}. {mensaje} ¡Buen viaje!";
        }

    }
}
