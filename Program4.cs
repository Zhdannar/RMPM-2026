namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run(); ///инициализация
        }

        private static void Run() //запуск шагов
        {
            ShowMenu(); ///менюшка с текстом
            string choice = ReadText();//выбрали задание
            ExecuteTask(choice); ///свич с выбором задания
        }

        private static void ShowMenu() ///менюшка с текстом
        {
            PrintText("Выберите задание:\n1 - Вывод элементов массива\n2 - Сумма элементов массива\n3 - Подсчёт чётных чисел\n4 - Поиск максимального числа\n5 - Поиск числа в массиве");
        }

        private static void ExecuteTask(string choice) ///свич с выбором задания
        {
            switch (choice)
            {
                case "1":
                    PrintRandomArray(); /// Вывод элементов
                    ///Создай массив из N целых чисел и заполние его случайными числами выведи все элементы на экран.
                    break;

                case "2":
                    SumArray(); ///Сумма элементов
                    ///Найди сумму всех чисел в массиве размером N. Заполняем либо случайно либо руками.
                    break;

                case "3":
                    CountEvenNumbers(); ///Подсчёт чётных чисел
                    ///Посчитай, сколько в массиве N чётных чисел. числа вводим руками.
                    break;

                case "4":
                    FindMaximum();///Поиск максимального числа
                    ///Найди самое большое число в массиве размером N и выведи его.заполняйте как хотите.
                    break;

                case "5":
                    FindNumber();///Поиск числа в массиве. Массив создайте как хотите
                    ///Попроси пользователя ввести число и проверь, есть ли оно в массиве. Выведи «Найдено» или «Не найдено».
                    break;

                default:
                    ShowInvalidChoiceMessage(); ///соо что надо определенное число а не что угодно
                    break;
            }
        }
        /// <summary>
        /// Задание 1. Вывод элементов
        /// Создай массив из N целых чисел и заполние его случайными числами выведи все элементы на экран.
        /// </summary>

        private static void PrintRandomArray() //выводим рандомный массив
        {
            int[] numbers = CreateRandomArray(); //создаем рандомный массив

            PrintText("Элементы массива:");
            PrintArray(numbers);
        }

        private static int[] CreateRandomArray() //создаем рандомный массив
        {
            int arraySize = ReadArraySize(); //берем размер
            return FillRandomArray(arraySize); //заполняем рандомный массив
        }

        private static int[] FillRandomArray(int arraySize) //заполняем массив рандомом
        {
            int[] numbers = CreateArray(arraySize); //создаем массив
            Random random = CreateRandom(); //инициализируем рандом

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = GenerateRandomNumber(random); //генерация рандомного числа
            }

            return numbers;
        }
        /// <summary>
        /// Задание 2. Сумма элементов
        ///Найди сумму всех чисел в массиве размером N. Заполняем либо случайно либо руками.
        /// </summary>
        private static void SumArray() //сумма элементов массива
        {
            int[] numbers = CreateArrayByChoice(); //создаем массив по выбору

            PrintArrayWithTitle(numbers); //вывод пафосный

            int sum = CalculateSum(numbers); //расчёт суммы
            PrintSum(sum);//вывод суммы
        }

        /// <summary>
        /// Задание 3. Подсчёт чётных чисел
        ///Посчитай, сколько в массиве N чётных чисел. числа вводим руками.
        /// </summary>
        private static void CountEvenNumbers() //подсчёт числа четных чисел
        {
            int[] numbers = CreateManualArray(); //создаем массив ручками

            int evenCount = CalculateEvenCount(numbers); //расчёт количества четных
            PrintEvenCount(evenCount); //вывод количества чётных
        }

        /// <summary>
        /// Задание 4. Поиск максимального числа
        ///Найди самое большое число в массиве размером N и выведи его.заполняйте как хотите.
        /// </summary>
        private static void FindMaximum() //поиск максимума
        {
            int[] numbers = CreateArrayByChoice(); //массив создаем по выбору

            PrintArrayWithTitle(numbers); //пафосный массив вывод

            int maximum = CalculateMaximum(numbers); //расчёт максимума
            PrintMaximum(maximum); //вывод максимума
        }

        /// <summary>
        /// Задание 5. Поиск числа в массиве. Массив создайте как хотите
        ///Попроси пользователя ввести число и проверь, есть ли оно в массиве. Выведи «Найдено» или «Не найдено».
        /// </summary>
        private static void FindNumber() //поиск числа
        {
            int[] numbers = CreateArrayByChoice(); //массив создаем по выбору
            int searchNumber = ReadSearchNumber();//вывод числа которое искали

            bool isFound = IsNumberFound(numbers, searchNumber); //найдено ли
            PrintSearchResult(isFound); //результат поиска бул
        }

        private static int[] CreateArrayByChoice() //создаем массив для заполнения по выбору
        {
            int arraySize = ReadArraySize(); //берем размер массива
            string fillChoice = ReadFillChoice();//метод заполнения

            return FillArray(arraySize, fillChoice);//заполняем массив
        }

        private static int[] FillArray(int arraySize, string fillChoice) //заполняем массив как нибудь
        {
            switch (fillChoice)
            {
                case "1":
                    return FillRandomArray(arraySize); //заполнение массива рандомом

                case "2":
                    return FillManualArray(arraySize); //заполнение массива ручками

                default:
                    PrintInvalidFillChoiceMessage(); //ошибка числа в свиче
                    return CreateEmptyArray(); //создать пустой массив
            }
        }


        private static int[] CreateManualArray() //создаем массив руками
        {
            int arraySize = ReadArraySize(); //берем размер массива
            return FillManualArray(arraySize); //заполняем вручную
        }
        private static int[] FillManualArray(int arraySize) //массив руками заполняем
        {
            int[] numbers = CreateArray(arraySize);  //создаем массив

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadArrayElement(i); //берем элемент массива
            }

            return numbers;
        }

        private static void PrintArrayWithTitle(int[] numbers) //вывод массива пафосный с заголовком
        {
            PrintText("Массив:");
            PrintArray(numbers);
        }

        private static void PrintArray(int[] numbers) //вывод массива
        {
            foreach (int number in numbers)
            {
                PrintText(number.ToString());
            }
        }

        private static int CalculateSum(int[] numbers) //сумма
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

          private static int CalculateEvenCount(int[] numbers) // количество четных
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

        private static bool IsEven(int number) //четное ли
        {
            return number % 2 == 0;
        }

        private static int CalculateMaximum(int[] numbers) //считаем максимум
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

        private static bool IsNumberFound(int[] numbers, int searchNumber) //поик числа в массиве
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

  
        private static int[] CreateArray(int arraySize) //просто массив
        {
            return new int[arraySize];
        }

        private static int[] CreateEmptyArray() //пустой массив
        {
            return new int[0];
        }

        private static Random CreateRandom() //новый генератор
        {
            return new Random();
        }

        private static int GenerateRandomNumber(Random random) //генерация великого рандома
        {
            return random.Next(1, 101);
        }

        private static int ReadArraySize() //размер массива
        {
            PrintText("Введите размер массива:");
            return GetPositiveNumber(); //ввод положительного целого числа
        }

            private static string ReadFillChoice() //способ заполнения
        {
            PrintText("Выберите способ заполнения:\n1- Рандом\n2- Руками");

            return ReadText();
        }

        private static int ReadArrayElement(int index) //вывод какого нибудь элемента массива
        {
            PrintText($"Введите элемент {index + 1}:");
            return GetNumberInt();//ввод целого числа
        }

        private static int ReadSearchNumber() //вывод числа которое искали
        {
            PrintText("Введите число для поиска:");
            return GetNumberInt();//ввод целого числа
        }
        private static void PrintSum<T>(T sum) //вывод суммы
        {
            PrintText($"Сумма: {sum}");
        }

        private static void PrintEvenCount(int evenCount) //вывод количества четных чисел
        {
            PrintText($"Чётных чисел: {evenCount}");
        }

        private static void PrintMaximum(int maximum) //вывод максимума
        {
            PrintText($"Максимум: {maximum}");
        }

        private static void PrintSearchResult(bool isFound) //вывод результата поиска
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

        private static void ShowInvalidChoiceMessage() //соо об ошибке числа в свиче
        {
            PrintText("Введите число в пределах указанных значений");
        }

        private static void PrintInvalidFillChoiceMessage() //соо об ошибке заполнения
        {
            PrintText("Неверный вариант заполнения.");
        }

        private static int GetNumberInt() //ввод целого числа
        {
            while (true)
            {
                string input = ReadText();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }

                PrintText("Введите целое число:");
            }
        }

        private static int GetPositiveNumber() //ввод положительного целого числа
        {
            while (true)
            {
                int number = GetNumberInt(); //ввод целого числа

                if (number > 0)
                {
                    return number;
                }

                PrintText("Введи число больше нуля");
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
