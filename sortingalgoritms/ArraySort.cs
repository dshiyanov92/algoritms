using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SortingAlgorithms
{

    class ArraySort
    {

        // Selection sort
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
        // Insertion sort
        public static void InsertionSort(int[] array)
        {
            int newElement, location;
            for (int i = 1; i < array.Length; i++)
            {
                newElement = array[i];
                location = i - 1;
                while (location >= 0 && array[location] > newElement)
                {
                    array[location + 1] = array[location];
                    location = location - 1;
                }
                array[location + 1] = newElement;
            }
        }
        // Shellsort
        public static void ShellSort(int[] array)
        {
            int step = array.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < array.Length; i++)
                {
                    int value = array[i];
                    for (j = i - step; (j >= 0) && (array[j] > value); j -= step)
                        array[j + step] = array[j];
                    array[j + step] = value;
                }
                step /= 2;
            }
        }
        // Quicksort
        public static void Quicksort(int[] array, int first, int last)
        {
            int p = array[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (array[i] < p && i <= last) ++i;
                while (array[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) Quicksort(array, first, j);
            if (i < last) Quicksort(array, i, last);
        }
        // Merge sort
        public static void MergeSort(ref int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(ref arr, left, middle);
                MergeSort(ref arr, middle + 1, right);
                int middle1 = middle + 1;
                int oldPosition = left;
                int size = right - left + 1;
                int[] temp = new int[size];
                int i = 0;

                while (left <= middle && middle1 <= right)
                {
                    if (arr[left] <= arr[middle1])
                        temp[i++] = arr[left++];
                    else
                        temp[i++] = arr[middle1++];
                }
                if (left > middle)
                    for (int j = middle1; j <= right; j++)
                        temp[i++] = arr[middle1++];
                else
                    for (int j = left; j <= middle; j++)
                        temp[i++] = arr[left++];
                Array.Copy(temp, 0, arr, oldPosition, size);
            }
        }
        // RadixSort
        public static void RadixSort(int[] arr, int range, int length)
        {
            ArrayList[] lists = new ArrayList[range];
            for (int i = 0; i < range; ++i)
                lists[i] = new ArrayList();

            for (int step = 0; step < length; ++step)
            {
                //распределение по спискам
                for (int i = 0; i < arr.Length; ++i)
                {
                    int temp = (arr[i] % (int)Math.Pow(range, step + 1)) /
                                                  (int)Math.Pow(range, step);
                    lists[temp].Add(arr[i]);
                }
                //сборка
                int k = 0;
                for (int i = 0; i < range; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        arr[k++] = (int)lists[i][j];
                    }
                }
                for (int i = 0; i < range; ++i)
                    lists[i].Clear();
            }
        }
    }
}

