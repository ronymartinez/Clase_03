using System;
using Biblioteca;

namespace Ej_EjemploUniversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Perez", "110110", "Pedro");
            Estudiante e2 = new Estudiante("Lopez", "525858", "Carla");
            Estudiante e3 = new Estudiante("Quispe", "656522", "Sandra");

            e1.SetNotaPrimerParcial(4);
            e1.SetNotaSegundoParcial(8);
            e2.SetNotaPrimerParcial(9);
            e2.SetNotaSegundoParcial(5);
            e3.SetNotaPrimerParcial(2);
            e3.SetNotaSegundoParcial(6);

            Console.WriteLine("Estudiante 1\n{0}", e1.Mostrar());
            Console.WriteLine("Estudiante 2\n{0}", e2.Mostrar());
            Console.WriteLine("Estudiante 3\n{0}", e3.Mostrar());
        }
    }
}
