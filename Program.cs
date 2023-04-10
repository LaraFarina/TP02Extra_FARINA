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
        Boxeador boxeador1 = new Boxeador(nom, pais, peso, pg, vp);
        Boxeador boxeador2 = new Boxeador(nom, pais, peso, pg, vp);


        Console.WriteLine("1. Cargar datos Boxeador 1");
        Console.WriteLine("2. Cargar datos Boxeador 2");
        Console.WriteLine("3. Pelear!");
        Console.WriteLine("4. Salir");
        opcion = IngresarEntero("Ingrese una de las opciones.");
        switch (opcion)
        {
            case 1:

                boxeador1 = ObtenerBoxeador();
                break;
            case 2:

                boxeador2 = ObtenerBoxeador(); break;
            case 3:
            Pelear(boxeador1,boxeador2);
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


    static void Pelear(Boxeador boxeador1, Boxeador boxeador2)
    {
        if (boxeador1 != null && boxeador2 != null)
        {
            double skill1;
            double skill2;
            skill1 = boxeador1.ObtenerSkill();
            skill2 = boxeador2.ObtenerSkill();
            if (skill1 > skill2)
            {
                if ((skill1 - skill2) >= 30)
                {
                    Console.WriteLine($"Ganó {boxeador1.Nombre} por KO");
                }
                else if ((skill1 - skill2) >= 10 && (skill1 - skill2) < 30)
                {
                    Console.WriteLine($"Ganó {boxeador1.Nombre} por puntos en fallo unánime");
                }
                else
                {
                    Console.WriteLine($"Ganó {boxeador1.Nombre} por puntos en fallo dividido");
                }
            }
            else if (skill2 > skill1)
            {
                if ((skill2 - skill1) >= 30)
                {
                    Console.WriteLine($"Ganó {boxeador2.Nombre} por KO");
                }
                else if ((skill2 - skill1) >= 10 && (skill2 - skill1) < 30)
                {
                    Console.WriteLine($"Ganó {boxeador2.Nombre} por puntos en fallo unánime");
                }
                else
                {
                    Console.WriteLine($"Ganó {boxeador2.Nombre} por puntos en fallo dividido");
                }
            }
            else
            {
                Console.WriteLine("Los dos boxeadores empataron");
            }
        } else{
            Console.WriteLine("Uno de los boxeadores (O ninguno) no existe.");
        }


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