namespace Collect_Dudes.Utilities
{
    using ConsoleUtilities.Inputs;
    using System;
    
    /// <summary>
    /// Utilities for text related functionality and styling.
    /// </summary>
    internal static class TextUtils
    {
        #region Fields
        
        /// <summary>
        /// A dashed line divider.
        /// </summary>
        public static string divider => "----------";

        #endregion

        #region Choices Entry

        /// <summary>
        /// Build a choice entry with default styling.
        /// </summary>
        /// <param name="message"> The message to pass to the choice entry, to be displayed. </param>
        /// <returns></returns>
        public static ChoiceEntry BuildChoiceEntry(string message)
        {
            return new ChoiceEntry("[", "]", message);
        }

        #endregion
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputMessage"></param>
        /// <param name="optionCount"></param>
        /// <param name="clearScreen"></param>
        /// <returns></returns>
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
                    Console.WriteLine("Error. The input value was not in range");
                    return GetChoice(inputMessage, optionCount, clearScreen);
                }
            }
            else
            {
                Console.WriteLine("Error. The input value was not a number. Learn how 2 read");
                return GetChoice(inputMessage, optionCount, clearScreen);
            }
            return inputValue;
        }
    }
}
