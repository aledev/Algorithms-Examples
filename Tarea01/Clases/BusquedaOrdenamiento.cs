using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01.Clases
{
    public class BusquedaOrdenamiento
    {
        #region Busqueda Recursiva
        public static int BusquedaRec(int e, int[] a, int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                if (e == a[n])
                {
                    return 1;
                }
                else
                {
                    return BusquedaRec(e, a, n - 1);
                }
            }
        }
        #endregion

        #region BusquedaBinaria
        /// <summary>
        /// Algoritmo de búsqueda binaria.
        /// Este algorimo funciona solo si el arreglo esta ordenado.
        /// </summary>
        /// <param name="e">Numero a buscar</param>
        /// <param name="a">Arreglo de int con valores ordenados</param>
        /// <param name="n">Tamaño del arreglo</param>
        /// <returns></returns>
        public static int BusquedaBinaria(int e, int[] a, int n)
        {
            int i, f, m;
            i = 1;
            f = n;
            m = (i + f) / 2;

            while ((e != a[m]) && (i <= f))
            {
                if (e < a[m])
                {
                    f = m - 1;
                }
                else
                {
                    i = m + 1;
                }

                m = (i + f) / 2;
            }

            if (e == a[m])
                return 1;
            else
                return 0;
        }
        #endregion
    }
}
