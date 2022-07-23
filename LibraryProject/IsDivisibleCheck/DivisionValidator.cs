using System;

namespace IsDivisibleCheck
{
    /// <summary>
    /// This class is used to find the division status of one number to another
    /// </summary>
    public class DivisionValidator
    {
        /// <summary>
        /// Determines whether x divisible by y.
        /// Method returns 1, if X can be divided by Y without a remainder.
        /// Method returns 0, if X can't be divided by Y without a remainder.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        public int IsXDivisibleByY(int X, int Y)
        {
            // Since X and Y can bring 0 in there values, which will raise exceptions
            // Translating this to float value
            // As float is capable of handling 0
            // This conversion will not be needed if we were allowed to validate the inputs
            int remainder = (int)((float)X % (float)Y);
            int outputValue = 0;

            // Lets bitwise check the value of the reminder to see if it was non-zero (integer 32 bits number)
            for (int i = 0; i < 32; i++)
            {
                outputValue = outputValue | (remainder & 1);
                remainder = remainder >> 1;
            }

            // XOR the output to return 0 or 1 based in condition of the question
            return outputValue ^ 1;
        }
    }
}
