using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolbb
{
    internal class Arbolbb
    {
        private Nodo raiz { get; set; }

        public Arbolbb()
        {
            raiz = null;
        }
        public void Insertar(int valor)
        {
            raiz = InsertarRecursivo(raiz, valor);

        }

        private Nodo InsertarRecursivo(Nodo r, int valor)
        {
            if (r == null)
            {
                return new Nodo(valor);
            }
            if (valor < r.Dato)
            {
                r.Izquierda = InsertarRecursivo(r.Izquierda, valor);
            }
            else if (valor > r.Dato)
            {
                r.Derecha = InsertarRecursivo(r.Derecha, valor);
            }
            return r;

        }
        public void Buscar(int valor)
        {
            BuscarRecursivo(raiz, valor);

        }
        private void BuscarRecursivo(Nodo r, int valor)
        {
            if (r == null)
            {
                Console.WriteLine("Valor no encontrado");
                return;
            }

            if (valor == r.Dato)
            {
                Console.WriteLine("Valor encontrado: " + valor);
                return;
            }
            else if (valor < r.Dato)
            {
                BuscarRecursivo(r.Izquierda, valor);
            }
            else
            {
                BuscarRecursivo(r.Derecha, valor);
            }

        }
        public void InOrden()
        {
            InOrdenRecursivo(raiz);
        }
        private void InOrdenRecursivo(Nodo r)
        {
            if (r != null)
            {
                InOrdenRecursivo(r.Izquierda);
                Console.Write(r.Dato + " ");
                InOrdenRecursivo(r.Derecha);
            }
        }
        public void PreOrden()
        {
            PreOrdenRecursivo(raiz);
        }
        private void PreOrdenRecursivo(Nodo r)
        {
            if (r != null)
            {
                Console.Write(r.Dato + " ");
                PreOrdenRecursivo(r.Izquierda);
                PreOrdenRecursivo(r.Derecha);
            }
        }
        public void PostOrden()
        {
            PostOrdenRecursivo(raiz);
        }
        private void PostOrdenRecursivo(Nodo r)
        {
            if (r != null)
            {
                PostOrdenRecursivo(r.Izquierda);
                PostOrdenRecursivo(r.Derecha);
                Console.Write(r.Dato + " ");
            }
        }


    }
}
