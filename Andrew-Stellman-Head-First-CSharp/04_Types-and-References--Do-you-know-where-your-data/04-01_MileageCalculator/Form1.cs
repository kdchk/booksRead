using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_01_MileageCalculator
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitialiseNumericUpDown();

            bool numericCondition = CheckNumericUpDownValues();

            if (numericCondition == true)
            {
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            InitialiseNumericUpDown();

            bool numericCondition = CheckNumericUpDownValues();

            if (numericCondition == true)
            {
                MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
            }
        }

        private bool CheckNumericUpDownValues()
        {
            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                return true;
            }
            else
            {
                MessageBox.Show("Starting Mileage can't be greater than Ending Mileage!", "Cannot Calculate Mileage");
                return false;
            }
        }

        private void InitialiseNumericUpDown()
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
        }
    }
}
