namespace Collect_Dudes.Data.Groups
{
    using General;

    /// <summary>
    /// An agency represents a group of units that act as one organisation.
    /// </summary>
    internal class Agency : IIdentifier, IName, IStarLevel
    {
        #region Properties
        
        /// <summary>
        /// The ID of the agency.
        /// </summary>
        public ushort id { get; set; }
        
        /// <summary>
        /// The name of the agency.
        /// </summary>
        public string name { get; set; }
        
        /// <summary>
        /// The star level of the agency.
        /// </summary>
        public byte starLevel { get; set; }

        /// <summary>
        /// The squad of units belonging to the agency.
        /// </summary>
        public Squad squad { get; set; }
        
        /// <summary>
        /// The amount of money the agency currently has.
        /// </summary>
        public int money { get; set; }

        #endregion

        #region Initialisation
        
        /// <summary>
        /// A constructor for the Agency.
        /// </summary>
        /// <param name="id"> The ID of the agency. </param>
        /// <param name="name"> The name of the agency. </param>
        /// <param name="starLevel"> The star level of the agency. </param>
        /// <param name="squad"> The squad of units belonging to the agency. </param>
        /// <param name="money"> The amount of money the agency currently has. </param>
        public Agency(ushort id, string name, byte starLevel, Squad squad, int money)
        {
            this.id = id;
            this.name = name;
            this.squad = squad;
            this.money = money;
            this.starLevel = starLevel;
        }

        #endregion
    }
}
