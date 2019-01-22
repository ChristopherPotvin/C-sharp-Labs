using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public static class Validator
    {
        // tests if  a text box is not empty (required fields)
        public static bool IsInputed(TextBox tb, string name) // validates that the power text boxes are not empty
        {
            bool result = true;
            if (tb.Text == "") // If the text box is empty, validate
            {
                result = false;
                MessageBox.Show(name + " for power used is required!", "Data field needs to be filled out"); // Messagebox that are is shown during the residential/commercial/industrial validation
                tb.Focus();
            }
            return result;
        }

        // tests if input is a non-negative decimal
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool result = true;

            decimal num; // The number being parsed

            if (!decimal.TryParse(tb.Text, out num)) // If the value is not a positive decimal
            {
                result = false;
                MessageBox.Show(name + " for power cannot be a negative value!", "Data field needs to be filled out"); // Messagebox that is shown during the the residential/commercial/industrial validation to make sure that the power entered is not negative
                tb.SelectAll(); // Selects all the text in the box
                tb.Focus(); // Focuses on that particular text box 
            }
            else //Checks that the value is not a non-negative decimal
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data field needs to be a non-negative");
                    tb.SelectAll(); // Selects all the text in the box
                    tb.Focus();  // Focuses on that particular text box
                }
            }

            return result;
        }

        public static bool IsRequired (TextBox tb, string name) // Requires the user to input a Customer Name and Account Number
        {
            bool result = true;
            if (tb.Text == "") // If the text box is empty, validate
            {
                result = false;
                MessageBox.Show(name + " is required!", "Data field needs to be filled out"); // Messagebox that are shown during the residential/commercial/industrial validation
                tb.Focus();
            }
            return result;
        }

        public static bool IsNotANegativeInteger(TextBox tb, string name) // Validation that makes sure that the account number is a positive 
        {
            bool result = true;

            Int32 num; // The number being parsed

            if (!Int32.TryParse(tb.Text, out num)) // If the value is not a positive decimal
            {
                result = false;
                MessageBox.Show(name + " needs to be a number!", "Data field needs to be a integer"); // Messages that are shown during the residential/commercial/industrial validation
                tb.SelectAll(); // Selects all the text in the box
                tb.Focus(); // Focuses on that particular text box 
            }
            else //Checks that the value is not a non-negative decimal
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive!", "Data field needs to be a non-negative");
                    tb.SelectAll(); // Selects all the text in the box
                    tb.Focus();  // Focuses on that particular text box
                }
            }

            return result;
        }
    }
}
