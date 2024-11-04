using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        (bool, bool, bool, bool, bool, double) ISortView.AddSort()
        {
            bool isBubbleActive = false;
            bool isInsertsActive = false;
            bool isFastActive = false;
            bool isShakeActive = false;
            bool isSwampActive = false;
            double swampIterations = 1000;

            if (bubble.Checked)
            {
                isBubbleActive = true;
            }
            if (inserts.Checked)
            {
                isInsertsActive = true;
            }
            if (fast.Checked)
            {
                isFastActive = true;
            }
            if (shake.Checked)
            {
                isShakeActive = true;
            }
            if (swamp.Checked)
            {
                isSwampActive = true;
                if (iterationsSwamp.Text.Length > 0)
                {
                    swampIterations = Convert.ToDouble(iterationsSwamp.Text);
                }
            }

            return (isBubbleActive, isInsertsActive, isFastActive, isShakeActive, isSwampActive, swampIterations);
        }

        public event EventHandler<EventArgs> AddData;
        public event EventHandler<EventArgs> Sort;

        private void toolStripTextBox1_Click(object sender, EventArgs inputEvent)
        {
            
            AddData(sender, inputEvent);
        }

        private void toolStripTextBox2_Click(object sender, EventArgs inputEvent)
        {

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

        //private void ResetDataGridView(DataGridView dataGridView)
        //{
        //    dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
        //    dataGridView.BeginEdit(true);
        //}
    }
}
