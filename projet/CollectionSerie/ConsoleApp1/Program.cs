using System;
using Modele;
using Data;

namespace AfficherDetailsSerieTest
{
    public class Program
    {
        static void Main()
        {
             Manager Manager = new Manager(new Stub());

            foreach (Serie serie in Manager.Serietheque.ListeSeries)
            {
                Console.WriteLine(serie.Synopsis);
                Console.WriteLine(serie.BandeAnnonce);
                Console.WriteLine(serie.Disponibilite);
                foreach (Commentaire com in serie.ListeCommentaires)
                {
                    Console.WriteLine(com);
                }
            }
        }
    }
}
