using System;
using System.Collections.Generic;
using Modele;
using Data;

namespace TrieSerie
{
    class Program
    {
        static void Main()
        {
            Manager Manager = new Manager(new Stub());
            Manager.TriSeries("Documentaire");

            foreach (Serie serie in Manager.Serietheque.ListeSeriesAffiche)
            {
                Console.WriteLine(serie);
            }
        }
    }
}
