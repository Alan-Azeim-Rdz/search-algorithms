using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_algorithms
{
    internal class SearchAlgorithms
    {
        // Búsqueda Secuencial
        public static int SequentialSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                    return i + 1; // Retorna el índice si se encuentra
            }
            return -1; // No encontrado
        }


        // Búsqueda Binaria
        public static int BinarySearch(int[] array, int key)
        {
            Array.Sort(array); // Aseguramos que la lista esté ordenada
            int left = 0, right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == key)
                    return middle;
                else if (array[middle] < key)
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            return -1; // No encontrado
        }


        // Búsqueda por Hash
        public static int HashSearch(int[] array, int key)
        {
            Dictionary<int, int> hashTable = new Dictionary<int, int>();

            // Crear la tabla hash
            for (int i = 0; i < array.Length; i++)
            {
                if (!hashTable.ContainsKey(array[i]))
                    hashTable[array[i]] = i;
            }

            // Buscar en la tabla hash
            return hashTable.ContainsKey(key) ? hashTable[key] : -1;
        }
    }
}
