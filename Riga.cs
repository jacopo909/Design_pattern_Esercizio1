using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    public class Riga
    {
        private List<Cella> cella = new List<Cella>();
        public Riga() { }

        public Cella CreaCella()
        {
            Cella c = new Cella();
            cella.Add(c);
            return c;
        }
    }
}
