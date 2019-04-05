using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPotter
    {
        decimal SetOf5 { get; } = (8 * 5) * .75M;
        decimal SetOf4 { get; } = (8 * 4) * .80M;
        decimal SetOf3 { get; } = (8 * 3) * .90M;
        decimal SetOf2 { get; } = (8 * 2) * .95M;

        public decimal GetCost(int[] array)
        {
            int highestNumber = GetHighestNumber(array);

            int counter = 0;
            int counter5 = 0, counter4 = 0, counter3 = 0, counter2 = 0, counter1 = 0;

            while (highestNumber > 0)
            {
                counter = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        counter++;
                        array[i]--;
                    }
                }

                if (counter == 5) { counter5++; }
                if (counter == 4) { counter4++; }
                if (counter == 3) { counter3++; }
                if (counter == 2) { counter2++; }
                if (counter == 1) { counter1++; }
                highestNumber--;
            }

            if (counter5 > 0 && counter3 > 0)
            {
                counter5--;
                counter3--;
                counter4 += 2;
            }
            decimal totalCost = 0M;
            if (counter5 > 0)
            {
                totalCost += SetOf5 * counter5;
            }
            if (counter4 > 0)
            {
                totalCost += SetOf4 * counter4;
            }  
            if (counter3 > 0)
            {
                totalCost += SetOf3 * counter3;
            } 
            if (counter2 > 0)
            {
                totalCost += SetOf2 * counter2;
            }
            if (counter1 > 0)
            {
                totalCost += 8 * counter1;
            }

            return totalCost;
        }

        public int GetHighestNumber(int[] array)
        {
            int highestNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > highestNumber)
                {
                    highestNumber = array[i];
                }
            }

            return highestNumber;
        }
    }

    
}
