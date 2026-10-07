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
            ShowMenu();
            string choice = ReadText();
            ExecuteTask(choice);
        }

        // Главное меню
        private static void ShowMenu()
        {
            PrintText("ДЗ. Массивы");
            PrintText("1 - Вывод элементов массива");
            PrintText("2 - Сумма элементов массива");
            PrintText("3 - Подсчёт чётных чисел");
            PrintText("4 - Поиск максимального числа");
            PrintText("5 - Поиск числа в массиве");
            PrintText("Выберите задание:");
        }

        // Запуск выбранного задания
        private static void ExecuteTask(string choice)
        {
            switch (choice)
            {
                case "1":
                    PrintRandomArray();
                    break;

                case "2":
                    SumArray();
                    break;

                case "3":
                    CountEvenNumbers();
                    break;

                case "4":
                    FindMaximum();
                    break;

                case "5":
                    FindNumber();
                    break;

                default:
                    ShowInvalidChoiceMessage();
                    break;
            }
        }

        // 1. Вывод элементов массива
        private static void PrintRandomArray()
        {
            int[] numbers = CreateRandomArray();

            PrintText("Элементы массива:");
            PrintArray(numbers);
        }

        // Создание массива со случайными числами
        private static int[] CreateRandomArray()
        {
            int arraySize = ReadArraySize();
            return FillRandomArray(arraySize);
        }

        // Заполнение массива случайными числами
        private static int[] FillRandomArray(int arraySize)
        {
            int[] numbers = CreateArray(arraySize);
            Random random = CreateRandom();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = GenerateRandomNumber(random);
            }

            return numbers;
        }

        // 2. Сумма элементов массива
        private static void SumArray()
        {
            int[] numbers = CreateArrayByChoice();

            PrintArrayWithTitle(numbers);

            int sum = CalculateSum(numbers);
            PrintSum(sum);
        }

        // 3. Подсчёт чётных чисел
        private static void CountEvenNumbers()
        {
            int[] numbers = CreateManualArray();

            int evenCount = CalculateEvenCount(numbers);
            PrintEvenCount(evenCount);
        }

        // 4. Поиск максимального числа
        private static void FindMaximum()
        {
            int[] numbers = CreateArrayByChoice();

            PrintArrayWithTitle(numbers);

            int maximum = CalculateMaximum(numbers);
            PrintMaximum(maximum);
        }

        // 5. Поиск числа в массиве
        private static void FindNumber()
        {
            int[] numbers = CreateManualArray();
            int searchNumber = ReadSearchNumber();

            bool isFound = IsNumberFound(numbers, searchNumber);
            PrintSearchResult(isFound);
        }

        // Создание массива с выбором способа заполнения
        private static int[] CreateArrayByChoice()
        {
            int arraySize = ReadArraySize();
            string fillChoice = ReadFillChoice();

            return FillArray(arraySize, fillChoice);
        }

        // Заполнение массива выбранным способом
        private static int[] FillArray(int arraySize, string fillChoice)
        {
            switch (fillChoice)
            {
                case "1":
                    return FillRandomArray(arraySize);

                case "2":
                    return FillManualArray(arraySize);

                default:
                    PrintInvalidFillChoiceMessage();
                    return CreateEmptyArray();
            }
        }

        // Создание массива вручную
        private static int[] CreateManualArray()
        {
            int arraySize = ReadArraySize();
            return FillManualArray(arraySize);
        }

        // Заполнение массива вручную
        private static int[] FillManualArray(int arraySize)
        {
            int[] numbers = CreateArray(arraySize);

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadArrayElement(i);
            }

            return numbers;
        }

        // Вывод массива
        private static void PrintArrayWithTitle(int[] numbers)
        {
            PrintText("Массив:");
            PrintArray(numbers);
        }

        private static void PrintArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                PrintText(number.ToString());
            }
        }

        // Подсчёт суммы элементов
        private static int CalculateSum(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        // Подсчёт чётных чисел
        private static int CalculateEvenCount(int[] numbers)
        {
            int evenCount = 0;

            foreach (int number in numbers)
            {
                if (IsEven(number))
                {
                    evenCount++;
                }
            }

            return evenCount;
        }

        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Поиск максимального числа
        private static int CalculateMaximum(int[] numbers)
        {
            int maximum = numbers[0];

            foreach (int number in numbers)
            {
                if (number > maximum)
                {
                    maximum = number;
                }
            }

            return maximum;
        }

        // Поиск числа в массиве
        private static bool IsNumberFound(int[] numbers, int searchNumber)
        {
            foreach (int number in numbers)
            {
                if (number == searchNumber)
                {
                    return true;
                }
            }

            return false;
        }

        // Создание массива
        private static int[] CreateArray(int arraySize)
        {
            return new int[arraySize];
        }

        private static int[] CreateEmptyArray()
        {
            return new int[0];
        }

        // Создание генератора случайных чисел
        private static Random CreateRandom()
        {
            return new Random();
        }

        private static int GenerateRandomNumber(Random random)
        {
            return random.Next(1, 101);
        }

        // Ввод размера массива
        private static int ReadArraySize()
        {
            PrintText("Введите размер массива:");
            return GetPositiveNumber();
        }

        // Выбор способа заполнения
        private static string ReadFillChoice()
        {
            PrintText("Выберите способ заполнения:");
            PrintText("1 - Случайными числами");
            PrintText("2 - Вручную");

            return ReadText();
        }

        // Ввод элемента массива
        private static int ReadArrayElement(int index)
        {
            PrintText($"Введите элемент {index + 1}:");
            return GetNumberInt();
        }

        // Ввод искомого числа
        private static int ReadSearchNumber()
        {
            PrintText("Введите число для поиска:");
            return GetNumberInt();
        }

        // Вывод результатов
        private static void PrintSum(int sum)
        {
            PrintText($"Сумма: {sum}");
        }

        private static void PrintEvenCount(int evenCount)
        {
            PrintText($"Чётных чисел: {evenCount}");
        }

        private static void PrintMaximum(int maximum)
        {
            PrintText($"Максимум: {maximum}");
        }

        private static void PrintSearchResult(bool isFound)
        {
            if (isFound)
            {
                PrintText("Найдено");
            }
            else
            {
                PrintText("Не найдено");
            }
        }

        private static void ShowInvalidChoiceMessage()
        {
            PrintText("Введите число от 1 до 5.");
        }

        private static void PrintInvalidFillChoiceMessage()
        {
            PrintText("Неверный вариант заполнения.");
        }

        // Ввод любого целого числа
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

        // Ввод положительного числа
        private static int GetPositiveNumber()
        {
            while (true)
            {
                int number = GetNumberInt();

                if (number > 0)
                {
                    return number;
                }

                PrintText("Число должно быть больше нуля. Попробуйте ещё раз:");
            }
        }

        private static void PrintText(string text)
        {
            Console.WriteLine(text);
        }

        private static string ReadText()
        {
            return Console.ReadLine() ?? "";
        }
    }
}
