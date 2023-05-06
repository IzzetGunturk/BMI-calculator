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
            double lengthInCm = Convert.ToDouble(tBLength.Text);
            double lengthInM = lengthInCm / 100; // 100cm = 1m
            double weight = Convert.ToDouble(tBWeight.Text);

            double resultBmi = weight / (lengthInM * lengthInM);
            string resultMessage = resultBmi.ToString("F2");
            labelBmiResult.Text = "BMI result:" + " " + resultMessage;


            if (rBAge.Checked)
            {
                if (resultBmi < 18.5) {
                    labelBmiMeaning.Text = "Underweight";
                }
                else if (resultBmi < 25)
                {
                    labelBmiMeaning.Text = "Healthy weight";
                }
                else if (resultBmi < 30)
                {
                    labelBmiMeaning.Text = "Overweight";
                }
                else
                {
                    labelBmiMeaning.Text = "Obesity";
                }
            }

            if (rBAge2.Checked)
            {
                if (resultBmi < 22)
                {
                    labelBmiMeaning.Text = "Underweight";
                }
                else if (resultBmi < 28)
                {
                    labelBmiMeaning.Text = "Healthy weight";
                }
                else if (resultBmi < 30)
                {
                    labelBmiMeaning.Text = "Overweight";
                }
                else
                {
                    labelBmiMeaning.Text = "Obesity";
                }
            }

        }
    }
}
