namespace Collect_Dudes.Data.Player
{
    using General;
    using World;

    /// <summary>
    /// A player that represents a the user.
    /// </summary>
    internal class Player : IName, IAge
    {
        
        #region Properties
        
        /// <summary>
        /// The name of the player.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The birthday of the player.
        /// </summary>
        public Date birthday { get; set; }

        public ushort playerSquadID { get; set; }

        #endregion

        /// <summary>
        /// A constructor for the player.
        /// </summary>
        /// <param name="name"> The name of the player. </param>
        /// <param name="birthday"> The birthday of the player. </param>
        public Player(string name, Date birthday, ushort playerSquadID)
        {
            this.name = name;
            this.birthday = birthday;
            this.playerSquadID = playerSquadID;
        }

    }
}
