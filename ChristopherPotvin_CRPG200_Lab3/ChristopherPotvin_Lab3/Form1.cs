using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// 
/// Author: Chris Potvin
/// Date: 1/10/2019
/// Details: This is a windows form application where a data view is incorporated to connect to a database located on a SQL server. 
/// This application allows the user to add, modify and delete the data in real time. It has 5 instances of different exception handling
/// that prevents the user from adding different formated data than the ones stated for each individual column in the SQL server DB. 
/// Further there is concurrency error that triggers when there are two users modifyng the data in the respective tables in real time. 
/// A word document called "Lab 3 Exception Handling Screenshots" has been attached to view screenshots of the exceptions activating. 
///

namespace ChristopherPotvin_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();

            try
            {
                int supplierID = Convert.ToInt32(productIDTextBox.Text);

                if (supplierID <= -2)
                {
                    MessageBox.Show("Product ID cannot be above -2"); // Format exception stating that the product ID needs to be posiitve and not zero (5)
                }

                else
                {
                    this.productsTableAdapter.Fill(this.northwndDataSet.Products);
                }
            }

            catch (FormatException ex) // Another fomat exception requiring the user to input a whole number and not a type of character (4)
            {
                MessageBox.Show("Product ID must be a whole number " , ex.Message);
                this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            }

            try
            {
                this.productsBindingSource.EndEdit(); // finalize (accept) edited data
                this.tableAdapterManager.UpdateAll(this.northwndDataSet); // 
            }

            catch (OverflowException ex) // An overflow exception in 
            {
                MessageBox.Show("User has entered too much data", ex.Message);
            }

            catch (SqlException) // Exception so the user cannot delete and save the same Customer ID (2)
            {
                MessageBox.Show("User has no permission to delete the data", "Delete Error");
                this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            }

            catch (DBConcurrencyException) // Concurrency Exception activating if a user is in the DB modifying the data while another user is in the application in real time

            {
                MessageBox.Show("Another user has already updated or deleted data, please try again.", "Concurrency Error");
                this.productsTableAdapter.Fill(this.northwndDataSet.Products); // refresh data in the dataset
            }

            try
            {
                Convert.ToDecimal(unitPriceTextBox.Text);
            }

            catch (FormatException ex) // Exception on unit price that it needs to be in decimal format and will not work with a string (3)
            {
                MessageBox.Show("Input data needs to be decimal and the " + ex.Message, ex.GetType().ToString());
                this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'northwndDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northwndDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northwndDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwndDataSet.Categories);
            // TODO: This line of code loads data into the 'northwndDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northwndDataSet.Suppliers);
            // TODO: This line of code loads data into the 'northwndDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwndDataSet.Products);
        }

    }
}

        

     