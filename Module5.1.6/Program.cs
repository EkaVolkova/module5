using System;

namespace Module5._1._6
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
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if(result[i] > result[j])
                    {
                        int k = result[i];
                        result[i] = result[j];
                        result[j] = k;
                    }
                }
            }
            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
            return result;
        }
        static void Main(string[] args)
        {
            GetArrayFromConsole();
        }
    }
}
