using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRef
{
    public static class Extensions
    {
        public static bool StartsWithAny(this string source, IEnumerable<string> strings)
        {
            foreach (var valueToCheck in strings)
            {
                if (source.StartsWith(valueToCheck))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
