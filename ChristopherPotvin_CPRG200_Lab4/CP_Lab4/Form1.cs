using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Lab4
{
    public partial class Form1 : Form
    {
        northwndEntities entities = new northwndEntities(); // intstantiate the entity framework

        // defining the objects
        
        List<Order> selectOrder;
        List<Order_Detail> selectOrderDetails;
        List<Order_Detail> getOrderTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var OrderIDs = (from order in entities.Orders
                            orderby order.OrderID
                            select order.OrderID).ToList(); // ToList executes the query, we are retrieving the data here from the entitiy framework

            var orderDetailIDs = (from orderDetails in entities.Order_Details
                                  orderby orderDetails.OrderID
                                  select orderDetails.OrderID).ToList();

            // ToList executs the query for the second data view, order_details

            orderIDComboBox.DataSource = OrderIDs; 
            DisplayOrder();
            
        }

        private void orderIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int orderID = (int)orderIDComboBox.SelectedValue; // the selected order ID
            selectOrder = (from order in entities.Orders
                           where order.OrderID == orderID // for equality because it's LINQ and not SQL it is ==
                           select order).ToList(); // Single executes query single(); because it is only one object

            int detailID = (int)orderIDComboBox.SelectedValue;

            selectOrderDetails = (from orderDetails in entities.Order_Details
                                  where orderDetails.OrderID == detailID
                                  orderby orderDetails.OrderID
                                  select orderDetails).ToList();
            
            // Call the four methods
            GetOrders(orderID); // getting the orderID from the orders data table
            GetOrderDetails(detailID); // getting the orderID from the order details table
            DisplayOrder(); // getting the updated dates from the orderID's
            CheckNull(); // checking to see if the dates are null

            decimal orderTotal = GetOrderTotal(orderID); // summing the orders

            OrderTotaltextBox.Text = orderTotal.ToString("c"); // displaying the total of each order 

        }

        private void GetOrders(int orderID)
        {
            selectOrder = (from order in entities.Orders
                           where order.OrderID == orderID
                           orderby order.OrderID
                           select order).ToList();

            orderDataGridView.DataSource = selectOrder;
        }

        private void GetOrderDetails(int detailID)
        {
            selectOrderDetails = (from orderDetails in entities.Order_Details
                                  where orderDetails.OrderID == detailID
                                  orderby orderDetails.OrderID
                                  select orderDetails).ToList(); // LINQ statement retrieving the data int he order_details table
            
            
            order_DetailDataGridView.DataSource = selectOrderDetails;
        }

        private decimal GetOrderTotal(int orderid) // method for calculating the total of each order depending on the orderID 
        {
            decimal total = 0.0m;

            getOrderTotal = (from orderDetails in entities.Order_Details
                             where orderDetails.OrderID == orderid                         
                             select orderDetails).ToList(); // LINQ statement to gather the unit price, quantity and discount from the order details table

            foreach (Order_Detail od in getOrderTotal) {
                
                total += od.UnitPrice * od.Quantity * (1 - (decimal)od.Discount); // formula for calculating the sum based on the data in the order details table
            }
            
            return total; // return the calculate total 
            
        }

        private void DisplayOrder() // method for updating the ship date, order date, and required date
        {

            foreach (Order item in selectOrder)
            {
                shippedDateTimePicker.Value = item.ShippedDate.Value;
                orderDateTimePicker.Value = item.OrderDate.Value;
                requiredDateTimePicker.Value = item.RequiredDate.Value;
            }
            
        }

        private void CheckNull() // method for checking if the data type is null in the order table against the different dates
        {
            int orderID = (int)orderIDComboBox.SelectedValue; // the selected order ID

            var orderupdate = (from order in entities.Orders
                               where order.OrderID == orderID
                               select order).Single();

            if (orderupdate.ShippedDate == null) // Check to see if the Shipped date is null
            {
                MessageBox.Show("Please enter a valid date to be shipped");
            }

            else if (orderupdate.RequiredDate == null) // check to see if the Required date is null
            {
                MessageBox.Show("Please enter a valid order date");
            }

            else if (orderupdate.OrderDate == null) // check to see if the Order date is null
            {
                MessageBox.Show("Please enter a valid required date");

            }
        }

        private void ValidateShipDate() // method for checking to ensure that the shipped date is before the order date and after the required date
        {
            int orderID = (int)orderIDComboBox.SelectedValue; // the selected order ID
            var orderupdate = (from order in entities.Orders
                               where order.OrderID == orderID
                               select order).Single();

            if (shippedDateTimePicker.Value <= orderDateTimePicker.Value) // Validation to ensure the shipped date cannot be before the order date
            {
                MessageBox.Show("Shipped date must be after the order date!");
            }

            else if (shippedDateTimePicker.Value >= requiredDateTimePicker.Value) // Validation to ensure that the shipped date is after the required date
            {
                MessageBox.Show("Shipped date must be before the required date!");

            }
            else
            {
                orderupdate.ShippedDate = shippedDateTimePicker.Value; // Update the shipped date if it does not conflict with the other dates
            }
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            entities.SaveChanges(); // save the changes made to the shipped date
            ValidateShipDate(); // validate the shipped date on the save button event handler
        }
    }
}
