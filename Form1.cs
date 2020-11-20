using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_6;

namespace Практическая_работа__6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка Справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Алешина Дарья гр.ИСП-31" +
               "Вариант 6" +
               "Использовать класс Triad (тройка положительных чисел)." +
               " Разработать операции определения равенства / неравенства чисел true / false." +
               " Разработать операции проверки полного равенства / неравенства чисел в триадах(a1, b1, c1) == (a2, b2, c2).");
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Создание объекта triada
        private Triad triada1 = new Triad();
        private Triad triada2 = new Triad();

        //Кнопка Заполнить
        private void button1_Click(object sender, EventArgs e)
        {
            triada1.Random();
            triada2.Random();
            textBox1.Text = triada1.num1.ToString();
            textBox2.Text = triada1.num2.ToString();
            textBox3.Text = triada1.num3.ToString();
            textBox9.Text = triada2.num4.ToString();
            textBox8.Text = triada2.num5.ToString();
            textBox7.Text = triada2.num6.ToString();
        }

        //Кнопка Расчитать
        private void button2_Click(object sender, EventArgs e)
        {
            triada1.Summ();
            textBox4.Text = triada1.Summ().ToString();
        }

        //Начальные значения
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = triada1.num1.ToString();
            textBox2.Text = triada1.num2.ToString();
            textBox3.Text = triada1.num3.ToString();
            textBox9.Text = triada2.num4.ToString();
            textBox8.Text = triada2.num5.ToString();
            textBox7.Text = triada2.num6.ToString();
        }

        //Кнопка Очистить
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
        }

        //Кнопка Задать для первого числа
        private void button3_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int n1))
            {
                if (n1 >= 0)
                {
                    triada1.num1 = n1;
                    textBox1.Text = triada1.num1.ToString();
                }
                else
                {
                    MessageBox.Show("Число должно быть положительным");
                }

            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }

        //Кнопка Задать для второго числа
        private void button4_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox2.Text, out int n2))
            {
                if (n2 >= 0)
                {
                    triada1.num2 = n2;
                    textBox2.Text = triada1.num2.ToString();
                }
                else
                {
                    MessageBox.Show("Число должно быть положительным");
                }
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }

        //Кнопка Задать для третьего числа
        private void button5_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox3.Text, out int n3))
            {
                if (n3 >= 0)
                {
                    triada1.num3 = n3;
                    textBox3.Text = triada1.num3.ToString();
                }
                else
                {
                    MessageBox.Show("Число должно быть положительным");
                }
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }

        //Кнопка Задать все
        private void button6_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox5.Text, out int a))
            {
                triada1.SetParams(a);
                triada2.SetParams(a);
                textBox1.Text = triada1.num1.ToString();
                textBox2.Text = triada1.num2.ToString();
                textBox3.Text = triada1.num3.ToString();
                textBox9.Text = triada2.num4.ToString();
                textBox8.Text = triada2.num5.ToString();
                textBox7.Text = triada2.num6.ToString();
            }
            else
            {
                MessageBox.Show("Число задано неправильно");
            }
        }

        //Кнопка Увеличить
        private void button7_Click(object sender, EventArgs e)
        {
                int a1 = Convert.ToInt32(textBox6.Text);
                int a2 = Convert.ToInt32(textBox10.Text);
                int a3 = Convert.ToInt32(textBox11.Text);
                int a4 = Convert.ToInt32(textBox12.Text);
                int a5 = Convert.ToInt32(textBox13.Text);
                int a6 = Convert.ToInt32(textBox14.Text);
                triada1.SetParams(a1, a2, a3, a4, a5, a6);
                triada2.SetParams(a1, a2, a3, a4, a5, a6);
                textBox1.Text = triada1.num1.ToString();
                textBox2.Text = triada1.num2.ToString();
                textBox3.Text = triada1.num3.ToString();
                textBox9.Text = triada2.num4.ToString();
                textBox8.Text = triada2.num5.ToString();
                textBox7.Text = triada2.num6.ToString();
        }

        //Кнопка Сравнить
        private void button11_Click(object sender, EventArgs e)
        {

            if (triada1)
            {
                 MessageBox.Show("Числа первой триады равны");
            }
            else
            {
                MessageBox.Show("Числа первой триады неравны");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (triada1==triada2)
            {
                MessageBox.Show("Числа первой триады равны числам второй триады");
            }
            else
            {
                MessageBox.Show("Числа первой триады неравны числам второй триады");
            }
        }
    }
}
