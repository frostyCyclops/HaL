using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaL
{
    public class Tier
    {
        public static int TryGetSave(int key) => !Bonus.TryGetValue(key, out var value) ? Save.First().Value : value;
        public static Dictionary<int, int> Save = new Dictionary<int, int>()
        {
            {1, 0},
            {2, 6},
            {3, 12},
            {4, 18}
        };

        public static int TryGetMinDr(int key) => !Bonus.TryGetValue(key, out var value) ? MinDr.First().Value : value;
        public static Dictionary<int, int> MinDr = new Dictionary<int, int>()
        {
            {1, 10},
            {2, 16},
            {3, 22},
            {4, 28}
        };

        public static int TryGetBonus(int key) => !Bonus.TryGetValue(key, out var value) ? Bonus.First().Value : value;
        public static Dictionary<int, int> Bonus = new Dictionary<int, int>()
        {
            {1, 0},
            {2, 6},
            {3, 12},
            {4, 18}
        };

    }

    public class Training
    {
        public static Dictionary<int, string> Names = new Dictionary<int, string>()
        {
            {0, "Untrained"},
            {1, "Trained"},
            {5, "Expert"},
            {15, "Master"},
            {21, "Legendary"}
        };

        public static Dictionary<int, int> Bonus = new Dictionary<int, int>()
        {
            {0, 0},
            {1, 2},
            {5, 4},
            {15, 6},
            {21, 8}
        };
    }

    public class Attribute
    {
        public const int Strength = 0;
        public const int Agility = 1;
        public const int Fortitude = 2;
        public const int Intuition = 3;
        public const int Abstraction = 4;
        public const int Charisma = 5;

        public static string TryGetNames(int key) => !Names.TryGetValue(key, out var value) ? "UNKNOWN" : value;

        public static readonly Dictionary<int, string> Names = new Dictionary<int, string>()
        {
            {Strength, "Strength"},
            {Agility,"Agility"},
            {Fortitude,"Fortitude"},
            {Intuition,"Intuition"},
            {Abstraction,"Abstraction"},
            {Charisma,"Charisma"},
        };
    }
    
}
