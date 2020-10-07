using System;
using System.Collections.Generic;
using System.Text;

namespace HOFSApp
{
    [Serializable]
    public class Shop : CommercialEstate
    {

        public Shop(int estateID, Address address,EstateLegalForm estateLegalForm, int estatePrice, double estateDimensions, int estateRent) : base(estateID, address, estateLegalForm, estatePrice, estateDimensions, estateRent)
        {
            this.estateID = estateID;
            this.address = address;
            this.estateType = EstateType.Shop;
            this.estateLegalForm = estateLegalForm;
            this.estatePrice = estatePrice;
            this.estateDimensions = estateDimensions;
            this.estateRent = estateRent;
        }

        public override EstateCategory estateCategory => base.estateCategory;
        public override int estatePrice { get => base.estatePrice; set => base.estatePrice = value; }
        public override double estateDimensions { get => base.estateDimensions; set => base.estateDimensions = value; }
        public override int estateRent { get => base.estateRent; set => base.estateRent = value; }
        public override EstateType estateType { get => base.estateType; set => base.estateType = value; }
        public override EstateLegalForm estateLegalForm { get => base.estateLegalForm; set => base.estateLegalForm = value; }

        public override string GetSummary => base.GetSummary;

        public override string EstatePicture { get => base.EstatePicture; set => base.EstatePicture = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    };
}
