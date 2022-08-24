namespace Collect_Dudes.Data.Units.Enums
{
    /// <summary>
    /// The levels of star ratings used by objects.
    /// </summary>
    internal enum StarLevel
    {
        /// <summary>
        /// One star is the bottom level and any object possessing it are considered to be of the lowest quality.
        /// </summary>
        ONE = 1,
        
        /// <summary>
        /// Two star is the lower level and any object possessing it are considered to be of lower quality.
        /// </summary>
        TWO = 2,
        
        /// <summary>
        /// Two star is the middle level and any object possessing it are considered to be of standard quality.
        /// </summary>
        THREE = 3,
        
        /// <summary>
        /// Two star is the higher level and any object possessing it are considered to be of higher quality.
        /// </summary>
        FOUR = 4,
        
        /// <summary>
        /// Two star is the top level and any object possessing it are considered to be of the highest quality.
        /// </summary>
        FIVE = 5
    }
}