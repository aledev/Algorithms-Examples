using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Clases
{
    public class Algoritmos
    {
        #region OrdenamientoInsercion
        public static PersonaDTO[] OrdenamientoInsercion(PersonaDTO[] p_array)
        {
            for (int i = 0; i < p_array.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (p_array[j - 1].Id > p_array[j].Id)
                    {
                        var temp = p_array[j - 1];
                        p_array[j - 1] = p_array[j];
                        p_array[j] = temp;
                    }
                    j--;
                }
            }
            return p_array;
        }
        #endregion

        #region OrdenamientoBurbuja
        public static void OrdenamientoBurbuja(PersonaDTO[] p_Array)
        {
            PersonaDTO temp = null;

            for (int write = 0; write < p_Array.Length; write++)
            {
                for (int sort = 0; sort < p_Array.Length - 1; sort++)
                {
                    if (p_Array[sort].Id > p_Array[sort + 1].Id)
                    {
                        temp = p_Array[sort + 1];
                        p_Array[sort + 1] = p_Array[sort];
                        p_Array[sort] = temp;
                    }
                }
            }
        }
        #endregion

        #region OrdenamientoSeleccion
        public static void OrdenamientoSeleccion(PersonaDTO[] p_array)
        {
            int pos_min;
            PersonaDTO temp;

            for (int i = 0; i < p_array.Length - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < p_array.Length; j++)
                {
                    if (p_array[j].Id < p_array[pos_min].Id)
                    {
                        pos_min = j;
                    }
                }

                if (pos_min != i)
                {
                    temp = p_array[i];
                    p_array[i] = p_array[pos_min];
                    p_array[pos_min] = temp;
                }
            }
        }
        #endregion

        #region OrdenamientoMezcla
        public static void OrdenamientoMezcla(PersonaDTO[] p_array, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;

                OrdenamientoMezcla(p_array, left, mid);
                OrdenamientoMezcla(p_array, (mid + 1), right);
                MainMergeSort(p_array, left, (mid + 1), right);
            }
        }

        private static void MainMergeSort(PersonaDTO[] p_array, int left, int mid, int right)
        {
            PersonaDTO[] temp = new PersonaDTO[p_array.Count()];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (p_array[left].Id <= p_array[mid].Id)
                    temp[pos++] = p_array[left++];
                else
                    temp[pos++] = p_array[mid++];
            }

            while (left <= eol)
                temp[pos++] = p_array[left++];

            while (mid <= right)
                temp[pos++] = p_array[mid++];

            for (i = 0; i < num; i++)
            {
                p_array[right] = temp[right];
                right--;
            }
        }
        #endregion

        #region OrdenamientoRapido
        public static void OrdenamientoRapido(PersonaDTO[] p_array, int primero, int ultimo)
        {
            int i, j, central;
            PersonaDTO pivote;
            central = (primero + ultimo) / 2;
            pivote = p_array[central];
            i = primero;
            j = ultimo;
            do
            {
                while (p_array[i].Id < pivote.Id) i++;
                while (p_array[j].Id > pivote.Id) j--;
                if (i <= j)
                {
                    PersonaDTO temp;
                    temp = p_array[i];
                    p_array[i] = p_array[j];
                    p_array[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
                OrdenamientoRapido(p_array, primero, j);
            if (i < ultimo)
                OrdenamientoRapido(p_array, i, ultimo);
        }
        #endregion

        #region OrdenamientoMonticulos
        public static void OrdenamientoMonticulos(PersonaDTO[] p_array, int index)
        {
            int heapSize = 0;
            BuildHeap(p_array, out heapSize);
            for (int i = p_array.Length - 1; i >= 0; i--)
            {
                Swap(p_array, 0, i);
                heapSize--;
                Heapify(p_array, 0, heapSize);
            }
        }
        private static void BuildHeap(PersonaDTO[] p_array, out int heapSize)
        {
            heapSize = p_array.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(p_array, i, heapSize);
            }
        }
        private static void Swap(PersonaDTO[] p_array, int x, int y)
        {
            PersonaDTO temp = p_array[x];
            p_array[x] = p_array[y];
            p_array[y] = temp;
        }
        private static void Heapify(PersonaDTO[] p_array, int index, int heapSize)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int largest = index;
        
            if (left <= heapSize && p_array[left].Id > p_array[index].Id)
                largest = left;

            if (right <= heapSize && p_array[right].Id > p_array[largest].Id)
                largest = right;

            if (largest != index)
            {
                Swap(p_array, index, largest);
                Heapify(p_array, largest, heapSize);
            }
        }
        #endregion
    }
}
