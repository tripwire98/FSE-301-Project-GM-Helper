using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class SceneGeneration
    {
        //Object Variables
        //public SceneGenerator SG = new SceneGenerator();
        public TimeOfDay TimeOfDayGetter = new TimeOfDay();
        public Location location = new Location();
        public PersonCreator pCreator = new PersonCreator();
        //public SceneGeneration sGenerator = new SceneGeneration();
        public AdjectiveController adjCon = new AdjectiveController();

        string scene;
        public string generateScene()
        {
            System.Diagnostics.Debug.WriteLine(TimeOfDayGetter.GetTimeOfDay());
            scene = ("You see in front of you a " + adjCon.getTimeOfDayAdj() + " " + location.getLocation() + ", off to the " + "East " + adjCon.getNPCActionAdj() + " a " +
                adjCon.getPersonalAjectives() + " " + pCreator.getPersonsAge() + " " + " Dwarf" + " who says ( my name is " + pCreator.getPersonsName() + " )");

            return scene;
        }
    }
}