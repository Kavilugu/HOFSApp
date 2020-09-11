using System;
using System.Collections.Generic;
using System.Text;

namespace HOFSApp
{
    interface IEstate
    {
        public int estateID { get; set; }
        public Address address { get; set; }
    }
}
