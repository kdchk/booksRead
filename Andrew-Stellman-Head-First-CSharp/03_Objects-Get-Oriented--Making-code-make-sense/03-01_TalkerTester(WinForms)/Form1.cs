using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_01_TalkerTester_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Talker.BlahBlahBlah(textBox1.Text, (int)numericUpDown1.Value);
            len = сountLineFeeds(len);
            MessageBox.Show("The message length is " + len);
        }

        private int сountLineFeeds(int len)
        {
            if (checkBox1.Checked == true)
            {
                //count only textBox1 symbols
                len -= (int)numericUpDown1.Value;
            }

            return len;
        }
    }
}
