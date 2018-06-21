using System;
using System.Collections.Generic;
using System.Text;


namespace SortingAlgorithms
{
    class ArrayGenerator
    {
        public enum Cases {Random, Best, Average, Worst };
        public int[] GenerateArray(int size, Cases fortuity)
        {
            int[] array = new int[size];

            switch (fortuity){
                case Cases.Best:
                    Random n = new Random();
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = n.Next(0, (int)(2*Math.Pow(10,9)));
                    }
                    Array.Sort(array);
                    break;
                case Cases.Average:
                    Random n2 = new Random();
                    int array_middle = array.Length / 2;
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = n2.Next(0, (int)(2 * Math.Pow(10, 9)));
                    }
                    Array.Sort(array);
                    array[array_middle] = n2.Next(0, (int)(2 * Math.Pow(10, 9)));
                    break;
                case Cases.Worst:
                    break;
                case Cases.Random:
                    Random n3 = new Random();
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = n3.Next(0, 2000000000);
                    }
                    return array;
                    break;
            }
            return array;
        }


    }
}
