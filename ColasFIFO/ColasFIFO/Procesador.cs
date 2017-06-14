using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Procesador
    {
        public Proceso inicio { get; private set; }
        public Proceso fin { get; private set; }
        public int _totalProcesos { get; private set; }
        public int _ciclosNecesarios { get; private set; }

        public Procesador()
        {
            this._totalProcesos = 0;
            this._ciclosNecesarios = 0;
            this.inicio = null;
            this.fin = null;
        }

        public void push(Proceso nuevo)
        {
            if (inicio != null) 
            {
                fin.siguente = nuevo;
                fin = nuevo;
            }
            else 
            {
                inicio = nuevo;
                fin = nuevo;
            }
            _totalProcesos++;
            _ciclosNecesarios += nuevo._ciclosProceso;
        }
        
        public void pop(int ciclosR)
        {
            if (ciclosR == 0) 
            {
                inicio = inicio.siguente;
                _totalProcesos--;
            }
        }

        public int procesar()
        {
            int restantes;
            restantes = inicio.ciclosRestantes();
            _ciclosNecesarios--;
            return restantes;
        }

    }
}
