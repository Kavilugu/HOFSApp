using System;
using System.Collections.Generic;
using System.Text;

namespace HOFSApp
{
    class CommercialEstate : Estate
    {
        private EstateCategory _estateCategory = EstateCategory.Commercial;

        public CommercialEstate(int estateID, Address address, EstateType estateType, EstateLegalForm estateLegalForm, int estatePrice, double estateDimensions, int estateRent) : base(estateID, address, estateType, estateLegalForm)
        {
            this.estatePrice = estatePrice;
            this.estateDimensions = estateDimensions;
            this.estateRent = estateRent;
            this.estateType = estateType;
            this.estateLegalForm = estateLegalForm;
        }
        public override EstateCategory estateCategory { get => _estateCategory; }
        public override int estatePrice { get; set; }
        public override double estateDimensions { get; set; }
        public override int estateRent { get; set; }
        public override EstateType estateType { get; set; }
        public override EstateLegalForm estateLegalForm { get; set; }
        public override string GetSummary => $"ID: {base.estateID}, Country: {base.address.country}, City: {base.address.city}, Dimensions: {estateDimensions} m^2, Price: {estatePrice}";

        public override string GetFullInfo => throw new NotImplementedException();
    }
}
