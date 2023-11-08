namespace _09_Delegados1
{
    // Definimos el delegado con las caracteristicas que nos interesa
    public delegate void MiDelegado(string m);
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto del delegado y lo referenciamos a un metodo
            MiDelegado delegado = new MiDelegado(Radio.MetodoRadio);

            // Ahora por medio del delegado hacemos uso del metodo
            delegado("hola a todos");

            // Hacemos que apunte a otro metodo
            delegado = new MiDelegado(Pastel.MostrarPastel);

            // Ahora invocamos el otro metodo
            delegado("Feliz cumpleaños");
        }
    }
}
