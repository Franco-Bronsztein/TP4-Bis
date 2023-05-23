public static class Info
{
    private static List<Pais> ListaPaises = new List<Pais>{};

    private static void inicializarLista()
    {
        Pais unPais = new Pais("Argentina","Argentina.jpg",4500000,new DateTime(1816,7,9),"Cataratas");
        ListaPaises.Add(unPais);
        unPais = new Pais("Brasil","Brasil.jpg",14500000,new DateTime(1816,7,10),"Amazonas");
        ListaPaises.Add(unPais);
        unPais = new Pais("Chile","Chile.jpg",2500000,new DateTime(1816,7,11),"Chile");
        ListaPaises.Add(unPais);
        unPais = new Pais("Uruguay","Uruguay.jpg",3000000,new DateTime(1816,7,17),"Punta Del Este");
        ListaPaises.Add(unPais);
        unPais = new Pais("Mexico","Mexico.jpg",1000000,new DateTime(1816,4,12),"Guadalajara");
        ListaPaises.Add(unPais);
    }
    
    public static List<Pais> ListarPaises()
    {
        if(ListaPaises.Count == 0)
        {
            inicializarLista();
        }
        return ListaPaises;
    }

    public static Pais DetallePais(string Nombre)
    {      
        Pais devolver = new Pais();
        foreach (Pais item in ListaPaises)
        {
            if(item.Nombre == Nombre)
            {
                return item;
            }
        }
        return devolver;
    }

}