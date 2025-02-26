namespace ListasDoblementeLigadasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista(); // Se crea la lista

            lista.Agregar("A");
            lista.Agregar("B");
            lista.Agregar("C");
            lista.Agregar("D");
            lista.Agregar("E");

            // Se agregan los elementos para verificar la lista
            Console.WriteLine("Lista original:");
            Console.WriteLine(lista.ObtenerValores());

            // Eliminar un elemento
            lista.Eliminar("C");
            Console.WriteLine("Eliminando la letra asignada la lista queda 'C':");
            Console.WriteLine(lista.ObtenerValores());
        }
    }
}
