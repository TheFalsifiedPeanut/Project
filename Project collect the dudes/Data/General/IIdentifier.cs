namespace Collect_Dudes.Data.General
{
    /// <summary>
    /// An interface for interacting with IDs.
    /// </summary>
    internal interface IIdentifier
    {
        /// <summary>
        /// The ID of the object.
        /// </summary>
        ushort id { get; set; }
    }
}
