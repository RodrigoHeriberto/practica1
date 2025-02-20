using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_3_19795362
{
    internal class Computador
    {
        public string Marca;
        public string Procesador;

        //RAM en GB
        public int Memoria;
        // Capacidad del disco en GB
        public int DiscoDuro;

        //Constructor
        public Computador(string marca, string procesador, int memoria, int discoDuro)
        {
            Marca = marca;
            Procesador = procesador;
            Memoria = memoria;
            DiscoDuro = discoDuro;
        }

        //aumenta la capacidad del disco en 100GB
        public void MayorCapacidad()
        {
            DiscoDuro += 100;
            Console.WriteLine($"Capacidad aumentada: {DiscoDuro} GB");
            Console.ReadLine();
        }

        //reduce la capacidad del disco en 100GB, sin bajar de los 0GB
        public void MenorCapacidad()
        {
            if (DiscoDuro >= 100)
            {
                DiscoDuro -= 100;
                Console.WriteLine($"Capacidad reducida: {DiscoDuro} GB");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No se puede reducir más la capacidad del disco duro.");
                Console.WriteLine("Presiona cualquier tecla para salir del programa...");
                Console.ReadKey();
            }
        }
    }
}
