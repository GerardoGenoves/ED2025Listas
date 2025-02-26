using System.Text;

namespace ListasSimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial; //se declara el nodo por defecto con valor empty y apuntando a null

        public Lista() 
        {
            _nodoInicial = new Nodo();
        }

        public void Agregar(string dato) //Este metodo es para agregar nodos 
        {
            Nodo nodoActual = _nodoInicial; 

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Dato = dato;

            nodoActual.Siguiente = nodoNuevo;
        }

        public bool EstaVacio()  //este metodo pregunta si el nodo inicial.siguiente es igual a null
        {
           
            return (_nodoInicial.Siguiente == null); 
        }
        public Nodo? Buscar(string dato) //metodo para buscar datos cuando se necesite eliminar
        {
            if (!EstaVacio())
            {
                Nodo nodoActual = _nodoInicial;

                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;

                    if (nodoActual.Dato == dato)
                    {
                        return nodoActual;
                    }
                }
            }
            return null;
        }

        private Nodo? BuscarAnterior(string dato) //busca el nodo predecesor al nodo que contiene un valor especifico
        {
            if (!EstaVacio())
            {
                Nodo nodoActual = _nodoInicial;

                while (nodoActual.Siguiente != null)
                {
                    if (nodoActual.Siguiente.Dato == dato)
                    {
                        return nodoActual;
                    }

                    nodoActual = nodoActual.Siguiente;
                }
            }
            return null;
        }

        public void Eliminar(string dato) //metodo para eliminar
        {
            if (!EstaVacio())
            {
                Nodo? nodoActual = Buscar(dato);

                if (nodoActual != null)
                {
                    Nodo? nodoAnterior = BuscarAnterior(dato);

                    if (nodoAnterior != null)
                    {
                        nodoAnterior.Siguiente = nodoActual.Siguiente;
                        nodoActual.Siguiente = null;
                    }
                }
            }
        }

        public string ObtenerValores() //recorre la lista y devuelve todos los valores almacenados en la lista como un string
        {
            StringBuilder datos = new StringBuilder();
            Nodo nodoActual = _nodoInicial;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;

                datos.AppendLine(nodoActual.Dato);
            }

            return datos.ToString();
        }
    }
}
