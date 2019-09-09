using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class Sorting
    {
        public static void BubbleSort(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 1; i < arr.Length - 1 - j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                int val = arr[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                        flag = 1;
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[index])
                    {
                        index = j;
                    }
                }
                int temp = arr[index];
                arr[index] = arr[i];
                arr[i] = temp;
            }
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public static void CountingSort(int[] arr)
        {
            int minVal = arr[0];
            int maxVal = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minVal)
                    minVal = arr[i];
                else if (arr[i] > maxVal)
                    maxVal = arr[i];
            }

            int[] counts = new int[maxVal - minVal + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                counts[arr[i] - minVal]++;
            }

            for (int i = 0, j = 0; i < counts.Length; i++)
            {
                while (counts[i] != 0)
                {
                    arr[j++] = i + minVal;
                    counts[i]--;
                }
            }
        }

        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(arr, left, leftArray, 0, middle - left + 1);
            Array.Copy(arr, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
            }
        }

        public static void HeapSort(int[] arr)
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
                Heapify(arr, arr.Length, i);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr, i, 0);
            }
        }
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, n, largest);
            }
        }

    }
}
