using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Proceso
    {
        public Proceso siguente { get; set; }
        static Random random = new Random();
        public int _ciclosProceso { get; private set; }

        public Proceso()
        {
            _ciclosProceso = random.Next(4, 15);
            siguente = null;
        }

        public int ciclosRestantes()
        {
            _ciclosProceso--;
            return _ciclosProceso;
        }

        public override string ToString()
        {
            return "Ciclos necesarios: " + _ciclosProceso + Environment.NewLine;
        }
    }
}
