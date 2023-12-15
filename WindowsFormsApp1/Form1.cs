using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int[] array;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Add("CzasWykonania");
            chart1.Series["CzasWykonania"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["CzasWykonania"].Color = System.Drawing.Color.DarkRed;
            chart1.Series["CzasWykonania"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chart1.Titles.Add("Czas wykonania sortowania");

            chart1.ChartAreas[0].AxisX.Title = "Rodzaj sortowania";
            chart1.ChartAreas[0].AxisY.Title = "Czas wykonania (ms)";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Malejace_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLiczby.Text, out int iloscLiczb) && iloscLiczb > 0)
            {
                array = new int[iloscLiczb];

                for (int i = 0; i < iloscLiczb; i++)
                {
                    array[i] = iloscLiczb - i;
                    Generowane.Items.Add(array[i]);
                }
            }
            else
            {
                MessageBox.Show("Proszę podać poprawną liczbę liczb do wygenerowania.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLiczby.Text, out int iloscLiczb) && iloscLiczb > 0)
            {
                array = new int[iloscLiczb];

                for (int i = 0; i < iloscLiczb; i++)
                {
                    array[i] = i + 1;
                    Generowane.Items.Add(array[i]);
                }
            }
            else
            {
                MessageBox.Show("Proszę podać poprawną liczbę liczb do wygenerowania.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLiczby.Text, out int iloscLiczb) && iloscLiczb > 0)
            {
                array = new int[iloscLiczb];
                Random rnd = new Random();

                for (int i = 0; i < iloscLiczb; i++)
                {
                    array[i] = rnd.Next(1000);
                    Generowane.Items.Add(array[i]);
                }
            }
            else
            {
                MessageBox.Show("Proszę podać poprawną liczbę liczb do wygenerowania.");
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

        private List<int> MergeSortAlgo(List<int> arr)
        {
            if (arr.Count <= 1)
                return arr;

            int srodek = arr.Count / 2;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < srodek; i++)
                left.Add(arr[i]);
            for (int i = srodek; i < arr.Count; i++)
                right.Add(arr[i]);

            left = MergeSortAlgo(left);
            right = MergeSortAlgo(right);

            return Merge(left, right);
        }


        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            return result;
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

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

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
            else if (Scalanie.Checked)
            {
                DoPosortowania = MergeSortAlgo(DoPosortowania);
            }

            stopwatch.Stop();
            TimeSpan czasWykonania = stopwatch.Elapsed;

            if(chart1.Series.IndexOf("CzasWykonania") == -1)
            {
                chart1.Series.Add("CzasWykonania");
                chart1.Series["CzasWykonania"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Series["CzasWykonania"].Color = System.Drawing.Color.DarkRed;
                chart1.Series["CzasWykonania"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            }

            chart1.Series["CzasWykonania"].Points.AddXY(WybraneSortowanie(), czasWykonania.TotalMilliseconds);

            Sortowane.Items.Clear();

            foreach (var item in DoPosortowania)
            {
                Sortowane.Items.Add(item);
            }
        }
        private string WybraneSortowanie()
        {
            if (Babelkowe.Checked)
                return "Sortowanie Bąbelkowe";
            else if (Wybor.Checked)
                return "Sortowanie Przez Wybór";
            else if (Wstawianie.Checked)
                return "Sortowanie Przez Wstawianie";
            else if (Szybkie.Checked)
                return "Sortowanie Szybkie";
            else if (Scalanie.Checked)
                return "Sortowanie Przez Scalanie";
            else
                return "Brak wyboru";
        }

        

        private void textBoxLiczby_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}