using GM_Helper.Code_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GM_Helper
{
    public partial class SceneGenerator : Page
    {
        //Objects used for The time of day and location
<<<<<<< Updated upstream
        public TimeOfDay TimeOfDayGetter = new TimeOfDay();
        public Location location = new Location();
        public PersonCreator pCreator = new PersonCreator();

        //What happens when the page loads
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            //If statements get the value of the selected item and call the script Location.cs to
            //set and get the correct loaction value
            //System.Diagnostics.Debug.WriteLine(location.getLocation()) is used to display result in console for debug purposes
            string loc = DropDownList1.SelectedItem.Text;
            location.setLocation(loc);
            System.Diagnostics.Debug.WriteLine(location.getLocation());
=======
            //update loc variable to current selection
            loc = DropDownList1.SelectedItem.Text;
>>>>>>> Stashed changes
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            //If statements get the value of the selected item and call the script TimeOfDay.cs to
            //set and get the correct Time Of Day value
            //System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay()) is used to display result in console for debug purposes
            string Time = DropDownList2.SelectedItem.Text;
            TimeOfDayGetter.SetTimeOfDay(Time);
            System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
=======
            //update time variable to current selection
            time = DropDownList2.SelectedItem.Text;
>>>>>>> Stashed changes
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            string person = DropDownList3.SelectedItem.Text;
            pCreator.createPerson(person);
            System.Diagnostics.Debug.WriteLine(pCreator.getPerson());
=======
            //update personRace variable to current selection
            personRace = DropDownList3.SelectedItem.Text;
        }

        protected void GenerateSceneBtn_Click(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedItem.Text == "Random") //if location is unselected
            {
                //tbd rand function to pick through entries hard setting to Afternoon.
                loc = "Forest";
            }
            else
            {
                // use the chosen location in dropdown
                loc = DropDownList1.SelectedItem.Text;
            }

            if (DropDownList2.SelectedItem.Text == "Random") //if time is unselected
            {
                //tbd rand function to pick through entries hard setting to Afternoon.
                time = "Afternoon";
            }
            else
            {
                // use the chosen time in dropdown
                time = DropDownList2.SelectedItem.Text;
            }
            if (DropDownList3.SelectedItem.Text == "Random") //if race is unselected
            {
                personRace = "Random";
            }
            else
            {
                // use the chosen race in dropdown
                personRace = DropDownList3.SelectedItem.Text;
            }
            sGenerator = new SceneGeneration(loc, time, personRace);
            SceneLbl.Text = sGenerator.generateScene();
>>>>>>> Stashed changes
        }
    }
}