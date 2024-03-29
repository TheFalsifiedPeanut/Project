﻿namespace Collect_Dudes.Data.Units
{
    using General;
    using Mental;
    using World;

    /// <summary>
    /// A unit that represents a character in world.
    /// </summary>
    internal class Unit : IIdentifier, IName, IAge, IStarLevel
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
        /// The star level of the unit.
        /// </summary>
        public int starLevel { get; set; }

        /// <summary>
        /// The birthday of the unit.
        /// </summary>
        public Date birthday { get; set; }

        #endregion

        #region Attributes
        
        /// <summary>
        /// The strength of the unit. Determines base attack damage in melee combat.
        /// </summary>
        public int strength { get; set; }
        
        /// <summary>
        /// The agility of the unit. Determines base attack damage in ranged combat.
        /// </summary>
        public int agility { get; set; }
        
        /// <summary>
        /// The intelligence of the unit. Determines base attack damage in magic combat.
        /// </summary>
        public int intelligence { get; set; }
        
        #endregion

        #region Physical Statistics
        
        /// <summary>
        /// The current health the unit has.
        /// </summary>
        public float currentHealth { get; set; }

        /// <summary>
        /// The maximum health the unit has.
        /// </summary>
        public float maximumHealth { get; set; }

        /// <summary>
        /// The current health regen the unit has.
        /// </summary>
        public float healthRegeneration { get; set; }
        
        /// <summary>
        /// The current mana the unit has. Used for magical attacks
        /// </summary>
        public float currentMana { get; set; }

        /// <summary>
        /// The maximum mana the unit has. Used for magical attacks
        /// </summary>
        public float maximumMana { get; set; }
        
        /// <summary>
        /// The current mana regen the unit has.
        /// </summary>
        public float manaRegeneration { get; set; }
        
        /// <summary>
        /// The current stamina the unit has. Used for physical attacks
        /// </summary>
        public float currentStamina { get; set; }

        /// <summary>
        /// The maximum stamina the unit has. Used for physical attacks
        /// </summary>
        public float maximumStamina { get; set; }
        
        /// <summary>
        /// The current stamina regen the unit has.
        /// </summary>
        public float staminaRegeneration { get; set; }

        /// <summary>
        /// The speed the unit has. This is for calculating the rate of attack.
        /// </summary>
        public int speed { get; set; }
        
        /// <summary>
        /// The physical resistance the unit has. This is the reduction in physical damage without armour.
        /// </summary>
        public float physicalResistance { get; set; }
        
        /// <summary>
        /// The magic resistance the unit has. This is the reduction in magic damage without armour.
        /// </summary>
        public float magicalResistance { get; set; }
        
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
        /// The leadership the unit has. This is for determining the ability to maintain steady the composure of other teammates.
        /// </summary>
        public int leadership { get; set; }
        
        /// <summary>
        /// The teamwork the unit has. This is for determining the ability to increase the chances of victory with more teammates around.
        /// </summary>
        public int teamwork { get; set; }
        
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
        
        #endregion

        #region Employment
        
        /// <summary>
        /// The weekly wage the unit earns. This is paid weekly to a unit for the duration of the contract.
        /// </summary>
        public int wage { get; set; }
        
        /// <summary>
        /// The amount of time remaining on the contract the unit has. At the end of the period the player will be a free agent and leave the team.
        /// </summary>
        public int termRemaining { get; set; }
        
        /// <summary>
        /// The ID of the team this unit belongs to. -1 means no team.
        /// </summary>
        public ushort teamID { get; set; }

        /// <summary>
        /// The ID of the squad this unit belongs to. -1 means no squad and therefore the unit is a free agent.
        /// </summary>
        public ushort squadID { get; set; }

        #endregion

        #endregion

        #region Initialisation

        /// <summary>
        /// The constructor for the Unit.
        /// </summary>
        /// <param name="id"> The ID of the unit. </param>
        /// <param name="name"> The name of the unit. </param>
        /// <param name="birthday"> The birthday of the unit. </param>
        /// <param name="starLevel"> The star level of the unit. </param>
        /// <param name="strength"> The strength of the unit. </param>
        /// <param name="agility"> The agility of the unit. </param>
        /// <param name="intelligence"> The intelligence of the unit. </param>
        /// <param name="maximumHealth"> The maximum health of the unit. </param>
        /// <param name="healthRegeneration"> The health regeneration of the unit. </param>
        /// <param name="maximumMana"> The maximum mana of the unit. </param>
        /// <param name="manaRegeneration"> The mana regeneration of the unit. </param>
        /// <param name="maximumStamina"> The maximum stamina of the unit. </param>
        /// <param name="staminaRegeneration"> The stamina regeneration of the unit. </param>
        /// <param name="speed"> The speed of the unit. </param>
        /// <param name="physicalResistance"> The physical resistance of the unit. </param>
        /// <param name="magicalResistance"> The magical resistance of the unit. </param>
        /// <param name="hitChance"> The hit chance of the unit. </param>
        /// <param name="dodgeChance"> The dodge chance of the unit. </param>
        /// <param name="basePhysicalDamage"> The base physical damage of the unit. </param>
        /// <param name="physicalCriticalChance"> The physical critical chance of the unit. </param>
        /// <param name="leadership"> The leadership of the unit. </param>
        /// <param name="teamwork"> The teamwork of the unit. </param>
        /// <param name="morale"> The morale of the unit. </param>
        /// <param name="happiness"> The happiness of the unit. </param>
        public Unit(ushort id, string name, Date birthday, int starLevel, int strength, int agility, int intelligence, float maximumHealth, float healthRegeneration, float maximumMana, float manaRegeneration, float maximumStamina, float staminaRegeneration, int speed, float physicalResistance, float magicalResistance, float hitChance, float dodgeChance, float basePhysicalDamage, float physicalCriticalChance, int leadership, int teamwork, Morale morale, Happiness happiness)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.starLevel = starLevel;
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
            this.maximumHealth = currentHealth = maximumHealth;
            this.healthRegeneration = manaRegeneration;
            this.maximumMana = currentMana = maximumMana;
            this.manaRegeneration = manaRegeneration;
            this.maximumStamina = currentStamina = maximumStamina;
            this.staminaRegeneration = staminaRegeneration;
            this.speed = speed;
            this.physicalResistance = physicalResistance;
            this.magicalResistance = magicalResistance;
            this.hitChance = hitChance;
            this.dodgeChance = dodgeChance;
            this.basePhysicalDamage = basePhysicalDamage;
            this.physicalCriticalChance = physicalCriticalChance;
            this.leadership = leadership;
            this.teamwork = teamwork;
            this.morale = morale;
            this.happiness = happiness;
        }

        #endregion
    }
}