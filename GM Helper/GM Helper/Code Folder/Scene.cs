using Microsoft.Ajax.Utilities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class Scene
    {
        public TimeOfDay time;
        public Location location;
        public int numberOfPeople;
        public String NPCs;
        public String periodDescription;
        public String sceneDescription;


        public String CreateSceneDescription()
        {
            //TBD
            String description = "";
            return description;
        }

        public void SetLocation(Location loc)
        {
            location = loc;
        }

        public void SetTime(TimeOfDay t)
        {
            time = t;
        }


        public void SetNumberOfPeople(int n)
        {
            numberOfPeople = n;
        }

    }
}