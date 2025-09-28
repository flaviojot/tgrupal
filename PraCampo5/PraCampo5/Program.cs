using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;


namespace PraCampo5
{
    internal class Program
    {
        //CASO: Calcular área y perímetro de un rectángulo
        //Parámetro por valor
        public static double CalcularArea(double l, double a)
        {
            return l * a; //no cambia la variable original
        }

        //Parámetro por referencia
        public static void CalcularPerimetro(double l, double a, ref double perimetro)
        {
            perimetro = 2 * (l + a); //cambia directamente la variable original
        }
        static void Main(string[] args)
        {
            double largo = 5, ancho = 3, perimetro = 0; //la variable original del périmetro es cero

            Console.WriteLine("Cálculo del área y périmetro");
            Console.WriteLine($"Largo inicial: {largo}");
            Console.WriteLine($"Ancho inicial: {ancho}");
            Console.WriteLine($"Périmetro inicial (antes del cáculo) {perimetro}");

            double area = Program.CalcularArea(largo, ancho);//cálculo del área (parámetro por valor)

            //cálculo del périmetro por referencia
            CalcularPerimetro (largo, ancho, ref perimetro);

            //LLamada a la libreria interna para mostrar resultados
            Resultados.MostrarResultado($"El área del rectángulo es: {area:F2}");
            Resultados.MostrarResultado($"El perímetro del rectángulo es: {perimetro:F2}"); //muestra el resultado final modificado por referencia)

            Console.WriteLine("Fin");
            Console.ReadKey();
        }
    }
}
