using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class Location
    {
        string SelLocation = "Random";

        public void setLocation(string location)
        {
            SelLocation = location;
        }

        public string getLocation()
        {
            return SelLocation;
        }
    }
}