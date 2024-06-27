namespace Homework3
{
    internal class Program
    {
        private static double x;
        private static double y;

        static void Main(string[] args)
        {
            GetInputNumbers();
        }

        private static void GetInputNumbers()
        {
            x = DataUtility.GetDouble("X");
            Console.WriteLine();
            y = DataUtility.GetDouble("Y");

            Console.WriteLine();
            Console.WriteLine("Ваши числа:");
            Console.WriteLine($"X = {x}\nY = {y}");
        }
    }
}
