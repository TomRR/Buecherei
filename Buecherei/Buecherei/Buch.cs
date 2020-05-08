using System;
using System.Collections.Generic;
using System.Text;

namespace Buecherei
{
    public class Buch : AusleihbaresMedium
    {
        public bool InReparatur { get; set; }

        public override bool KannAusgeliehenWerden(DateTime bis)
        {
            return base.KannAusgeliehenWerden(bis) && !InReparatur;
        }
    }
}
