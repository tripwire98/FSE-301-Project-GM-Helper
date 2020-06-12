using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class TimeOfDay
    {
        string Morning = "Morning";
        string Afternoon = "Afternoon";
        string Evening = "Evening";
        string Night = "Night";
        string TheTimeOfDay = "Afternoon";

        public void SetTimeToMorning()
        {
            TheTimeOfDay = Morning;
        }
        public void SetTimeToAfternoon()
        {
            TheTimeOfDay = Afternoon;
        }
        public void SetTimeToEvening()
        {
            TheTimeOfDay = Evening;
        }
        public void SetTimeToNight()
        {
            TheTimeOfDay = Night;
        }

        public string GetTimeOfDay()
        {
            return TheTimeOfDay;
        }
    }
}