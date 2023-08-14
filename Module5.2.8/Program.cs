using System;

namespace Module5._2._8
{
    class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            
            return result;
        }
        static int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int k = array[i];
                        array[i] = array[j];
                        array[j] = k;
                    }
                }
            }
            
            return array;
        }
        static void Main(string[] args)
        {
            
            int[] array = SortArray(GetArrayFromConsole());
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
