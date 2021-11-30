using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Modele
{
    public class Manager
    {
        public Manager(IPersistance pers) // Construtcteur de Manager
        {
            Persistance = pers;
            Serietheque = Persistance.ChargerDonneesSerietheque(); // on charge les données grâce au méthodes de persistance
            ComptesUtilisateur = Persistance.ChargerDonneesComptesUtilisateur(); // on charge les données grâce au méthodes de persistance
        }


        public Serietheque Serietheque {get; private set; }
        public ComptesUtilisateur ComptesUtilisateur { get; private set; }

        public IPersistance Persistance { get; private set; } 


        public void RechercherSerie(string NomSerie)
        {
            Serietheque.Recherche = NomSerie;         // on donne à recherche le nom de la série recherché
            Serietheque.EventOn();                    // on lance un événement avec la méthode EventOn de Serietheque pour que l'affichage dans la listbox s'actualise 
        }

        public void TriSeries(string categorie)
        {
            if (categorie != null) // on vérifie que categorie n'est pas null 
            {
                Serietheque.CategorieSelectionne = categorie; // on donne à recherche le nom de la catégorie sélectionné 
                Serietheque.EventOn(); // on lance un événement avec la méthode EventOn de Serietheque pour que l'affichage dans la listbox s'actualise
            }
        }

        public void AjouterCom(Serie s , string com) // méthode qui permet d'ajouter un commentaire a la liste de commentaire d'une série 
        {
            var temp = Serietheque.ListeSeriesAffiche.IndexOf(s); // on récupère l'index de la série selectionné dans la liste de série 
            Serietheque.ListeSeriesAffiche[temp].AjouterCommentaire(new Commentaire(com)); // on appelle la méthode ajouterCommentaire de la série sélectionné 
        }

        public string Inscription(Inscrit inscrit)
        {
            return ComptesUtilisateur.Inscription(inscrit); // appelle de la méthode Inscription de ComptesUtilisateur 
        }

        public string Connexion(string identifiant, string passwd)
        {
            return ComptesUtilisateur.Connexion(identifiant, passwd); // appelle de la méthode Connexion de ComptesUtilisateurs 
        }

        public string Deconnexion()
        {
            return ComptesUtilisateur.Deconnexion(); // appelle de la méthode Deconnexion de ComptesUtilisateurs
        }

        public void Sauvegarde() // méthode de sauvegarde des données 
        {
            Persistance.SauvegardeDonneesSerietheque(Serietheque); // appel de la méthode de sauvegarde de données 
            Persistance.SauvegardeDonneesComptesUtilisateur(ComptesUtilisateur); // appel de la méthode de sauvegarde de données
        }


    }
}
