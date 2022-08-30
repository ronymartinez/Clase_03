using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        public decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string getTitular()
        {
            return this.titular;
        }
        public decimal getCantidad()
        {
            return this.cantidad;
        }
        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Titular: {this.titular}");
            sb.AppendLine($"Cantidad: {this.cantidad}");

            return sb.ToString();
        }
        public void ingresar(decimal cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }  
        
        public void retirar(decimal cantidad)
        {
            this.cantidad -= cantidad;
        }
    }
}
