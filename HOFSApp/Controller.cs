using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HOFSApp
{
    class Controller
    {
        private int estateID;
        private List<Estate> estateList;

        public Controller()
        {
            estateID = 0;
            estateList = new List<Estate>();

        }
        public List<Estate> SearchEstate(Countries country, string city, EstateType estateType)
        {
            List<Estate> matchList = new List<Estate>();
            var formattedCity = city.ToUpper();

            if (country == Countries.All && estateType == EstateType.All)
            {
                for (int i = 0; i < estateList.Count; i++)
                {
                    if (estateList[i].address.city.ToUpper().Contains(formattedCity))
                    {
                        matchList.Add(estateList[i]);
                    }
                }
            }
            else if (country == Countries.All)
            {
                for (int i = 0; i < estateList.Count; i++)
                {
                    if (estateList[i].estateType == estateType && estateList[i].address.city.ToUpper().Contains(formattedCity))
                    {
                        matchList.Add(estateList[i]);
                    }
                }
            }
            else if (estateType == EstateType.All)
            {
                for (int i = 0; i < estateList.Count; i++)
                {
                    if (estateList[i].address.country == country && estateList[i].address.city.ToUpper().Contains(formattedCity))
                    {
                        matchList.Add(estateList[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < estateList.Count; i++)
                {
                    if (estateList[i].address.country == country && estateList[i].address.city.ToUpper().Contains(formattedCity) && estateList[i].estateType == estateType)
                    {
                        matchList.Add(estateList[i]);
                    }
                }
            }

            return matchList;
        }

        public List<Estate> DeleteEstate(int ID)
        {
            for (int i = 0; i < estateList.Count; i++)
            {
                if (estateList[i].estateID == ID)
                {
                    estateList.RemoveAt(i);
                }
            }
            return CopyList(estateList);
        }

        public bool AddEstate(Address address, EstateCategory estateCategory, EstateType estateType, EstateLegalForm estateLegalForm, string estatePrice, string estateDimensions, string estateRent)
        {
            Estate estate;
            if (String.IsNullOrEmpty(address.city) || String.IsNullOrEmpty(address.street) || String.IsNullOrEmpty(address.zipCode))
            {
                return false;
            }

            if (int.TryParse(estatePrice, out int estatePriceResult) &&
                double.TryParse(estateDimensions, out double estateDimensionsResult) &&
                int.TryParse(estateRent, out int estateRentResult))
            {
                if (estateCategory == EstateCategory.Commercial)
                {
                    estate = new CommercialEstate(generateEstateID(), address, estateType, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estateList.Add(estate);
                    return true;
                }
                else if (estateCategory == EstateCategory.Residential)
                {
                    estate = new ResidentialEstate(generateEstateID(), address, estateType, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estateList.Add(estate);
                    return true;
                }
            }

            return false;
        }

        public bool ModifyEstate(string estateID, Countries country, string city, string street, string zipCode, EstateType estateType, EstateLegalForm estateLegalForm, string estatePrice, string estateDimensions, string estateRent)
        {
            Estate estate = null;
            int ID;
            bool IDExists = ValidateID(estateID, out ID);
            if (!IDExists)
            {
                return false;
            }
            
            foreach (Estate compareEstate in estateList)
            {
                if (compareEstate.estateID == ID)
                {
                    estate = compareEstate;
                }
            }

            estate.address.country = country;
            estate.estateType = estateType;
            estate.estateLegalForm = estateLegalForm;

            try
            {
                if (!String.IsNullOrEmpty(city)) { estate.address.city = city; }
                if (!String.IsNullOrEmpty(street)) { estate.address.street = street; }
                if (!String.IsNullOrEmpty(zipCode)) { estate.address.zipCode = zipCode; }
                if (!String.IsNullOrEmpty(estateDimensions)) { estate.estateDimensions = double.Parse(estateDimensions); }
                if (!String.IsNullOrEmpty(estateRent)) { estate.estateRent = int.Parse(estateRent); }
                if (!String.IsNullOrEmpty(estatePrice)) { estate.estatePrice = int.Parse(estatePrice); }
            } catch (Exception e)
            {
                return false;
            }

            return true;
        }

        private List<Estate> CopyList(List<Estate> target)
        {
            List<Estate> tempList = new List<Estate>();

            for (int i = 0; i < estateList.Count; i++)
            {
                tempList.Add(target[i]);
            }
            return tempList;
        }
        private int generateEstateID()
        {
            return ++estateID;
        }

        private bool ValidateID(string estateID, out int result)
        {

            bool IDExists = false;

            if (!int.TryParse(estateID, out result))
            {
                return false;
            }

            foreach (Estate estate in estateList)
            {
                if (result == estate.estateID)
                {
                    IDExists = true;
                }
            }
            if (!IDExists)
            {
                return false;
            }
            return IDExists;
        }
    }
}
