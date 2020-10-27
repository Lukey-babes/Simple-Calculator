using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        bool previouslyPressedEquals;
        bool operatorJustPressed;
        bool numberJustPressed;
        string previousOperator = ""; // never set this to "=" because that is registered with the justPressedEquals bool
        float number1 = 0; // this is where the number that was displayed before pressing an operator key is stored
        float number2 = 0;// this is the number we are using to operate against number1 after we press an operator key

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyPress += new KeyPressEventHandler(PressedKey);
            textBox1.Text = "0";
        }

        private void PerformOperation(object sender, EventArgs e)
        {

            Button pressedOperator = sender as Button;

            if(previouslyPressedEquals && numberJustPressed)
            {
                previousOperator = "";
                float.TryParse(textBox1.Text,out number1);
            }

            if (previouslyPressedEquals && pressedOperator.Text != "=")
            {
                previouslyPressedEquals = false;
                previousOperator = pressedOperator.Text;
                operatorJustPressed = true;
                numberJustPressed = false;
                return;
            }

            if (previousOperator == "")
            {
                float.TryParse(textBox1.Text, out number1);
            }

            else
            {

                if (numberJustPressed)
                    float.TryParse(textBox1.Text, out number2);

                switch (previousOperator)
                {
                    case "÷":
                        Divide();
                        break;
                    case "x":
                        Multiply();
                        break;
                    case "+":
                        Add();
                        break;
                    case "-":
                        Subtract();
                        break;
                }
            }

            if (pressedOperator.Text != "=")
            {
                previousOperator = pressedOperator.Text;
            }

            else
            {
                previouslyPressedEquals = true;
            }
            numberJustPressed = false;
            operatorJustPressed = true;
        }



        private void Divide()
        {
            number1 = number1 / number2;
            textBox1.Text = number1.ToString();
        }

        private void Multiply()
        {
            number1 = number1 * number2;
            textBox1.Text = number1.ToString();

        }

        private void Add()
        {
            number1 += number2;
            textBox1.Text = number1.ToString();
        }

        private void Subtract()
        {
            number1 -= number2;
            textBox1.Text = number1.ToString();
        }





        private void InputNumber(object sender, EventArgs e)
        {
            Button pressedNumber = sender as Button;

            if (operatorJustPressed || numberJustPressed == false)
            {
                textBox1.Text = pressedNumber.Text;
            }

            else
            {
                textBox1.Text += pressedNumber.Text;
            }
            operatorJustPressed = false;
            numberJustPressed = true;
        }

        private void Reset(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            previousOperator = "";
            numberJustPressed = false;
            operatorJustPressed = false;
            previouslyPressedEquals = false;
            textBox1.Text = number1.ToString();
        }

        private void PressedKey(object sender, KeyPressEventArgs e)
        {
            Button pressed = digit0;
            // pressed.PerformClick();
            char.TryParse(e.KeyChar.ToString(), out char pressedKey);
            if(e.KeyChar.Equals(Keys.Enter))
            {
                textBox1.Text = "enter";
                return;
            }
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].AccessibleDescription == pressedKey.ToString() ||
                    this.Controls[i].Text == pressedKey.ToString())
                {
                    pressed = this.Controls[i] as Button;
                    pressed.PerformClick();
                    return;
                }
            }
        }

    }
}
