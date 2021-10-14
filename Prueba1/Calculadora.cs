using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        String operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";

        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";

        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";

        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";

        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";

        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";

        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";

        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";

        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";

        }

        private void btnp_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";

        }

        private void btns_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);

            double sum;
            double res;
            double div;
            double mul;

            switch(operador)
            {
                case "+" :
                    sum = obj.Sumar((primero), (segundo));
                    tbxScreen.Text = sum.ToString();
                    break;

                case "-":
                    res = obj2.Restar((primero), (segundo));
                    tbxScreen.Text = res.ToString();
                    break;

                case "*":
                    mul = obj3.Multiplicar((primero), (segundo));
                    tbxScreen.Text = mul.ToString();
                    break;

                case "/":
                    div = obj4.Dividir((primero), (segundo));
                    tbxScreen.Text = div.ToString();
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }
    }
}