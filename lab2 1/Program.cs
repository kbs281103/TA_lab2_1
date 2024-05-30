using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Налаштування кодування консолі на UTF-8

        string input;
        do
        {
            Console.WriteLine("Введіть номер у списку групи (від 1 до 10), або введіть 'Q' для виходу:");
            input = Console.ReadLine();

            if (input.ToUpper() == "Q")
            {
                Console.WriteLine("До побачення!");
                break;
            }

            int groupNumber;
            if (!int.TryParse(input, out groupNumber))
            {
                Console.WriteLine("Неправильний формат введеної інформації. Будь ласка, введіть номер групи або 'Q' для виходу.");
                continue;
            }

            switch (groupNumber)
            {
                case 1:
                    Console.WriteLine("Прізвище: Іванов, Ім'я: Іван");
                    break;
                case 2:
                    Console.WriteLine("Прізвище: Петров, Ім'я: Петро");
                    break;
                case 3:
                    Console.WriteLine("Прізвище: Сидоров, Ім'я: Олександр");
                    break;
                case 4:
                    Console.WriteLine("Прізвище: Ковальчук, Ім'я: Марія");
                    break;
                case 5:
                    Console.WriteLine("Прізвище: Коваленко, Ім'я: Олексій");
                    break;
                case 6:
                    Console.WriteLine("Прізвище: Шевченко, Ім'я: Юлія");
                    break;
                case 7:
                    Console.WriteLine("Прізвище: Бондаренко, Ім'я: Дмитро");
                    break;
                case 8:
                    Console.WriteLine("Прізвище: Мельник, Ім'я: Анна");
                    break;
                case 9:
                    Console.WriteLine("Прізвище: Григоренко, Ім'я: Катерина");
                    break;
                case 10:
                    Console.WriteLine("Прізвище: Ткаченко, Ім'я: Олег");
                    break;
                default:
                    Console.WriteLine("Немає інформації про цей номер групи.");
                    break;
            }

        } while (input.ToUpper() != "Q");
    }
}
