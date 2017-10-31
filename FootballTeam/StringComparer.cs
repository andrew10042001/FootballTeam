using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            for (var i = 0; i < x.Length && i < y.Length; i++)
            {
                var result = Compare(x[i], y[i]);
                if (result != 0) return result;
            }
            return string.Compare(x, y);
        }

        private int Compare(char x, char y)
        {
            if (char.IsDigit(x) && char.IsLetter(y)) return 1;
            if (char.IsLetter(x) && char.IsDigit(y)) return -1;
            return Comparer<char>.Default.Compare(x, y);
        }
    }
}
