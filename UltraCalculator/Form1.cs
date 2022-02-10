using System;
using System.Windows.Forms;

namespace UltraCalculator
{
    public partial class Form1 : Form
    {

        private double input; // Введенное число
        private double value; // Сохраненное число
        private double result; // Результат операции
        private byte opr = 0; // Номер оператора




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void btn_Click(object sender, EventArgs e) // Кнопка цифры
        {
            if( ((Button)sender).Text.Equals(",") && inputBx.Text.Equals(""))
            {

                var text = ((Button)sender).Text; 

                inputBx.Text = $"0{text}";

            }
            else
            {

                var text = ((Button)sender).Text; // ((Button)sender) возвращает нажатую кнопку, поэтому у всех кнопок после клика вызывается этот метод

                inputBx.Text += text;

            }
        }


        private void operator_Click(object sender, EventArgs e) // Кнопка операторов
        {

            switch (((Button)sender).Text) // По тексту кнопки определяет шо це за оператор и присваивает переменной opr его номер*
            {

                case "+": 
                    value = double.Parse(inputBx.Text);
                    opr = 1; // *Вот тут
                    label.Text = $"{inputBx.Text} +";
                    inputBx.Text = "";
                    break;

                case "-": 
                    value = double.Parse(inputBx.Text);
                    opr = 2;
                    label.Text = $"{inputBx.Text} -";
                    inputBx.Text = "";
                    break;

                case "x": 
                    value = double.Parse(inputBx.Text);
                    opr = 3;
                    label.Text = $"{inputBx.Text} *";
                    inputBx.Text = "";
                    break;

                case "/": 
                    value = double.Parse(inputBx.Text);
                    opr = 4;
                    label.Text = $"{inputBx.Text} /";
                    inputBx.Text = "";
                    break;

            }

        }
        private void btnEq_Click(object sender, EventArgs e) // Кнопка Равно
        {
            input = double.Parse(inputBx.Text);
            
            switch (opr)  // Выбор оператора 
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
            opr = 0;

        }

        private void ClearAll(object sender, EventArgs e) // Кнопка Очистить
        {

            inputBx.Text = "";
            label.Text = "";
            input = 0;
            value = 0;
            result = 0;

        }

        private void buttonPM_Click(object sender, EventArgs e)
        {

            if (inputBx.Text.Equals(""))
            {
                return;
            }
            else
            {

               if (!inputBx.Text.Contains("-"))
               {

                    inputBx.Text = "-" + inputBx.Text;

               }
               else if (inputBx.Text.Contains("-"))
               {

                    inputBx.Text = inputBx.Text.Replace("-", "");

               }
               
            }
        }
    }
}
