using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                this.array[i] = rnd.Next(10);
                Generowane.Items.Add(rnd.Next(this.array[i]));
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
            

            foreach (var item in DoPosortowania)
            {
                Sortowane.Items.Add(item);
            }
        }
    }
}