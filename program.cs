namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            PrintText("ДЗ 3. Циклы\n1 - Сумма чисел от 1 до N\n2 - Сумма чисел до ввода нуля\n3 - Проверка положительного числа\n4 - Подсчёт чётных чисел\nВыберите задание:");

            string choice = ReadText();

            switch (choice)
            {
                case "1":
                    GetSumFor();
                    break;

                case "2":
                    GetSumUntil0();
                    break;

                case "3":
                    CheckNumberDoWhile();
                    break;

                case "4":
                    EvenNumbers();
                    break;

                default:
                    PrintText("Введите число от 1 до 4.");
                    break;
            }
        }

        private static void GetSumFor() /// 1. Цикл for — сумма чисел Пользователь вводит число N.Найди сумму всех чисел от 1 до N включительно.
        {
            PrintText("Введите число N:");

            int n = GetNumberInt();
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            PrintText($"Сумма чисел от 1 до {n}: {sum}");
        }

        private static void GetSumUntil0()
        {
            int[] numbers = new int[0];
            int sum = 0;
            int index = 0;

            PrintText("Введите числа. Для завершения введите 0.");

            int number = GetNumberInt();

            while (number != 0)
            {
                Array.Resize(ref numbers, numbers.Length + 1);

                numbers[index] = number;
                sum += number;
                index++;

                number = GetNumberInt();
            }

            PrintText($"Сумма введённых чисел: {sum}");
        }

        private static void CheckNumberDoWhile()
        {
            int[] numbers = new int[0];
            int index = 0;
            int number;

            do
            {
                PrintText("Введите число:");
                number = GetNumberInt();

                Array.Resize(ref numbers, numbers.Length + 1);

                numbers[index] = number;
                index++;

                if (number <= 0)
                {
                    PrintText("Число должно быть положительным. Попробуйте ещё раз.");
                }

            } while (number <= 0);

            PrintText($"Спасибо! Чётное введённое число: {number}");

            PrintText("Все введённые числа:");

            foreach (int item in numbers)
            {
                PrintText(item.ToString());
            }
        }

        private static void EvenNumbers() ///Цикл foreach — подсчёт чётных чисел
///Создай массив из нескольких целых чисел.С помощью foreach посчитай, сколько в нём чётных чисел, и выведи результат.
        {
            int[] numbers = new int[0];
            int sum = 0;
            int index = 0;
            int evenCount = 0;

            PrintText("Введите числа. Для завершения введите 0.");

            int number = GetNumberInt();

            while (number != 0)
            {
                Array.Resize(ref numbers, numbers.Length + 1);

                numbers[index] = number;
                if (number % 2 == 0)
                {
                    evenCount++;
                }

                number = GetNumberInt();
            }
            PrintText($"Чётных чисел: {evenCount}");
        }

        private static int GetNumberInt()
        {
            while (true)
            {
                string input = ReadText();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }

                PrintText("Ошибка! Введите целое число:");
            }
        }

        private static void PrintText(string text)
        {
            Console.WriteLine(text);
        }
        private static string ReadText()
        {
            return Console.ReadLine();
        }
    }
}
