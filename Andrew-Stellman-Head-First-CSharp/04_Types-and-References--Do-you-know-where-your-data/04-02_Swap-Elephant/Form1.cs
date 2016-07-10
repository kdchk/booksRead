using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_02_Swap_Elephant
{
    public partial class Form1 : Form
    {
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant swapTemp = lucinda;
            lucinda = lloyd;
            lloyd = swapTemp;
            MessageBox.Show("Objects swapped", "Swap!");
        }
    }
}
