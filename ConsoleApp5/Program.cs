using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Sort<T> 
    {
        static void RemoveAt(ref T[] arr, int index) 
        {
            T[] newArray = new T[arr.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = arr[i];
            }
            for (int i = index + 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
        }

        public void func(ref T[] arr)
        {
            Dictionary<T, int> count = new Dictionary<T, int>(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                if (!count.ContainsKey(arr[i])) 
                {
                    count.Add(arr[i], 0);

                }
                count[arr[i]] += 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (count[arr[i]] % 2 == 0) 
                {
                    RemoveAt(ref arr, i);
                    i--;
                }
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 2, 6, 6, 9 }; // пример массива
            Sort<int> sort = new Sort<int>();
            sort.func(ref arr);

        }
    }
}
