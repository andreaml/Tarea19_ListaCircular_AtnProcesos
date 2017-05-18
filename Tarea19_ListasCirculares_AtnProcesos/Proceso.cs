using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea19_ListasCirculares_AtnProcesos
{
    class Proceso
    {
        private int _ciclos;
        public int ciclos { set { _ciclos = value; } get { return _ciclos; } }
        private Proceso _anterior;
        public Proceso anterior { set { _anterior = value; } get { return _anterior; } }
        private Proceso _siguiente;
        public Proceso siguiente { set { _siguiente = value; } get { return _siguiente; } }

        public Proceso(int ciclos)
        {
            _ciclos = ciclos;
        }
    }
}
