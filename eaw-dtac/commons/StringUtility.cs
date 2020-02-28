using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using eaw.dtac.Annotations;

namespace eaw.dtac.commons
{
    internal static class StringUtility
    {
        [NotNull]
        internal static List<string> ParseSeparatedStringToList(string s, char separator = ',')
        {
            List<string> list = new List<string>();
            if (IsNullEmptyOrWhiteSpace(s))
            {
                return list;
            }
            Debug.Assert(s != null, nameof(s) + " != null");
            string[] split = s.Split(separator);
            list.AddRange(from str in split where !IsNullEmptyOrWhiteSpace(str) select str.Trim());
            return list;
        }
        internal static bool IsNullEmptyOrWhiteSpace(string value, int offset = 0)
        {
            if (null == value)
            {
                return true;
            }

            for(int i = offset; i < value.Length; ++i)
            {
                if (!char.IsWhiteSpace(value[i]))
                {
                    return false;
                }
            }
            return true;
        }
        internal static bool IsNullEmptyOrWhiteSpace(string value, int offset, int length)
        {
            if (null == value)
            {
                return true;
            }

            length = Math.Min(value.Length, length);
            for(int i = offset; i < length; ++i)
            {
                if (!char.IsWhiteSpace(value[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
