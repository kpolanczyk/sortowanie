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
        public void Sort(List<int> arr)
        {
            QuickSortRecursive(arr, 0, arr.Count - 1);
        }

        private void QuickSortRecursive(List<int> arr, int left, int right)
        {
            if (left < right)
            {
                int pi = Partition(arr, left, right);
                QuickSortRecursive(arr, left, pi - 1);
                QuickSortRecursive(arr, pi + 1, right);
            }
        }
        private int Partition(List<int> arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;
            return i + 1;
        }
    }
}
