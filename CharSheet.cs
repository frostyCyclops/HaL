using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaL
{
    class CharSheet
    {
        public string Name;
        public string Ancestry;
        public string Size;
        public int Level;
        public int Resilience;
        public int Speed;
        public int Dr;
        public int CharTier;

        public int[] CharAttributes = { 0, 0, 0, 0, 0, 0 };
        public int[] CharTrainingBonus = { 0, 0, 0, 0, 0, 0 };
        public List<int> CharAbilities;
        public List<int> CharWeapons;
        public List<int> CharArmor;
        public List<(int, int)> CharItems;

        public CharSheet(string name, string ancestry, int level)
        {
            Name = name;
            Ancestry = ancestry;
            Level = level;
            CalculateCharTier();
        }

        public void CalculateCharTier()
        {
            var calculation = Convert.ToInt32(Math.Floor(Level / 5.0) + 1);
            CharTier = calculation > 4 ? 4 : calculation;
        }

        public int Formula(int a, int circumstance=0, int status=0) => GetAttributeScore(a) + GetTrainingBonus(a) + circumstance + status + Tier.TryGetBonus(CharTier);

        public int GetAttributeScore(int a) => a >= 0 && a <= CharAttributes.Length ? CharAttributes[a] : -1;

        public void SetAttributeScore(int a, int newValue)
        {
            if (a >= 0 && a <= CharAttributes.Length) CharAttributes[a] = newValue;
        }

        public int GetTrainingBonus(int a) => a >= 0 && a <= CharTrainingBonus.Length ? CharTrainingBonus[a] : -1;

        public void AddToTrainingBonus(int a, int addedValue=1)
        {
            if (a >= 0 && a <= CharTrainingBonus.Length) CharTrainingBonus[a] += addedValue;
        }

        public void ReCalculateTraining()
        {
            CharTrainingBonus = new[] { 0, 0, 0, 0, 0, 0 };

            foreach (var ability in CharAbilities)
            {
                var (a1, a2, _) = AbilitiesList.Data[ability];
                AddToTrainingBonus(a1);
                AddToTrainingBonus(a2);
            }
        }
    }
}
