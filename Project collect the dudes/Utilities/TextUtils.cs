namespace Collect_Dudes.Utilities
{
    using ConsoleUtilities.Inputs;
    using System.Text;

    /// <summary>
    /// Utilities for text related functionality and styling.
    /// </summary>
    internal static class TextUtils
    {
        #region Properties
        
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

        #region Formatting
        
        /// <summary>
        /// Calculates the spacing before or after values in a column.
        /// </summary>
        /// <param name="columnSize"> The size of the column. </param>
        /// <param name="dataSize"> The size of the data entry. </param>
        /// <returns> Returns spaces, that added to the data entry, correctly pads the column. </returns>
        public static string Spacing(int columnSize, int dataSize)
        {
            StringBuilder spaceString = new StringBuilder();
            
            for (int i = 0; i < columnSize - dataSize; i++)
            {
                spaceString.Append(" ");
            }
            
            return spaceString.ToString();
        }

        #endregion
    }
}
