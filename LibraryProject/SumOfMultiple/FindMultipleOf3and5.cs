using System;

namespace SumOfMultiple
{
    /// <summary>
    /// This class is used to 
    /// find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input
    /// </summary>
    public class FindMultipleOf3and5
    {
        /// <summary>
        /// Gets the sum of the natural number that multiple of 3 and 5
        /// </summary>
        /// <param name="range">The range.</param>
        /// <returns>Sum of natural number</returns>
        public int GetSum(int range)
        {
            return FindMultipleOfnumber(range, 3) + FindMultipleOfnumber(range, 5);
        }

        /// <summary>
        /// Finds the multiple of the number to a range
        /// </summary>
        /// <param name="range">The range.</param>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        private int FindMultipleOfnumber(int range, int number)
        {
            int sumOfMultiple = 0;
            int multiplier = 1, value = number * multiplier++;
            // Loop through till the range is higher than the multiple
            while (value <= range)
            {
                sumOfMultiple += value;
                value = number * multiplier++;                
            }

            return sumOfMultiple;
        }
    }
}
