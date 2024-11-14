﻿using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Sortings : Form, ISortView
    {
        BackgroundWorker _backgroundWorker = new BackgroundWorker();
        string path = "temporary";
        private double[] savedArray;
        private int _progress = 0;
        private Size formOriginalSize;
        private Rectangle recSortGroup;
        private Rectangle recInputGroup;
        private Rectangle recIncreaseGroup;
        private Rectangle recInputData;
        private Rectangle recSortingsResults;
        private Rectangle recBubble;
        private Rectangle recInserts;
        private Rectangle recFast;
        private Rectangle recShake;
        private Rectangle recSwamp;


        public Sortings()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.DoWork += _backgroundWorkerDoWork;
            _backgroundWorker.ProgressChanged += _backgroundWorkerProgressChanged;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorkerRunWorkerCompleted;
            formOriginalSize = this.Size;
            recSortGroup = new Rectangle(sortGroup.Location, sortGroup.Size);
            recInputGroup = new Rectangle(inputBox.Location, inputBox.Size);
            recSortingsResults = new Rectangle(dataGridView2.Location, dataGridView2.Size);
            recIncreaseGroup = new Rectangle(groupBox1.Location, groupBox1.Size);
            recInputData = new Rectangle(dataGridView1.Location, dataGridView1.Size);
            recBubble = new Rectangle(bubble.Location, bubble.Size);
            recInserts = new Rectangle(inserts.Location, inserts.Size);
            recFast = new Rectangle(fast.Location, fast.Size);
            recShake = new Rectangle(shake.Location, shake.Size);
            recSwamp = new Rectangle(swamp.Location, swamp.Size);
        }

        private void _backgroundWorkerDoWork(object sender, DoWorkEventArgs inputEvent) {
            double[] array = (double[])inputEvent.Argument;
            List <double> list = new List <double>();
            for (int inputIndex = 0; inputIndex < array.Length; ++inputIndex)
            {
                list.Add (array[inputIndex]);
                int progress = Convert.ToInt32(inputIndex / Convert.ToDouble(array.Length) * 100);
                _backgroundWorker.ReportProgress(progress);
            }
            inputEvent.Result = list;
        }

        private void AutoResize(Control control, Rectangle rectangle)
        {
            double xRatio = (double)(this.Width) / (double)(formOriginalSize.Width);
            double yRatio = (double)(this.Height) / (double)(formOriginalSize.Height);
            int newX = (int)(rectangle.X * xRatio);
            int newY = (int)(rectangle.Y * yRatio);

            int newWidth = (int)(rectangle.Width * xRatio);
            int newHeight = (int)(rectangle.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void SortingsForm_Resize(object sender, EventArgs e)
        {
            AutoResize(sortGroup, recSortGroup);
            AutoResize(inputBox, recInputGroup);
            AutoResize(dataGridView2, recSortingsResults);
            AutoResize(groupBox1, recIncreaseGroup);
            AutoResize(dataGridView1, recInputData);
            AutoResize(bubble, recBubble);
            AutoResize(inserts, recInserts);
            AutoResize(fast, recFast);
            AutoResize(shake, recShake);
            AutoResize(swamp, recSwamp);
        }

        private void _backgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs inputEvent)
        {
            List<double> dataList = (List<double>)inputEvent.Result;
            foreach(double data in dataList)
            {
                dataGridView1.Rows.Add(data);
            }
            MessageBox.Show("Ввод завершён");
        }

        private void _backgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs inputEvent)
        {
            progressBar1.Value = inputEvent.ProgressPercentage;
        }


        int ISortView.ArraySizeToRandom()
        {
            if (randomArray.Text.Length == 0)
            {
                return 10;
            }
            return Convert.ToInt32(randomArray.Text);
        }
        
        int ISortView.leftInterval()
        {

            if (left.Text.Length == 0)
            {
                return 10;
            }
            return Convert.ToInt32(left.Text);
        }

        int ISortView.rightInterval()
        {
            if (right.Text.Length == 0)
            {
                return 10;
            }
            return Convert.ToInt32(right.Text);
        }

        string ISortView.PathToFile()
        {
            return path;
        }

        void ISortView.ChooseInput(double[] inputArray)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            if (Double.IsNaN(inputArray[0]))
            {
                savedArray = inputArray;
                MessageBox.Show("Вводите числа в столбцы. Дробь пишется через запятую, пустая ячейка - последнее число.", "Ввод доступен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                savedArray = inputArray;            
            }

        }

        void ISortView.ShowSortResult(string[] methodName, int[] methodIterations, double[] methodTime)
        {
            dataGridView2.Rows.Clear();
            int rowCount = Math.Max(methodName.Length, Math.Max(methodIterations.Length, methodTime.Length));
            for (int index = 0; index < rowCount; ++index)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = methodName[index] });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = methodIterations[index] });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = methodTime[index] });
                dataGridView2.Rows.Add(row);
            }
        }

        byte ISortView.StartInput()
        {
            byte inputMethod = 0;
            if (hand.Checked)
            {
                inputMethod = 1;
            }
            if (generation.Checked)
            {
                inputMethod = 2;
            }
            if (file.Checked)
            {
                inputMethod = 3;
            }
            return inputMethod;
        }

        bool ISortView.IsIncreasing()
        {
            if (increasing.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        double[] ISortView.NumbersToSort()
        {
            double[] numbers = new double[dataGridView1.Rows.Count - 1];
            for (int index = 0; index < dataGridView1.Rows.Count - 1; ++index)
            {
                double value = Convert.ToDouble(dataGridView1.Rows[index].Cells[0].Value);
                numbers[index] = value;
            }
            return numbers;
        }

        bool ISortView.IsActiveBubble()
        {
            if (bubble.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ISortView.IsActiveInserts()
        {
            if (inserts.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ISortView.IsActiveFast()
        {
            if (fast.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ISortView.IsActiveShake()
        {
            if (shake.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ISortView.IsActiveSwamp()
        {
            if (swamp.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        double ISortView.SwampsIterations()
        {
            if (iterationsSwamp.Text.Length > 0)
            {
                return Convert.ToDouble(iterationsSwamp.Text);
            }
            else
            {
                return 1000;
            }
        }

        public void UpdateProgress(int progress)
        {
            progressBar1.Value = progress;
        }

        public event EventHandler<EventArgs> AddData;
        public event EventHandler<EventArgs> Sort;

        private void toolStripTextBox1_Click(object sender, EventArgs inputEvent)
        {
            if(ValidateText())
            {
                AddData(sender, inputEvent);
                if (!double.IsNaN(savedArray[0]))
                {
                    _backgroundWorker.RunWorkerAsync(savedArray);
                }
            }
            
        }

        private void toolStripTextBox2_Click(object sender, EventArgs inputEvent)
        {
            if (ValidateText()) 
            {
                Sort(sender, inputEvent);
            }
            
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
        }


        private void SetDataGridView(DataGridView dataGridView, int row, int cell)
        {
            dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
            dataGridView.BeginEdit(true);
        }

        private void testingButton_Click(object sender, EventArgs inputEvent)
        {
            ValidateText();
            AddData(sender, inputEvent);
            Sort(sender, inputEvent);
        }
        private bool ValidateText()
        {
            Regex regex = new Regex(@"^[\d,-]+$");
            bool result = true;
            bool mathces;
            if (string.IsNullOrEmpty(randomArray.Text) || (mathces = regex.IsMatch(randomArray.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода числа генерируемых чисел для массива", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(iterationsSwamp.Text) || (mathces = regex.IsMatch(iterationsSwamp.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода числа итераций для болотной сортировки", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(left.Text) || (mathces = regex.IsMatch(left.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода левого значения интервала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(right.Text) || (mathces = regex.IsMatch(right.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода правого значения интервала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
    
}
