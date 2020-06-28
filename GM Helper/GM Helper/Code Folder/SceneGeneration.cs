using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class SceneGeneration
    {
        public Location location;
        public TimeOfDay TimeOfDayGetter;
        public PersonCreator pCreator;
        public AdjectiveController adjCon;

        public SceneGeneration(String loc, String time, String race)
        {
            location = new Location(loc);
            TimeOfDayGetter = new TimeOfDay(time);
            adjCon = new AdjectiveController(time);
            pCreator = new PersonCreator(race);
        }

        string scene;
        public string generateScene()
        {
            System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
            scene = ("You see in front of you a " + adjCon.getTimeOfDayAdj() + " " + location.getLocation() + ", off to the " + "East " + adjCon.getNPCActionAdj() + " a " +
                adjCon.getPersonalAjectives() + " " + pCreator.getPersonsAge() + " year old " + pCreator.getPersonsRace() + " who says ( my name is " + pCreator.getPersonsName() + " )");

            return scene;
        }
    }
}