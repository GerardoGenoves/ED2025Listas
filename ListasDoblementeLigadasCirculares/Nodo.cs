using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    public class Nodo
    {
        public string Dato { get; set; } = string.Empty; // Almacena el valor del nodo
        public Nodo? Siguiente { get; set; } = null; // Apunta al siguiente nodo
        public Nodo? Anterior { get; set; } = null; // Apunta al nodo anterior
    }
}
