using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class PersonCreator
    {
        public string PersonsName;
        int raceNum;
        int age;
        Random rand = new Random();
        string[,] fNames = new string[,]
        {
            /* Human First Names*/ {"John","Carl","Steve"},
            /* Dwarf First Names*/ {"Bombur","Thorin","Gimli"},
        };
        string[,] lNames = new string[,]
        {
            /* Human Last Names*/ {"Smith","Black","O'Brien"},
            /* Dwarf Last Names*/ {"Blackbeard","Bronzebeard","Ironback"},
        };

        public void createPerson(string race)
        {
            if(race == "Human")
            {
                raceNum = 0;
            }
            if(race == "Dwarf")
            {
                raceNum = 1;
            }

            
            int fIndex = rand.Next(fNames.Length/2);
            int lIndex = rand.Next(lNames.Length/2);

            PersonsName = (fNames[raceNum, fIndex] + " " + lNames[raceNum, lIndex]);
        }
        public string getPersonsName()
        {
            System.Diagnostics.Debug.WriteLine(PersonsName);
            return PersonsName;
        }
        public string getPersonsAge()
        {
            rand.Next(10, 90);
            return age.ToString();
        }
    }
}