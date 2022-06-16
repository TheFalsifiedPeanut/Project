namespace Collect_Dudes.Utilities
{
    using ConsoleUtilities.Colours;
    using Data.General;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Utilities for data related functionality.
    /// </summary>
    internal static class DataUtilities
    {
        #region IDs

        /// <summary>
        /// Finds the first free ID, if one is available.
        /// </summary>
        /// <param name="identifierObjects"> The list of all objects of this type with IDs. </param>
        /// <returns> Returns the first free ID, if one is available. </returns>
        public static ushort FindFirstFreeID(IEnumerable<IIdentifier> identifierObjects)
        {
            IEnumerable<IIdentifier> identifiers = identifierObjects as IIdentifier[] ?? identifierObjects.ToArray();
            
            for (ushort i = ushort.MinValue; i < ushort.MaxValue; i++)
            {
                if (identifiers.Where(identifierObject => identifierObject.id == i).ToArray().Length is 0)
                {
                    return i;
                }
            }

            ColourUtilities.Warning($"There are no free IDs. Returning the max value of ushort {ushort.MaxValue}.");
            
            return ushort.MaxValue;
        }

        #endregion
    }
}