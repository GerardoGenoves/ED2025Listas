using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    public class Lista
    {
        private Nodo? _nodoInicial; // El primer nodo de la lista

        public Lista()
        {
            _nodoInicial = null; // Inicialmente la lista está vacía
        }

        // Agregar un nodo al final de la lista
        public void Agregar(string dato)
        {
            Nodo nodoNuevo = new Nodo
            {
                Dato = dato
            };

            if (_nodoInicial == null) // Si la lista está vacía
            {
                _nodoInicial = nodoNuevo;
                nodoNuevo.Siguiente = nodoNuevo; // El primer nodo apunta a sí mismo (circular)
                nodoNuevo.Anterior = nodoNuevo; // El primer nodo también tiene como anterior al mismo nodo
            }
            else
            {
                Nodo nodoActual = _nodoInicial;

                // Recorrer hasta llegar al último nodo
                while (nodoActual.Siguiente != _nodoInicial)
                {
                    nodoActual = nodoActual.Siguiente!;
                }

                // Conectar el nuevo nodo al último nodo
                nodoActual.Siguiente = nodoNuevo;
                nodoNuevo.Anterior = nodoActual;

                // Hacer que el nuevo nodo apunte de nuevo al nodo inicial
                nodoNuevo.Siguiente = _nodoInicial;
                _nodoInicial.Anterior = nodoNuevo;
            }
        }

        // Verificar si la lista está vacía
        public bool EstaVacio()
        {
            return _nodoInicial == null;
        }

        // Vaciar la lista
        public void Vaciar()
        {
            _nodoInicial = null;
        }

        // Buscar un nodo por su dato
        public Nodo? Buscar(string dato)
        {
            if (!EstaVacio())
            {
                Nodo nodoActual = _nodoInicial;

                do
                {
                    if (nodoActual.Dato == dato)
                    {
                        return nodoActual;
                    }
                    nodoActual = nodoActual.Siguiente!;
                } while (nodoActual != _nodoInicial); // Volver a iniciar el ciclo cuando llegamos al nodo inicial

            }
            return null;
        }

        // Eliminar un nodo
        public void Eliminar(string dato)
        {
            if (!EstaVacio())
            {
                Nodo? nodoAEliminar = Buscar(dato);

                if (nodoAEliminar != null)
                {
                    // Si es el único nodo en la lista
                    if (nodoAEliminar.Siguiente == nodoAEliminar)
                    {
                        _nodoInicial = null;
                    }
                    else
                    {
                        Nodo nodoAnterior = nodoAEliminar.Anterior!;
                        Nodo nodoSiguiente = nodoAEliminar.Siguiente!;

                        nodoAnterior.Siguiente = nodoSiguiente;
                        nodoSiguiente.Anterior = nodoAnterior;

                        if (nodoAEliminar == _nodoInicial)
                        {
                            _nodoInicial = nodoSiguiente; // Si eliminamos el primer nodo, actualizamos el nodo inicial
                        }
                    }
                }
            }
        }

        // Obtener todos los valores de la lista como una cadena de texto
        public string ObtenerValores()
        {
            StringBuilder datos = new StringBuilder();
            if (_nodoInicial != null)
            {
                Nodo nodoActual = _nodoInicial;

                do
                {
                    datos.AppendLine(nodoActual.Dato);
                    nodoActual = nodoActual.Siguiente!;
                } while (nodoActual != _nodoInicial); // Continuar hasta volver al nodo inicial

            }

            return datos.ToString();
        }
    }
}
