using System.ComponentModel;

namespace ListasSimplementeLigadas
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
            Console.WriteLine(lista.ObtenerValores());

            lista.Eliminar("B"); //se elimina la letra C

            Console.WriteLine();
            Console.WriteLine(lista.ObtenerValores()); //se imprimen los valores de la lista
        }
    }
}
