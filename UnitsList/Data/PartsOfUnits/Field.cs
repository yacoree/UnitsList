﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsList.Data.PartsOfUnits
{
    public class Field
    {
        public Field(int minimum, int maximum, UnitProperty property)
        {
            Minimum = minimum;
            Maximum = maximum;
            Property = property;
        }

        public Field(int minimum, int maximum, int physicalProtection, int healthPoint,
            int manaPool, int physicalAttack, int magicalAttack)
        {
            Minimum = minimum;
            Maximum = maximum;
            Property = new UnitProperty(physicalProtection, healthPoint, manaPool, physicalAttack, magicalAttack);
        }

        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public UnitProperty Property { get; set; }

        public UnitProperty SetPoints(int points)
        {
            if (points >= Minimum)
            {
                if (points <= Maximum) return Property * points;
                else return Property * Maximum;
            }
            return Property * Minimum;
        }

        public UnitProperty AddPoints(int points)
        {
            return Property * points;
        }

        public int SetFieldValue(int newValue)
        {
            if (newValue >= Minimum)
            {
                if (newValue <= Maximum)
                {
                    return newValue;
                }
                return Maximum;
            }
            return Minimum;
        }

        public UnitProperty SetUnitPropertydValue(int oldValue, int newValue)
        {
            if (newValue >= Minimum)
            {
                if (newValue <= Maximum)
                {
                    return AddPoints(newValue);
                }
                return AddPoints(Maximum - oldValue);
            }
            return AddPoints(Minimum - oldValue);
        }
    }
}
