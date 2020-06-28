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
        public SceneGeneration sGenerator;
        string loc;
        string time;
        string personRace;

        //What happens when the page loads
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update loc variable to current selection
            loc = DropDownList1.SelectedItem.Text;
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update time variable to current selection
            time = DropDownList2.SelectedItem.Text;
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update personRace variable to current selection
            personRace = DropDownList3.SelectedItem.Text;
        }

        protected void GenerateSceneBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomChoice;
            if (DropDownList1.SelectedItem.Text == "Random") //if location is unselected
            {
                //choose random location
                randomChoice = rnd.Next(1,DropDownList1.Items.Count);
                loc = DropDownList1.Items[randomChoice].Text;
            }
            else
            {
                // use the chosen location in dropdown
                loc = DropDownList1.SelectedItem.Text;
            }

            if (DropDownList2.SelectedItem.Text == "Random") //if time is unselected
            {
                //choose random time
                randomChoice = rnd.Next(1, DropDownList2.Items.Count);
                time = DropDownList2.Items[randomChoice].Text;
            }
            else
            {
                // use the chosen time in dropdown
                time = DropDownList2.SelectedItem.Text;
            }
            if (DropDownList3.SelectedItem.Text == "Random") //if race is unselected
            {
                //choose random race
                randomChoice = rnd.Next(1, DropDownList3.Items.Count);
                personRace = DropDownList3.Items[randomChoice].Text;
            }
            else
            {
                // use the chosen race in dropdown
                personRace = DropDownList3.SelectedItem.Text;
            }
            sGenerator = new SceneGeneration(loc, time, personRace);
            SceneLbl.Text = sGenerator.generateScene();
        }
    }
}