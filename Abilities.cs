using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaL
{
    class AbilitiesList
    {
        public static readonly Dictionary<int, (int, int, string)> Data = new Dictionary<int, (int, int, string)>()
        {
            {1, (0, 1, "placeHolder1")},
            {1, (2, 2, "placeHolder2")}
        };

    }
}
