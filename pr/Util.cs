using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace pr
{
    internal class Util
    {
        static readonly Regex _regex = new Regex("[0-9,]+");
        public static bool IsTextNumeric(string text)
        {
            bool result = _regex.IsMatch(text);
            if (text.Count(c => c == ',') > 1) result = false;
            return result;
        }
    }
}
