using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class PersonCreator
    {
        public string CreatedPerson;
        int raceNum;
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

            var rand = new Random();

            int fIndex = rand.Next(fNames.Length/2);
            int lIndex = rand.Next(lNames.Length/2);

            CreatedPerson = (fNames[raceNum, fIndex] + " " + lNames[raceNum, lIndex]);
        }
        public string getPerson()
        {
            return CreatedPerson;
        }
    }
}