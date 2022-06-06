using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightPractice_ACM.BL
{
    internal class Address : EntityBase
    {

        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public int AddressId { get; set; }
        public int Street1 { get; set; }
        public int Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string AddressType { get; set; }

        public override bool Validate()
        {
            var isValid = true;
            if (PostalCode == null) isValid = false;
            return isValid;
        }

    }
}
