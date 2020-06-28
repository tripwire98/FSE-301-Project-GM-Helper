using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class Location
    {
        public string SelLocation;
        public Location(String loc)
        {
            SelLocation = loc;
        }

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