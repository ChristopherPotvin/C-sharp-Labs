using CustomerData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristopherPotvin
{
    public static class FileiO // Static classes do not take variables, only constants
    {
        const string path = "customerdata.txt"; // location of the file but it needs to be placed in the bin (debug)

        // writes data from the array to the file
        public static void WriteData (List<Customer>customerData)
        {
            FileStream fs = null;
            StreamWriter sw = null;


            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                // write data
                foreach (Customer a in customerData)
                    sw.WriteLine(a.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while writing to the file: " +
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sw != null) sw.Close(); // also closes fs
            }
        }

        // reads data from the file and puts it in a list, and eturns it

        public static List<Customer> ReadData() // with arrays you don't have to use ref or out unless you are changing the location of the array
        {
            List<Customer> customerData= new List<Customer>();
            FileStream fs = null;
            StreamReader sr = null;
            string line; // for reading 
            string[] fields; // result from splitting the line

            // open the file for reading and read the numbers into a data array 

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read); // if the file did not access you can use open or create, fileacces/read is necessary for streamreader
                sr = new StreamReader(fs); // the stream reader is the necessary method for reading but doesn't specify the path
                while(!sr.EndOfStream) // while there is still data in the file
                {
                    line = sr.ReadLine(); // read the next line
                    fields = line.Split(','); // Split line into fields
                    
                    //Console.WriteLine(fields[0]);
                    //Console.WriteLine(Convert.ToDecimal(fields[1]));
                    //Console.WriteLine(Convert.ToChar(fields[2]));
                    //Console.WriteLine(Convert.ToDecimal(fields[3]));
                    Customer a = new Customer(fields[2], Convert.ToInt32(fields[1]), fields[0]);

                    a.setChargeAmount(Convert.ToDecimal(fields[3]));
                    customerData.Add(a);
                }
            }

            catch(FormatException)
            {
                MessageBox.Show("File contains bad format data. Aborting reading");
            }

            catch(Exception ex)

            {
                MessageBox.Show("Error while reading the file: "
                    + ex.Message, ex.GetType().ToString());
            }

            finally
            {
                // close the file if open
                if (sr != null) sr.Close(); // file stream will close too
            }

            return customerData;

        }
    }
}
