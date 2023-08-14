using System;

namespace Module5._2
{
    class Program
    {
		static string ShowColors(string name, int age)
		{
			Console.WriteLine("{0}, {1}\nНапишите свой любимый цвет на английском с маленькой буквы", name, age);
			string color = Console.ReadLine();
			switch (color)
			{
				case "red":
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is red!");
					break;
				case "green":
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is green!");
					break;
				case "cyan":
					Console.BackgroundColor = ConsoleColor.Cyan;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is cyan!");
					break;
				default:
					Console.BackgroundColor = ConsoleColor.Yellow;
					Console.ForegroundColor = ConsoleColor.Red;

					Console.WriteLine("Your color is yellow!");
					break;
			}
			return color;
		}

		static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);
			var favColors = new string[3];
			foreach(var color in favColors)
            {
				ShowColors(anketa.name, anketa.age);
            }
            Console.ReadKey();
        }
    }
}
