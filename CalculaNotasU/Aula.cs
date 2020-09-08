using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotasU
{
    class Aula
    {
        public void calcularNota() {

            Console.WriteLine("                                          Bienvenid@ \n");
            Console.WriteLine("                             Calcule la nota de su Asignatura\n\n");
            Console.WriteLine("                                  *Debe ingresar sus 3 notas*");
            Console.WriteLine(" Nota 1er Corte: ");
            Asignatura a = new Asignatura();
            a.nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Nota 2do Corte: ");
            a.nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Nota 3er Corte: ");
            a.nota3 = Convert.ToDouble(Console.ReadLine());

            double promedio = ((a.nota1 * 0.3) + (a.nota2 * 0.3) + (a.nota3 * 0.4));

            confirma(promedio);

            Console.ReadLine();

        }

        private void confirma( double nota) {

            if ((nota)>=3.0)
            {
                Console.WriteLine("\n\n                                     *** Felicidades ***\n\n");
                Console.WriteLine("                                     Aprobo Su Asigatura\n");
            }
            else
            {
                Console.WriteLine("                                     Reprobo Su Asigantuta\n");
            }

            Console.WriteLine("Su Promedio fue: " + nota);

        }

    }
}
