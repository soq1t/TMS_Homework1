using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public static class DataUtility
    {
        /// <summary>
        /// Позволяет получить данные от пользователя.
        /// </summary>
        /// <param name="initMessage">Сообщение для пользователя перед вводом информации.</param>
        /// <param name="nullValueMessage">Сообщение, выводимое в случае, если пользователь ввёл пустую строку. Значение <c>null</c> по умолчанию позволяет пропустить эту проверку проверку.</param>
        /// <returns>
        /// Возвращает введённое пользователем значение (либо <c>null</c> в случае, если такой вариант допускается).
        /// </returns>
        public static string? GetStrData(string initMessage, string? nullValueMessage = null)
        {
            string? result;
            // Инициализируем значением false, чтобы изначально при вызове метода не выводилось null-сообщение
            bool isNullValue = false;

            Console.WriteLine(initMessage);
            do
            {
                // Выводит заданное null-сообщение в случае, если введённая строка была пустой
                if (isNullValue)
                    Console.WriteLine(nullValueMessage);

                result = GetClearStr(Console.ReadLine());

                // Если строка пустая, и при этом в параметрах передано null-сообщение, то меняет значение isNullValue на true. Иначе - false
                // В случае, если null-сообщение не указано, то в любом случае присваивается false
                isNullValue = (result == null && nullValueMessage != null);                    


            } while (isNullValue);

            return result;
        }

        /// <summary>
        /// Проверяет строку на <c>null</c>, убирает лишние пробелы
        /// </summary>
        /// <param name="value">Входящая строка</param>
        /// <returns>Возвращает строку (либо <c>null</c>, если строка пустая)</returns>
        private static string? GetClearStr(string? value)
        {
            if (value == null)
                return null;

            value = value.Trim();

            if (string.IsNullOrWhiteSpace(value))
                return null;
            else
                return value;
        }
    }
}
