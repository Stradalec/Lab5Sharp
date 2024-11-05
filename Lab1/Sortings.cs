using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Sortings : Form, ISortView
    {
        string path = "temporary";
        public Sortings()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        int ISortView.ArraySizeToRandom()
        {
            if (randomArray.Text.Length == 0)
            {
                return 10;
            }
            return Convert.ToInt32(randomArray.Text);
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
                MessageBox.Show("Вводите числа в столбцы. Дробь пишется через запятую, пустая ячейка - последнее число.", "Ввод доступен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach(var number in inputArray)
                {
                    dataGridView1.Rows.Add(number);
                }
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

        

        public event EventHandler<EventArgs> AddData;
        public event EventHandler<EventArgs> Sort;

        private void toolStripTextBox1_Click(object sender, EventArgs inputEvent)
        {
            
            AddData(sender, inputEvent);
        }

        private void toolStripTextBox2_Click(object sender, EventArgs inputEvent)
        {
            Sort(sender, inputEvent);
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                path  = openFileDialog1.FileName;
            }
        }

        //private void ClearColumn(DataGridView dataGridView, int columnIndex) 
        //{
        //    foreach(DataGridViewRow row in dataGridView.Rows)
        //    {
        //        row.Cells[columnIndex].Value = null;
        //    }
        //}

        private void SetDataGridView(DataGridView dataGridView, int row, int cell)
        {
            dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
            dataGridView.BeginEdit(true);
        }
    }
}
