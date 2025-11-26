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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
           
        {
            try
            {
                // Чтение значений через Convert.ToDouble
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);
                double z = Convert.ToDouble(textBoxZ.Text);

                // |x – y|
                double absXY = Math.Abs(x - y);

                // Первая часть формулы
                double numerator = Math.Pow(8 + absXY * absXY + 1, 1.0 / 3.0);
                double denominator = x * x + y * y + 2;
                double part1 = numerator / denominator;

                // Вторая часть формулы
                double part2 = Math.Exp(absXY) * Math.Pow(Math.Tan(z) * Math.Tan(z) + 1, x);

                // Итоговая формула
                double u = part1 - part2;

                textBoxResult.Text = "Результат: " + u;
            }
            catch
            {
                textBoxResult.Text = "Ошибка: введите корректные числовые значения.";
            }
        }

    }
}
}
