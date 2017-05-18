using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea19_ListasCirculares_AtnProcesos
{
    class Procesador
    {
        private static Random _nuevoProceso = new Random();
        private int _procesosAtendidosEnTotalidad = 0;
        private int _procesosFormados = 0;
        private int _ciclosVacia = 0;
        private Lista _miLista = new Lista();

        public Procesador()
        {

        }

        public void iniciarCiclos()
        {
            for (int i = 0; i < 200; i++)
            {
                if (_nuevoProceso.Next(1, 5) == 1)
                {
                    _miLista.agregarProceso();
                    _procesosFormados++;
                }
                if (_miLista.primero != null)
                {
                    atenderProceso();
                }
                else
                    _ciclosVacia++;
            }
        }

        private void atenderProceso()
        {
            _miLista.primero.ciclos--;
            if (_miLista.primero.ciclos == 0)
            {
                _miLista.eliminarProceso();
                _procesosAtendidosEnTotalidad++;
            }
            else
                _miLista.rotarProceso();
        }

        public int procesosFormados()
        {
            return _procesosFormados;
        }

        public int procesosAtendidosEnTotalidad()
        {
            return _procesosAtendidosEnTotalidad;
        }

        public int procesosPendientes()
        {
            return _procesosFormados - _procesosAtendidosEnTotalidad;
        }

        public int ciclosPendientes()
        {
            return _miLista.calcularCiclosPendientes();
        }

        public int ciclosVacia()
        {
            return _ciclosVacia;
        }

    }
}
