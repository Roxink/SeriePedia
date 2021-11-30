using Modele;
using System.Collections.Generic;
using Data;

namespace Test
{
    class Program
    {
        static void Main()
        {

            // Manager manager = new Manager(new Stub("").ChargeSerietheque(), new ComptesUtilisateur());
            Manager manager = new Manager(new Stub());
            // manager.ComptesUtilisateur.AjouterInscrit(new Inscrit("titi", "tutu"));
            manager.Serietheque.ListeSeries[1].AjouterCommentaire(new Commentaire("test"));
            manager.ComptesUtilisateur.Inscription(new Inscrit("titi", "tutu"));

            manager.Sauvegarde();

        }
    }
}
