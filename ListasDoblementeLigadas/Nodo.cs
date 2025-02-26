using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Nodo
    {
        public string Dato { get; set; } = string.Empty;  // Almacena el dato del nodo
        public Nodo? Siguiente { get; set; } = null;  // Apunta al siguiente nodo
        public Nodo? Anterior { get; set; } = null;  // Apunta al nodo anterior
    }
}

