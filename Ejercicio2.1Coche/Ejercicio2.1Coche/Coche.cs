using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._1Coche
{
    public class Coche
    {
        public string Marca;
        public string Modelo;
        public int VelocidadMaxima;
        public int VelocidadActual;

        public Coche(string marca, string modelo, int velocidadMaxima)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadMaxima = velocidadMaxima;
            VelocidadActual = 0;
        }

        public void Acelerar()
        {
            if (VelocidadActual + 5 <= VelocidadMaxima)
            {
                VelocidadActual += 5;
            }
            else
            {
                VelocidadActual = VelocidadMaxima;
            }
            Console.WriteLine($"Velocidad actual: {VelocidadActual} km/h");
            
        }

        public void Desacelerar()
        {
            if (VelocidadActual - 5 >= 0)
            {
                VelocidadActual -= 5;
            }
            else
            {
                VelocidadActual = 0;
            }
            Console.WriteLine($"Velocidad actual: {VelocidadActual} km/h");
            Console.ReadKey();
        }
    }
}