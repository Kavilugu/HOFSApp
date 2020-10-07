using System;
using System.Collections.Generic;
using System.Text;

namespace HOFSApp
{
    [Serializable]
    public abstract class CommercialEstate : Estate
    {
        private EstateCategory _estateCategory = EstateCategory.Commercial;
        public CommercialEstate(int estateID, Address address, EstateLegalForm estateLegalForm, int estatePrice, double estateDimensions, int estateRent) : base(estateID, address, estateLegalForm)
        {
            this.estatePrice = estatePrice;
            this.estateDimensions = estateDimensions;
            this.estateRent = estateRent;
            this.estateLegalForm = estateLegalForm;
        }
        public override EstateCategory estateCategory { get => _estateCategory; }
        public override int estatePrice { get; set; }
        public override double estateDimensions { get; set; }
        public override int estateRent { get; set; }
        public override EstateType estateType { get; set; }
        public override EstateLegalForm estateLegalForm { get; set; }
        public override string EstatePicture { get; set; }
        public override string GetSummary => $"ID: {base.estateID}, Country: {base.address.country}, City: {base.address.city}, Dimensions: {estateDimensions} m^2, Price: {estatePrice}";

        public override string ToString()
        {
            return $" ID: {base.estateID}\n Country: {base.address.country}\n City: {base.address.city}\n Address: {address.street}, {address.zipCode}\n Dimensions: {estateDimensions} m^2\n Price: {estatePrice}\n Rent: {estateRent}\n Estate Type: {estateType}\n Legal Form: {estateLegalForm}";
        }
    }
}
