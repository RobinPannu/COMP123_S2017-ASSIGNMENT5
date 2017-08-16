using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_ASSIGNMENT5
{
/*
* Name: Robin Singh Pannu
* Student ID: 300930741
* Date: August 15th, 2017
* Description: BMI calculator Project.
* Version 0.2:- Printed BMI in result textbox.
*/
    public partial class BMICalculator : Form
    {
        //PRIVATE INSTANCE VARIABLES

        private double _bmiResult;

        //PUBLIC PROPERTIES

        public double BMIResult
        {
            get
            {
                return this._bmiResult;
            }
            set
            {
                this._bmiResult = value;
            }
        }
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ImperialRadioButton.Checked)
            {
                HeightValueLabel.Text = "In";
                WeightValueLabel.Text = "lbs";
                this.BMIResult = ( (Convert.ToDouble(WeightTextBox.Text))* 703) / (Math.Pow(Convert.ToDouble(HeightTextBox.Text),2));
            }

            else if (ImperialRadioButton.Checked)
            {
                HeightValueLabel.Text = "m";
                WeightValueLabel.Text = "kgs";
                this.BMIResult = ((Convert.ToDouble(WeightTextBox.Text)) / (Math.Pow(Convert.ToDouble(HeightTextBox.Text), 2)));
            }
            BMIResultTextBox.Text = Convert.ToString(BMIResult);
        }
    }
}
