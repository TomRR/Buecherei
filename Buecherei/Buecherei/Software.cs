using System;
using System.Collections.Generic;
using System.Text;

namespace Buecherei
{
    public class Software : AusleihbaresMedium
    {
        public override int AUSLEIHFRIST
        {
            get { return 7; }
        }
    }
}
