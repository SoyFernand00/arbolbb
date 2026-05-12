using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolbb
{
    internal class Nodo
    {
        int dato;
        Nodo izquierda;
        Nodo derecha;

        public Nodo(int dato)
        {
            this.dato = dato;
            izquierda = null;
            derecha = null;
        }
    }
}
