using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int[] array;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                this.array[i] = rnd.Next(100);
                Generowane.Items.Add((this.array[i]));
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Babelkowe_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Bubblesort(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0;i < n - 1;i++) 
            { 
            for (int j = 0;j < n - 1;j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp; 
                    }
                }
            }
        }
        private void Selectionsort(List<int> arr)
        {
            int n = arr.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i ; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
        

        private List<int> Insertionsort(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while(j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        } 

        private void Quicksort(List<int> arr, int left, int right)
        {
            if (left<right)
            {
                int pi = Partition(arr, left, right);
                Quicksort(arr, left, pi - 1);
                Quicksort(arr, pi + 1, right);
            }
        }
        private int Partition(List<int> arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left -1;

            for(int j = left; j < right; j++)
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
        private void Wybor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Szybkie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Scalanie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<int> DoPosortowania = new List<int>();
            foreach (var item in Generowane.Items)
            {
                DoPosortowania.Add(Convert.ToInt32(item));
            }
            if (Babelkowe.Checked)
            {
                Bubblesort(DoPosortowania);
            }
            else if (Wybor.Checked)
            {
                Selectionsort(DoPosortowania);
            }
            else if (Wstawianie.Checked)
            {
                Insertionsort(DoPosortowania);
            }
            else if (Szybkie.Checked)
            {
                Quicksort(DoPosortowania, 0, DoPosortowania.Count -1);
            }

            Sortowane.Items.Clear();

            foreach (var item in DoPosortowania)
            {
                Sortowane.Items.Add(item);
            }
        }
    }
}