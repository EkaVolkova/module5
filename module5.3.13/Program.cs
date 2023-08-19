using System;

namespace module5._3._13
{
    /// <summary>
    /// Используйте код метода SortArray. Сейчас этот метод сортирует массив по возрастанию значения. Создайте методы SortArrayDesc и SortArrayAsc — сортировка массива от большего к меньшему и сортировка массива от меньшего к большему.
    /// Метод SortArray модифицируйте так, чтобы он вызвал оба этих метода.Результаты методов SortArrayAsc и SortArrayDesc должны представлять собой массивы.
    /// Метод SortArray должен иметь один входной параметр array и два выходных: sorteddesc и sorted asc.
    /// </summary>
    class Program
    {
        static int[] SortArrayAsc(in int[] array)
        {
            var result = new int[array.Length];
            Array.Copy(array, result, array.Length);
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        int k = result[i];
                        result[i] = result[j];
                        result[j] = k;
                    }
                }
            }
            return result;
        }
        static int[] SortArrayDesc(in int[] array)
        {
            var result = new int[array.Length];
            Array.Copy(array, result, array.Length);
            
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        int k = result[i];
                        result[i] = result[j];
                        result[j] = k;
                    }
                }
            }
            return result;
        }
        static void SortArray(in int[] array, out int[] arrayAsc, out int[] arrayDesc)
        {

            arrayAsc = SortArrayAsc(in array);
            arrayDesc = SortArrayDesc(in array);
            
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 10, -8, 7, 4, 11 };
            Console.WriteLine("Исходный массив до вызова сортировки");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            
            
            SortArray(in array,  out int[] arrayAsc, out int[] arrayDesc);
            Console.WriteLine("\n\nИсходный массив после вызова сортировки");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nПрямой порядок сортировки");
            foreach (var item in arrayAsc)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\nОбратный порядок сортировки");
            foreach (var item in arrayDesc)
            {
                Console.Write(item + " ");
            }
        }
    }
}
