using Collect_Dudes.Data.Units;
using Collect_Dudes.Data.Units.Enums;
using Collect_Dudes.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.World.Generators
{
    internal static class UnitGenerator
    {
        public static Unit GenerateUnit(ushort id)
        {

            Random random = new Random();
            // Random.Next is exclusive for the upper bounds.
            byte starIndex = (byte)(random.Next(1, 26));
            StarLevel starLevel = StarLevel.FIVE;
            if (starIndex <= 5)
            {
                starLevel = StarLevel.ONE;
            }
            else if (starIndex <= 12)
            {
                starLevel = StarLevel.TWO;
            }
            else if (starIndex <= 20)
            {
                starLevel = StarLevel.THREE;
            }
            else if (starIndex <= 23)
            {
                starLevel = StarLevel.FOUR;
            }
            return GenerateUnit(id, starLevel);
        }
        public static Unit GenerateUnit(ushort id, StarLevel starLevel)
        {
            Random random = new Random();
            int baseAttributePoints = 0;
            int capacityAttributePoints = 0;
            switch (starLevel)
            {
                case StarLevel.ONE:
                    baseAttributePoints = InternalSettings.baseAttributePoints;
                    capacityAttributePoints = InternalSettings.oneStarAttributePointsMaximum;
                    break;
                case StarLevel.TWO:
                    baseAttributePoints = InternalSettings.oneStarAttributePointsMaximum;
                    capacityAttributePoints = InternalSettings.twoStarAttributePointsMaximum;
                    break;
                case StarLevel.THREE:
                    baseAttributePoints = InternalSettings.twoStarAttributePointsMaximum;
                    capacityAttributePoints = InternalSettings.threeStarAttributePointsMaximum;
                    break;
                case StarLevel.FOUR:
                    baseAttributePoints = InternalSettings.threeStarAttributePointsMaximum;
                    capacityAttributePoints = InternalSettings.fourStarAttributePointsMaximum;
                    break;
                case StarLevel.FIVE:
                    baseAttributePoints = InternalSettings.fourStarAttributePointsMaximum;
                    capacityAttributePoints = InternalSettings.fiveStarAttributePointsMaximum;
                    break;

            }
            int attributePoints = random.Next(baseAttributePoints, capacityAttributePoints) - (3 * InternalSettings.baseAttributeValue);
            byte strength = InternalSettings.baseAttributeValue;
            byte agility = InternalSettings.baseAttributeValue;
            byte intelligence = InternalSettings.baseAttributeValue;
            while (attributePoints > 0)
            {
                attributePoints--;
                int attributeIndex = random.Next(0, 3);
                if (attributeIndex == 0)
                {
                    if (strength + 1 <= InternalSettings.capacityAttributeValue)
                    {
                        strength++;
                    }
                    else
                    {
                        attributePoints++;
                    }
                }
                else if (attributeIndex == 1)
                {
                    if (agility + 1 <= InternalSettings.capacityAttributeValue)
                    {
                        agility++;
                    }
                    else
                    {
                        attributePoints++;
                    }
                }
                else
                {
                    if (intelligence + 1 <= InternalSettings.capacityAttributeValue)
                    {
                        intelligence++;
                    }
                    else
                    {
                        attributePoints++;
                    }
                }
            }
            float health = strength * InternalSettings.healthPerStrength;
            float healthRegen = strength * InternalSettings.healthRegenPerStrength;
            float mana = intelligence * InternalSettings.manaPerIntelligence;
            float manaRegen = intelligence * InternalSettings.manaRegenPerIntelligence;
            float stamina = agility * InternalSettings.staminaPerAgility;
            float staminaRegen = agility * InternalSettings.staminaRegenPerAgility;
            byte speed = (byte)(agility * InternalSettings.speedPerAgility);
            float physicalResistance = strength * InternalSettings.physicalResitancePerStrength;
            float magicResistance = intelligence * InternalSettings.magicResistancePerIntelligence;
            float hitChance = agility * InternalSettings.hitChancePerAgility;
            float dodgeChance = agility * InternalSettings.dodgeChancePerAgility;
            float basePhysicalDamage = strength * InternalSettings.basePhysicalDamagePerStrength;
            float physicalCritChance = agility * InternalSettings.physicalCritChancePerAgility;
            byte leadership = (byte)(random.Next(1, 21));
            byte teamwork = (byte)(random.Next(1, 21));

            return new Unit(id, "UNIT " + id, new Date(1, 1, 1), (byte)starLevel, strength, agility, intelligence, health, healthRegen, mana, manaRegen, stamina, staminaRegen, speed, physicalResistance, magicResistance, hitChance, dodgeChance, basePhysicalDamage, physicalCritChance, leadership, teamwork, Data.Mental.Morale.Neutral, Data.Mental.Happiness.Indifferent);
        }
    }
}
