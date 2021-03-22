using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace lab1_true
{
    public partial class Lab1Form : Form
    {
        public Lab1Form()
        {
            InitializeComponent();
        }



        private void ButtonOkay_Click(object sender, EventArgs e)
        {
            if (NumbersCountNumericUpDown.Value > 0) {

                double[] numbers = new double[(int)NumbersCountNumericUpDown.Value];
                for (int i = 0; i < NumbersCountNumericUpDown.Value; i++)
                {
                    while (!double.TryParse(Interaction.InputBox($"Input number {i + 1}", "Enter your number:"), out numbers[i]) && numbers[i] >= 0)
                        MessageBox.Show("Incorrect value!");
                   
                }
                double percent;
                while (!double.TryParse(Interaction.InputBox($"Input percent", "Enter your percent:"), out percent) && percent >= 0)
                    MessageBox.Show("Incorrect percent!");
                GetResult(numbers, percent);
            }
        }

        private void GetResult(double[] numbers, double percent)
        {
            ResultTextBox.Clear();
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 > (numbers[i] - numbers[i]%1) * (percent/100))
                    result += numbers[i] + "; ";
            }
            ResultTextBox.Text = result.Length > 0 ? result.Remove(result.Length - 2) : "No results";
        }
    }
}
