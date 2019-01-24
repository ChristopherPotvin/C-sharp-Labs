using CustomerData;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ChristopherPotvin_CPRG200_Lab2.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        // Unit test for Residential customer input when the add button is clicked
        public void CalculateResidential_WhenCalledWithTheAddButton_ExpectedWhenPowerIsEqualToZero() 
        {
            // Arrange
            Customer residentialTest = new Customer("R", 1234, "Jerry"); // This object is created to simulate user inputing new customer information from the customer class
            decimal testPower = 0m; // power = 0
            decimal expectedChargeRate = 6m; // flat rate charge when test power = 0

            // Act
            var result = residentialTest.CalculateCharge(testPower);

            // Assert
            Assert.AreEqual(expectedChargeRate, result);

        }

        [TestMethod]
        // Unit test for Residential customer input when the add button is clicked
        public void CalculateResidential_WhenCalledWithTheAddButton_ExpectedWhenPowerIsGreaterThan1000()
        {
            // Arrange

            Customer residentialTest = new Customer("R", 1234, "Jerry"); // This object is created to simulate the user inputing new customer information for residential type when the power is greater than 1000
            decimal testPower = 1001m; // power > 1000
            decimal expectedChargeRate = 58.052m; // expected charge rate when test power = 1001 with the following equation ; amount = res_rate + ((power) * (decimal)(res_kwh));

            // Act

            var result = residentialTest.CalculateCharge(testPower);

            // Assert
            Assert.AreEqual(expectedChargeRate, result);
        }

        [TestMethod]
        // Unit test for Commercial customer input when the add button is clicked
        public void CalculateCommercial_WhenCalledWithTheAddButton_ExpectedWhenPowerIsEqualToZero() 
        {
            // Arrange
            Customer commercialTest = new Customer("C", 4321, "John"); // This object is created to simulate the user inputing new customer information for industrial type when the power is equal to zero
            decimal testPower = 0m; // power = 0
            decimal expectedChargeRate = 60m; // flat rate charge for industrial customer when test power = 0

            // Act
            var result = commercialTest.CalculateCharge(testPower);

            // Assert
            Assert.AreEqual(expectedChargeRate, result);
        }

        [TestMethod]
        // Unit test for Commercial customer input when the add button is clicked
        
        public void CalculateCommercial_WhenCalledWithTheAddButton_ExpectedWhenPowerIsLessThan1000()
        {
            // Arrange
            Customer commercialTest = new Customer("C", 4321, "John"); // This object is created to simulate the user inputing new customer information for industrial type when the power is equal to zero
            decimal testPower = 500m; // power < 1000
            decimal expectedChargeRate = 60m; // flat rate charge for industrial customer when test power = 0

            // Act
            var result = commercialTest.CalculateCharge(testPower);

            // Assert
            Assert.AreEqual(expectedChargeRate, result);

        }

        [TestMethod]
        // Unit test for Commercial customer input when the add button is clicked
        public void CalculateCommercial_WhenCalledWithTheAddButton_ExpectedWhenPowerIsGreaterThan1000() 
        {
            // Arrange
            Customer commercialTest = new Customer("C", 4321, "John"); // This object is created to simulate the user inputing new customer information for industrial type when the power is equal to zero
            decimal testPower = 1001m; // power > 1000
            decimal expectedChargeRate = 60.045m; //  expected charge rate when test power = 1001 with the following equation; amount = com_rate + ((power - 1000) * (decimal)(com_kwh)); 

            // Act
            var result = commercialTest.CalculateCharge(testPower);

            // Assert
            Assert.AreEqual(expectedChargeRate, result);

        }

        [TestMethod]
        /*
        *  Unit test for Industrial customer input when the add button is clicked 
        *  and the peak_power and off_peak_power is equal to zero
        */
        public void CalculateIndustrial_WhenCalledWithTheAddButton_ExpectedWhenPeakPowerAndOffPeakPowerIsEqualToZero()
        {
            // Arrange
            Customer industrialTest = new Customer("I", 23456, "Jamie");
            decimal testPeakPower = 0m; // peak power = 0
            decimal testOffPeakPower = 0m; // off peak power = 0
            decimal expectedChargeRate = 116m; //  expected charge rate when test off peak power and peak power = 0 ; amount =  ind_peak_rate + ind_off_rate;

            // Act
            var result = industrialTest.CalculateCharge(testPeakPower, testOffPeakPower);

            // Assert
            Assert.AreEqual(expectedChargeRate, result);
        }

        [TestMethod]
        /*
         *  Unit test for Industrial customer input when the add button is clicked 
         *  and the peak_power and off_peak_power is less than 1000 kwh
         */

        public void CalculateIndustrial_WhenCalledWithTheAddButton_ExpectedWhenPeakPowerAndOffPeakPowerIsLessThan1000() 
        {
            

            // Arrange
            Customer industrialTest = new Customer("I", 23456, "Jamie");
            decimal testPeakPower = 500m; // peak power = 500
            decimal testOffPeakPower = 500m; // off peak power = 500
            decimal expectedChargeRate = 116m; //  expected charge rate when test off peak power and peak power = 0 ; amount =  ind_peak_rate + ind_off_rate;

            // Act
            var result = industrialTest.CalculateCharge(testPeakPower, testOffPeakPower);

            // Assert
            Assert.AreEqual(expectedChargeRate, result);
        }

        [TestMethod]
        // Unit test for Industrial customer input when the add button is clicked
        //* and the peak_power and off_peak_power is greater than 1000 kwh
        public void CalculateIndustrial_WhenCalledWithTheAddButton_ExpectedWhenPeakPowerAndOffPeakPowerIsGreaterThan1000()
        {
            // Arrange
            Customer industrialTest = new Customer("I", 23456, "Jamie");
            decimal testPeakPower = 1500m; // peak power = 1500; peak power > 1000
            decimal testOffPeakPower = 1500m; // off peak power = 1500; off peak power > 1000
            decimal expectedChargeRate = 162.50m; // expected charge rate when test off peak power and peak power > 1000 ; amount = ( peak_amount = (ind_peak_rate + ((peak_power - 1000) * (decimal)(ind_peak_kwh))) +  off_amount = (ind_off_rate + ((off_power - 1000) * (decimal)(ind_off_kwh)));

            // Act
            var result = industrialTest.CalculateCharge(testPeakPower, testOffPeakPower);

            // Assert
            Assert.AreEqual(expectedChargeRate, result);

        }

        [TestMethod]
        // Unit test for Industrial customer input when the add button is clicked
        //* and the peak_power > 1000 and off_peak_power < 1000 
        public void CalculateIndustrial_WhenCalledWithTheAddButton_ExpectedWhenPeakPowerIsGreaterThan1000AndOffPeakPowerIsLessThan1000()
        {
            // Arrange
            Customer industrialTest = new Customer("I", 23456, "Jamie");
            decimal testPeakPower = 1500m; // peak power = 1500; peak power > 1000
            decimal testOffPeakPower = 500m; // off peak power = 500; off peak power < 1000
            decimal expectedChargeRate = 148.50m; // expected charge rate when testing off peak power < 1000 and peak power > 1000 ; amount = ( peak_amount = (ind_peak_rate + ((peak_power - 1000) * (decimal)(ind_peak_kwh))) +  off_amount = (ind_off_rate + ((off_power - 1000) * (decimal)(ind_off_kwh)));

            // Act
            var result = industrialTest.CalculateCharge(testPeakPower, testOffPeakPower);

            // Assert
            Assert.AreEqual(expectedChargeRate, result);

        }

        [TestMethod]
        // Unit test for Industrial customer input when the add button is clicked
        //* and the peak_power < 1000 and off_peak_power > 1000 
        public void CalculateIndustrial_WhenCalledWithTheAddButton_ExpectedWhenOffPeakPowerIsGreaterThan1000AndPeakPowerIsLessThan1000()
        {
            // Arrange
            Customer industrialTest = new Customer("I", 23456, "Jamie");
            decimal testPeakPower = 500m; // peak power = 500; peak power < 1000
            decimal testOffPeakPower = 1500m; // off peak power = 1500; off peak power > 1500
            decimal expectedChargeRate = 130.00m; // expected charge rate when testing off peak power > 1000 and peak power < 1000 ; amount = ( peak_amount = (ind_peak_rate + ((peak_power - 1000) * (decimal)(ind_peak_kwh))) +  off_amount = (ind_off_rate + ((off_power - 1000) * (decimal)(ind_off_kwh)));

            // Act
            var result = industrialTest.CalculateCharge(testPeakPower, testOffPeakPower);

            // Assert
            Assert.AreEqual(expectedChargeRate, result);

        }
    }
}
