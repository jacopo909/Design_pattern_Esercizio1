using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    public class Tabella
    {
        private List<Riga> riga = new List<Riga>();

        public Riga CreaRighe()
        {
            Riga r = new Riga();
            riga.Add(r);
            return r;
        }
    }
}
