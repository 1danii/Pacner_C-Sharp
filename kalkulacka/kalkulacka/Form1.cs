using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulacka
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        bool prvniSelected = true;

        private void addNumber(int num)
        {
            //label1.Text = Convert.ToString(Convert.ToDouble(label1.Text) + num);
            if (prvniSelected)
            {
                if (label1.Text == "0") label1.Text = "";
                label1.Text = label1.Text + num;
            }
            else
            {
                if (label2.Text == "0") label2.Text = "";
                label2.Text = label2.Text + num;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Clear
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
        }
        
        //Dement si
        //Výpočty
        private void button11_Click(object sender, EventArgs e)
        {
            // +
            label3.Text = Convert.ToString(Math.Round(Convert.ToDouble(label1.Text) + Convert.ToDouble(label2.Text),2));
        }
        private void button12_Click(object sender, EventArgs e)
        {
            // -
            label3.Text = Convert.ToString(Math.Round(Convert.ToDouble(label1.Text) - Convert.ToDouble(label2.Text),2));
        }
        private void button13_Click(object sender, EventArgs e)
        {
            // *
            label3.Text = Convert.ToString(Math.Round(Convert.ToDouble(label1.Text) * Convert.ToDouble(label2.Text),2));
        }
        private void button14_Click(object sender, EventArgs e)
        {
            // /
            label3.Text = Convert.ToString(Math.Round(Convert.ToDouble(label1.Text) / Convert.ToDouble(label2.Text),2));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Další číslo
            prvniSelected = !prvniSelected;
            
            //Selected highlight
            label1.ForeColor = System.Drawing.Color.Black;
            label2.ForeColor = System.Drawing.Color.Black;
            if (prvniSelected)
            {
                label1.ForeColor = System.Drawing.Color.Red;
            }
            else label2.ForeColor = System.Drawing.Color.Red;
        }

        //Přidat číslo
        private void button1_Click(object sender, EventArgs e)
        {
            addNumber(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addNumber(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            addNumber(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            addNumber(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            addNumber(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            addNumber(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            addNumber(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            addNumber(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            addNumber(9);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            addNumber(0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
