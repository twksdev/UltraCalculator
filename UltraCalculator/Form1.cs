using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraCalculator
{
    public partial class Form1 : Form
    {

        private int input;
        private int value;
        private int result;
        private short opr;
        //private string valueStr;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






        private void btn_Click(object sender, EventArgs e)
        {

            var text = ((Button)sender).Text;
            inputBx.Text += text;
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            input = int.Parse(inputBx.Text);
            
            switch (opr)
            {

                case 1:
                    label.Text = $"{value.ToString()} + {input.ToString()}";
                    result = value + input; 
                    break;
                case 2:
                    label.Text = $"{value.ToString()} - {input.ToString()}";
                    result = value - input;
                    break;
                case 3:
                    label.Text = $"{value.ToString()} * {input.ToString()}";
                    result = value * input;
                    break;
                case 4:
                    label.Text = $"{value.ToString()} / {input.ToString()}";
                    result = value / input;
                    break;

            }

            inputBx.Text = result.ToString();

        }

        private void operator_Click(object sender, EventArgs e)
        {

            switch (((Button)sender).Text) 
            {

                case "+": 
                    value = int.Parse(inputBx.Text);
                    opr = 1;
                    label.Text = $"{inputBx.Text} +";
                    inputBx.Text = "";
                    break;

                case "-": 
                    value = int.Parse(inputBx.Text);
                    opr = 2;
                    label.Text = $"{inputBx.Text} -";
                    inputBx.Text = "";
                    break;

                case "x": 
                    value = int.Parse(inputBx.Text);
                    opr = 3;
                    label.Text = $"{inputBx.Text} *";
                    inputBx.Text = "";
                    break;

                case "/": 
                    value = int.Parse(inputBx.Text);
                    opr = 4;
                    label.Text = $"{inputBx.Text} /";
                    inputBx.Text = "";
                    break;

            }

        }

        private void ClearAll(object sender, EventArgs e)
        {

            inputBx.Text = "";
            label.Text = "";
            input = 0;
            value = 0;
            result = 0;

        }
    }
}
