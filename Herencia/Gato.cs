using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Gato: Animal
    {
        //Propiedades
        public string Color { get; set; }

        //Constructor
        public Gato() : base()
        {

        }

        //Constructor con parametros
        public Gato(string nombre, int anionacimiento, string color): base(nombre,anionacimiento)
        {
            Color = color;
        }

        //Metodo propio gato
        public void ImprimirGato()
        {
            base.Imprimir();
            Console.WriteLine("Color: {0}", Color);
        }

        //Sobreescritura del metodo HacerSonido
        public override void HacerSonio()
        {
            Console.WriteLine("El gato esta Mauyando");
        }



    }
}
