namespace ConsoleApp2
{
    internal class Program
    {
        private static int sum;

        static void Main(string[] args)
        {
            int a = GetNumber();
            int b = GetNumber();
            GetSum(a, b);
            Console.WriteLine(sum);
        }
        private static int GetNumber()
        {
            Console.Write("Введите переменную: ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        private static int GetSum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        
        
    }
}