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
using static WindowsFormsApp1.Form1;

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

        

        private void Malejace_Click(object sender, EventArgs e)
        {
           Generowane.Items.Clear();
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
            Generowane.Items.Clear();
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
            Generowane.Items.Clear();
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

        public interface ISorter
        {
            void Sort(List<int> arr);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<int> DoPosortowania = new List<int>();
            foreach (var item in Generowane.Items)
            {
                DoPosortowania.Add(Convert.ToInt32(item));
            }
            var bubbleSort = new Bubblesort();
            var insertionSort = new Insertionsort();
            var selectionSort = new Selectionsort();
            var quickSort = new Quicksort();
            var mergeSort = new Mergesort();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (Babelkowe.Checked)
            {
                bubbleSort.Sort(DoPosortowania);
            }
            else if (Wybor.Checked)
            {
                selectionSort.Sort(DoPosortowania);
            }
            else if (Wstawianie.Checked)
            {
                insertionSort.Sort(DoPosortowania);
            }
            else if (Szybkie.Checked)
            {
                quickSort.Sort(DoPosortowania);
            }
            else if (Scalanie.Checked)
            {
                mergeSort.Sort(DoPosortowania);
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

            chart1.Series["CzasWykonania"].Points.AddXY(WybraneSortowanie(), Math.Round(czasWykonania.TotalMilliseconds));

            listBox1.Items.Add($"{WybraneSortowanie()}: {Math.Round(czasWykonania.TotalMilliseconds)} ms");

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

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Generowane.Items.Clear();
            Sortowane.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series["CzasWykonania"].Points.Clear();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Babelkowe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void CzyscWynik_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}