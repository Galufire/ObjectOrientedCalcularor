using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b;
        int count;
        bool znak = true;

        private void multiply()
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void devide()
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void plus()
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void minus()
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void sinus()
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = "sin (" + a.ToString() + ")";
            znak = true;
        }

        private void cosinus()
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            label1.Text = "cos (" + a.ToString() + ")";
            znak = true;
        }

        private void zerocheck()        //Проверяет окно на нуль. При его наличие - убирает
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            return;
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + double.Parse(textBox1.Text);
                    break;
                case 2:
                    b = a - double.Parse(textBox1.Text);
                    break;
                case 3:
                    b = a * double.Parse(textBox1.Text);
                    break;
                case 4:
                    b = a / double.Parse(textBox1.Text);
                    break;
                case 5:
                    b = Math.Sin(a);
                    break;
                case 6:
                    b = Math.Cos(a);
                    break;

                default:
                    break;
            }
            textBox1.Text = b.ToString();       //Оптимизировал код(теперь выполняется одним действием после переключателя)
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            zerocheck();                        //Убирает нуль там, где он не нужен
            textBox1.Text = textBox1.Text + 0;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            zerocheck();                        //Убирает нуль там, где он не нужен
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            zerocheck();                        //Убирает нуль там, где он не нужен
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            zerocheck();                        //Убирает нуль там, где он не нужен
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            zerocheck();                        //Убирает нуль там, где он не нужен
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            zerocheck();                        //Убирает нуль там, где он не нужен
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            zerocheck();                        //Убирает нуль там, где он не нужен
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            zerocheck();                        //Убирает нуль там, где он не нужен
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            zerocheck();                        //Убирает нуль там, где он не нужен
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            zerocheck();                        //Убирает нуль там, где он не нужен
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            plus();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            minus();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            multiply();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            devide();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            calculate();
            //label1.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = textBox1.Text + 0;      //Не делает окно пустым(заполняет нулём)
            label1.Text = "";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
            if (textBox1.Text == "")                    //Не делает окно пустым(заполняет нулём)
                textBox1.Text = textBox1.Text + 0;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            sinus();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            cosinus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;       //Заполняет окно нулём
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) //Обработка нажатий клавиш
        {
            if (textBox1.Text == "")
                textBox1.Text = textBox1.Text + 0;
            switch (e.KeyCode)
            {
                case Keys.NumPad0:case Keys.D0:
                    zerocheck();                        //Убирает нуль там, где он не нужен
                    textBox1.Text = textBox1.Text + 0;
                    break;
                case Keys.NumPad1:case Keys.D1:
                    zerocheck();                        //Убирает нуль там, где он не нужен
                    textBox1.Text = textBox1.Text + 1;
                    break;
                case Keys.NumPad2:case Keys.D2:
                    zerocheck();                        //Убирает нуль там, где он не нужен
                    textBox1.Text = textBox1.Text + 2;
                    break;
                case Keys.NumPad3:case Keys.D3:
                    zerocheck();                        //Убирает нуль там, где он не нужен
                    textBox1.Text = textBox1.Text + 3;
                    break;
                case Keys.NumPad4:case Keys.D4:
                    zerocheck();                        //Убирает нуль там, где он не нужен
                    textBox1.Text = textBox1.Text + 4;
                    break;
                case Keys.NumPad5:case Keys.D5:
                    zerocheck();                        //Убирает нуль там, где он не нужен
                    textBox1.Text = textBox1.Text + 5;
                    break;
                case Keys.NumPad6:case Keys.D6:
                    zerocheck();                        //Убирает нуль там, где он не нужен
                    textBox1.Text = textBox1.Text + 6;
                    break;
                case Keys.NumPad7:case Keys.D7:
                    zerocheck();                        //Убирает нуль там, где он не нужен
                    textBox1.Text = textBox1.Text + 7;
                    break;
                case Keys.NumPad8:case Keys.D8:
                    zerocheck();                        //Убирает нуль там, где он не нужен
                    textBox1.Text = textBox1.Text + 8;
                    break;
                case Keys.NumPad9:case Keys.D9:
                    zerocheck();                        //Убирает нуль там, где он не нужен
                    textBox1.Text = textBox1.Text + 9;
                    break;
                case Keys.Add:
                    plus();
                    break;
                case Keys.Multiply:
                    multiply();
                    break;
                case Keys.Divide:
                    devide();
                    break;
                case Keys.Enter:
                    calculate();
                    label1.Text = "";
                    break;
                case Keys.Back:
                    int lenght = textBox1.Text.Length - 1;
                    string text = textBox1.Text;
                    textBox1.Clear();
                    for (int i = 0; i < lenght; i++)
                    {
                        textBox1.Text = textBox1.Text + text[i];
                    }
                    if (textBox1.Text == "")                    //Не делает окно пустым(заполняет нулём)
                        textBox1.Text = textBox1.Text + 0;
                    break;
                case Keys.Delete:
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + 0;      //Не делает окно пустым(заполняет нулём)
                    label1.Text = "";
                    break;
            }
        }
        private void button1_KeyPress(object sender, KeyPressEventArgs e) //Обработка нажатий клавиш
        {
            if (textBox1.Text == "")
                textBox1.Text = textBox1.Text + 0;
            switch (e.KeyChar)
            {
                case 's': case 'ы':
                    sinus();break;
                case 'c': case 'с':
                    cosinus();break;
                case 'x': case 'ч':
                    multiply();break;
                case '/': case 'd': case 'в':
                    devide();break;
                case '-':
                    minus();break;
                case '.':case ',':
                    textBox1.Text = textBox1.Text + ",";break;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
