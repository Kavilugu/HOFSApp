using System;
using System.Collections.Generic;
using System.Text;

namespace HOFSApp
{
    class Address
    {
        public Address(Countries country, string city, string street, string zipCode)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.zipCode = zipCode;
        }
        public Countries country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string zipCode { get; set; }
    }
}
