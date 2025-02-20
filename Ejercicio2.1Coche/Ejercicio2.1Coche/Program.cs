using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._1Coche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche MiCoche = new Coche("Toyota", "Supra Mk4", 250);
            MiCoche.Acelerar();
            MiCoche.Acelerar();
            MiCoche.Desacelerar();


            CarroDeportivo MiDeportivo = new CarroDeportivo("Urus", "Performante", 300);
            MiDeportivo.Acelerar();
            MiDeportivo.Acelerar();
            MiDeportivo.Frenar();
        }
    }
}
