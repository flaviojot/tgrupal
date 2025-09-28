using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER1._1
{
    internal class Program
    {
        static List<string> historial = new List<string>();

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                LibreriaResultados.EscribirConColor("=========== CALCULADORA DE IMC =============", ConsoleColor.Cyan);
                Console.WriteLine("1. Calcular IMC");
                Console.WriteLine("2. Ver informacion del IMC");
                Console.WriteLine("3. Creditos");
                Console.WriteLine("4. Ver Historial");
                Console.WriteLine("5. SALIR");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }
                switch (opcion)
                {
                    case 1:
                        CalcularIMC();
                        break;
                    case 2:
                        MostrarInformacion();
                        break;
                    case 3:
                        MostrarCreditos();
                        break;
                    case 4:
                        MostrarHistorial();
                        break;
                    case 5:
                        LibreriaResultados.EscribirConColor("Saliendo del programa...", ConsoleColor.Yellow);
                        break;
                    default:
                        LibreriaResultados.EscribirConColor("Opcion inválida, intenta nuevamente. ", ConsoleColor.Red);
                        break;
                }
                if (opcion != 5)
                {
                    LibreriaResultados.EscribirConColor("\n Presione una tecla para continuar...", ConsoleColor.DarkGray);
                    Console.ReadKey();
                }
            } while (opcion != 5);
        }
        // Método con parámetro por REFERENCIA
        private static void CalcularIMCRef(double peso, double altura, ref double imc)
        {
            imc = peso / (altura * altura);
        }
        static void CalcularIMC()
        {
            LibreriaResultados.EscribirConColor("================================================", ConsoleColor.Green);
            LibreriaResultados.EscribirConColor("Ingrese su nombre, por favor:", ConsoleColor.Yellow);
            string nombre = Console.ReadLine();

            double peso;
            do
            {
                LibreriaResultados.EscribirConColor("Ingrese su peso en Kilogramos (Kg): ", ConsoleColor.Yellow);
            } while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0);

            LibreriaResultados.EscribirConColor("Ingrese su altura en metros (m): ", ConsoleColor.Yellow);
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = 0;
            CalcularIMCRef(peso, altura, ref imc);

            LibreriaResultados.EscribirConColor($"\n Su peso es: {peso} Kg", ConsoleColor.Cyan);
            LibreriaResultados.EscribirConColor($" Su altura es: {altura} m", ConsoleColor.Cyan);
            LibreriaResultados.EscribirConColor($"\nSu IMC es: {imc:N2}", ConsoleColor.Cyan);

            // Diagnóstico
            string diagnostico;
            ConsoleColor ColorResultado;
            if (imc < 16)
            {
                diagnostico = "Criterio de ingreso en Hospital";
                ColorResultado = ConsoleColor.Red;
            }
            else if (imc >= 16 && imc < 17)
            {
                diagnostico = "Infrapeso";
                ColorResultado = ConsoleColor.Yellow;
            }
            else if (imc >= 17 && imc < 18)
            {
                diagnostico = "Bajo de peso";
                ColorResultado = ConsoleColor.Yellow;
            }
            else if (imc >= 18 && imc < 25)
            {
                diagnostico = "Peso normal (Saludable)";
                ColorResultado = ConsoleColor.Green;
            }
            else if (imc >= 25 && imc < 30)
            {
                diagnostico = "Sobrepeso (Obesidad de grado I)";
                ColorResultado = ConsoleColor.Yellow;
            }
            else if (imc >= 30 && imc < 35)
            {
                diagnostico = "Sobrepeso crónico (Obesidad de grado II)";
                ColorResultado = ConsoleColor.Red;
            }
            else if (imc >= 35 && imc < 40)
            {
                diagnostico = "Obesidad premórbida (Obesidad de grado III)";
                ColorResultado = ConsoleColor.Red;
            }
            else
            {
                diagnostico = "Obesidad mórbida (Obesidad de grado IV)";
                ColorResultado = ConsoleColor.DarkRed;
            }

            LibreriaResultados.EscribirConColor($"\n{nombre}", ConsoleColor.Cyan);
            LibreriaResultados.EscribirConColor($"Diagnóstico: {diagnostico}", ColorResultado);

            // Guardar en historial
            string registro = $"{DateTime.Now:dd/MM/yyyy  HH:mm:ss} | Nombre: {nombre} | IMC : {imc:N2} | {diagnostico}";
            historial.Add(registro);

            // Mostrar fecha y hora
            DateTime fechaActual = DateTime.Now;
            LibreriaResultados.EscribirConColor($"\nFecha: {fechaActual:dd/MM/yyyy} ", ConsoleColor.DarkGray);
            LibreriaResultados.EscribirConColor($"Hora: {fechaActual:HH:mm:ss} ", ConsoleColor.DarkGray);

            LibreriaResultados.EscribirConColor("\n================================================", ConsoleColor.Green);
        }
        static void MostrarInformacion()
        {
            LibreriaResultados.EscribirConColor("\nInformación de rangos IMC:", ConsoleColor.Magenta);
            Console.WriteLine("< 16 : Criterio de ingreso en Hospital");
            Console.WriteLine("16 - 17 : Infrapeso");
            Console.WriteLine("17 - 18 : Bajo de peso");
            Console.WriteLine("18 - 25 : Peso Normal");
            Console.WriteLine("25 - 30 : Sobrepeso (Grado I)");
            Console.WriteLine("30 - 35 : Obesidad (Grado II)");
            Console.WriteLine("35 - 40 : Obesidad premórbida (Grado III)");
            Console.WriteLine("> 40 : Obesidad mórbida (Grado IV)");
        }
        static void MostrarHistorial()
        {
            Console.Clear();
            LibreriaResultados.EscribirConColor("========== HISTORIAL DE CALCULOS ============", ConsoleColor.Magenta);
            if (historial.Count == 0)
            {
                LibreriaResultados.EscribirConColor("No hay registros todavía", ConsoleColor.DarkGray);
            }
            else
            {
                foreach (var item in historial)
                {
                    LibreriaResultados.EscribirConColor(item, ConsoleColor.White);
                }
            }
        }
        static void MostrarCreditos()
        {
            Console.Clear();
            LibreriaResultados.EscribirConColor("============== CREDITOS ==============", ConsoleColor.Cyan);
            LibreriaResultados.EscribirConColor("Programa: Calculadora de IMC", ConsoleColor.Yellow);
            LibreriaResultados.EscribirConColor("Autor: Jaime Gustavo Ramirez R.", ConsoleColor.Green);
            LibreriaResultados.EscribirConColor("Curso: F. de Programacion", ConsoleColor.Magenta);
            LibreriaResultados.EscribirConColor($"Fecha de creación: {DateTime.Now:dd/MM/yyyy}", ConsoleColor.Gray);
            LibreriaResultados.EscribirConColor("\nGracias por usar mi programa! :)", ConsoleColor.Cyan);
        }
    }
}

