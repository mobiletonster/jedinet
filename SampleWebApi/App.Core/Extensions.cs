using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core
{
    public static class Extensions
    {
        public static Dictionary<int, string> ToDictionary(this Enum @enum)
        {
            var type = @enum.GetType();
            return Enum.GetValues(type).Cast<int>().ToDictionary(e => e, e => Enum.GetName(type, e));
        }
    }
}
