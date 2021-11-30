using System;
using Modele;
using Data;

namespace AfficherSerieTest
{
    class Program
    {
        static void Main()
        {
            Manager Manager = new Manager(new Stub());
            foreach (Serie serie in Manager.Serietheque.ListeSeries)
            {
                Console.WriteLine(serie.Nom);
                Console.WriteLine(serie.Miniature);
            }
        }
    }
}
