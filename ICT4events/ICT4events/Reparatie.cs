using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICT4events
{
    class Reparatie : Onderhoud
    {
        private string commentaar;
        public string Commentaar { get { return commentaar; } }

        private DateTime geschatteEindDatum;
        public DateTime GeschatteEindDatum { get { return geschatteEindDatum; } }

        public Reparatie()
            : base()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
