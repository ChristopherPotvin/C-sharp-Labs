using Conversions;
using CustomerData;
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
    /// Date: 1/1/2019
    /// Details: This is a windows form application for the agent that calculates the cost of three different types of customers. The first being residential, followed by commercial and lastly industrial.
    /// The agent is able to select what type of customer category that they wish to caculate using the selection combo box. The input fields are then adjusted to display only
    /// when the customer has selected their respective type. Based on this, their cost is then calculated depending on the flat rate and the kWh rate. 
    /// Form resets when the clear button is clicked, and application exits when the exit button is clicked.
    /// Form validation is added to all of the input fields to require the user to input an amount and a non negative value in the power category.
    /// Further validation on the customer account number and customer name to having a required input and a non-negative number for the account number. 
    /// The sums are then written using the customer class to the customer fileIO text file, and displayed in the list box for the agent to view as they enter each one. 
    /// Account number, customer name, charge amount and customer type are all listed in the list box. 
    /// Furthermore, the number of customers, total sums of all the different types of customers are caculated and dsiplayed for the agent to view it at all times, even at form load, and finally the sum of all carges are displayed. 
    ///
  

    public partial class Form1 : Form
    {
        List<Customer> customerData = new List<Customer>(); // This creates an object of an empty list
        //Initalize the Customer Object via constructor
        Customer CustomerObj;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUser.SelectedIndex == 0 || cmbUser.SelectedIndex == 1) // Visibility for residential and commercial customers
            {
                lblCustName.Visible = true;
                txtCustName.Visible = true;
                lblAcctNumber.Visible = true;
                txtAcctNum.Visible = true;
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
                lblCustName.Visible = true;
                txtCustName.Visible = true;
                lblAcctNumber.Visible = true;
                txtAcctNum.Visible = true;
                lblPowerUsed.Visible = false;
                txtPower.Visible = false;
                lblAmount.Visible = true;
                txtAmount.Visible = true;
                lblPeak.Visible = true;
                txtPeak.Visible = true;
                lblOff.Visible = true;
                txtOff.Visible = true;
            }
        } // Visibility changes when the user cycles through the customer types

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustName.Text = ""; // clears customer name text box
            txtAcctNum.Text = ""; // clears account number text box
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
            lblCustName.Visible = true;
            txtCustName.Visible = true;
            lblAcctNumber.Visible = true;
            txtAcctNum.Visible = true;
            lblPowerUsed.Visible = true;
            txtPower.Visible = true;
            lblAmount.Visible = true;
            txtAmount.Visible = true;
            lblPeak.Visible = false;
            txtPeak.Visible = false;
            lblOff.Visible = false;
            txtOff.Visible = false;


            //DisplayCustomerDataFromFile(customerData); // display the data from the FileiO on form load
            DisplayCustomerDataRealTime();
        }

        private void DisplayCustomerDataFromFile(List<Customer> customerData)
        {
            lstCustomerData.Items.Clear(); // start with empty list box
            // go through the list and add each customer object to the list box
            foreach (Customer a in customerData)
            {
                lstCustomerData.Items.Add(a.ToFileString());

            }
        }

        private void DisplayCustomerDataRealTime () 
        {
            customerData = FileiO.ReadData(); // read the data from the FileiO created by the customer data on form load %%

            // initialize customer lists according to the types of customers
            List<decimal> resTotalSum = new List<decimal>();
            List<decimal> comTotalSum = new List<decimal>();
            List<decimal> indTotalSum = new List<decimal>();

            lstCustomerData.Items.Clear(); // clear the customer data
            foreach (var newcust in customerData)
            {
                lstCustomerData.Items.Add(newcust.ToFileString());

                if (newcust.custType == "R")
                {
                    resTotalSum.Add(newcust.charge_amount);
                }
                else if (newcust.custType == "C")
                {
                    comTotalSum.Add(newcust.charge_amount);
                }
                else
                {
                    indTotalSum.Add(newcust.charge_amount);
                }
            }

            // Display the different total sums for each type of res, com, and ind list

            txtSumRes.Text = Convert.ToString(resTotalSum.Sum().ToString("C"));
            txtSumComm.Text = Convert.ToString(comTotalSum.Sum().ToString("C"));
            txtSumInd.Text = Convert.ToString(indTotalSum.Sum().ToString("C"));

            
            txtNumCust.Text = Convert.ToString(customerData.Count()); // convert the customer data into a number count and display it in the number of customers text box

            // Grand Total for all three types of customers, residential, commercial and industrial
            txtSum.Text = Convert.ToString(customerData.Sum(item => item.charge_amount).ToString("C"));

        }

        private void btnAdd_Click(object sender, EventArgs e) // button for adding customers to the list box 
        {
            // Declare local variables

            decimal power;
            decimal amount;
            decimal peak_power;
            decimal off_power;


            if (cmbUser.SelectedIndex == 0)
            {
                if (Validator.IsRequired(txtCustName, "Customer Name") && Validator.IsRequired(txtAcctNum, "Account Number") && Validator.IsNotANegativeInteger(txtAcctNum, "Account Number") && Validator.IsInputed(txtPower, "Amount") &&
                Validator.IsNonNegativeDecimal(txtPower, "Amount")) // Validation for residential customer requiring them to have their fields inputed and a non negative value

                {
           
                    power = Convert.ToDecimal(txtPower.Text);

                    CustomerObj = new Customer("R", Convert.ToInt32(txtAcctNum.Text), Convert.ToString(txtCustName.Text)); //

                    amount = CustomerObj.CalculateCharge(power);
                    CustomerObj.setChargeAmount(amount);
                    customerData.Add(CustomerObj);
                    txtAmount.Text = amount.ToString("C");

                    FileiO.WriteData(customerData);
                    lstCustomerData.Items.Clear(); // clear the customer data
                    DisplayCustomerDataRealTime(); // display the customer data in real time when the user presses the add button

                    txtCustName.Focus(); //form focus on inputing the customer name
                }
            }

            else if (cmbUser.SelectedIndex == 1) // User selects commercial from the combo box
            {
 
                if (Validator.IsRequired(txtCustName, "Customer Name") && Validator.IsRequired(txtAcctNum, "Account Number") && Validator.IsNotANegativeInteger(txtAcctNum, "Account Number") && Validator.IsInputed(txtPower, "Amount") &&
                    Validator.IsNonNegativeDecimal(txtPower, "Amount")) // validation for commercial customers, requirng them to have their fields inputed and a non negative value 
                {

                    power = Convert.ToDecimal(txtPower.Text);
               
                    CustomerObj = new Customer("C", Convert.ToInt32(txtAcctNum.Text), Convert.ToString(txtCustName.Text)); //

                    amount = CustomerObj.CalculateCharge(power);
                    CustomerObj.setChargeAmount(amount);
                    customerData.Add(CustomerObj);

                    txtAmount.Text = amount.ToString("C");

                    FileiO.WriteData(customerData);

                    DisplayCustomerDataRealTime();

                    txtCustName.Focus(); // form focuses on user inputing customer name

                }
            }

            else
            {
                if (Validator.IsRequired(txtCustName, "Customer Name") && Validator.IsRequired(txtAcctNum, "Account Number") && Validator.IsNotANegativeInteger(txtAcctNum, "Account Number") && Validator.IsInputed(txtPeak, "Peak amount") &&
                Validator.IsNonNegativeDecimal(txtPeak, "Peak amount") &&
                Validator.IsInputed(txtOff, "Off-peak amount") &&
                Validator.IsNonNegativeDecimal(txtOff, "Off-peak amount")) // validation for industrial customers, requirng them to have there fields inputed and a non negative value

                {

                    peak_power = Convert.ToDecimal(txtPeak.Text);
                    off_power = Convert.ToDecimal(txtOff.Text);

                    CustomerObj = new Customer("I", Convert.ToInt32(txtAcctNum.Text), Convert.ToString(txtCustName.Text)); 

                    amount = CustomerObj.CalculateCharge(peak_power, off_power);
                    CustomerObj.setChargeAmount(amount);
                    customerData.Add(CustomerObj);

                    txtAmount.Text = amount.ToString("C");

                    FileiO.WriteData(customerData);
                    lstCustomerData.Items.Clear(); // clear the customer data
                    DisplayCustomerDataRealTime();

                    txtCustName.Focus(); // form focuses on user inputing their customer name 
                }
            }

            

        }
    }
}

