using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Runtime.Serialization;

namespace Modele 
{
    [DataContract]
    public class Serie
    {
        [DataMember]
        public ObservableCollection<Commentaire> ListeCommentaires { get; private set; } = new ObservableCollection<Commentaire>(); // Collection qui conttient une liste de commentaire

        
        public Serie(string categorie, string synopsis, Uri bandeAnnonce, string miniature, string nom, string disponibilite) // Constructeur de serie qui initialise categorie, synopsis,
        {                                                                                   //bandeAnnonce, miniature, nom et disponibilite avec les paramètres saisis lors de l'appel de la méthode 
            Categorie = categorie;
            Synopsis = synopsis;
            BandeAnnonce = bandeAnnonce;
            Miniature = miniature;
            Nom = nom;
            Disponibilite = disponibilite;

        }

        [DataMember]
        public string Nom { get;  private set; }
        [DataMember]
        public string Categorie { get; private set; }
        [DataMember]
        public string Synopsis { get; private set; }
        [DataMember]
        public Uri BandeAnnonce { get; private set; }
        [DataMember]
        public string Miniature { get; private set; }
        [DataMember]
        public string Disponibilite { get; private set; }


        public void AjouterCommentaire(Commentaire commentaire )  // méthode qui ajoute un commentaire donné en paramètre a la liste de commentaire d'une série
        {
            ListeCommentaires.Add(commentaire);
        }

      
        public override string ToString()   // Redéfinition de la méthode ToString de Serie
        {
            return $"{Nom} {Categorie} {Synopsis} {Disponibilite}";
        }

    }
}
