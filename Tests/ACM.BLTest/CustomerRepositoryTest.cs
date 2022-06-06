using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            var actual = customerRepository.Retrieve(expected);
            Assert.AreEqual(expected, actual);
        }

        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                AddressList = new List<Adddress>()
                {
                        new Address()
                        {
                            AddressType = 1,
                            Street1 = "Bagshot row",
                        }
                }

            };
        }
        

    }
    

}
