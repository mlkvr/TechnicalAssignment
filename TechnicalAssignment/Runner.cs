using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SumOfMultiple;
using SequenceAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Class1 class1 = new();
        Class2 class2 = new();

        Console.WriteLine("Type '1' for SumOfMultiple, '2' for SequenceAnalysis");
        string key = Console.ReadLine();

        switch(key){
            case "1":
                Console.WriteLine("Type limit (inclusive) for SumOfMultiple");
                string inputVal = Console.ReadLine();
                class1.sumFinder(Int32.Parse(inputVal));
                break;

            case "2":
                Console.WriteLine("Type limit for SequenceAnalysis");
                string inputStr = Console.ReadLine();
                class2.stringAnalyzer(inputStr);
                break;
        }
        Console.WriteLine();
    }

}