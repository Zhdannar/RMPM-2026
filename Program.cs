namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunCalculator();
        }

        private static void RunCalculator()
        {
            PrintText("Калькулятор\n1 - Сумма двух целых чисел\n2 - Сумма трёх целых чисел\n 3 - Сумма двух целых и одного double\n4 - Сумма двух double\n5 - Конкатенация двух строк\nВыберите операцию (1-5):");
            string? choice = ReadText();

            switch (choice)
            {
                case "1":
                    int inum11 = GetNumberInt();
                    int inum12 = GetNumberInt();
                    int result1 = GetSum(inum11, inum12);
                    PrintText($"Результат: {result1}");
                    break;

                case "2":
                    int inum21 = GetNumberInt();
                    int inum22 = GetNumberInt();
                    int inum23 = GetNumberInt();
                    int result2 = GetSum(inum21, inum22, inum23);
                    PrintText($"Результат: {result2}");
                    break;

                case "3":
                    int inum31 = GetNumberInt();
                    int inum32 = GetNumberInt();
                    double dnum33 = GetNumberDouble();
                    double result3 = GetSum(inum31, inum32, dnum33);
                    PrintText($"Результат: {result3}");
                    break;

                case "4":
                    double dnum41 = GetNumberDouble();
                    double dnum42 = GetNumberDouble();
                    double result4 = GetSum(dnum41, dnum42);
                    PrintText($"Результат: {result4}");
                    break;

                case "5":
                    string str51 = GetString();
                    string str52 = GetString();
                    string result5 = GetSum(str51, str52);
                    PrintText($"Результат: {result5}");
                    break;

                default:
                    PrintText("Введите число от 1 до 5.");
                    break;
            }
        }

        private static int GetNumberInt()
        {
            while (true)
            {
                PrintText("Введите целую переменную: ");
                string input = ReadText();

                if (string.IsNullOrWhiteSpace(input))
                {
                    PrintText("Требуется целое число");
                    continue;
                }

                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    PrintText("Требуется целое число");
                }
            }
        }

        private static double GetNumberDouble()
        {
            while (true)
            {
                PrintText("Введите дробную переменную с запятой: ");
                string input = ReadText();

                if (string.IsNullOrWhiteSpace(input))
                {
                    PrintText("Требуется дробное число с запятой");
                    continue;
                }

                if (double.TryParse(input, out double result))
                {
                    return result;
                }
                else
                {
                    PrintText("Требуется целое число");
                }
            }
        }

        private static string GetString()
        {
            while (true)
            {
                PrintText("Введите строку: ");
                string input = Read();

                if (string.IsNullOrWhiteSpace(input))
                {
                    PrintText("Требуется непустая строка");
                    continue;
                }
                else
                {
                    return input;
                }
            }
        }

        private static int GetSum(int a, int b)
        {
            return a + b;
        }

        private static int GetSum(int a, int b, int c)
        {
            return a + b + c;
        }

        private static double GetSum(int a, int b, double c)
        {
            return a + b + c;
        }

        private static double GetSum(double a, double b)
        {
            return a + b;
        }

        private static string GetSum(string str1, string str2)
        {
            return str1 + str2;
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
