using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_test2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num = (int)nudNumber.Value;
            int count = 1;
            

            while (count < (int)nudNumber.Value)
            {
              num = num * (count);

                count++;
            }

            lblFactorial.Text = num.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudNumber.Value = 1;
            lblFactorial.Text = "";
        }
    }
}
