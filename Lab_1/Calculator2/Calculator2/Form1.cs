using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                float firstValue = Convert.ToSingle(firstInput.Text);
                float secondValue = Convert.ToSingle(secondInput.Text);
                string sign = signInput.Text;
                var operationB = new System.Data.DataTable().Compute(firstValue + sign + secondValue, "");
                txtAnswer.Text = operationB.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода. Повторите еще раз!");
            }
        }
    }
}
