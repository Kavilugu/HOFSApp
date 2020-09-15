using System;
using System.Collections.Generic;
using System.Text;

namespace HOFSApp
{
    // Abstract class defining Estates
    abstract class Estate : IEstate
    {
        public Estate(int estateID, Address address, EstateType estateType, EstateLegalForm estateLegalForm)
        {
            _estateID = estateID;
            _address = address;
            this.estateType = estateType;
            this.estateLegalForm = estateLegalForm;
        }
        private int _estateID;
        public int estateID { get => _estateID; set => _estateID = value; }
        private Address _address;
        public Address address { get => _address; set => _address = value; }
        public abstract EstateCategory estateCategory { get;}
        public abstract int estatePrice { get; set; }
        public abstract double estateDimensions { get; set; }
        public abstract int estateRent { get; set; }
        public abstract EstateType estateType { get; set; }
        public abstract EstateLegalForm estateLegalForm { get; set; }
        public abstract string GetSummary { get; }
        public abstract string GetFullInfo { get; }
        public abstract string EstatePicture { get; set; }




    }
}
