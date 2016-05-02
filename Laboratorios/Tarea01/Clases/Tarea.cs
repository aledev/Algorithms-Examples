using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01.Clases
{
    public class Tarea
    {
        #region Factorial
        /// <summary>
        /// Metodo para calcular un factorial utilizando una "mantisa"
        /// </summary>
        /// <param name="num">Número a calcular su factorial</param>
        public static void Factorial(int num)
        {
            float fac = 0.1f;
            int exp = 0;

            for (int i = 1; i <= num; i++)
            {
                fac = fac * i;

                if (fac > 1.0f)
                {
                    fac = fac / 10;
                    exp++;
                }
            }

            Console.WriteLine("El resultado es: {0}E{1}", fac, exp);
        }
        #endregion

        #region Fibonacci
        /// <summary>
        /// Metodo para calcular la sucesión de fibonacci con recursividad
        /// </summary>
        /// <param name="k">"k"-esimo número a calcular</param>
        /// <returns></returns>
        public static int Fibonacci_R(int k)
        {
            if (k == 0)
            {
                return 0;
            }
            else if (k == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci_R(k - 1) + Fibonacci_R(k - 2);
            }
        }

        /// <summary>
        /// Metodo para calcular la sucesión de fibonacci iterativamente
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int Fibonacci_I(int k)
        {
            if (k == 1)
                return 0;
            else if (k == 2)
                return 1;
            else
            {
                int a = 0;
                int b = 1;

                for (int i = 0; i < k; i++)
                {
                    int aux = a;
                    a = b;
                    b = aux + b;
                }

                return a;
            }
        }
        #endregion

        #region Primos
        public static void NumerosPrimos(int cantidad)
        {
            int iterador = 1;
            int numAux = 1;

            while (iterador <= cantidad)
            {
                if (Tarea.EsNumeroPrimo(numAux, numAux - 1))
                {
                    Console.WriteLine("N° primo {0}: {1}", iterador, numAux);
                    iterador++;
                }

                numAux++;
            }
        }

        private static bool EsNumeroPrimo(int n, int k)
        {
            if (n < 2)
                return true;
            if (k == 1)
                return true;
            else
            {
                if (n % k == 0)
                    return false;
                else
                    return EsNumeroPrimo(n, k - 1);
            }
        }
        #endregion

        #region Numeros Perfectos
        public static void CalcularNumerosPerfectos(int cantidad)
        {
            int iterador = 1;
            int factor = 1;
            int contador = 1;

            while (iterador <= cantidad)
            {
                bool isPerfect = EsNumeroPerfecto(ref factor, contador);

                if (isPerfect && (factor > 1))
                {
                    Console.WriteLine("N° Perfecto {0}: {1}", iterador, factor);
                    iterador++;
                }

                factor = 1;
                contador++;
            }         
        }

        private static bool EsNumeroPerfecto(ref int f, int n)
        {
            int temp;
            int contador = 2;

            bool esPerfect = false;

            while (contador <= (n - 1))
            {
                temp = n % contador;

                if (temp == 0)
                {
                    f = f + contador;
                }

                contador++;
            }

            if ((f) == n)
                esPerfect = true;

            else
                esPerfect = false;

            return esPerfect;
        }

        #endregion
    }
}
