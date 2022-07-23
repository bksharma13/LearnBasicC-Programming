using System;
using System.Collections.Generic;

namespace SequenceAnalysis
{
    /// <summary>
    /// This class is used to
    /// find the uppercase words in a string, provided as input, and order all characters in these words alphabetically
    /// </summary>
    public class AnalyseTheString
    {
        /// <summary>
        /// Finds the upper case character in the input string.
        /// </summary>
        /// <param name="inputString">The input string.</param>
        /// <returns></returns>
        public string FindUpperCaseChar(string inputString)
        {
            string outputStr = string.Empty;
            if (!string.IsNullOrEmpty(inputString))
            {
                List<char> upperCaseChar = new List<char>();
                foreach (char item in inputString)
                {
                    // Check the ASCII value of each character of the string for upper case values
                    if ((int)item >= 65 && (int)item <= 90)
                    {
                        upperCaseChar.Add(item);
                    }
                }

                // If items are found, sort them and return the string
                if (upperCaseChar.Count > 0)
                {
                    upperCaseChar.Sort();
                    outputStr = new string(upperCaseChar.ToArray());
                }
            }

            return outputStr;
        }
    }
}
