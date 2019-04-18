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
            string first = source.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length==0? String.Empty: source.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
            foreach (var valueToCheck in strings)
            {
                if (first.StartsWith(valueToCheck))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool EndWithAny(this string source, IEnumerable<string> strings)
        {
            foreach (var valueToCheck in strings)
            {
                if (source.EndsWith(valueToCheck))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
