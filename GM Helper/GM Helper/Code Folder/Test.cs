using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;

namespace GM_Helper.Code_Folder
{
    public class Class1
    {
        Random random = new Random();

        //An example way of handling our descriptions of places, people, events, etc. This can be added to.
        struct description
        {
            public String descript;
            public List<String> tags;
        }

        List<description> places;
        List<description> people;
        List<description> events;

        //The massive description lists need to be put somewhere
        void addplaces()
        {
            description d1 = new description();
            d1.descript = "It's a forest.";
            d1.tags.Add("forest");
            d1.tags.Add("trees");
            places.Add(d1);
            //And so on
        }

        //Returns a list of descriptions that have the given tag
        List<description> findplaces(String tag)
        {
            List<description> copy = places;
            for (int i = 0; i < places.Count; i++)
            {
                bool save = false;
                foreach (String t in places[i].tags)//Checks all tags for the one you're looking for
                {
                    if (t.Equals(tag))
                    {
                        save = true;//Makes this description not get deleted from the copy
                    }
                }
                if (!save)
                {
                    copy.RemoveAt(i);
                }
            }
            return copy;
        }

        //Generated the scene/output.
        String generate(String placeTag)//The parameters of this function should be filled with all the settings
        {
            String output = "";

            //Follow this logic but for every section of the output
            List<description> filteredPlaces = findplaces(placeTag);
            int randomPlace = (int)Math.Floor((double)random.Next(filteredPlaces.Count));
            output += filteredPlaces[randomPlace].descript;

            return output;
        }
    }
}