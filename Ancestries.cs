using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaL
{
    class Ancestries
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
