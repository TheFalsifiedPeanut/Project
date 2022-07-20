namespace Collect_Dudes.Data.Mental
{
    /// <summary>
    /// The levels of morale a unit can have.
    /// </summary>
    internal enum Morale
    {
        /// <summary>
        /// The unit feels extremely dubious entering battle and may perform much worse than expected.
        /// </summary>
        Shattered,
        
        /// <summary>
        /// The unit feels unsettled entering battle and may perform worse than expected.
        /// </summary>
        Negative,
        
        /// <summary>
        /// The unit feels no strong emotions entering battle and will perform average.
        /// </summary>
        Neutral,
        
        /// <summary>
        /// The unit feels excited entering battle and may perform better than expected.
        /// </summary>
        Positive,
        
        /// <summary>
        /// The unit feels extremely emboldened entering battle and may perform much better than expected.
        /// </summary>
        Confident
    }
     
}
