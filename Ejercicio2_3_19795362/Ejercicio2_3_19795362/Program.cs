using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_3_19795362
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computador MiComputador = new Computador("Dell", "Intel i8", 16, 500);

            //Muestra los datos iniciales
            Console.WriteLine("Información del Computador:");
            Console.WriteLine($"Marca: {MiComputador.Marca}");
            Console.WriteLine($"Procesador: {MiComputador.Procesador}");
            Console.WriteLine($"Memoria RAM: {MiComputador.Memoria} GB");
            Console.WriteLine($"Disco Duro: {MiComputador.DiscoDuro} GB");

            //Aumenta la capacidad del disco en 100GB
            Console.WriteLine("Aumentando la capacidad del disco duro...");
            MiComputador.MayorCapacidad();

            //Reduce la capacidad del disco en 100GB
            Console.WriteLine("\nReduciendo la capacidad del disco duro...");
            MiComputador.MenorCapacidad();

            //Intenta reducir por debajo de 0GB
            Console.WriteLine("\nIntentando reducir más allá del límite...");
            for (int i = 0; i < 6; i++) // Intentamos reducir varias veces
            {
                MiComputador.MenorCapacidad();
            }
        }
    }
}
