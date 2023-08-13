using System;

namespace Module5._1._5
{
    class Program
    {
        static string ShowColors()
        {
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
            Console.WriteLine("Введите 3 Ваших любимых цвета");
			var favColors = new string[3];
            for (int i = 0; i < favColors.Length; i++)
            {
				favColors[i] = ShowColors();
            }
            Console.WriteLine("Ваши любимые цвета:");
			foreach(var color in favColors)
            {
                Console.WriteLine(color);
            }
		}
	}
}
