using System;
using Biblioteca;

namespace Ej_NecesitoPrestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Juan", 5000);

            Console.Write(cuenta.mostrar());
            Console.Write("Indique el importe a aumentar: ");
            if(int.TryParse(Console.ReadLine(), out int aumento))
            {
                cuenta.ingresar(aumento);
                Console.WriteLine("\nResultado:\n"+cuenta.mostrar());
            }

            Console.Write("Indique el importe a retirar: ");
            if (int.TryParse(Console.ReadLine(), out int retiro))
            {
                cuenta.retirar(retiro);
                Console.WriteLine("\nResultado:\n" + cuenta.mostrar());
            }
        }
    }
}
