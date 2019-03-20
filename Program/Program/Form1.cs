using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char znak;  
        private double liczba;
        private bool liczbaIstnieje = false, koniec = false;

        private void plus_Click(object sender, EventArgs e)
        {
            if(liczbaIstnieje == true)
            {
                liczba = double.Parse(pole.Text);
                znak = '+';
                pole.Text = "";
            }
          
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if(liczbaIstnieje == true)
            {
                liczba = double.Parse(pole.Text);
                znak = '-';
                pole.Text = "";
            }
          
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            if(liczbaIstnieje == true)
            {
                liczba = double.Parse(pole.Text);
                znak = '*';
                pole.Text = "";
            }
          
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            if(liczbaIstnieje == true)
            {
                liczba = double.Parse(pole.Text);
                znak = '/';
                pole.Text = "";
            }
          
        }

        private void kropka_Click(object sender, EventArgs e)
        {
            string line_temp = Convert.ToString(liczba);
            double zmienna_double = double.Parse(line_temp, CultureInfo.InvariantCulture.NumberFormat);
            pole.AppendText(",");
        }

        private void b3_Click(object sender, EventArgs e)
        {
            pole.AppendText("3");
            liczbaIstnieje = true;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            pole.AppendText("6");
            liczbaIstnieje = true;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            pole.AppendText("9");
            liczbaIstnieje = true;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            pole.AppendText("8");
            liczbaIstnieje = true;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            pole.AppendText("5");
            liczbaIstnieje = true;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            pole.AppendText("2");
            liczbaIstnieje = true;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            pole.AppendText("0");
            liczbaIstnieje = true;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            pole.AppendText("1");
            liczbaIstnieje = true;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            pole.AppendText("4");
            liczbaIstnieje = true;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            pole.AppendText("7");
            liczbaIstnieje = true;
        }

        private void rowna_Click(object sender, EventArgs e)
        {
            if(liczbaIstnieje = true && koniec == false)
            switch (znak)
            {
                case '+':
                    pole.Text = (liczba + double.Parse(pole.Text)).ToString();
                    liczbaIstnieje = false;
                    koniec = true;
                    break;
                case '-':
                    pole.Text = (liczba - double.Parse(pole.Text)).ToString();
                    liczbaIstnieje = false;
                    koniec = true;
                    break;
                case '*':
                    pole.Text = (liczba * double.Parse(pole.Text)).ToString();
                    liczbaIstnieje = false;
                    koniec = true;
                    break;
                case '/':
                    if (pole.TextLength==1 && pole.Text[0].Equals('0'))
                    {
                        pole.Text = "Nie można dzielić przez zero!";
                        liczbaIstnieje = false;
                        koniec = true;
                        break;
                    }
                    else
                    {
                        pole.Text = (liczba / double.Parse(pole.Text)).ToString();
                        liczbaIstnieje = false;
                        koniec = true;
                        break;
                    }
                default:
                    liczbaIstnieje = false;
                    break;
            }
            
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            pole.Focus();
            pole.Text = "";
        }

        private void cofnij_Click(object sender, EventArgs e)
        {
            pole.Focus();
            int textLength = pole.Text.Length;
            if(textLength > 0)
            {
                pole.Text = pole.Text.Substring(0, textLength - 1);
            }
        }

        private void pole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        //private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    switch (e.KeyChar)
        //    {
        //        //case (char)48:
        //        //    liczba(button11, e);
        //        //    break;
        //        //case (char)49:
        //        //    liczba(button9, e);
        //        //    break;
        //        //case (char)50:
        //        //    liczba(button8, e);
        //        //    break;
        //        //case (char)51:
        //        //    liczba(button7, e);
        //        //    break;
        //        //case (char)52:
        //        //    liczba(button6, e);
        //        //    break;
        //        //case (char)53:
        //        //    liczba(button5, e);
        //        //    break;
        //        //case (char)54:
        //        //    liczba(button4, e);
        //        //    break;
        //        //case (char)55:
        //        //    liczba(button1, e);
        //        //    break;
        //        //case (char)56:
        //        //    liczba(button2, e);
        //        //    break;
        //        //case (char)57:
        //        //    liczba(button3, e);
        //        //    break;
        //        case (char)44:
        //            kropka_Click(liczba, e);
        //            break;
        //        case (char)61:
        //            rowna_Click(liczba, e);
        //            break;
        //        case (char)45:
        //            minus_Click(minus, e);
        //            break;
        //        case (char)47:
        //            dzielenie_Click(dzielenie, e);
        //            break;
        //        case (char)42:
        //            mnozenie_Click(mnozenie, e);
        //            break;
        //        case (char)13:
        //            rowna_Click(rowna, e);
        //            break;
        //        case (char)8:
        //            cofnij_Click(cofnij, e);
        //            break;
        //    }
        //}
    }
}
