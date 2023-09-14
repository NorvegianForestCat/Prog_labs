using System; // Подключение объектов к области видимости System

namespace LB1._1._1 // Объявление пространства имен лабораторных работ
{
    class Program // Объявление класса
    {
        static void Main(string[] args) // Точка входа
        {
            double a, b, c; // Объявление переменных длины, высоты и ширины изучаемой зоны
            bool inputFlag; // Объявление флага ввода, отвечающего за работу ввода корректных аргументов

            const double oxygenVolumeFraction = 0.21; // Объявление и иницализация константы, отвечающей за долю О2 в зоне

            a = b = c = 0; // Инициализация переменных высоты, ширины и длины
            inputFlag = true; // Инициализация флага ввода

            while(inputFlag) // Цикл ввода корректных значений
            {

                Console.WriteLine("Please, input a height value"); // Вывод информации о требуемом значении
                a = Convert.ToDouble(Console.ReadLine()); // Чтение значения высоты с консоли

                Console.WriteLine("Please, input a width value"); // Вывод информации о требуемом значении
                b = Convert.ToDouble(Console.ReadLine()); // Чтение значения ширины с консоли

                Console.WriteLine("Please, input a lenght value"); // Вывод информации о требуемом значении
                c = Convert.ToDouble(Console.ReadLine()); // Чтение значения длины с консоли

                if (a <= 0 || b <= 0 || c <= 0) // Проверка введенных данных на корректность
                {
                    Console.WriteLine("Please, enter a positive values (e.g. 15 3 2)"); // Вывод информации о неправильном формате ввода
                }
                else // Если данные корректны
                {
                    inputFlag = false; // Флаг ввода снимается, сигнализируя об окончании ввода аргументов
                    break; // Преднамеренный выход из цикла ввода аргументов
                }
            }

            Console.WriteLine($"Volume fraction of oxygen in this area is equal {a * b * c * oxygenVolumeFraction}"); // Вычисление объемной доли кислорода и вывод информации на консоль

            Console.ReadKey(); // Ожидание сигнала окончания работы программы
            
        }
    }
}
