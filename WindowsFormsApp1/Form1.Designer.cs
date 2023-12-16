namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Sortowane = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Generowane = new System.Windows.Forms.ListBox();
            this.Losowe = new System.Windows.Forms.Button();
            this.Babelkowe = new System.Windows.Forms.CheckBox();
            this.Wybor = new System.Windows.Forms.CheckBox();
            this.Wstawianie = new System.Windows.Forms.CheckBox();
            this.Szybkie = new System.Windows.Forms.CheckBox();
            this.Scalanie = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Rosnace = new System.Windows.Forms.Button();
            this.Malejace = new System.Windows.Forms.Button();
            this.textBoxLiczby = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CzyscWynik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sortowane
            // 
            this.Sortowane.FormattingEnabled = true;
            this.Sortowane.Location = new System.Drawing.Point(349, 61);
            this.Sortowane.Name = "Sortowane";
            this.Sortowane.Size = new System.Drawing.Size(105, 238);
            this.Sortowane.TabIndex = 0;
            this.Sortowane.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(488, 18);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Generowane
            // 
            this.Generowane.FormattingEnabled = true;
            this.Generowane.Location = new System.Drawing.Point(221, 61);
            this.Generowane.Name = "Generowane";
            this.Generowane.Size = new System.Drawing.Size(106, 238);
            this.Generowane.TabIndex = 2;
            this.Generowane.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Losowe
            // 
            this.Losowe.Location = new System.Drawing.Point(53, 136);
            this.Losowe.Name = "Losowe";
            this.Losowe.Size = new System.Drawing.Size(72, 28);
            this.Losowe.TabIndex = 3;
            this.Losowe.Text = "Losowe";
            this.Losowe.UseVisualStyleBackColor = true;
            this.Losowe.Click += new System.EventHandler(this.button1_Click);
            // 
            // Babelkowe
            // 
            this.Babelkowe.AutoSize = true;
            this.Babelkowe.Location = new System.Drawing.Point(53, 175);
            this.Babelkowe.Name = "Babelkowe";
            this.Babelkowe.Size = new System.Drawing.Size(79, 17);
            this.Babelkowe.TabIndex = 4;
            this.Babelkowe.Text = "Babelkowe";
            this.Babelkowe.UseVisualStyleBackColor = true;
            this.Babelkowe.CheckedChanged += new System.EventHandler(this.Babelkowe_CheckedChanged);
            // 
            // Wybor
            // 
            this.Wybor.AutoSize = true;
            this.Wybor.Location = new System.Drawing.Point(53, 198);
            this.Wybor.Name = "Wybor";
            this.Wybor.Size = new System.Drawing.Size(57, 17);
            this.Wybor.TabIndex = 5;
            this.Wybor.Text = "Wybor";
            this.Wybor.UseVisualStyleBackColor = true;
            this.Wybor.CheckedChanged += new System.EventHandler(this.Wybor_CheckedChanged);
            // 
            // Wstawianie
            // 
            this.Wstawianie.AutoSize = true;
            this.Wstawianie.Location = new System.Drawing.Point(53, 221);
            this.Wstawianie.Name = "Wstawianie";
            this.Wstawianie.Size = new System.Drawing.Size(81, 17);
            this.Wstawianie.TabIndex = 6;
            this.Wstawianie.Text = "Wstawianie";
            this.Wstawianie.UseVisualStyleBackColor = true;
            this.Wstawianie.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Szybkie
            // 
            this.Szybkie.AutoSize = true;
            this.Szybkie.Location = new System.Drawing.Point(53, 245);
            this.Szybkie.Name = "Szybkie";
            this.Szybkie.Size = new System.Drawing.Size(63, 17);
            this.Szybkie.TabIndex = 7;
            this.Szybkie.Text = "Szybkie";
            this.Szybkie.UseVisualStyleBackColor = true;
            this.Szybkie.CheckedChanged += new System.EventHandler(this.Szybkie_CheckedChanged);
            // 
            // Scalanie
            // 
            this.Scalanie.AutoSize = true;
            this.Scalanie.Location = new System.Drawing.Point(53, 269);
            this.Scalanie.Name = "Scalanie";
            this.Scalanie.Size = new System.Drawing.Size(67, 17);
            this.Scalanie.TabIndex = 8;
            this.Scalanie.Text = "Scalanie";
            this.Scalanie.UseVisualStyleBackColor = true;
            this.Scalanie.CheckedChanged += new System.EventHandler(this.Scalanie_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Rosnace
            // 
            this.Rosnace.Location = new System.Drawing.Point(53, 107);
            this.Rosnace.Name = "Rosnace";
            this.Rosnace.Size = new System.Drawing.Size(75, 23);
            this.Rosnace.TabIndex = 10;
            this.Rosnace.Text = "Rosnace";
            this.Rosnace.UseVisualStyleBackColor = true;
            this.Rosnace.Click += new System.EventHandler(this.button2_Click);
            // 
            // Malejace
            // 
            this.Malejace.Location = new System.Drawing.Point(53, 78);
            this.Malejace.Name = "Malejace";
            this.Malejace.Size = new System.Drawing.Size(75, 23);
            this.Malejace.TabIndex = 11;
            this.Malejace.Text = "Malejace";
            this.Malejace.UseVisualStyleBackColor = true;
            this.Malejace.Click += new System.EventHandler(this.Malejace_Click);
            // 
            // textBoxLiczby
            // 
            this.textBoxLiczby.Location = new System.Drawing.Point(53, 52);
            this.textBoxLiczby.Name = "textBoxLiczby";
            this.textBoxLiczby.Size = new System.Drawing.Size(75, 20);
            this.textBoxLiczby.TabIndex = 12;
            this.textBoxLiczby.TextChanged += new System.EventHandler(this.textBoxLiczby_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "CzyscList";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "CzyscWykr";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(488, 338);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 134);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // CzyscWynik
            // 
            this.CzyscWynik.Location = new System.Drawing.Point(349, 356);
            this.CzyscWynik.Name = "CzyscWynik";
            this.CzyscWynik.Size = new System.Drawing.Size(105, 23);
            this.CzyscWynik.TabIndex = 16;
            this.CzyscWynik.Text = "CzyscWynik";
            this.CzyscWynik.UseVisualStyleBackColor = true;
            this.CzyscWynik.Click += new System.EventHandler(this.CzyscWynik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Podaj liczbę";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Liczby Generowane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Liczby Posortowane";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Czas wykonania sortowań";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CzyscWynik);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxLiczby);
            this.Controls.Add(this.Malejace);
            this.Controls.Add(this.Rosnace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Scalanie);
            this.Controls.Add(this.Szybkie);
            this.Controls.Add(this.Wstawianie);
            this.Controls.Add(this.Wybor);
            this.Controls.Add(this.Babelkowe);
            this.Controls.Add(this.Losowe);
            this.Controls.Add(this.Generowane);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Sortowane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Sortowane;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox Generowane;
        private System.Windows.Forms.Button Losowe;
        private System.Windows.Forms.CheckBox Babelkowe;
        private System.Windows.Forms.CheckBox Wybor;
        private System.Windows.Forms.CheckBox Wstawianie;
        private System.Windows.Forms.CheckBox Szybkie;
        private System.Windows.Forms.CheckBox Scalanie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Rosnace;
        private System.Windows.Forms.Button Malejace;
        private System.Windows.Forms.TextBox textBoxLiczby;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CzyscWynik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

