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
        public List<Sector> Sectoren { get { return sectoren; } }
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

        //Voegt een aantal sectoren toe aan een spoor op het moment dat het spoor aangemaakt wordt.
        public void Add(int sectorNr)
        {
            Sector sector = new Sector(sectorNr);
            sectoren.Add(sector);
        }

        //Blokkeert een heel spoor
        public void Blokkeer()
        {
            foreach(Sector s in sectoren)
            {
                s.Blokkeer();
            }
        }
        
        //Blokkeert alle sectoren achter de geselecteerde sector incl. het gekozen nr.
        public void Blokkeer(int sectorNr)
        {
            foreach(Sector s in sectoren)
            {
                if(sectorNr <= s.SectorNr)
                {
                    s.Blokkeer();
                }
            }
        }
    }
}
