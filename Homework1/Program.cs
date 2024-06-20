namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintUserData("Данные некорректны... Попробуйте ещё раз!");
        }

        private static void PrintUserData(string nullValueMessage)
        { 

            string firstName = DataUtility.GetStrData("Введите Ваше имя", nullValueMessage);
            Console.WriteLine();
            string lastName = DataUtility.GetStrData("Введите Вашу фамилию", nullValueMessage);

            Console.WriteLine();
            Console.WriteLine($"Здравствуйте, {firstName} {lastName}!");
        }
    }
}
