namespace Collect_Dudes.Data.Mental
{
    /// <summary>
    /// The levels of happiness a unit can have.
    /// </summary>
    internal enum Happiness : byte
    {
        /// <summary>
        /// The unit feels extremely at odds with the current state of their contract and most likely wish to leave.
        /// </summary>
        Miserable = 1,
        
        /// <summary>
        /// The unit feels unenthusiastic about the current state of their contract and may wish to leave.
        /// </summary>
        Sad = 2,
        
        /// <summary>
        /// The unit feels indecisive about the current state of their contract and will opt to maintain status quo.
        /// </summary>
        Indifferent = 3,
        
        /// <summary>
        /// The unit feels content about the current state of their contract and may wish to extend.
        /// </summary>
        Happy = 4,
        
        /// <summary>
        /// The unit feels extremely satisfied about the current state of their contract and most likely wish to extend.
        /// </summary>
        Ecstatic = 5
    }
}
