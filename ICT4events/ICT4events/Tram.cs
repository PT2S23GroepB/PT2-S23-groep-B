using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICT4events
{
    enum status {
        Defect = 1,
        InDienst = 2,
        Remise = 3,
        Vervuild = 4,
        VervuildenDefect = 5}

    class Tram
    {
        public List<Onderhoud> onderhoudsbeurten;

        private int lengte;
        public int Lengte { get { return lengte; } }

        private int rfid;
        public int RFID { get { return rfid; } }

        /*Status van de Tram
         * 1 = Defect, 2 = In Dienst, 3 = Remise, 4 = Vervuild
         * 5 = Vervuild & Defect
         */

        private int status;
        public int Status { get { return status; } }

        private int tramNr;
        public int TramNr { get { return tramNr; } }

        private int voorkeurslijn;
        public int Voorkeurslijn { get { return voorkeurslijn; } }

        public Tram(int lengte, int tramNr, int voorkeurslijn, int rfid)
        {
            this.lengte = lengte;
            this.tramNr = tramNr;
            this.voorkeurslijn = voorkeurslijn;
            this.rfid = rfid;
            this.status = 3;
            onderhoudsbeurten = new List<Onderhoud>();
        }

        public void GeefSchoonmaaklijst()
        {
            foreach(Onderhoud o in onderhoudsbeurten)
            {
                
            }
        }
    }
}
