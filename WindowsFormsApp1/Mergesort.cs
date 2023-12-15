using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.Form1;

namespace WindowsFormsApp1
{
    public class Mergesort : ISorter
    {
        public void Sort(List<int> arr)
        {
            MergeSortRecursive(arr);
        }

        private void MergeSortRecursive(List<int> arr)
        {
            if (arr.Count <= 1)
                return;

            int middle = arr.Count / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < middle; i++)
                left.Add(arr[i]);

            for (int i = middle; i < arr.Count; i++)
                right.Add(arr[i]);

            MergeSortRecursive(left);
            MergeSortRecursive(right);

            Merge(arr, left, right);
        }

        private void Merge(List<int> arr, List<int> left, List<int> right)
        {
            int leftIndex = 0, rightIndex = 0, arrIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    arr[arrIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[arrIndex] = right[rightIndex];
                    rightIndex++;
                }
                arrIndex++;
            }

            while (leftIndex < left.Count)
            {
                arr[arrIndex] = left[leftIndex];
                leftIndex++;
                arrIndex++;
            }

            while (rightIndex < right.Count)
            {
                arr[arrIndex] = right[rightIndex];
                rightIndex++;
                arrIndex++;
            }
        }
    }
}
