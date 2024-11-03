using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Sortings : Form, ISortView
    {
        public Sortings()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
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

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
