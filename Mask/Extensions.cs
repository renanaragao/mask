using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mask
{
    public static class Extensions
    {
        public static string ToMasked(this string value, string mask)
        {
            if (string.IsNullOrWhiteSpace(mask))
                return value;

            var masks = mask.ToArray();
            var chars = value.GetEnumerator();
            char[] tokens = new char[] { 'A', 'S', '0', '9' };
            var newValue = new StringBuilder();

            foreach (var item in masks)
            {
                if (tokens.Contains(item))
                {
                    if (chars.MoveNext())
                    {
                        newValue.Append(chars.Current);
                    }
                    continue;
                }

                newValue.Append(item);
            }

            return newValue.ToString();
        }
    }
}
