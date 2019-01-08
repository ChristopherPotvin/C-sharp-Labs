using Conversions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristopherPotvin
    
{
    /// 
    /// Author: Chris Potvin
    /// Date: 12/6/2018
    /// Details: This windows form application that calculates the cost of three different types of customers. The first being residential, followed by commercial and lastly industrial.
    /// The customer is able to select what type of customer category that they fall into using the selection box. The input fields are then adjusted to display only
    /// when the customer has selected their respective type. Based on this, their cost is then calculated depending on the flat rate and the kWh rate. 
    /// Form resets when the clear button is clicked, and application exits when the exit button is clicked.
    /// Form validation is added to all of the input fields to require the user to input an amount and a non negative value. 
    /// 

    public partial class Form1 : Form
    {
        //Declare Constants

        const decimal res_rate = 6; // flat rate constant for residential
        const double res_kwh = 0.052; // kWh rate for residential
        const decimal com_rate = 60; // flat rate for commercial
        const double com_kwh = 0.045; // kwh rate for commercial after 1000 kwh
        const decimal ind_peak_rate = 76; // flat rate for industrial during peak hours before 1000 kwh
        const double ind_peak_kwh = 0.065; // kwh for industrial during peak hours after 1000 kwh
        const decimal ind_off_rate = 40; // flat rate for industrial during non-peak hours before 1000 kwh
        const double ind_off_kwh = 0.028; // kwh for industrial during non-peak hours after 1000 kwh
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare local variables

            decimal power;
            decimal amount;
            decimal peak_power;
            decimal off_power;

            // User selects the type of customer they are from the combo box <start>

            if (cmbUser.SelectedIndex == 0) // User selects residential from the combo box
            {

                if (Validator.IsInputed(txtPower, "Amount") &&
                    Validator.IsNonNegativeDecimal(txtPower, "Amount")) // validation for residential customers, requirng them to have there fields inputed and a non negative value

                {
                    power = Convert.ToDecimal(txtPower.Text);
                    amount = InputRes(power);
                    txtAmount.Text = amount.ToString("c");
                    txtPower.Focus(); //form focuses on user inputing power
                }

            }


            else if (cmbUser.SelectedIndex == 1) // User selects commercial from the combo box
            {
                if (Validator.IsInputed(txtPower, "Amount") &&
                    Validator.IsNonNegativeDecimal(txtPower, "Amount")) // validation for commercial customers, requirng them to have there fields inputed and a non negative value
                {
                    power = Convert.ToDecimal(txtPower.Text);
                    amount = InputCom(power);
                    txtAmount.Text = amount.ToString("c");
                    txtPower.Focus(); // form focuses on user inputing power
                }

            }

            else // User selects industrial from the combo box
            {
                if (Validator.IsInputed(txtPeak, "Peak amount") &&
                    Validator.IsNonNegativeDecimal(txtPeak, "Peak amount") &&
                    Validator.IsInputed(txtOff, "Off-peak amount") &&
                    Validator.IsNonNegativeDecimal(txtOff, "Off-peak amount")) // validation for industrial customers, requirng them to have there fields inputed and a non negative value
                {
                    peak_power = Convert.ToDecimal(txtPeak.Text); 
                    off_power = Convert.ToDecimal(txtOff.Text); 
                    amount = InputInd(peak_power, off_power);
                    txtAmount.Text = amount.ToString("c");
                    txtPeak.Focus(); // form focuses on user inputing peak power 
                }
            }

        }

        private decimal InputRes (decimal power) // method for residential customers
        {
            decimal amount = 0;

            if (power == 0)
            {
                amount = res_rate; // flat rate cost for residential 
            }

            else

            {
                amount = res_rate + ((power) * (decimal)(res_kwh)); // cost for residential customers < 1000 kwh
            }
        
            return amount;
        }

        private decimal InputCom (decimal power) // method for commercial customers
        {
            decimal amount = 0;

            if (power == 0 || power < 1000)
            {
                amount = com_rate; // flat rate for commercial customers < 1000 kwh
            }
            else
            {
                amount = com_rate + ((power - 1000) * (decimal)(com_kwh)); // cost for commercial customers > 1000 kwh
            }

            return amount;
        }

        private decimal InputInd (decimal peak_power, decimal off_power) // method for industrial customers
        {
            decimal amount = 0;
            decimal peak_amount = 0;
            decimal off_amount = 0;

            {
                if (peak_power <= 1000)
                {
                    peak_amount = ind_peak_rate; // flat rate for industrial off peak hours
                }

                else 
                {
                    peak_amount = (ind_peak_rate + ((peak_power - 1000) * (decimal)(ind_peak_kwh)));  // amount after 1000 kwh for industrial peak
                }


                if (off_power <= 1000)
                {
                    off_amount = ind_off_rate; // flat rate for industrial peak hours
                }
               
                else
                {
                    off_amount = (ind_off_rate + ((off_power - 1000) * (decimal)(ind_off_kwh))); // amount after 1000 kwh for industrial off peak
                }

                amount = peak_amount + off_amount; 
                return amount;
            }
        }

 
        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex == 0 || cmbUser.SelectedIndex == 1) // Visibility for residential and commercial customers
            {
                lblPowerUsed.Visible = true;
                txtPower.Visible = true;
                lblAmount.Visible = true;
                txtAmount.Visible = true;
                lblPeak.Visible = false;
                txtPeak.Visible = false;
                lblOff.Visible = false;
                txtOff.Visible = false;
            }

            else //  Visibility for industrial customers

            {
                lblPowerUsed.Visible = false;
                txtPower.Visible = false;
                lblAmount.Visible = true;
                txtAmount.Visible = true;
                lblPeak.Visible = true;
                txtPeak.Visible = true;
                lblOff.Visible = true;
                txtOff.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPower.Text = ""; // clears power text box
            txtAmount.Text = ""; // clears amount text box
            txtPeak.Text = ""; // clears peak power text box
            txtOff.Text = ""; // clears off peak power text box

            txtPower.Focus(); // focuses back on the power text box after you clear
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close button for the application 
        }

        private void Form1_Load(object sender, EventArgs e) // Form loads on Residential 
        {
            // selection box set to residential as default

            cmbUser.SelectedIndex = 0;

            // Visibility set to residential as default

            lblPowerUsed.Visible = true;
            txtPower.Visible = true;
            lblAmount.Visible = true;
            txtAmount.Visible = true;
            lblPeak.Visible = false;
            txtPeak.Visible = false;
            lblOff.Visible = false;
            txtOff.Visible = false;
        }
    }
}
