public class Pais
{
    public string Nombre{get;private set;}
    public string imgBandera{get;private set;}
    public int Poblacion{get;private set;}
    public DateTime FechaIndependencia{get;private set;}
    public string AtractivosTuristicos{get;private set;}

    public Pais()
    {

    }
    public Pais(string Nom,string imgBand,int Pob,DateTime Inde,string Tur)
    {
        Nombre = Nom;
        imgBandera = imgBand;
        Poblacion = Pob;
        FechaIndependencia = Inde;
        AtractivosTuristicos = Tur;
    }
}