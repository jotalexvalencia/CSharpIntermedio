// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
// Metodo 1

class Program
{
    static void Main(string[] args)
    {
        // Busqueda de expresion en un texto
        string texto = "La casa del casamentero";
        string exp = "casa";

        MatchCollection encontrado = Regex.Matches(texto, exp);

        foreach (Match e in encontrado)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("------------");

        // Metodo 2

        // busqueda de una palabra especifica (ojo si está al final)
        texto = "El estudiante es un casanova en la escuela";
        exp = " casa ";

        Regex expReg = new Regex(exp);

        encontrado = expReg.Matches(texto);

        foreach (Match e in encontrado)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("------------");

        // uso de . significa cualquier caracter
        // cabal, campeon, academico

        texto = "Saludos al mas cabal";
        exp = " ca.";

        MatchesExp(texto, exp);

        // uso de clases de caracteres, se usa [] para contener los caracteres
        // Nico, Necio, Naco
        texto = "Hola Nico";
        exp = "N[ie]c";

        MatchesExp(texto, exp);

        // un rango
        // Nico, Neco, Noco, Ndco, Nzco
        texto = "Hola Nico, Naco, Neco, Noco, Nuco, Ndco, Nzco";
        exp = "N[a-u]c";

        MatchesExp(texto, exp);

        // uso de complemento
        // Noco, Nico
        texto = "Hola Noco, Nico, Naco, Nuco";
        exp = "N[^ie]c";
        MatchesExp(texto, exp);

        // verificamos si tiene la expresion despues de n caracter
        texto = "De Youtube Nicosiored es mi canal favorito Necesario";
        exp = "N[ie]c";

        expReg = new Regex(exp);
        if (expReg.IsMatch(texto,5))
        {
            Console.WriteLine("Si tiene");


        } else
            Console.WriteLine("No tiene");
        Console.WriteLine("------------");

        // para saber si una cadena finaliza con una expresion
        texto = "De Youtube Nicosiored es mi canal favorito Nic";
        exp = "N[ie]c$";

        MatchesExp(texto,exp);

        // Elemento opcional
        // Nico, Nilo, Nio
        texto = "Hola Nico";
        exp = "N[ie]c?o";

        MatchesExp(texto, exp);

        // cuantificador
        // busca que existan n de esos elementos
        texto = "Holaa 25 Nico 90";
        exp = "[0-9]{2}"; // que entre el 0 y el 9 existan 2 elementos
        MatchesExp(texto, exp);

        // alternaciones
        texto = "Yo se programar en java";
        exp = "(c|java|python)";
        MatchesExp(texto, exp);

        // Split
        texto = "Este es un tes de separacion, division";
        exp = ",";

        string[] cadenas = Regex.Split(texto, exp);

        foreach (string c in cadenas)
            Console.WriteLine(c);

        Console.WriteLine("------------");

        // Reemplazar
        texto = "Yo hablo ingles y no soy ingles";
        expReg = new Regex("ingles");

        string reemplazo = "Español";

        string resultado = expReg.Replace(texto,reemplazo);

        Console.WriteLine(resultado);
    }

    public static void MatchesExp(string pTexto, string pExp)
    {
        MatchCollection encontrado = Regex.Matches(pTexto, pExp);

        foreach (Match e in encontrado)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("------------");
    }
}