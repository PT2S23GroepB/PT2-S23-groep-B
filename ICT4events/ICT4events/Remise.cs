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

        public Remise(string naam)
        {
            this.naam = naam;
        }

        public void Add(Gebruiker gebruiker)
        {

        }

        public void Add(Tram tram)
        { }

        public void Blokkeer(int spoorNr, int sector)
        {

        }

        public void Blokkeer(int spoorNr)
        {

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
