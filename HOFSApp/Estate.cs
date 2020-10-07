using System;
using System.Collections.Generic;
using System.Text;

namespace HOFSApp
{
    // Abstract class defining Estates
    [Serializable]
    public abstract class Estate : IEstate
    {
        public Estate(int estateID, Address address, EstateLegalForm estateLegalForm)
        {
            this.estateID = estateID;
            this.address = address;
            this.estateType = estateType;
            this.estateLegalForm = estateLegalForm;
        }
        public int estateID { get; set; }
        public Address address { get; set; }
        public abstract EstateCategory estateCategory { get;}
        public abstract int estatePrice { get; set; }
        public abstract double estateDimensions { get; set; }
        public abstract int estateRent { get; set; }
        public abstract EstateType estateType { get; set; }
        public abstract EstateLegalForm estateLegalForm { get; set; }
        public abstract string GetSummary { get; }
        public abstract override string ToString();
        public abstract string EstatePicture { get; set; }

    }
}
