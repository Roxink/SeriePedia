using Modele;
using System;

namespace AfficherDetailsSerieTest
{
    class Program
    {
        public void Test()
        {

            Manager manager = new Stub("").ChargeManager();

            foreach (Serie serie in manager.Serietheque.ListeSeries)
            {
                Console.WriteLine(serie.Nom);
                Console.WriteLine(serie.Miniature);
            }
        }
    }
}
