using System;
using BubbleSortLib;

//IDK JUST TESTING YO

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 52, 34, 4, 15, 60 };
            BubbleSortLib.Sorter.sort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
