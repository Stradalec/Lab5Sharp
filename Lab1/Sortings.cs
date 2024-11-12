using NPOI.SS.Formula.Functions;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Sortings : Form, ISortView, IProgressBar
    {
        BackgroundWorker _backgroundWorker = new BackgroundWorker();
        string path = "temporary";
        private double[] savedArray;
        private int _progress = 0;

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
        }

        private void _backgroundWorkerDoWork(object sender, DoWorkEventArgs inputEvent) {
            List <double> list = new List <double>();
            for (int inputIndex = 0; inputIndex < savedArray.Length; ++inputIndex)
            {
                list.Add (savedArray[inputIndex]);
                _progress = GetProgress(inputIndex, savedArray.Length);
                _backgroundWorker.ReportProgress(_progress);
            }
            inputEvent.Result = list;
        }

        private void _backgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs inputEvent)
        {
            List<double> dataList = (List<double>)inputEvent.Result;
            foreach(double data in dataList)
            {
                dataGridView1.Rows.Add(data);
            }
            MessageBox.Show("о");
        }

        private void _backgroundWorkerProgressChanged(object sender, EventArgs inputEvent)
        {
            progressBar1.Value = _progress;
        }


        private int GetProgress(int doneIterations, int allIterations)
        {
            return Convert.ToInt32(doneIterations / Convert.ToDouble(allIterations) * 100);
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
                savedArray = inputArray;
                _backgroundWorker.RunWorkerAsync();
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
            AddData(sender, inputEvent);
        }

        private void toolStripTextBox2_Click(object sender, EventArgs inputEvent)
        {
            Sort(sender, inputEvent);
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
            AddData(sender, inputEvent);
            Sort(sender, inputEvent);
        }
    }
}
