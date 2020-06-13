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
        //Objects used for The time of day and location
        public TimeOfDay TimeOfDayGetter = new TimeOfDay();
        public Location location = new Location();
        public PersonCreator pCreator = new PersonCreator();

        //What happens when the page loads
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If statements get the value of the selected item and call the script Location.cs to
            //set and get the correct loaction value
            //System.Diagnostics.Debug.WriteLine(location.getLocation()) is used to display result in console for debug purposes
            string loc = DropDownList1.SelectedItem.Text;
            location.setLocation(loc);
            System.Diagnostics.Debug.WriteLine(location.getLocation());
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If statements get the value of the selected item and call the script TimeOfDay.cs to
            //set and get the correct Time Of Day value
            //System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay()) is used to display result in console for debug purposes
            string Time = DropDownList2.SelectedItem.Text;
            TimeOfDayGetter.SetTimeOfDay(Time);
            System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string person = DropDownList3.SelectedItem.Text;
            pCreator.createPerson(person);
            System.Diagnostics.Debug.WriteLine(pCreator.getPerson());
        }
    }
}