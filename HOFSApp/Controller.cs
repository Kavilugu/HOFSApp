using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HOFSApp
{
    //This class handles most of the logic and computing that the GUI uses
    class Controller
    {
        private int estateID;
        private List<Estate> estateList;

        public Controller()
        {
            estateID = 0;
            estateList = new List<Estate>();

        }
        //This class checks which fields are specified in the GUI and then bases the serach on that.
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

        //Deletes the Estate chosen in the GUI from the list of Estates
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

        //Makes sure that no info is empty and then creates and adds and Estate to the list.
        public bool AddEstate(Address address, EstateCategory estateCategory, EstateType estateType, EstateLegalForm estateLegalForm, string estatePrice, string estateDimensions, string estateRent, string imageString)
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
                    estate = new CommercialEstate(GenerateEstateID(), address, estateType, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estate.EstatePicture = imageString;
                    estateList.Add(estate);
                    return true;
                }
                else if (estateCategory == EstateCategory.Residential)
                {
                    estate = new ResidentialEstate(GenerateEstateID(), address, estateType, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estate.EstatePicture = imageString;
                    estateList.Add(estate);
                    return true;
                }
            }

            return false;
        }
        //Modifies the chosen estate after verifying the ID. 
        public bool ModifyEstate(string estateID, Countries country, string city, string street, string zipCode, EstateType estateType, EstateLegalForm estateLegalForm, string estatePrice, string estateDimensions, string estateRent, string imageString)
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

            //Checks which fields are entered and only modifies those. Also cathces any parsing errors.
            try
            {
                if (!String.IsNullOrEmpty(city)) { estate.address.city = city; }
                if (!String.IsNullOrEmpty(street)) { estate.address.street = street; }
                if (!String.IsNullOrEmpty(zipCode)) { estate.address.zipCode = zipCode; }
                if (!String.IsNullOrEmpty(estateDimensions)) { estate.estateDimensions = double.Parse(estateDimensions); }
                if (!String.IsNullOrEmpty(estateRent)) { estate.estateRent = int.Parse(estateRent); }
                if (!String.IsNullOrEmpty(estatePrice)) { estate.estatePrice = int.Parse(estatePrice); }
                if (!String.IsNullOrEmpty(imageString)) { estate.EstatePicture = imageString; }
            } catch (Exception e)
            {
                return false;
            }

            return true;
        }

        //Puts a user selected image into the passed on image box
        public string HandleImage(PictureBox pictureBox)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (*.jpg; *.png; *.jpeg; | *.jpg; *.png; *.jpeg;)";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(ofd.FileName);
                return ofd.FileName;
            }
            return "";
        }

        //Copies a list of Estates to prevent list errors.
        private List<Estate> CopyList(List<Estate> target)
        {
            List<Estate> tempList = new List<Estate>();

            for (int i = 0; i < estateList.Count; i++)
            {
                tempList.Add(target[i]);
            }
            return tempList;
        }

        private int GenerateEstateID()
        {
            return ++estateID;
        }

        //Makes sure that the ID passed on is correct and that an Estate with that ID exists.
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
