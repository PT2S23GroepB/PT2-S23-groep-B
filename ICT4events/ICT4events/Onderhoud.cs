using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICT4events
{
    abstract class Onderhoud
    {
        private DateTime eindDatum;
        public DateTime EindDatum { get { return eindDatum; } }

        public Onderhoud()
        {

        }

        abstract string ToString();
    }
}
