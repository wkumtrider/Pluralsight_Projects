using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();

            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {    //-- Arrange
            Customer customer = new Customer();

            customer.LastName = "Baggins";
            string expected = "Baggins";

            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
                    
            string expected = "Bilbo";

            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        public void StaticTest()
        {
            var c1 = new Cuustomer();
            c1.FirstName = "Frodo";
            Customer.InstanceCount += 1;
        }
        
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me";
            }
        var actual = Customer.Validate();

        Assert.AreEqual(expected, actual);
        }
    }
}
