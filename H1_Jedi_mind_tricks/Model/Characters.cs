using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Jedi_mind_tricks.Model
{
    /// <summary>
    /// Class that contains a dictionary. 
    /// String is for their name and the bool is for force sensitivity
    /// </summary>
    internal class Characters
    {
            public Dictionary<string, bool> people = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false },
                { "Hondo", false },
                { "Ezra", true},
                { "Rex", false },
                { "Jabba", false },
                { "Yoda", true },
                { "Rey", true },
                { "Thrawn", false },
                { "Darth maul", true },
                { "Jar-Jar Binks", false },
                { "Yordan", false }, // https://starwars.fandom.com/wiki/Jordan_Smythe
                { "Magnus", true }, // https://starwars.fandom.com/wiki/Magnus_(Sith)
                { "Jonas", false}, // https://starwars.fandom.com/wiki/Jonas_Balkar
            };
    }
}
