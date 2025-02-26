using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista(); //se crea la lista

            lista.Agregar("A");
            lista.Agregar("B");
            lista.Agregar("C");
            lista.Agregar("D");
            lista.Agregar("E");
            //se agregan las letras para verificar la lista
            Console.WriteLine("Lista original:");
            Console.WriteLine(lista.ObtenerValores());

            lista.Eliminar("A"); //se elimina la letra B

            Console.WriteLine("\nLista después de eliminar 'A':");
            Console.WriteLine(lista.ObtenerValores()); //se imprimen los valores de la lista
        }
    }
}