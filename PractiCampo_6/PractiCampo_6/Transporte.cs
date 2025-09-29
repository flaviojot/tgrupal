using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiCampo_6
{
    internal class Transporte
    {
        // Recibe distancia en km y costo por km
        public static double CalcularCosto(double km, double costoKm)
        {
            return km * costoKm;
        }

    }
}
