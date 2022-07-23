using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReverseWord
{
    // I am good
    // good am I
    public class ReverseWordLogic
    {
        public string Reverse(string inputString)
        {
            string outString = inputString;
            if(!string.IsNullOrEmpty(inputString))
            {                
                List<string> breakStr = inputString.ToLower().Split(' ').ToList();
                breakStr.Reverse();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var item in breakStr)
                {
                    stringBuilder.Append(item + ' ');
                }

                outString = stringBuilder.ToString();
                outString = outString.Substring(0, outString.Length - 1);
            }

            return outString;
        }

        // 1,2,3
        // 2,3,1
        public int[] LeftRotate(int[] inputArray, int rotationCount)
        {
            if(inputArray == null || inputArray.Length < 2 || rotationCount < 1)
            {                
                return inputArray;
            }

            int inputLength = inputArray.Length;
            int firstValue = inputArray[0];
            int[] outArray = new int[inputLength];
            int countIndex = 0;
            for (int i = 1; i < inputLength; i++)
            {
                outArray[countIndex++] = inputArray[i];
            }

            outArray[countIndex] = firstValue;
            if(--rotationCount != 0)
            {
                outArray = LeftRotate(outArray, rotationCount);
            }

            return outArray;
        }
    }
}
