using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jthacker2747ex2e1dbmapper
{
    public class Address
    {
        public Address(int addressID, string addressLine1, string addressLine2, string city, 
            int stateProvinceID, string postalCode, DateTime modifiedDate)
        {
            this.AddressID = addressID;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.StateProvinceID = stateProvinceID;
            this.PostalCode = postalCode; 
        }

        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateProvinceID { get; set; }

        public string PostalCode { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
