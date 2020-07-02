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
        public SceneType sceneType;

        public SceneGeneration(String loc, String time, String race, String sType)
        {
            location = new Location(loc);
            TimeOfDayGetter = new TimeOfDay(time);
            adjCon = new AdjectiveController(time);
            pCreator = new PersonCreator(race);
            sceneType = new SceneType(sType);
        }

        string scene = "";
        public string generateScene()
        {
            System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
            System.Diagnostics.Debug.WriteLine(sceneType.getSceneType());
            if (sceneType.getSceneType() == "Social")
            {
                scene = ("You see in front of you a " + adjCon.getTimeOfDayAdj() + " " + location.getLocation() + ", off to the " + "East " + adjCon.getNPCActionAdj() + " a " +
                    adjCon.getPersonalAjectives() + " " + pCreator.getPersonsAge() + " year old " + pCreator.getPersonsRace() + " who says ( my name is " + pCreator.getPersonsName() + " )");
            }
            if (sceneType.getSceneType() == "Combat")
            {
                scene = ("While traveling through a " + adjCon.getTimeOfDayAdj() + " " + location.getLocation() + " You hear a noise behind you, as you turn around you see " + " 4" +
                    " large" + " orc's" + " Looking for blood" + " roll for initiative");
            }
            if (sceneType.getSceneType() == "Exploration")
            {
                scene = ("While wandering through a " + adjCon.getTimeOfDayAdj() + " " + location.getLocation() + " you notice something" + " strange" + " towards the" + " west" +
                    " suddenly it begins to" + " glow");
            }

            return scene;
        }
    }
}