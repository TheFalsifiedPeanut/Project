using System;
using System.Collections.Generic;
using System.Text;

namespace Collect_Dudes.Utilities
{
    class TextUtils
    {
        public static int GetChoice(string inputMessage, int optionCount, bool clearScreen = false)
        {
            if (clearScreen)
            {
                Console.Clear();
            }
            if (!string.IsNullOrEmpty(inputMessage))
            {
                Console.WriteLine(inputMessage);
                Console.WriteLine("--------------------> :)");

            }
            string inputRaw = Console.ReadLine();
            int inputValue;
            if (int.TryParse(inputRaw, out inputValue))
            {
                if ( inputValue < 0 && inputValue >= optionCount)
                {
                    Console.WriteLine("Error you donkey. The input value was not in range");
                    return GetChoice(inputMessage, optionCount, clearScreen);
                }
            }
            else
            {
                Console.WriteLine("Error you donkey. The input value was not a number. Learn how 2 read");
                return GetChoice(inputMessage, optionCount, clearScreen);
            }
            return inputValue;
        }
    }
}
