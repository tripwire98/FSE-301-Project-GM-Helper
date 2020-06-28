using Microsoft.Ajax.Utilities;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class PersonCreator
    {
        public string CreatedPerson;
        int raceNum;
<<<<<<< Updated upstream
=======
        int age;
        String personRace;
        Random rand = new Random();
>>>>>>> Stashed changes
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
        public PersonCreator(String race)
        {
            personRace = race;
            PersonsName = createPerson(personRace);
            age = setPersonsAge();
        }

        public String createPerson(string race)
        {
            String pname;
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

<<<<<<< Updated upstream
            CreatedPerson = (fNames[raceNum, fIndex] + " " + lNames[raceNum, lIndex]);
        }
        public string getPerson()
        {
            return CreatedPerson;
=======
            pname = (fNames[raceNum, fIndex] + " " + lNames[raceNum, lIndex]);
            return pname;
        }
        public string getPersonsName()
        {
            System.Diagnostics.Debug.WriteLine(PersonsName);
            return PersonsName;
        }

        public int setPersonsAge()
        {
            int newAge;
            newAge = rand.Next(10, 90);
            return newAge;
        }
        public String getPersonsAge()
        {
            return age.ToString();
>>>>>>> Stashed changes
        }

        public String getPersonsRace()
        {
            return personRace;
        }
    }
}