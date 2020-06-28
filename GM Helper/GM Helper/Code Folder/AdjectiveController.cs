using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class AdjectiveController
    {
        string ReffrenceCon;
        int RandIndex;
        Random rand = new Random();
        TimeOfDay tod;
        string[] morningAdjectives = { "Calm", "Peaceful", "Lightly Lit" };
        string[] afternoonAdjectives = { "Bright", "Peaceful", "Calm" };
        string[] eveningAdjectives = { "Barely Lit", "Dim", "Creepy" };
        string[] nightAdjectives = { "Dark", "Creepy", "Horrifying" };
        string[] NPCActionAdj = { "Sits", "Stands", "Rests" };
        string[] personalAjectives = { "Fat", "Skinny", "Sickly", "Pale" };

        public AdjectiveController(String time)
        {
            tod = new TimeOfDay(time);
        }
        public string getTimeOfDayAdj()
        {
            ReffrenceCon = tod.GetTimeOfDay();
            if(ReffrenceCon == "Morning")
            {
                RandIndex = rand.Next(morningAdjectives.Length);
                return morningAdjectives[RandIndex];
            }
            else if (ReffrenceCon == "Afternoon")
            {
                RandIndex = rand.Next(afternoonAdjectives.Length);
                return afternoonAdjectives[RandIndex];
            }
            else if(ReffrenceCon == "Evening")
            {
                RandIndex = rand.Next(eveningAdjectives.Length);
                return eveningAdjectives[RandIndex];
            }
            else if(ReffrenceCon == "Night")
            {
                RandIndex = rand.Next(nightAdjectives.Length);
                return nightAdjectives[RandIndex];
            }
            else
            {
                return null;
            }
        }
        public string getNPCActionAdj()
        {
            RandIndex = rand.Next(NPCActionAdj.Length);
            return NPCActionAdj[RandIndex];
        }

        public string getPersonalAjectives()
        {
            RandIndex = rand.Next(personalAjectives.Length);
            return personalAjectives[RandIndex];
        }
    }
}