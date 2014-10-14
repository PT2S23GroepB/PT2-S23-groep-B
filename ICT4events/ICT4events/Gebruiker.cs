using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICT4events
{
    class Gebruiker
    {
        private string gebruikersnaam;
        public string GebruikersNaam { get { return gebruikersnaam; } }

        private int type;
        public int Type { get { return type; } }

        private string wachtwoord;
        public string Wachtwoord { get { return wachtwoord; } }

        public Gebruiker(string gebruikersnaam, int type, string wachtwoord)
        {
            this.gebruikersnaam = gebruikersnaam;
            this.type = type;
            this.wachtwoord = wachtwoord;
        }
    }
}
