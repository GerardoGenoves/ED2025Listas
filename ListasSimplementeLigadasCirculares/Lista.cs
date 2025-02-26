using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadasCirculares
{
    internal class Lista
    {
        private Nodo? _nodoInicial;

        public Lista()
        {
            _nodoInicial = null;
        }

        public void Agregar(string dato)
        {
            Nodo nuevoNodo = new Nodo { Dato = dato };

            // Si la lista está vacía, inicializamos el primer nodo
            if (_nodoInicial == null)
            {
                _nodoInicial = nuevoNodo;
                _nodoInicial.Siguiente = _nodoInicial; // Se apunta a sí mismo, formando el ciclo
            }
            else
            {
                Nodo nodoActual = _nodoInicial;
                while (nodoActual.Siguiente != _nodoInicial) // Recorremos hasta el último nodo
                {
                    nodoActual = nodoActual.Siguiente;
                }
                nodoActual.Siguiente = nuevoNodo;
                nuevoNodo.Siguiente = _nodoInicial; // Cierra el ciclo, apuntando al nodo inicial
            }
        }

        public bool EstaVacio() => _nodoInicial == null;

        public void Vaciar()
        {
            _nodoInicial = null; // Vaciamos la lista
        }

        public Nodo? Buscar(string dato)
        {
            if (EstaVacio()) return null;

            Nodo nodoActual = _nodoInicial;
            do
            {
                if (nodoActual.Dato == dato)
                {
                    return nodoActual;
                }
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != _nodoInicial); // Si volvemos al nodo inicial, la lista es circular

            return null;
        }

        public void Eliminar(string dato)
        {
            if (EstaVacio()) return;

            Nodo nodoActual = _nodoInicial, nodoAnterior = null;

            // Si el nodo a eliminar es el nodo inicial
            if (_nodoInicial.Dato == dato)
            {
                if (_nodoInicial.Siguiente == _nodoInicial) // Si solo hay un nodo
                {
                    _nodoInicial = null; // La lista se vacía
                }
                else
                {
                    Nodo ultimo = _nodoInicial;
                    while (ultimo.Siguiente != _nodoInicial)
                    {
                        ultimo = ultimo.Siguiente;
                    }
                    _nodoInicial = _nodoInicial.Siguiente;
                    ultimo.Siguiente = _nodoInicial; // El último nodo apunta al nuevo nodo inicial
                }
                return;
            }

            // Buscamos el nodo a eliminar en el resto de la lista
            do
            {
                nodoAnterior = nodoActual;
                nodoActual = nodoActual.Siguiente;

                if (nodoActual.Dato == dato)
                {
                    nodoAnterior.Siguiente = nodoActual.Siguiente;
                    return;
                }
            } while (nodoActual != _nodoInicial); // Si volvemos al nodo inicial, la lista es circular
        }

        public string ObtenerValores()
        {
            if (EstaVacio()) return "Lista vacía";

            StringBuilder datos = new StringBuilder();
            Nodo nodoActual = _nodoInicial;

            // Comentario indicando el inicio de la lista
            datos.AppendLine("Inicio de la lista:");

            do
            {
                datos.AppendLine(nodoActual.Dato);
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != _nodoInicial); // Detiene el ciclo cuando se vuelve al nodo inicial

            // Comentario indicando el final de la lista (que vuelve al inicio)
            datos.AppendLine("Fin de la lista (vuelve al inicio).");

            return datos.ToString();
        }
    }
}
    