namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista(); // Se crea la lista doblemente ligada

            lista.Agregar("A");
            lista.Agregar("B");
            lista.Agregar("C");
            lista.Agregar("D");
            lista.Agregar("E");

            Console.WriteLine("Lista de inicio a fin:");
            Console.WriteLine(lista.ObtenerValores());

            lista.Eliminar("B"); // Se elimina la letra B

            Console.WriteLine("\nLista después de eliminar 'B' de inicio a fin:");
            Console.WriteLine(lista.ObtenerValores());

            Console.WriteLine("\nLista de fin a inicio:");
            Console.WriteLine(lista.ObtenerValoresInverso()); // Imprime la lista de fin a inicio
        }
    }
}