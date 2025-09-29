using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiCampo_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Gestión de Viajes ===\n");

            // Paso 1: Calcular costo
            double km = 120;
            double costoKm = 0.5;
            double costo = Transporte.CalcularCosto(km, costoKm);

            // Paso 2: Crear mensaje con el costo
            string mensaje = Mensajes.CrearMensaje(costo);

            // Paso 3: Confirmar viaje
            string pasajero = "Maria Rojas";
            string confirmacion = Viajes.ConfirmarViaje(pasajero, mensaje);

            // Mostrar resultado
            Console.WriteLine(confirmacion);

        }
    }
}
