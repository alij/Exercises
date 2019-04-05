using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            if (str.IndexOf("x") != -1)
            {
                if ((str.IndexOf("x") != str.Length-1) && str[str.IndexOf("x") + 1] == 'x')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
