using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ricot_Calculator_Design
{
    public partial class Form1 : Form
    {
        OperatorClass calc = new OperatorClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if((output.Text == "0")||(calc.Oper_press))
            {
                output.Clear();
            }

            Button button = (Button)sender;
            output.Text = output.Text + button.Text;
            calc.Oper_press = false;
        }

        private void button_clear(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void op_pres(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calc.Text = button.Text;
            calc.Val = Double.Parse(output.Text);
            calc.Oper_press = true;
        }

        private void op_res(object sender, EventArgs e)
        {
            calc.Calc2 = output.Text;
            switch (calc.Text)
            {
                case "+":
                    calc.Add();
                    output.Text = calc.Calc2;
                    break;
                case "-":
                    calc.Subtract();
                    output.Text = calc.Calc2;
                    break;
                case "/":
                    calc.Division();
                    output.Text = calc.Calc2;
                    break;
                case "*":
                    calc.Multiply();
                    output.Text = calc.Calc2;
                    break;
                default:
                    break;
            }
            calc.Oper_press = false;
        }

        private void c_pres(object sender, EventArgs e)
        {
            output.Clear();
            calc.Val = 0;
        }
    }
}
