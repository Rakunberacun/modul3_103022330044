using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace modul3_103022330044
{
    public partial class Form1 : Form
    {
        string angka1;
        string number;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = number + "1";
            textbox1.Text = number;
            textbox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = number + "2";
            textbox1.Text = number;
            textbox1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = number + "3";
            textbox1.Text = number;
            textbox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number = number + "4";
            textbox1.Text = number;
            textbox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number = number + "5";
            textbox1.Text = number;
            textbox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number = number + "6";
            textbox1.Text = number;
            textbox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number = number + "7";
            textbox1.Text = number;
            textbox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number = number + "8";
            textbox1.Text = number;
            textbox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number = number + "9";
            textbox1.Text = number;
            textbox1.Show();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            number = number + "0";
            textbox1.Text = number;
            textbox1.Show();
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            angka1 = textbox1.Text;
            number = "+";
            Console.WriteLine(angka1);
            textbox1.Text = "";
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            int a1 = Int32.Parse(angka1);
            int result = Int32.Parse(number);
            int hasil = a1 + result;
            textbox1.Text = hasil.ToString();
        }
    }
}
