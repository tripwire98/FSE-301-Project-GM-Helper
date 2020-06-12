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

        //What happens when the page loads
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If statements get the value of the selected item and call the script Location.cs to
            //set and get the correct loaction value
            //System.Diagnostics.Debug.WriteLine(location.getLocation()) is used to display result in console for debug purposes
            if (DropDownList1.SelectedItem.Text == "Random")
            {
                location.setLocation("Random");
                System.Diagnostics.Debug.WriteLine(location.getLocation());
            }
            if (DropDownList1.SelectedItem.Text == "Forest")
            {
                location.setLocation("Forest");
                System.Diagnostics.Debug.WriteLine(location.getLocation());
            }
            if (DropDownList1.SelectedItem.Text == "Cave")
            {
                location.setLocation("Cave");
                System.Diagnostics.Debug.WriteLine(location.getLocation());
            }
            if (DropDownList1.SelectedItem.Text == "Village")
            {
                location.setLocation("Village");
                System.Diagnostics.Debug.WriteLine(location.getLocation());
            }
            if (DropDownList1.SelectedItem.Text == "Swamp")
            {
                location.setLocation("Swamp");
                System.Diagnostics.Debug.WriteLine(location.getLocation());
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If statements get the value of the selected item and call the script TimeOfDay.cs to
            //set and get the correct Time Of Day value
            //System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay()) is used to display result in console for debug purposes
            if (DropDownList2.SelectedItem.Text == "Random")
            {
                TimeOfDayGetter.SetTimeOfDay("Random");
                System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
            }
            if (DropDownList2.SelectedItem.Text == "Morning")
            {
                TimeOfDayGetter.SetTimeOfDay("Morning");
                System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
            }
            if (DropDownList2.SelectedItem.Text == "Afternoon")
            {
                TimeOfDayGetter.SetTimeOfDay("Afternoon");
                System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
            }
            if (DropDownList2.SelectedItem.Text == "Evening")
            {
                TimeOfDayGetter.SetTimeOfDay("Evening");
                System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
            }
            if (DropDownList2.SelectedItem.Text == "Night")
            {
                TimeOfDayGetter.SetTimeOfDay("Night");
                System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
            }
        }
    }
}