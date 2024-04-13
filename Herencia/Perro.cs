using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Perro: Animal
    {
        //Propiedades o atributos
        public string Raza { get; set; }

        //Constructores por defecto
        public Perro() : base()
        {

        }

        //Constructor por parametro
        public Perro(string nombre, int anionacimiento, string raza): base(nombre,anionacimiento)
        {
            Raza = raza;
        }

        //Metodos propio de la clase perro
        public void ImprimirPerro()
        {
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Año: {0}", AnioNacimiento);
            Console.WriteLine("Raza: {0}", Raza);
        }

        //Sobreescritura del metodo HacerSonido
        public override void HacerSonio()
        {
            Console.WriteLine("El perro esta Ladrando");
        }
    }
}
