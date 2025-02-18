using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPersonaCS19795362
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona Personal = new Persona("verdes", "187", "85", "V");
            Console.WriteLine("Descripcion de la persona: ");
            Console.WriteLine("Ojos: " + Personal.Ojos);
            Console.WriteLine("Altura: " + Personal.Altura);
            Console.WriteLine("Peso: " + Personal.Peso);
            Console.WriteLine("Sexo: " + Personal.Sexo);

            Personal.Hablar(" Me llamo Borja");
            Console.WriteLine("Color de mis ojos: " + Personal.Ojos);
            Personal.Correr(1000);
            Console.WriteLine("Mi peso actual es: " + Personal.Peso);
            
            PersonaNadadora Persona1 = new PersonaNadadora("Verdes", "187", "85", "V");
            Console.WriteLine("Descripcion de la persona: ");
            Console.WriteLine("Ojos", Personal.Ojos);
            Console.WriteLine("Altura: " + Personal.Altura);
            Console.WriteLine("Peso: " + Personal.Peso);
            Console.WriteLine("Sexo: " + Personal.Sexo);
            Persona1.Hablar(" Me llamo Borja");
            Console.WriteLine("Color de mis ojos : " + Persona1.Ojos);
            Persona1.Correr(1000);
            Console.WriteLine("Mi peso actual es: " + Persona1.Peso);
            Persona1.Nadar();
            Console.WriteLine("Tras nadar peso: " + Persona1.Peso);
            Console.ReadKey();
        }
    }
}
