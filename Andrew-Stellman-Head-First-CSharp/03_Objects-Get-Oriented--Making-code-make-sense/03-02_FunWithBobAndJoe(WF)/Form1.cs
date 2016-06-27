using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_02_FunWithBobAndJoe_WF_
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Joe" };

            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;

            UpdateForm();
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("There is no money in the bank");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            //MyJoeToBobMethod();//ok
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();

        }


        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            //MyBobToJoeMethod();//ok

            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }

        //private void MyJoeToBobMethod()
        //{
        //    if (joe.Cash >= 10)
        //    {
        //        joe.Cash -= bob.ReceiveCash(10);
        //        UpdateForm();
        //    }
        //    else
        //    {
        //        MessageBox.Show("I have not enough money", joe.Name + " says...");
        //    }
        //}

        //private void MyBobToJoeMethod()
        //{
        //    if (bob.Cash >= 10)
        //    {
        //        bob.Cash -= joe.ReceiveCash(10);
        //        UpdateForm();
        //    }
        //    else
        //    {
        //        MessageBox.Show("I have not enough money", bob.Name + " says...");
        //    }
        //}
    }
}
