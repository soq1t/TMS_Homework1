using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public static class DataUtility
    {
        public static string? GetStrData(string initMessage, string? nullValueMessage = null)
        {
            string? result;
            bool isNullValue = false;

            Console.WriteLine(initMessage);
            do
            {
                if (isNullValue)
                    Console.WriteLine(nullValueMessage);

                result = GetClearStr(Console.ReadLine());

                isNullValue = result == null && nullValueMessage != null;                    


            } while (isNullValue);

            return result;
        }


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
