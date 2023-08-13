using System;

namespace Module_5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Delishes) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();
            User.Delishes = new string[5];
            Console.WriteLine("Введите пять любимых блюд через Enter");
            for (int i = 0; i < 5; i++)
            {
                User.Delishes[i] = Console.ReadLine();
            }
        }
    }
}
