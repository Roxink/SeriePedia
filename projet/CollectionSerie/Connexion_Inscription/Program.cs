using System;
using Modele;
using Data;

namespace Connexion_Inscription
{
    class Program
    {
        static void Main()
        {
            Manager Manager = new Manager(new Stub());

            Console.WriteLine(Manager.ComptesUtilisateur.Inscription(new Inscrit("toto", "azerty123")));
            Console.WriteLine(Manager.ComptesUtilisateur.Connecte);

            Manager.Deconnexion();
            Console.WriteLine(Manager.ComptesUtilisateur.Connexion("toto", "azerty123"));

            Manager.Deconnexion();
            Console.WriteLine(Manager.ComptesUtilisateur.Connexion("toto", "azerty23"));
        }
    }
}
