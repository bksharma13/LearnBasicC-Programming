using SequenceAnalysis;
using SumOfMultiple;
using System;

namespace ClassLibrarySampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Range: ");
            string enteredValue = Console.ReadLine();
            int.TryParse(enteredValue, out int inputNumber);

            FindMultipleOf3and5 findMultipleOf3And5obj = new FindMultipleOf3and5();
            Console.WriteLine("Output: " + findMultipleOf3And5obj.GetSum(inputNumber));
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Enter string to analyse: ");
            enteredValue = Console.ReadLine();
            AnalyseTheString analyseTheString = new AnalyseTheString();
            Console.WriteLine("Output: " + analyseTheString.FindUpperCaseChar(enteredValue));

            Console.ReadLine();
        }
    }
}
