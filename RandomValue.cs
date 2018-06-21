using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SortingAlgorithms
{
    class RandomValue
    {
        public void test1()
        {
            int[] arraySize = { 100, 500, 1000, 5000, 10000, 50000, 100000 };
            ArrayGenerator sort = new ArrayGenerator();
            for (int i = 0; i < arraySize.Length; i++)
            {
                int[] testArray = sort.GenerateArray(arraySize[i], ArrayGenerator.Cases.Random);
                string s1 = arraySize[i].ToString();
                string s2 = String.Concat(s1, ".txt");
                string fileName = String.Concat(@"C:\Users\N56\Desktop\SortingAlgorithms\Random_", s2);

                string s3 = String.Concat("Количество элементов массива - ", s1);
                File.WriteAllText(fileName, s3 + Environment.NewLine, System.Text.Encoding.Default);

                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

                for (int j = 0; j < 10; j++)
                {
                    File.AppendAllText(fileName, "Начало нового теста\n" + Environment.NewLine);
                    // Selection sort            
                    int[] test1 = new int[arraySize[i]];
                    Array.Copy(testArray, test1, testArray.Length);
                    sw = new System.Diagnostics.Stopwatch();
                    sw.Start();
                    ArraySort.SelectionSort(test1);
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed.TotalMilliseconds);
                    File.AppendAllText(fileName, sw.Elapsed.TotalMilliseconds.ToString() + Environment.NewLine);

                    // Insertion sort
                    int[] test2 = new int[arraySize[i]];
                    Array.Copy(testArray, test2, testArray.Length);
                    sw = new System.Diagnostics.Stopwatch();
                    sw.Start();
                    ArraySort.InsertionSort(test2);
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed.TotalMilliseconds);
                    File.AppendAllText(fileName, sw.Elapsed.TotalMilliseconds.ToString() + Environment.NewLine);

                    // Shellsort
                    int[] test3 = new int[arraySize[i]];
                    Array.Copy(testArray, test3, testArray.Length);
                    sw = new System.Diagnostics.Stopwatch();
                    sw.Start();
                    ArraySort.ShellSort(test3);
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed.TotalMilliseconds);
                    File.AppendAllText(fileName, sw.Elapsed.TotalMilliseconds.ToString() + Environment.NewLine);

                    // Quicksort
                    int[] test4 = new int[arraySize[i]];
                    Array.Copy(testArray, test4, testArray.Length);
                    sw = new System.Diagnostics.Stopwatch();
                    sw.Start();
                    ArraySort.Quicksort(test4, 0, test4.Length - 1);
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed.TotalMilliseconds);
                    File.AppendAllText(fileName, sw.Elapsed.TotalMilliseconds.ToString() + Environment.NewLine);

                    // Merge sort
                    int[] test5 = new int[arraySize[i]];
                    Array.Copy(testArray, test5, testArray.Length);
                    sw = new System.Diagnostics.Stopwatch();
                    sw.Start();
                    ArraySort.MergeSort(ref test5, 0, test5.Length - 1);
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed.TotalMilliseconds);
                    File.AppendAllText(fileName, sw.Elapsed.TotalMilliseconds.ToString() + Environment.NewLine);

                    // RadixSort
                    int[] test6 = new int[arraySize[i]];
                    Array.Copy(testArray, test6, testArray.Length);
                    sw = new System.Diagnostics.Stopwatch();
                    sw.Start();
                    ArraySort.RadixSort(test6, 10, 10);
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed.TotalMilliseconds);
                    File.AppendAllText(fileName, sw.Elapsed.TotalMilliseconds.ToString() + Environment.NewLine);
                    File.AppendAllText(fileName, "------------------------" + Environment.NewLine);
                }
            }
        }
    }
}