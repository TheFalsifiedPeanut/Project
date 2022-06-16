namespace Collect_Dudes.Data.General
{
    using World;

    /// <summary>
    /// An interface for interacting with age.
    /// </summary>
    internal interface IAge
    {
        /// <summary>
        /// The birthday of the object.
        /// </summary>
        Date birthday { get; set; }
        
        /// <summary>
        /// The age of the object.
        /// </summary>
        ushort age => Time.GetYearsSince(birthday);
    }
}
