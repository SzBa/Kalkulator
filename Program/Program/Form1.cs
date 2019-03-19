using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char znak;  
        double liczba; 


        private void plus_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(pole.Text);
            znak = '+';
            pole.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(pole.Text);
            znak = '-';
            pole.Text = "";
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(pole.Text);
            znak = '*';
            pole.Text = "";
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(pole.Text);
            znak = '/';
            pole.Text = "";
        }

        private void kropka_Click(object sender, EventArgs e)
        {
            pole.AppendText(".");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            pole.AppendText("3");
        }

        private void b6_Click(object sender, EventArgs e)
        {
            pole.AppendText("6");
        }

        private void b9_Click(object sender, EventArgs e)
        {
            pole.AppendText("9");
        }

        private void b8_Click(object sender, EventArgs e)
        {
            pole.AppendText("8");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            pole.AppendText("5");
        }

        private void b2_Click(object sender, EventArgs e)
        {
            pole.AppendText("2");
        }

        private void b0_Click(object sender, EventArgs e)
        {
            pole.AppendText("0");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            pole.AppendText("1");
        }

        private void b4_Click(object sender, EventArgs e)
        {
            pole.AppendText("4");
        }

        private void b7_Click(object sender, EventArgs e)
        {
            pole.AppendText("7");
        }

        private void rowna_Click(object sender, EventArgs e)
        {
            switch (znak)
            {
                case '+':
                    pole.Text = (liczba + double.Parse(pole.Text)).ToString();
                    break;
                case '-':
                    pole.Text = (liczba - double.Parse(pole.Text)).ToString();
                    break;
                case '*':
                    pole.Text = (liczba * double.Parse(pole.Text)).ToString();
                    break;
                case '/':
                    if (pole.TextLength==1 && pole.Text[0].Equals('0'))
                    {
                        pole.Text = "Nie można dzielić przez zero!";
                        break;
                    }
                    else
                    {
                        pole.Text = ((double)liczba / double.Parse(pole.Text)).ToString();
                        break;
                    }
                default:
                    break;
            }
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            pole.Text = "";
        }

        private void cofnij_Click(object sender, EventArgs e)
        {
            int textLength = pole.Text.Length;
            if(textLength > 0)
            {
                pole.Text = pole.Text.Substring(0, textLength - 1);
            }
        }
    }
}
