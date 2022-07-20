namespace Collect_Dudes.Data.Groups
{
    using General;
    using System.Collections.Generic;
    using Units;

    /// <summary>
    /// A team represents a group of units that battle together.
    /// </summary>
    internal class Team : IIdentifier, IName, IStarLevel
    {
        #region Properties

        /// <summary>
        /// The ID of the team.
        /// </summary>
        public ushort id { get; set; }

        /// <summary>
        /// The name of the team.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The star level of the team.
        /// </summary>
        public byte starLevel { get; set; }
        
        /// <summary>
        /// The ID of the squad this team belongs to.
        /// </summary>
        public ushort squadID { get; set; }
        
        /// <summary>
        /// A hash set of all the IDs of units in the team.
        /// All IDs are unique and a hash set guarantees to not have duplicates of a unit.
        /// </summary>
        HashSet<ushort> units { get; set; }
        
        #endregion

        #region Initialisation
        
        /// <summary>
        /// A constructor for the Team.
        /// </summary>
        /// <param name="id"> The ID of the team. </param>
        /// <param name="name"> The name of the team. </param>
        /// <param name="starLevel"> The star level of the team. </param>
        /// <param name="squadID"> The ID of the squad this team belongs to. </param>
        public Team(ushort id, string name, ushort squadID, byte starLevel, HashSet<ushort> units)
        {
            this.id = id;
            this.name = name;
            this.starLevel = starLevel;
            this.squadID = squadID;
            this.units = units;
        }

        #endregion

        #region Units

        /// <summary>
        /// Attempt to add the specified unit to the team.
        /// </summary>
        /// <param name="unit"> The unit to add. </param>
        /// <returns> Returns whether the unit was added. </returns>
        public bool AddUnit(Unit unit)
        {
            bool added = units.Add(unit.id);

            if (added)
            {
                unit.teamID = id;
            }

            return added;
        }

        /// <summary>
        /// Remove the unit with the specified ID from the team.
        /// </summary>
        /// <param name="id"> The ID of the unit to remove. </param>
        /// <returns> Returns whether the unit was removed. </returns>
        public bool RemoveUnitByID(ushort id)
        {
            return units.Remove(id);
        }

        /// <summary>
        /// Remove the specified unit from the team.
        /// </summary>
        /// <param name="unit"> The unit to remove. </param>
        /// <returns> Returns whether the unit was removed. </returns>
        public bool RemoveUnitByValue(Unit unit)
        {
            return units.Remove(unit.id);
        }

        #endregion
    }
}
