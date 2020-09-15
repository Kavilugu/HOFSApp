using System;
using System.Collections.Generic;
using System.Text;

namespace HOFSApp
{
    class ResidentialEstate : Estate
    {
        private EstateCategory _estateCategory = EstateCategory.Residential;
        public ResidentialEstate(int estateID, Address address, EstateType estateType, EstateLegalForm estateLegalForm, int estatePrice, double estateDimensions, int estateRent) : base(estateID, address, estateType, estateLegalForm)
        {
            this.estatePrice = estatePrice;
            this.estateDimensions = estateDimensions;
            this.estateRent = estateRent;
            this.estateType = estateType;
            this.estateLegalForm = estateLegalForm;
        }
        public override EstateCategory estateCategory { get => _estateCategory;}
        public override int estatePrice { get; set; }
        public override double estateDimensions { get; set; }
        public override int estateRent { get; set; }
        public override EstateType estateType { get; set; }
        public override EstateLegalForm estateLegalForm { get; set; }
        public override string GetSummary =>  $"ID: {base.estateID}, Country: {base.address.country}, City: {base.address.city}, Dimensions: {estateDimensions} m^2, Price: {estatePrice}";
        public override string EstatePicture { get; set; }
        public override string GetFullInfo => $" ID: {base.estateID}\n Country: {base.address.country}\n City: {base.address.city}\n Address: {address.street}, {address.zipCode}\n Dimensions: {estateDimensions} m^2\n Price: {estatePrice}\n Rent: {estateRent}\n Estate Type: {estateType}\n Legal Form: {estateLegalForm}";
    }
}
