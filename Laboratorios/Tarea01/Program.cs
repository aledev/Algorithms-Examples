using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea01.Clases;

namespace Tarea01
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;

            while (aux != 6)
            {
                Console.Clear();
                Console.WriteLine("Que acción desea realizar?");
                Console.WriteLine("1) Calcular Factorial \n" +
                    "2) Calcular Fibonacci (R)\n" +
                    "3) Calcular Fibonacci (I)\n" +
                    "4) Calcular Números Primos\n" +
                    "5) Calcular Números Perfectos\n" +
                    "6) Salir");

                string menu = Console.ReadLine();
                aux = int.Parse(menu);

                if (aux == 1)
                {
                    Console.Write("Ingrese un número para calcular su factorial: ");
                    string numero = Console.ReadLine();

                    int num = int.Parse(numero);

                    DateTime fchInicio = DateTime.Now; 

                    Tarea.Factorial(num);

                    DateTime fchTermino = DateTime.Now;
                    var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                    Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                    Console.ReadLine();
                }
                else if(aux == 2)
                {
                    Console.Write("Ingrese un número para su valor en fibonacci: ");
                    string numero = Console.ReadLine();

                    int num = int.Parse(numero);

                    DateTime fchInicio = DateTime.Now; 

                    int resultado = Tarea.Fibonacci_R(num);

                    Console.WriteLine("El resultado es: {0}", Math.Abs(resultado));

                    DateTime fchTermino = DateTime.Now;
                    var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                    Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                    Console.ReadLine();
                }
                else if (aux == 3)
                {
                    Console.Write("Ingrese un número para su valor en fibonacci: ");
                    string numero = Console.ReadLine();

                    int num = int.Parse(numero);

                    DateTime fchInicio = DateTime.Now;

                    int resultado = Tarea.Fibonacci_I(num);

                    Console.WriteLine("El resultado es: {0}", Math.Abs(resultado));

                    DateTime fchTermino = DateTime.Now;
                    var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                    Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                    Console.ReadLine();
                }
                else if (aux == 4)
                {
                    Console.Write("Ingrese cuantos números primos quiere calcular: ");
                    string numero = Console.ReadLine();

                    int num = int.Parse(numero);

                    DateTime fchInicio = DateTime.Now;

                    Tarea.NumerosPrimos(num);

                    DateTime fchTermino = DateTime.Now;
                    var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                    Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                    Console.ReadLine();
                }
                else if (aux == 5)
                {
                    Console.Write("Ingrese cuantos números perfectos quiere calcular: ");
                    string numero = Console.ReadLine();

                    int num = int.Parse(numero);

                    DateTime fchInicio = DateTime.Now;

                    Tarea.CalcularNumerosPerfectos(num);

                    DateTime fchTermino = DateTime.Now;
                    var tiempoDemora = (fchTermino - fchInicio).TotalMilliseconds.ToString();

                    Console.WriteLine("El proceso se demoró: {0} milisegundos", tiempoDemora);
                    Console.ReadLine();
                }
            }
        }
    }
}
