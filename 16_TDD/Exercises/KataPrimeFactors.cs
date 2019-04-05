using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /* OPTIONAL */
    public class KataPrimeFactors
    {
        public List<int> Factorize(int n)
        {
            List<int> factorized = new List<int>();

            if (n % 7 == 0)
            {
                if (n > 7)
                {
                    factorized.AddRange(Factorize(n / 7));
                }
                factorized.Add(7);
            } else if (n % 5 == 0)
            {
                if (n > 5)
                {
                    factorized.AddRange(Factorize(n / 5));
                }
                factorized.Add(5);
            } else if (n % 4 == 0)
            {
                if (n > 4)
                {
                    factorized.AddRange(Factorize(n / 4));
                }
                factorized.Add(2);
                factorized.Add(2);
            } else if (n % 3 == 0)
            {
                if (n > 3)
                {
                    factorized.AddRange(Factorize(n / 3));
                }
                factorized.Add(3);
            } else if (n % 2 == 0)
            {
                if (n > 2)
                {
                    factorized.AddRange(Factorize(n / 2));
                }
                factorized.Add(2);
            } else
            {
                factorized.Add(n);
            }

            

            return factorized;
        }
    }
}
