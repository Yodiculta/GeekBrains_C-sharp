using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.IO;



namespace calculator
{
    public partial class Form1 : Form
    {
        private DialogResult internalDialogResult = DialogResult.None;
        private Stack<int> numbers = new Stack<int>();//0-plus, 1-mult

        Random rand = new Random();
        public DialogResult InternalDialogResult
        {
            get { return internalDialogResult; }
        }

        public Form1()
        {

            int num = rand.Next(1, 40);
            InitializeComponent();
            MessageBox.Show($"Try to reach {num} int minimal count of operations!", "Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            num_lab.Text = num.ToString();
            numbers.Push(-1);
            plus_lab.Text = "0";
            mult_lab.Text = "0";
        }
        private int minimal_count_of_steps(int number)
        {
            int steps = 0;

            while (number > 1)
            {
                steps += minimal_count_of_mult(ref number);
                if (number != 1)
                {
                    number -= 1;
                    steps++;
                }
            }
           
            return steps;

        }
        private int minimal_count_of_mult(ref int number)
        {
            int i = 0;
            while(number%2==0)
            {
                number /= 2;
                i++;
            }
            return i;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                answer_lab.Text = (int.Parse(answer_lab.Text) * 2).ToString();
                mult_lab.Text = (int.Parse(mult_lab.Text) + 1).ToString();
            Check(int.Parse(answer_lab.Text));
            numbers.Push(1);

        }

        private void num_pluses_click(object sender, EventArgs e)
        {
            plus_lab.Text = "0";

        }

        private void num_mult_click(object sender, EventArgs e)
        {
            mult_lab.Text = "0";
        }

        private void play_but_Click(object sender, EventArgs e)
        {
            internalDialogResult = DialogResult.Abort;
            Close();
        }
        private void reset()
        {
            plus_lab.Text = "0";
            mult_lab.Text = "0";
            answer_lab.Text = "1";
            numbers.Clear();
            numbers.Push(-1);
        }
        private void reset_but_Click(object sender, EventArgs e)
        {
            reset();


        }
        private void Check(int num1)
        {
            if (num1 > int.Parse(num_lab.Text))
            {
                MessageBox.Show("Failure!");
                internalDialogResult = DialogResult.No;
                Close();
            }
            if (num1 == int.Parse(num_lab.Text))
            {
                MessageBox.Show("Victory!");
                internalDialogResult = DialogResult.Yes;
                int min_mult = minimal_count_of_steps(int.Parse(num_lab.Text));
                MessageBox.Show($"That is perfect result: {min_mult}\nThat is your result: {int.Parse(mult_lab.Text)+ int.Parse(plus_lab.Text)}");

                if ((MessageBox.Show("To save resutl?", "Victory!", MessageBoxButtons.YesNo))==DialogResult.Yes)
                    {
                    string name = Interaction.InputBox("Your name");
                    FileStream fs = new FileStream(@"C:\Users\Dasha\source\repos\calculator\Properties\The_table_of_winners.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.WriteLine($"{name} won in the fight with {int.Parse(mult_lab.Text) + int.Parse(plus_lab.Text)} in {min_mult}");
                    writer.Close();
                    fs.Close();
                    reset();
                }
                
                Close();
            }

        }

        private void _plusOne_Click(object sender, EventArgs e)
        {
            answer_lab.Text = (int.Parse(answer_lab.Text) +1).ToString();
            plus_lab.Text = (int.Parse(plus_lab.Text) + 1).ToString();
            Check(int.Parse(answer_lab.Text));
            numbers.Push(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            int number = numbers.Pop();
            if (number==-1)
                MessageBox.Show("error");
            if(number==0)
            {
                answer_lab.Text = (int.Parse(answer_lab.Text) - 1).ToString();
                plus_lab.Text = (int.Parse(plus_lab.Text) - 1).ToString();
            }
            if (number == 1)
            {
                answer_lab.Text = (int.Parse(answer_lab.Text) / 2).ToString();
                mult_lab.Text = (int.Parse(mult_lab.Text) - 1).ToString();
            }
        

        }
    }
}
