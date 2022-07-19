using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Time_Difference
{
    public partial class TimeDifferenceForm : Form
    {
        private Regex regex;
        public TimeDifferenceForm()
        {
            InitializeComponent();
            regex = new Regex(@"^(\s|[0-9])?[0-9]:[0-5][0-9]$"); //"7:59", " 7:59", "57:59" are valid
            //accepts an optional starting space or a numerical value, requires numerical value, requires
            //numerical value from 0-5, requires numerical value
        }

        private void ClearFields
            (ref MaskedTextBox mask1, ref MaskedTextBox mask2, ref TextBox textbox)
                => mask1.Text = mask2.Text = textbox.Text = "";
        
        private void Calculate(MaskedTextBox mask1, MaskedTextBox mask2, ref TextBox difference)
        {
            if (regex.IsMatch(mask1.Text) && regex.IsMatch(mask2.Text))
            {
                int result = TemporalDifference.BetweenMinutesIntoSeconds(mask1.Text, mask2.Text);

                difference.Text = result.ToString();
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Calculate(maskTime1Line1, maskTime2Line1, ref txtDifference1);         
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            ClearFields(ref maskTime1Line1, ref maskTime2Line1, ref txtDifference1);
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            ClearFields(ref maskTime1Line2, ref maskTime2Line2, ref txtDifference2);
        }

        private void btnClear3_Click(object sender, EventArgs e)
        {
            ClearFields(ref maskTime1Line3, ref maskTime2Line3, ref txtDifference3);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearFields(ref maskTime1Line1, ref maskTime2Line1, ref txtDifference1);
            ClearFields(ref maskTime1Line2, ref maskTime2Line2, ref txtDifference2);
            ClearFields(ref maskTime1Line3, ref maskTime2Line3, ref txtDifference3);

            txtSum.Text = "";
        }

        private void btnCalculate2_Click(object sender, EventArgs e)
        {
            Calculate(maskTime1Line2, maskTime2Line2, ref txtDifference2);
        }

        private void btnCalculate3_Click(object sender, EventArgs e)
        {
            Calculate(maskTime1Line3, maskTime2Line3, ref txtDifference3);
        }

        private void btnTotalCalculation_Click(object sender, EventArgs e)
        {
            int sum = 0;
            //textboxes will always be empty or some number
            if (!string.IsNullOrEmpty(txtDifference1.Text))
                sum += Convert.ToInt32(txtDifference1.Text);

            if (!string.IsNullOrEmpty(txtDifference2.Text))
                sum += Convert.ToInt32(txtDifference2.Text);

            if (!string.IsNullOrEmpty(txtDifference3.Text))
                sum += Convert.ToInt32(txtDifference3.Text);

            txtSum.Text = sum.ToString();
        }
    }
}
