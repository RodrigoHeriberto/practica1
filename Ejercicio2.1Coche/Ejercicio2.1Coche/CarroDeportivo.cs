using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._1Coche
{
    internal class CarroDeportivo : Coche
    {
        public CarroDeportivo(string marca, string modelo, int velocidadMaxima)
        : base(marca, modelo, velocidadMaxima) { }

        public void Frenar()
        {
            VelocidadActual = 0;
            Console.WriteLine("El coche ha frenado. Velocidad actual: 0 km/h");
            Console.ReadLine();
        }
    }
}

