class Boxeador
{
    public string Nombre { get; set; }
    public string Pais { get; set; }
    public int Peso { get; set; }
    public int PotenciaGolpes { get; set; }
    public int VelocidadPiernas { get; set; }

    public Boxeador(string nom, string pais, int peso, int pg, int vp)
    {

        Nombre = nom;
        Pais = pais;
        Peso = peso;
        PotenciaGolpes = pg;
        VelocidadPiernas = vp;
    }
    public double ObtenerSkill()
    {
        Random r = new Random();
        double skill;
        skill = (VelocidadPiernas * 0.6) + (PotenciaGolpes * 0.8) + r.Next(1, 10);
        return skill;
    }


}