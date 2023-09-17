using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorials
{
    public partial class frmFactorialCalculator : Form
    {
        public frmFactorialCalculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            UInt64 count = Convert.ToUInt64(NumberTextBox.Text);
            UInt64 factorial = Convert.ToUInt64(NumberTextBox.Text);
            while (count > 1)
            {
                count--;
                factorial = factorial*count;
            }
            FactorialTextBox.Text = factorial.ToString("N0");//Convert.ToString(factorial);
            NumberTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
