using System;

namespace Result
{
    /// <summary>
    /// Необходимо написать программу в классе Program со следующим функционалом:
    ///     Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
    ///         Имя;
    ///         Фамилия;
    ///         Возраст;
    ///         Наличие питомца;
    ///         Если питомец есть, то запросить количество питомцев;
    ///         Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек(заполнение с клавиатуры);
    ///         Запросить количество любимых цветов;
    ///         Вызвать метод, который возвращает массив любимых цветов по их количеству(заполнение с клавиатуры);
    ///         Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
    ///         Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
    ///         Корректный ввод: ввод числа типа int больше 0.
    ///    Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
    ///    Вызов методов из метода Main.

    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, int Age, bool HasPet, int CountPets, string[] PetsNames, int CountFavColor, string[] FavColors) User;
            Console.WriteLine("Hello World!");
            User = MakeNewUser();
            ShowUserData(User);
        }
        static (string Name, string LastName, int Age, bool HasPet, int CountPets, string[] PetsNames, int CountFavColor, string[] FavColors) MakeNewUser()
        {
            (string Name, string LastName, int Age, bool HasPet, int CountPets, string[] PetsNames, int CountFavColor, string[] FavColors) User;
            Console.Write("Ваше имя: ");
            User.Name = Console.ReadLine();
            Console.Write("Ваша фамилия: ");
            User.LastName = Console.ReadLine();
            do
            {
                Console.Write("Ваш возраст: ");

            } while (!IsNumbers(Console.ReadLine(), out User.Age));

            do
            {
                Console.Write("Есть питомцы: ");

            } while (!IsTrueFalse(Console.ReadLine(), out User.HasPet));
            if (User.HasPet)
            {
                do
                {
                    Console.Write("Количество питомцев: ");

                } while (!IsNumbers(Console.ReadLine(), out User.CountPets));

                MakeArrayPetsNames(User.CountPets, out User.PetsNames);


            }
            else
            {
                User.CountPets = 0;
                User.PetsNames = new string[1];
                User.PetsNames[0] = "No pets";
            }
            do
            {
                Console.Write("Количество любимых цветов: ");

            } while (!IsNumbers(Console.ReadLine(), out User.CountFavColor));

            User.FavColors = new string[User.CountFavColor];
            for (int i = 0; i < User.CountFavColor; i++)
            {
                Console.Write("Любимый цвет {0}: ", i);
                User.FavColors[i] = Console.ReadLine();
            }
            return User;

        }
        static void ShowUserData((string Name, string LastName, int Age, bool HasPet, int CountPets, string[] PetsNames, int CountFavColor, string[] FavColors) User)
        {
            Console.WriteLine("Ваше имя: {0}", User.Name);
            Console.WriteLine("Ваша фамилия: {0}", User.LastName);
            Console.WriteLine("Ваш возраст: {0}", User.Age);


            Console.WriteLine("Есть питомцы: {0}", User.HasPet ? "Да" : "Нет");

            if (User.HasPet)
            {
                Console.WriteLine("Количество питомцев: {0}", User.CountPets);
                ShowArrayPetsNames(User.CountPets, User.PetsNames);

            }
            Console.WriteLine("Количество любимых цветов: {0}", User.CountFavColor);

            for (int i = 0; i < User.CountFavColor; i++)
            {
                Console.WriteLine("Любимый цвет {0}: {1}", i, User.FavColors[i]);
            }
        }
        static void MakeArrayPetsNames(int countPets, out string[] arrayPets)
        {
            arrayPets = new string[countPets];
            for (int i = 0; i < countPets; i++)
            {
                Console.Write("Имя питомца {0}: ", i);
                arrayPets[i] = Console.ReadLine();
            }
        }
        static void ShowArrayPetsNames(int countPets, string[] arrayPets)
        {
            
            for (int i = 0; i < countPets; i++)
            {
                Console.WriteLine("Имя питомца {0}: {1}", i, arrayPets[i]);
            }
        }
        static bool IsNumbers(string checkenNum, out int result)
        {

            return (int.TryParse(checkenNum, out result) && result > 0);
        }
        static bool IsTrueFalse(string chekenStr, out bool result)
        {
            if (chekenStr == "Yes" || chekenStr == "yes" || chekenStr == "Да" || chekenStr == "да")
            {
                result = true;
                return true;
            }
            if (chekenStr == "No" || chekenStr == "no" || chekenStr == "Нет" || chekenStr == "нет")
            {
                result = false;
                return true;
            }
            result = false;
            return false;

        }

    }
}
