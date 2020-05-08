using System;
using System.Collections.Generic;
using System.Text;

namespace Buecherei
{
    public class AusleihbaresMedium
    {
        

        public bool istAusgeliehen;
        public DateTime ausgeliehenBis;

        public virtual int AUSLEIHFRIST
        {
            get { return 30; }
        }

        public virtual bool KannAusgeliehenWerden(DateTime bis)
        {
            DateTime localDate = DateTime.Now;
            bool istAusleihfristueberschritten = (bis <= localDate.AddDays(AUSLEIHFRIST));
            bool kannAusgeliehenWerden = !istAusgeliehen && istAusleihfristueberschritten;

            return kannAusgeliehenWerden;
        }

        public void AusleihenBis(DateTime bis)
        {
            if(KannAusgeliehenWerden(bis))
            {
                istAusgeliehen = true;
                ausgeliehenBis = bis;
            }
        }
    }
}
