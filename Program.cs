internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    static int Menu()
    {
        int opcion;
        string nom = "", pais = "";
        int peso = 0, pg = 0, vp = 0;
        Console.WriteLine("1. Cargar datos Boxeador 1");
        Console.WriteLine("2. Cargar datos Boxeador 2");
        Console.WriteLine("3. Pelear!");
        Console.WriteLine("4. Salir");
        opcion = IngresarEntero("Ingrese una de las opciones.");
        switch (opcion)
        {
            case 1:
                Boxeador boxeador1 = new Boxeador(nom, pais, peso, pg, vp);

                boxeador1 = ObtenerBoxeador();
                break;
            case 2:
                Boxeador boxeador2 = new Boxeador(nom, pais, peso, pg, vp);

                boxeador2 = ObtenerBoxeador(); break;
            case 3:
                break;
            case 4:
                break;
        }
        return opcion;
    }
    static Boxeador ObtenerBoxeador()
    {
        string nom, pais;
        int peso, pg, vp;
        nom = IngresarString("Ingrese el nombre del boxeador.");
        pais = IngresarString("Ingrese el país de procedencia del boxeador");
        peso = IngresarEntero("Ingrese el peso del boxeador");
        do
        {
            pg = IngresarEntero("Ingrese la potencia de golpes del boxeador");

        } while (pg < 0 && pg > 100);
        do
        {
            vp = IngresarEntero("Ingrese la velocidad de piernas del boxeador");

        } while (vp < 0 && vp > 100);
        Boxeador b = new Boxeador(nom, pais, peso, pg, vp);
        Console.WriteLine($"Se ha creado el boxeador {nom}");
        return b;
    }


    static void Pelear()
    {

    }
    static int IngresarEntero(string msg)
    {
        Console.WriteLine(msg);
        return int.Parse(Console.ReadLine());
    }
    static string IngresarString(string msg)
    {
        Console.WriteLine(msg);
        return Console.ReadLine();
    }
}