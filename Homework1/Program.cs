namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintUserData("Данные некорректны... Попробуйте ещё раз!");
        }
        /// <summary>
        /// Получает имя и фамилию пользователя и выводит их на консоль
        /// </summary>
        /// <param name="nullValueMessage">Сообщение об ошибке на случай, если пользователь ввёл пустую строку</param>
        private static void PrintUserData(string? nullValueMessage = null)
        { 

            string? firstName = DataUtility.GetStrData("Введите Ваше имя", nullValueMessage);
            Console.WriteLine();
            string? lastName = DataUtility.GetStrData("Введите Вашу фамилию", nullValueMessage);

            Console.WriteLine();
            Console.WriteLine($"Здравствуйте, {firstName} {lastName}!");
            Console.ReadKey();
        }
    }
}
