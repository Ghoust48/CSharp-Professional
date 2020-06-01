using System;
using System.Collections;

namespace Task_001
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};

            foreach (var item in GetEnumerator(arr))
            {
                Console.WriteLine(item);
            }
        }
        
        public static IEnumerable GetEnumerator(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    yield return arr[i] * arr[i];
                }
            }
        }
    }
}