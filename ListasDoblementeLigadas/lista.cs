using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        private Nodo? _nodoInicial;

        public Lista()
        {
            _nodoInicial = null;  // Inicia la lista vacía
        }

        public void Agregar(string dato)
        {
            Nodo nodoNuevo = new Nodo { Dato = dato };

            if (_nodoInicial == null)
            {
                _nodoInicial = nodoNuevo;
            }
            else
            {
                Nodo nodoActual = _nodoInicial;

                // Recorremos hasta el final de la lista
                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }

                nodoActual.Siguiente = nodoNuevo; // Apuntamos el nodo anterior al nuevo
                nodoNuevo.Anterior = nodoActual; // Establecemos la relación en sentido contrario
            }
        }

        public bool EstaVacio()
        {
            return _nodoInicial == null;  // Lista vacía si el nodo inicial es null
        }

        public void Vaciar()
        {
            _nodoInicial = null;  // Vacía la lista, eliminando la referencia inicial
        }

        public Nodo? Buscar(string dato)
        {
            Nodo? nodoActual = _nodoInicial;

            while (nodoActual != null)
            {
                if (nodoActual.Dato == dato)
                {
                    return nodoActual;
                }
                nodoActual = nodoActual.Siguiente;
            }

            return null;
        }

        public void Eliminar(string dato)
        {
            Nodo? nodoAEliminar = Buscar(dato);

            if (nodoAEliminar != null)
            {
                if (nodoAEliminar.Anterior != null)
                {
                    nodoAEliminar.Anterior.Siguiente = nodoAEliminar.Siguiente;
                }
                else
                {
                    _nodoInicial = nodoAEliminar.Siguiente; // Si es el primer nodo, actualizar el inicio
                }

                if (nodoAEliminar.Siguiente != null)
                {
                    nodoAEliminar.Siguiente.Anterior = nodoAEliminar.Anterior;
                }

                nodoAEliminar.Siguiente = null;
                nodoAEliminar.Anterior = null;
            }
        }

        public string ObtenerValores()
        {
            StringBuilder datos = new StringBuilder();
            Nodo? nodoActual = _nodoInicial;

            while (nodoActual != null)
            {
                datos.AppendLine(nodoActual.Dato);
                nodoActual = nodoActual.Siguiente;
            }

            return datos.ToString();
        }

        public string ObtenerValoresInverso()
        {
            StringBuilder datos = new StringBuilder();
            Nodo? nodoActual = _nodoInicial;

            // Ir hasta el último nodo
            while (nodoActual != null && nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            // Recorrer la lista en sentido inverso
            while (nodoActual != null)
            {
                datos.AppendLine(nodoActual.Dato);
                nodoActual = nodoActual.Anterior;
            }

            return datos.ToString();
        }
    }
}