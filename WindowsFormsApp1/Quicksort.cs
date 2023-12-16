using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.Form1;

namespace WindowsFormsApp1
{
    public class Quicksort : ISorter
    {
        private Random _random = new Random();

        public void Sort(List<int> arr)
        {
            QuickSortRecursive(arr, 0, arr.Count - 1);
        }

        private void QuickSortRecursive(List<int> arr, int left, int right)
        {
            if (left < right)
            {
                int pi = Partition(arr, left, right);
                QuickSortRecursive(arr, left, pi);
                QuickSortRecursive(arr, pi + 1, right);
            }
        }

        private int Partition(List<int> arr, int left, int right)
        {
            int pivotIndex = _random.Next(left, right + 1);
            int pivot = arr[pivotIndex];

            while (left <= right)
            {
                while (arr[left] < pivot) left++;
                while (arr[right] > pivot) right--;

                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    left++;
                    right--;
                }
            }
            return left - 1;
        }
    }
}