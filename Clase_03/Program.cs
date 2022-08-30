using System;

namespace Clase_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto("Honda", "CBR", "AA123", 600);
            Moto moto2 = new Moto("Yamaha", "R6", "BB321", 625);

            Console.WriteLine("Moto marca {0}", moto.marca);
            moto.TocarBocina();
            moto2.TocarBocina();


            Persona persona = new Persona("Juan", 123);

            Console.WriteLine("Persona {0} - {1}", persona.nombre, persona.getDni());

        }
    }
    public class Moto
    {
        public string marca;
        public string modelo;
        public string patente;
        public int cilindrada;
        public int combustible;
        static private int cantidadNafta = 1000;

        public Moto(string marca, string modelo, string patente, int cilindrada)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.patente = patente;
            this.cilindrada = cilindrada;
            this.combustible = 0;

           
        }

        public void TocarBocina()
        {
            Console.WriteLine("Beep beep {0}", this.patente);
        }

        static public void LlenarTanque(Moto moto)
        {
            moto.combustible = 100;
            Console.WriteLine("Tanque full, acelera {0}", moto.patente);
        }
    }

    public class Persona
    {
        private int _dni;
        public string nombre;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this._dni = dni;
        }
        public int getDni()
        {
            return this._dni;
        }

        public void setDni(int dni)
        {
            this._dni = dni;
        }
    }
}
