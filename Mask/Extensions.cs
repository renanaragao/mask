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
            var masks = mask.ToArray();
            var chars = new Queue<char>(value.ToArray());
            char[] tokens = new char[] { 'A', 'S', '0', '9' };
            var newValue = new StringBuilder();

            foreach (var item in masks)
            {
                if (tokens.Contains(item))
                {
                    newValue.Append(chars.Dequeue());

                    continue;
                }

                newValue.Append(item);
            }

            return newValue.ToString();
        }
    }
}
