using System;
using System.Collections.Generic;
using System.Text;

namespace HOFSApp
{
    class Controller
    {
        private List<Estate> estateList;

        public Controller()
        {

            estateList = new List<Estate>();
            Address address = new Address(Countries.Afghanistan, "Lund", "gatan 1", "21422");
            Address address2 = new Address(Countries.Sverige, "Stockholm", "gatan 2", "21422");
            Estate resE = new ResidentialEstate(1, address, EstateType.Apartment, EstateLegalForm.Ownership, 1000, 10, 100);
            Estate comE = new CommercialEstate(2, address2, EstateType.Factory, EstateLegalForm.Ownership, 100000, 250, 5000);
            estateList = new List<Estate>()
            {
                resE,
                comE
            };

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

        public Boolean addEstate(Address address, EstateType estateType)

        private List<Estate> CopyList(List<Estate> target)
        {
            List<Estate> tempList = new List<Estate>();

            for (int i = 0; i < estateList.Count; i++)
            {
                tempList.Add(target[i]);
            }
            return tempList;
        }
    }
}
