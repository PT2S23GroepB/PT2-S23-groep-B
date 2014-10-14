using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICT4events
{
    class Spoor
    {
        private bool bezet;
        private List<Sector> sectoren;
        public bool Bezet { get { return bezet; } }

        private int spoorNr;

        public int SpoorNr { get { return spoorNr; } }

        private string spoorstatus;
        public string SpoorStatus { get { return spoorstatus; } }

        public Spoor(int spoorNr, int aantalsectoren)
        {
            this.spoorNr = spoorNr;
            int i = 1;
            sectoren = new List<Sector>();

            while(i <= aantalsectoren)
            {
                Add(i);
                i++;
            }
        }

        public void Add(int sectorNr)
        {
            Sector sector = new Sector(sectorNr);
            sectoren.Add(sector);
        }
    }
}
