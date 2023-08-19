using System;

namespace module5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);
            Console.WriteLine(Factorial(20));
            Console.WriteLine("Введите число");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень");
            Byte power = Byte.Parse(Console.ReadLine());

            Console.WriteLine(PowerUp(N, power));
            Console.ReadKey();

        }
        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;
            if (modif.Length > 2)
                modif = modif.Remove(0, 2);
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);


            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        private static int PowerUp(int N, byte pow)
        {
            int result = N;
            
            if (pow == 0)
                return 1;
            if (pow == 1)
                return N;

            result = result * PowerUp(N, --pow);
            
            return result;
        }

    }

}

