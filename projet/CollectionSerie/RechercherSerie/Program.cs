using System;
using Modele;
using Data;

namespace RechercherSerie
{
    class Program
    {
        static void Main()
        {
            Manager Manager = new Manager(new Stub());

            Manager.RechercherSerie("Les Pyramides D'Egypte");

            Console.WriteLine(Manager.Serietheque.ListeSeriesAffiche[0].Nom);

            Console.WriteLine(Manager.Serietheque.ListeSeriesAffiche[0].Nom);
            Console.WriteLine(Manager.Serietheque.ListeSeriesAffiche[0].Miniature);


            Manager.RechercherSerie("Lucifer");
            if (Manager.Serietheque.ListeSeriesAffiche.Count == 0)
                Console.WriteLine("Aucune Série trouvé");
        }
    }
}
