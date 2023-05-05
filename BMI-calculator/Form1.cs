using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(tBLength.Text);
            string lengthstring = Convert.ToString(length);
            MessageBox.Show(lengthstring);
            //double weight = Convert.ToDouble(tBWeight.Text);




        }
    }
}
