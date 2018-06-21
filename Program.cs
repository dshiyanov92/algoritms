using System;
using System.IO;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            BestCase bc = new BestCase();
            RandomValue rand = new RandomValue();
            rand.test1(); // Random values
            bc.test2(); // Array sorted in ascending order


        }
        /*
        StreamWriter str = new StreamWriter(fileName);
        for (int i = 0; i < size; i++)
        {
            str.WriteLine(testArray[i]);
        }
        str.Close();
        */
    }
}
