using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICT4events
{
    public class Remise
    {
        private string naam;
        public string Naam { get { return naam; } }

        private List<Tram> trams;

        public List<Tram> Trams { get { return trams; } }
        private List<Spoor> sporen;
        public List<Spoor> Sporen { get { return sporen; } }
        private List<Gebruiker> gebruikers;
        public List<Gebruiker> Gebruikers { get { return gebruikers; } }

        public Remise(string naam)
        {
            this.naam = naam;
            trams = new List<Tram>();
            sporen = new List<Spoor>();
            gebruikers = new List<Gebruiker>();
        }

        public void Add(Gebruiker gebruiker)
        {
            gebruiker = new Gebruiker(gebruiker.GebruikersNaam, gebruiker.Type, gebruiker.Wachtwoord);
            gebruikers.Add(gebruiker);
        }

        public void Add(Tram tram)
        {
            tram = new Tram(tram.Lengte,tram.TramNr,tram.Voorkeurslijn,tram.RFID);
            trams.Add(tram);
        }

        public void Blokkeer(int spoorNr, int sector)
        {
            foreach(Spoor s in sporen)
            {
                if(s.SpoorNr == spoorNr)
                {
                    s.Blokkeer(sector);
                }
            }
        }

        public void Blokkeer(int spoorNr)
        {
            foreach (Spoor s in sporen)
            {
                s.Blokkeer();
            }
        }

        public void GeefSchoonmaakLijst(int tramNR)
        { }

        public void GeefSpoor(int tramNr)
        { }

        public void LogIn(string gebruikersnaam, string wachtwoord)
        { }

        public void PlanOnderhoud(int tramNr, DateTime geschatteEindDatum, Gebruiker gebruiker)
        { }

        public void PlanReparatie(int tramNr, DateTime geschatteEindDatum)
        {}

        public void PlanSchoonmaak(int tramNr, DateTime datum)
        {}

        public void RemoveGebruiker(Gebruiker gebruiker)
        { }

        public void RemoveTram(int tramNr)
        { }

        public void ReserveerSpoor(int tramNr, int spoorNr, int sectorNr)
        { }

        public void RFIDScan(int rfid)
        { }

        public void UpdateOnderhoud(int tramNr, DateTime datum, string commentaar, int status)
        { }

        public void UpdateTram(int tramNr, int spoorNr, int sectorNr)
        { }

        public void VeranderStatus(int tramNr, int status)
        { }
    }
}
