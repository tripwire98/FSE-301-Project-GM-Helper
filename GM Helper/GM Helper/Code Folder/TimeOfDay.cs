using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class TimeOfDay
    { 
        //Default time of day
        string TheTimeOfDay = "Afternoon";

        public TimeOfDay(String time) //value passed via dropdown
        {
            TheTimeOfDay = time;
        }

        //setter methods that set Time of day to selected option
        public void SetTimeOfDay(string SelectedTime)
        {
            TheTimeOfDay = SelectedTime;
        }

        //getter method
        public string GetTimeOfDay()
        {
            return TheTimeOfDay;
        }
    }
}