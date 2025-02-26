namespace ListasSimplementeLigadas
{
    internal class Nodo //Se declara la clase nodo y el internal significa que solo podra ser usada dentro del proyecto
    {
        public string Dato { get; set; } = string.Empty; //declara una propiedad de la clase nodo en este caso de tipo string, 
        //el get y set son para poder escribir el valor de la propiedad y el =string.empty 
        public Nodo? Siguiente { get; set; } = null;

    }
}
