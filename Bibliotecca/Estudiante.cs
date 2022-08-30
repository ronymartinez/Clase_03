using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + (float) this.notaSegundoParcial) / 2;
        }
        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial > 3 && notaSegundoParcial > 3)
            {
                return random.Next(5, 10);
            }
            else
            {
                return -1;
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota PP: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota SP: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");

            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota Final: {this.CalcularNotaFinal()}");

            }
            else
            {
                sb.AppendLine($"Nota Final: Alumno Desaprobado");
            }

            return sb.ToString();
        }

    }
}
