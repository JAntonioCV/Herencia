using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Animal
    {
        //Propiedades o Atributos
        public string Nombre { get; set; }
        public int AnioNacimiento { get; set; }

        //Constructor por defecto 
        public Animal()
        {

        }

        //Constructor por parametros
        public Animal(string nombre, int anionacimiento)
        {
            Nombre = nombre;
            AnioNacimiento = anionacimiento;
        }

        //Metodos

        public void Imprimir()
        {
            Console.WriteLine("Nombre: {0}",Nombre);
            Console.WriteLine("Año Nacimiento: {0}", AnioNacimiento);
        }

        //Metodo puede ser sobreescrito
        public virtual void HacerSonio() 
        {
            Console.WriteLine("El Animal esta haciendo un sonido");
        } 


    }
}
