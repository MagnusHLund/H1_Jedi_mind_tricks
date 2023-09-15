using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace H1_Jedi_mind_tricks.Controller
{
    internal class Controller
    {

        public void StartController()
        {
            // Create instance to the characters model,
            // which contains a dictionary for star wars characters and if they have force abilities.
            Model.Characters characters = new Model.Characters();

            // View class instance, which is my GUI class
            View.View view = new();

            // Add a character, in this case i added the droid Chopper https://starwars.fandom.com/wiki/C1-10P
            characters.people.Add("C1-10P", false);

            // Removes the character, whom is named "Han"
            characters.people.Remove("Han");

            // Runs through each character in the dictionary
            foreach (var character in characters.people)
            {
                view.Message($"Name: \t\t\t{character.Key} \nHas force abilities? \t{character.Value}\n");
            }
        }
    }
}
