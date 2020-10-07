using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace HOFSApp
{
    [Serializable]
    public class EstateManager : ListManager<Estate>
    {
        public EstateManager()   {}

        public override bool XMLSerialize(string fileName)
        {
            List<XMLData> ls = new List<XMLData>();
            for (int i = 0; i < Count; i++)
            {
                ls.Add(new XMLData()
                {
                    ID = GetAt(i).estateID,
                    streetAddress = GetAt(i).address.street,
                    city = GetAt(i).address.city
                });
            }
            XmlSerializer xs = new XmlSerializer(typeof(List<XMLData>));
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, ls);
            return true;
        }
    }
}
