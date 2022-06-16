namespace Collect_Dudes.Data.Units
{
    using General;
    using Mental;
    using World;

    /// <summary>
    /// A unit that represents a character in world.
    /// </summary>
    internal class Unit : IIdentifier, IName, IAge
    {
        #region Properties

        #region General
        
        /// <summary>
        /// The ID of the unit.
        /// </summary>
        public ushort id { get; set; }
        
        /// <summary>
        /// The name of the unit.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The birthday of the unit.
        /// </summary>
        public Date birthday { get; set; }

        #endregion

        #region Attributes
        
        /// <summary>
        /// The strength of the unit. Determines base attack damage in melee combat.
        /// </summary>
        public byte strength { get; set; }
        
        /// <summary>
        /// The agility of the unit. Determines base attack damage in ranged combat.
        /// </summary>
        public byte agility { get; set; }
        
        /// <summary>
        /// The willPower of the unit. Determines base attack damage in magic combat.
        /// </summary>
        public byte intelligence { get; set; }
        
        #endregion

        #region Statistics
        
        /// <summary>
        /// The current health the unit has.
        /// </summary>
        public float currentHealth { get; set; }

        /// <summary>
        /// The maximum health the unit has.
        /// </summary>
        public float maximumHealth { get; set; }
        
        /// <summary>
        /// The current mana the unit has. Used for magical attacks
        /// </summary>
        public float currentMana { get; set; }

        /// <summary>
        /// The maximum mana the unit has. Used for magical attacks
        /// </summary>
        public float maximumMana { get; set; }
        
        /// <summary>
        /// The current stamina the unit has. Used for physical attacks
        /// </summary>
        public float currentStamina { get; set; }

        /// <summary>
        /// The maximum stamina the unit has. Used for physical attacks
        /// </summary>
        public float maximumStamina { get; set; }

        /// <summary>
        /// The speed the unit has. This is for calculating the rate of attack.
        /// </summary>
        public byte speed { get; set; }
        
        /// <summary>
        /// The physical resistance the unit has. This is the reduction in physical damage without armour.
        /// </summary>
        public float physicalResistance { get; set; }
        
        /// <summary>
        /// The magic resistance the unit has. This is the reduction in magic damage without armour.
        /// </summary>
        public float magicResistance { get; set; }
        
        /// <summary>
        /// The hit chance the unit has. This is for calculating the chance of a successful hit.
        /// </summary>
        public float hitChance { get; set; }
        
        /// <summary>
        /// The dodge chance the unit has. This is for calculating the chance of a successful dodge.
        /// </summary>
        public float dodgeChance { get; set; }
        
        /// <summary>
        /// The base physical damage the unit has. This is the damage the unit does without a weapon.
        /// </summary>
        public float basePhysicalDamage { get; set; }
        
        /// <summary>
        /// The physical critical chance the unit has. This is the chance the unit will land a critical attack.
        /// </summary>
        public float physicalCriticalChance { get; set; }
        
        #endregion

        #region Mental Statistics
        
        /// <summary>
        /// The morale the unit has. This is the confidence the unit has going into a fight.
        /// </summary>
        public Morale morale { get; set; }
        
        /// <summary>
        /// The happiness the unit has. This is the satisfaction the unit has with their employment.
        /// </summary>
        public Happiness happiness { get; set; }
        
        /// <summary>
        /// The mental traits the unit has. A set of flags for unique traits a unit might have.
        /// </summary>
        public MentalTraits mentalTraits { get; set; }
        
        /// <summary>
        /// The leadership the unit has. This is for determining the ability to maintain steady the composure of other teammates.
        /// </summary>
        public byte leadership { get; set; }
        
        /// <summary>
        /// The teamwork the unit has. This is for determining the ability to increase the chances of victory with more teammates around.
        /// </summary>
        public byte teamwork { get; set; }
        
        #endregion

        #region Employment
        
        /// <summary>
        /// The weekly wage the unit earns. This is paid weekly to a unit for the duration of the contract.
        /// </summary>
        public int wage { get; set; }
        
        /// <summary>
        /// The ID of the team this unit belongs to. -1 means no team.
        /// </summary>
        public ushort teamID { get; set; }

        /// <summary>
        /// The ID of the squad this unit belongs to. -1 means no squad and therefore the unit is a free agent.
        /// </summary>
        public ushort squadID { get; set; }
        
        /// <summary>
        /// The amount of time remaining on the contract the unit has. At the end of the period the player will be a free agent and leave the team.
        /// </summary>
        public int termRemaining { get; set; }

        #endregion

        #endregion

        #region Initialisation
        
        public Unit(ushort id, string name, Date birthday, byte strength, byte agility, byte intelligence, Morale morale, Happiness happiness)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
            this.morale = morale;
            this.happiness = happiness;
        }

        #endregion
    }
}
