using System;
using Modele;
using Data;

namespace Ecrire_un_Commentaire
{
    class Program
    {
        static void Main()
        {
            Manager Manager = new Manager(new Stub());
            Manager.Serietheque.ListeSeries[1].AjouterCommentaire(new Commentaire("Je recommende ce reportage, il est incroyble.La biodiversité de l'amazonie est énorme!"));
            Console.WriteLine(Manager.Serietheque.ListeSeries[1].ListeCommentaires[0].Avis);
        }
    }
}
