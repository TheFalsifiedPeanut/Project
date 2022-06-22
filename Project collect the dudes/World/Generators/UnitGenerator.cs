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
        public static Unit GenerateUnit()
        {

            Random random = new Random();
            // Random.Next is exclusive for the upper bounds.
            int starLevel = random.Next(1, 6);
            int baseAttributePoints = 0;
            int capacityAttributePoints = 0;
            switch ((StarLevel)starLevel)
            {
                case StarLevel.oneStar:
                    baseAttributePoints = InternalSettings.baseAttributePoints;
                    capacityAttributePoints = InternalSettings.oneStarAttributePointsMaximum;
                    break;
                case StarLevel.twoStar:
                    baseAttributePoints = InternalSettings.oneStarAttributePointsMaximum;
                    capacityAttributePoints = InternalSettings.twoStarAttributePointsMaximum;
                    break;
                case StarLevel.threeStar:
                    baseAttributePoints = InternalSettings.twoStarAttributePointsMaximum;
                    capacityAttributePoints = InternalSettings.threeStarAttributePointsMaximum;
                    break;
                case StarLevel.fourStar:
                    baseAttributePoints = InternalSettings.threeStarAttributePointsMaximum;
                    capacityAttributePoints = InternalSettings.fourStarAttributePointsMaximum;
                    break;
                case StarLevel.fiveStar:
                    baseAttributePoints = InternalSettings.fourStarAttributePointsMaximum;
                    capacityAttributePoints = InternalSettings.fiveStarAttributePointsMaximum;
                    break;

            }
            int attributePoints = random.Next(baseAttributePoints, capacityAttributePoints) - (3 * InternalSettings.baseAttributeValue);
            int strength = InternalSettings.baseAttributeValue;
            int agility = InternalSettings.baseAttributeValue;
            int intelligence = InternalSettings.baseAttributeValue;
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
                    if (agility + 1 <= InternalSettings.capacityAttributeValue)
                    {
                        agility++;
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
            float speed = agility * InternalSettings.speedPerAgility;
            float physicalResistance = strength * InternalSettings.physicalResitancePerStrength;
            float magicResistance = intelligence * InternalSettings.magicResistancePerIntelligence;
            float hitChance = agility * InternalSettings.hitChancePerAgility;
            float dodgeChance = agility * InternalSettings.dodgeChancePerAgility;
            float basePhysicalDamage = strength * InternalSettings.basePhysicalDamagePerStrength;
            float physicalCritChance = agility * InternalSettings.physicalCritChancePerAgility;
        }
    }
}
