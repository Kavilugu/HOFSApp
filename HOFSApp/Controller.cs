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
        private EstateManager em;
        private bool hasChanged = false;
        private string filepath = "";
        private OpenFileDialog ofd = new OpenFileDialog();

        public Controller()
        {
            estateID = 0;
            em = new EstateManager();

        }
        //This class checks which fields are specified in the GUI and then bases the serach on that.
        public List<Estate> SearchEstate(Countries country, string city, EstateType estateType)
        {
            List<Estate> matchList = new List<Estate>();
            var formattedCity = city.ToUpper();
            DictionaryManager<EstateType, Estate> dictionary = new DictionaryManager<EstateType, Estate>();
            for (int i = 0; i < em.Count; i++)
            {
                dictionary.Add(em.GetAt(i).estateType, em.GetAt(i));
            }

            if (country == Countries.All && estateType == EstateType.All)
            {
                for (int i = 0; i < em.Count; i++)
                {
                    if (em.GetAt(i).address.city.ToUpper().Contains(formattedCity))
                    {
                        matchList.Add(em.GetAt(i));
                    }
                }
            }
            else if (country == Countries.All)
            {

                List<Estate> estateTypes = new List<Estate>();
                dictionary.Get(estateType, out estateTypes);
                for (int i = 0; i < estateTypes.Count; i++)
                {
                    if (estateTypes[i].address.city.ToUpper().Contains(formattedCity))
                    {
                        matchList.Add(estateTypes[i]);
                    }
                }
            }
            else if (estateType == EstateType.All)
            {
                for (int i = 0; i < em.Count; i++)
                {
                    if (em.GetAt(i).address.country == country && em.GetAt(i).address.city.ToUpper().Contains(formattedCity))
                    {
                        matchList.Add(em.GetAt(i));
                    }
                }
            }
            else
            {
                for (int i = 0; i < em.Count; i++)
                {
                    if (em.GetAt(i).address.country == country && em.GetAt(i).address.city.ToUpper().Contains(formattedCity) && em.GetAt(i).estateType == estateType)
                    {
                        matchList.Add(em.GetAt(i));
                    }
                }
            }

            return matchList;
        }

        //Deletes the Estate chosen in the GUI from the list of Estates
        public List<Estate> DeleteEstate(int ID)
        {
            for (int i = 0; i < em.Count; i++)
            {
                if (em.GetAt(i).estateID == ID)
                {
                    em.DeleteAt(i);
                }
            }
            SetChanged();
            return em.getList();
        }

        //Makes sure that no info is empty and then creates and adds and Estate to the list.
        public bool AddEstate(Address address, EstateType estateType, EstateLegalForm estateLegalForm, string estatePrice, string estateDimensions, string estateRent, string imageString)
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
                if (estateType == EstateType.Apartment)
                {
                    estate = new Apartment(GenerateEstateID(), address, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estate.EstatePicture = imageString;
                    em.Add(estate);
                    SetChanged();
                    return true;
                }
                else if (estateType == EstateType.House)
                {
                    estate = new House(GenerateEstateID(), address, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estate.EstatePicture = imageString;
                    em.Add(estate);
                    SetChanged();
                    return true;
                }
                else if (estateType == EstateType.Villa)
                {
                    estate = new Villa(GenerateEstateID(), address, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estate.EstatePicture = imageString;
                    em.Add(estate);
                    SetChanged();
                    return true;
                }
                else if (estateType == EstateType.Townhouse)
                {
                    estate = new TownHouse(GenerateEstateID(), address, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estate.EstatePicture = imageString;
                    em.Add(estate);
                    SetChanged();
                    return true;
                }
                else if (estateType == EstateType.Factory)
                {
                    estate = new Factory(GenerateEstateID(), address, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estate.EstatePicture = imageString;
                    em.Add(estate);
                    SetChanged();
                    return true;
                }
                else if (estateType == EstateType.Shop)
                {
                    estate = new Shop(GenerateEstateID(), address, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estate.EstatePicture = imageString;
                    em.Add(estate);
                    SetChanged();
                    return true;
                }
                else if (estateType == EstateType.Warehouse)
                {
                    estate = new Warehouse(GenerateEstateID(), address, estateLegalForm, estatePriceResult, estateDimensionsResult, estateRentResult);
                    estate.EstatePicture = imageString;
                    em.Add(estate);
                    SetChanged();
                    return true;
                }
            }

            return false;
        }
        //Modifies the chosen estate after verifying the ID. 
        public bool ModifyEstate(string estateID, Countries country, string city, string street, string zipCode, EstateLegalForm estateLegalForm, string estatePrice, string estateDimensions, string estateRent, string imageString)
        {
            Estate estate = null;
            int ID;
            bool IDExists = ValidateID(estateID, out ID);
            if (!IDExists)
            {
                return false;
            }

            foreach (Estate compareEstate in em.getList())
            {
                if (compareEstate.estateID == ID)
                {
                    estate = compareEstate;
                }
            }

            estate.address.country = country;
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
            }
            catch (Exception e)
            {
                return false;
            }
            SetChanged();
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

        public void SetChanged()
        {
            hasChanged = true;
        }

        public bool HasChanged()
        {
            return hasChanged;
        }

        public List<Estate> NewFile()
        {
            em = new EstateManager();
            hasChanged = false;
            filepath = "";
            estateID = 0;
            return em.getList();

        }

        public bool SaveAs()
        {
            ofd.Filter = "Files (*.txt; | *.txt;)";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                bool saved = em.BinarySerialize(filepath);
                hasChanged = !saved;
                return hasChanged;
            }
            return false;
        }

        public bool Save()
        {
            if (filepath.Length > 0)
            {
                bool saved = em.BinarySerialize(filepath);
                hasChanged = !saved;
                return saved;

            }
            return false;

        }

        public bool openFile()
        {
            ofd.Filter = "Files (*.txt | *.txt;)";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                bool opened = em.BinaryDeSerialize(filepath);
                estateID = em.GetAt(em.Count - 1).estateID;
                hasChanged = !opened;
                return opened;
            }
            return false;
        }

        public bool ExportXML()
        {
            ofd.Filter = "XML-Files (*.xml; | *.xml;)";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                bool saved = em.XMLSerialize(filepath);
                hasChanged = !saved;
                return saved;
            }
            return false;

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

            foreach (Estate estate in em.getList())
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
