using GM_Helper.Code_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GM_Helper
{
    public partial class SceneGenerator : Page
    {
        public TimeOfDay TimeOfDayGetter = new TimeOfDay();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MorningCB_CheckedChanged(object sender, EventArgs e)
        {
            if(MorningCB.Checked == true) { 
                //TimeOfDay TimeOfDayGetter = new TimeOfDay();
                TimeOfDayGetter.SetTimeToMorning();
                TimeOfDayGetter.GetTimeOfDay();
                System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
                AfternoonCB.Checked = false;
                EveningCB.Checked = false;
                NightCB.Checked = false;
            }
            
        }

        protected void AfternoonCB_CheckedChanged(object sender, EventArgs e)
        {
            if (AfternoonCB.Checked == true)
            {
                TimeOfDayGetter.SetTimeToAfternoon();
                TimeOfDayGetter.GetTimeOfDay();
                System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
                MorningCB.Checked = false;
                EveningCB.Checked = false;
                NightCB.Checked = false;
            }
        }

        protected void EveningCB_CheckedChanged(object sender, EventArgs e)
        {
            if (EveningCB.Checked == true)
            {
                TimeOfDayGetter.SetTimeToEvening();
                TimeOfDayGetter.GetTimeOfDay();
                System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
                AfternoonCB.Checked = false;
                MorningCB.Checked = false;
                NightCB.Checked = false;
            }
        }

        protected void NightCB_CheckedChanged(object sender, EventArgs e)
        {
            if (NightCB.Checked == true)
            {
                TimeOfDayGetter.SetTimeToNight();
                TimeOfDayGetter.GetTimeOfDay();
                System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
                AfternoonCB.Checked = false;
                EveningCB.Checked = false;
                MorningCB.Checked = false;
            }
        }
    }
}