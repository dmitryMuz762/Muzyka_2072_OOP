using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            sign1.Text = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            sign1.Text = "-";
        }

        private void umnozh_Click(object sender, EventArgs e)
        {
            sign1.Text = "*";
        }

        private void delenie_Click(object sender, EventArgs e)
        {
            sign1.Text = ":";
        }

        private void ravno_Click(object sender, EventArgs e)
        {
            bool num_1 = Int32.TryParse(chislitel1.Text, out int Num1);
            bool del_1 = Int32.TryParse(znamenatel1.Text, out int Del1);
            bool num_2 = Int32.TryParse(chislitel2.Text, out int Num2);
            bool del_2 = Int32.TryParse(znamenatel2.Text, out int Del2);

            if (Del1 == 0 || Del2 == 0 || num_1 == false || del_1 == false || num_2 == false || del_2 == false)
            {
                result.Text = "нет результата, не верно введены данные";
                return;
            }

            Rational r1 = new Rational(Num1, Del1);
            Rational r2 = new Rational(Num2, Del2);
            Rational r_result = new Rational();
            if (sign1.Text == "+")
            {
                r_result = r1 + r2;
                r_result.Reduction();
                result.Text = r_result.ToString();
            }
            if (sign1.Text == "-")
            {
                r_result = r1 - r2;
                r_result.Reduction();
                result.Text = r_result.ToString();
            }
            if (sign1.Text == "*")
            {
                r_result = r1 * r2;
                r_result.Reduction();
                result.Text = r_result.ToString();
            }
            if (sign1.Text == ":")
            {
                r_result = r1 / r2;
                r_result.Reduction();
                result.Text = r_result.ToString();
            }
        }
    }
}
