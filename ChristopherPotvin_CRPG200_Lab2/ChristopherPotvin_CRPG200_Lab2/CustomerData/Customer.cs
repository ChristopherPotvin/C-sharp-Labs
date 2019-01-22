using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{

    public class Customer // customer class for displaying and writing customer information such as customer name, account number, 
        // customer type and the charge amount of each type of customers along with the methods to calculate all three types of customers
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

        //Declare the local variables

        private Int32 acctnum;
        public decimal charge_amount;
   
      
        public string CustomerName { get; set; } // getting and setting the customer name

        public Int32 AccountNumber // getting and setting the account number
        {
            get { return acctnum; }
            set
            {
                if (value >= 0) { acctnum = value; }
            }
        }

        public string custType { get; set; } // getting and setting the customer type,hard coded for each one in the Form1.cs, "R", "C", and "I"

        public Customer(string customerType, Int32 accountNumber = 0, string customerName = "Unknown") // The custom constructor passing three arguments or parametres to the fileiO.cs and Form1.cs
        {
            this.AccountNumber = accountNumber;
            this.CustomerName = customerName;
            this.custType = customerType;
        }

        // Methods below tested with 10 individual unit tests in the CustomerTests.cs

        public decimal CalculateCharge (decimal power) // Calculate charge method for customer class
        {
     
            decimal amount = 0m;

            if (this.custType == "R")
            {
                if (power == 0)
                {
                    amount = res_rate; // flat rate cost for residential customers when power < 1000 kwh
                }

                else

                {
                    amount = res_rate + ((power) * (decimal)(res_kwh)); // cost for residential customers < 1000 kwh
                }

                return amount;

            }
            else if (this.custType == "C")
            {
                if (power == 0 || power < 1000)
                {
                    amount = com_rate; // flat rate for commercial customers when power < 1000 kwh
                }
                else if (power > 1000)
                {
                    amount = com_rate + ((power - 1000) * (decimal)(com_kwh)); // cost for commercial customers > 1000 kwh
                }

                return amount;
            }
            else
            {
                return amount;
            }
        }

        public decimal CalculateCharge (decimal peak_power, decimal off_power) // calculate charge method for industrial customer class

        {
            decimal amount = 0;
            decimal peak_amount = 0;
            decimal off_amount = 0;

            if (this.custType == "I")
            {
                if (peak_power <= 1000 && off_power <= 1000)
                {
                    peak_amount = ind_peak_rate; // flat rate for industrial peak hours
                    off_amount = ind_off_rate; // flat rate for industrial off peak hours
                }

                else if (peak_power <= 1000 && off_power > 1000)
                {
                    peak_amount = ind_peak_rate; // flat rate for industrial peak hours
                    off_amount = (ind_off_rate + ((off_power - 1000) * (decimal)(ind_off_kwh))); // charged amount after 1000 kwh for industrial off peak 
                }

                else if (off_power <= 1000 && peak_power > 1000)
                {
                    off_amount = ind_off_rate; // flat rate for industrial off peak hours
                    peak_amount = (ind_peak_rate + ((peak_power - 1000) * (decimal)(ind_peak_kwh))); // charged amount after 1000 kwh for industrial peak
                }          

                else if (peak_power > 1000 && off_power > 1000)
                {
                    peak_amount = (ind_peak_rate + ((peak_power - 1000) * (decimal)(ind_peak_kwh)));  // amount after 1000 kwh for industrial peak
                    off_amount = (ind_off_rate + ((off_power - 1000) * (decimal)(ind_off_kwh))); // amount after 1000 kwh for industrial off peak 
                }
            
                amount = peak_amount + off_amount;
                return amount;
            }

            else
            {
                return amount;
            }

        }


        public decimal setChargeAmount(decimal charged) { return this.charge_amount = charged; }

        public override string ToString() // to string that displays the information below to the text file customerdata.txt
        {
            return this.CustomerName + "," + AccountNumber.ToString() + "," + this.custType +
                "," + this.charge_amount.ToString();
        }

        public string ToFileString()  // to string that displays the information below to list box in the main form
        {
            return "Customer: " + this.CustomerName + "  Account Number: " + AccountNumber.ToString() + "  Customer Type: " + this.custType + "  Charge Amount: " + this.charge_amount.ToString("c");

        }

    }

}
