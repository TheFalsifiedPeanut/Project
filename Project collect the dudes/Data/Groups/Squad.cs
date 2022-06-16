﻿namespace Collect_Dudes.Data.Groups
{
    using General;
    using System.Collections.Generic;
    using System.Linq;
    using Units;

    /// <summary>
    /// A squad represents a group of units belonging to an agency.
    /// </summary>
    internal class Squad : IIdentifier
    {
        #region Properties

        /// <summary>
        /// The ID of the squad.
        /// </summary>
        public ushort id { get; set; }
        
        /// <summary>
        /// A hash set of all the IDs of units in the team.
        /// All IDs are unique and a hash set guarantees to not have duplicates of a unit.
        /// </summary>
        HashSet<ushort> units { get; set; }
        
        /// <summary>
        /// A hash set of all the teams in the squad.
        /// </summary>
        HashSet<Team> teams { get; set; }

        #endregion

        #region Initialisation

        /// <summary>
        /// A constructor for the Squad.
        /// </summary>
        public Squad()
        {
            units = new HashSet<ushort>();
            teams = new HashSet<Team>();
        }

        #endregion

        #region Units

        /// <summary>
        /// Attempt to add the specified unit to the squad.
        /// </summary>
        /// <param name="unit"> The unit to add. </param>
        /// <returns> Returns whether the unit was added. </returns>
        public bool AddUnit(Unit unit)
        {
            bool added = units.Add(unit.id);

            if (added)
            {
                unit.squadID = id;
            }

            return added;
        }

        /// <summary>
        /// Remove the unit with the specified ID from the squad.
        /// </summary>
        /// <param name="id"> The ID of the unit to remove. </param>
        /// <returns> Returns whether the unit was removed. </returns>
        public bool RemoveUnit(ushort id)
        {
            return units.Remove(id);
        }

        /// <summary>
        /// Remove the specified unit from the squad.
        /// </summary>
        /// <param name="unit"> The unit to remove. </param>
        /// <returns> Returns whether the unit was removed. </returns>
        public bool RemoveUnit(Unit unit)
        {
            return units.Remove(unit.id);
        }

        #endregion

        #region Teams

        /// <summary>
        /// Creates a new team with the specified ID and name.
        /// </summary>
        /// <param name="id"> The ID of the team. </param>
        /// <param name="name"> The name of the team. </param>
        /// <returns> Returns whether the team was created. </returns>
        public bool CreateTeam(ushort id, string name)
        {
            // Determine if there is a team with the ID already in the squad.
            if (teams.Where(team => team.id == id).ToArray().Length > 0)
            {
                return false;
            }
            
            return teams.Add(new Team(id, name, id));
        }

        /// <summary>
        /// Delete the team matching the specified ID.
        /// </summary>
        /// <param name="id"> The ID of the team to delete. </param>
        /// <returns> Returns the number of teams that were deleted. </returns>
        public ushort DeleteTeam(ushort id)
        {
            return (ushort)teams.RemoveWhere(team => team.id == id);
        }

        /// <summary>
        /// Deletes all teams matching the specified name.
        /// </summary>
        /// <param name="name"> The name of the teams to delete. </param>
        /// <returns> Returns the number of teams that were deleted. </returns>
        public ushort DeleteTeam(string name)
        {
            return (ushort)teams.RemoveWhere(team => team.name == name);
        }

        /// <summary>
        /// Delete the specified team.
        /// </summary>
        /// <param name="team"> The team to delete. </param>
        /// <returns> Returns whether the team was deleted. </returns>
        public bool DeleteTeam(Team team)
        {
            return teams.Remove(team);
        }

        #endregion
    }
}
