using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Number
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            var rand = new Random();
            int number = rand.Next(10, 200);
            number_l.Visible = false;
            number_l.Text = number.ToString();
            //MessageBox.Show(int.Parse(count_lab.Text).ToString());

        }
        private int Checking(int num)
        {
            int num_real = int.Parse(number_l.Text);
            if (num_real > num)
            {
                inf_lab.Text = "It's more";
                return 0;
            }
            if (num_real < num)
            {
                inf_lab.Text = "It's less";
                return 0;
            }
            if (num_real == num)
            {
                inf_lab.Text = "Yes! It is";
                return 1;
            }
            return -1;

        }

        private void check_but_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tb.Text);
            count_lab.Text = (int.Parse(count_lab.Text) + 1).ToString();
            if (Checking(num)==1)
            {
                MessageBox.Show($"you made {int.Parse(count_lab.Text)} steps to find number", "Yees!");
            }

        }
    }
}
