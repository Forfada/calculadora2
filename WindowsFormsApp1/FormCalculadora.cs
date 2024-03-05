using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
  
            lblImparPar.Text = " ";
            lblSinal.Text = "?";
            lblCompara.Text = " ";
            lbl3.Text = " ";

            double a, b, r;

            lblSinal.Text = "+";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);

                r = a + b;

                lblResul.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vc é burro?");
            }
          

                
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblImparPar.Text = " ";
            lblSinal.Text = "?";
            lblCompara.Text = " ";
            lbl3.Text = " ";

            double a, b, r;

            lblSinal.Text = "-";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);

                r = a - b;

                lblResul.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vc é burro?");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            lblResul.Text = " ";
            lblImparPar.Text = " ";
            lblSinal.Text = "?";
            txtn1.Focus();
            lblCompara.Text = " ";
            lbl3.Text = " ";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblImparPar.Text = " ";
            lblSinal.Text = "?";
            lblCompara.Text = " ";
            lbl3.Text = " ";

            double a, b, r;

            lblSinal.Text = "*";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);

                r = a * b;

                lblResul.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vc é burro?");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblImparPar.Text = " ";
            lblSinal.Text = "?";
            lblCompara.Text = " ";
            lbl3.Text = " ";

            double a, b, r;

            lblSinal.Text = "/";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);

                r = a / b;

                lblResul.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vc é burro?");
            }
        }

        private void btnPot_Click(object sender, EventArgs e)
        {
            lblImparPar.Text = " ";
            lblSinal.Text = "?";
            lblCompara.Text = " ";
            lbl3.Text = " ";

            double a, b, r;

            lblSinal.Text = "^";

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);

                r = a * a;

                for(int i=2; i<b; i++)
                {
                    r = r * a;
                }
                

                lblResul.Text = r.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vc é burro?");
            }
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            double a, b, r, r2;

            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);

                r = a % 2;
                if (r == 0)
                {
                    lblImparPar.Text = "O primeiro resultado é par";
                }

                if (r == 1)
                {
                    lblImparPar.Text = "O primeiro resultado é impar";
                }

                r2 = b % 2;
                if (r2 == 0)
                {
                    lbl3.Text = "O segundo resultado é par";
                }

                if (r2 == 1)
                {
                    lbl3.Text = "O segundo resultado é impar";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vc é burro?");
            }
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            
            double a, b;
            
            try
            {
                a = double.Parse(txtn1.Text);
                b = double.Parse(txtn2.Text);

                if (a < b)
                {
                    lblCompara.Text = "O segundo múmero é maior";
                }

                else if (a > b)
                {
                    lblCompara.Text = "O primeiro múmero é maior";
                }

                else if (a == b)
                {
                    lblCompara.Text = "Os números são iguais";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vc é burro?");
            }
        }
    }
 
}
