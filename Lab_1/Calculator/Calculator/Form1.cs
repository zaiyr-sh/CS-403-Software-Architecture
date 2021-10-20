using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                float firstNumber = Convert.ToSingle(firstInput.Text);
                float secondNumber = Convert.ToSingle(secondInput.Text);
                txtAnswer.Text = (firstNumber - secondNumber).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Введите только числовые значения");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                float firstNumber = Convert.ToSingle(firstInput.Text);
                float secondNumber = Convert.ToSingle(secondInput.Text);
                txtAnswer.Text = (firstNumber / secondNumber).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Введите только числовые значения");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                float firstNumber = Convert.ToSingle(firstInput.Text);
                float secondNumber = Convert.ToSingle(secondInput.Text);
                txtAnswer.Text = (firstNumber + secondNumber).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Введите только числовые значения");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                float firstNumber = Convert.ToSingle(firstInput.Text);
                float secondNumber = Convert.ToSingle(secondInput.Text);
                txtAnswer.Text = (firstNumber * secondNumber).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Введите только числовые значения");
            }
        }
    }
}
