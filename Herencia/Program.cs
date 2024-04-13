using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase padre
            Animal animal = new Animal("Juanito",2014);
            animal.Imprimir();
            animal.HacerSonio();
            Console.WriteLine();
            //Clase Hijas

            Perro perro = new Perro("Pedrito",2020,"Salchicha");
            perro.ImprimirPerro();
            perro.HacerSonio();
            Console.WriteLine();

            Gato gato = new Gato("Michi",2024,"Naranja");
            gato.ImprimirGato();
            gato.HacerSonio();

            Console.ReadKey();
        }
    }
}
