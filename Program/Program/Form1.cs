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
        private double liczba=0.0;
        private bool liczbaIstnieje = false, przecinek = false;

        private void plus_Click(object sender, EventArgs e)
        {
            if(liczbaIstnieje == true)
            {
                liczba = double.Parse(pole.Text);
                znak = '+';
                pole.Text = "";
                blokowanieZnakow();
            }
          
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if(liczbaIstnieje == true)
            {
                liczba = double.Parse(pole.Text);
                znak = '-';
                pole.Text = "";
                blokowanieZnakow();
            }
            else
            {
                pole.AppendText("-");
            }
          
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            if(liczbaIstnieje == true)
            {
                liczba = double.Parse(pole.Text);
                znak = '*';
                pole.Text = "";
                blokowanieZnakow();
            }
          
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            if(liczbaIstnieje == true)
            {
                liczba = double.Parse(pole.Text);
                znak = '/';
                pole.Text = "";
                blokowanieZnakow();
            }
          
        }

        private void kropka_Click(object sender, EventArgs e)
        {
            if(przecinek == false)
            {
                string line_temp = Convert.ToString(liczba);
                double zmienna_double = double.Parse(line_temp, CultureInfo.InvariantCulture.NumberFormat);
                if(pole.Text == "")
                {
                    pole.AppendText("0,");
                }
                else if (pole.Text != "")
                {
                    pole.AppendText(",");
                }
                przecinek = true;
            }

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
            if(liczbaIstnieje == true)
            switch (znak)
            {
                case '+':
                    pole.Text = (liczba + double.Parse(pole.Text)).ToString();
                    liczbaIstnieje = false;
                    guziki();
                    break;
                case '-':
                    pole.Text = (liczba - double.Parse(pole.Text)).ToString();
                    liczbaIstnieje = false;
                    guziki();
                    break;
                case '*':
                    pole.Text = (liczba * double.Parse(pole.Text)).ToString();
                    liczbaIstnieje = false;
                    guziki();
                    break;
                case '/':
                    if (pole.TextLength==1 && pole.Text[0].Equals('0'))
                    {
                        pole.Text = "Nie można dzielić przez zero!";
                    }
                    else
                    {
                        pole.Text = (liczba / double.Parse(pole.Text)).ToString();
                    }
                    liczbaIstnieje = false;
                    guziki();
                    break;
                }
            
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            pole.Text = "";
            guzikiOn();
            liczba = 0.0;
        }

        private void cofnij_Click(object sender, EventArgs e)
        {
            int textLength = pole.Text.Length;
            if(textLength > 0)
            {
                pole.Text = pole.Text.Substring(0, textLength - 1);
            }
        }

        //private void pole_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsNumber(e.KeyChar) && e.KeyChar != ',')
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void blokowanieZnakow()
        {
            plus.Enabled = false;
            minus.Enabled = false;
            mnozenie.Enabled = false;
            dzielenie.Enabled = false;
            przecinek = false;
        }
        
        private void guziki()
        {
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
            b0.Enabled = false;
            blokowanieZnakow();
            kropka.Enabled = false;
            cofnij.Enabled = false;
            rowna.Enabled = false;
        }
        private void guzikiOn()
        {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            b0.Enabled = true;
            plus.Enabled = true;
            minus.Enabled = true;
            mnozenie.Enabled = true;
            dzielenie.Enabled = true;
            kropka.Enabled = true;
            cofnij.Enabled = true;
            rowna.Enabled = true;
        }
    }
}
