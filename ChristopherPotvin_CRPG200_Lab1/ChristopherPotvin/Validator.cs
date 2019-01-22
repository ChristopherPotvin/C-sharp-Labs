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
        public static bool IsInputed(TextBox tb, string name)
        {
            bool result = true;
            if (tb.Text == "") // If the text box is empty, validate
            {
                result = false;
                MessageBox.Show(name + " for power used is required!", "Data field needs to be filled out"); // Messages that are shown during the residential validation
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
                MessageBox.Show(name + " for power cannot be a negative value!", "Data field needs to be filled out"); // Messages that are shown during the commercial validation
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
    }
}
