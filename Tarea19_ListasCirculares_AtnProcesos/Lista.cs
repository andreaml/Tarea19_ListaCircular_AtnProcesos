using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea19_ListasCirculares_AtnProcesos
{
    class Lista
    {
        private static Random _numCiclos = new Random();
        private Proceso _primero;
        public Proceso primero { get { return _primero; } }

        public Lista()
        {

        }

        public void agregarProceso()
        {
            if (_primero == null)
            {
                _primero = new Proceso(_numCiclos.Next(4, 13));
                _primero.siguiente = _primero;
                _primero.anterior = _primero;
            }
            else
            {
                Proceso baseNueva = new Proceso(_numCiclos.Next(4, 13));
                _primero.anterior.siguiente = baseNueva;
                baseNueva.anterior = _primero.anterior;
                baseNueva.siguiente = _primero;
                _primero.anterior = baseNueva;
            }
        }
        
        public void eliminarProceso()
        {
            if (_primero.siguiente == _primero && _primero.anterior == _primero)
                _primero = null;
            else
            {
                _primero.anterior.siguiente = _primero.siguiente;
                _primero.siguiente.anterior = _primero.anterior;
                _primero = _primero.siguiente;
            }
        }

        public void rotarProceso()
        {
            _primero = _primero.siguiente;
        }

        public int calcularCiclosPendientes()
        {
            if (_primero != null)
                return calcularCiclosPendientes(_primero);
            else
                return 0;
        }

        private int calcularCiclosPendientes(Proceso ultimo)
        {
            if (ultimo.siguiente != _primero)
                return ultimo.ciclos + calcularCiclosPendientes(ultimo.siguiente);
            else
            {
                return ultimo.ciclos;
            }
        }
    }
}
