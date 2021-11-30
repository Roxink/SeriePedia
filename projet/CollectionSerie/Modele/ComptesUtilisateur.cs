using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Modele
{
    [DataContract]
    public class ComptesUtilisateur
    {
        [DataMember]
        public List<Inscrit> ListeInscrits { get; private set; } = new List<Inscrit>();

        

        public bool Connecte { get; private set; }

        public ComptesUtilisateur() // Constructeur de ComptesUtilisateur qui initialise Connecte à false;
        {
            Connecte = false;
        }


        public string Inscription(Inscrit ins) // méthode qui gére l'inscrption d'un nouvel inscrit 
        {
            if (string.IsNullOrWhiteSpace(ins.Identifiant) == true && string.IsNullOrWhiteSpace(ins.MotDePasse) == true || string.IsNullOrWhiteSpace(ins.Identifiant) == true || string.IsNullOrWhiteSpace(ins.MotDePasse) == true) // on vérifie que identifiant et mdp ne sont pas null ou ne contiennet pas unique un espace  
            {
                return "Mdp ou/et identifiant invalide"; 
            }
            else{
                    if (ListeInscrits.Count == 0) // condition appliqué si la liste d'inscrit est vide 
                    {
                        AjouterInscrit(ins); // appelle de la méthode AjouterInscrit 
                        Connecte = true;
                        return "Nouvelle inscription enregistré, vous êtes connecté";
                    }

                    if (ChercherInscrit(ins) == false)
                    {
                        AjouterInscrit(ins);
                        Connecte = true;
                        return "Nouvelle inscription enregistré, vous êtes connecté";
                    }
                    else return "identifiant déja existant, inscription impossible";
                }
        }

        public bool ChercherInscrit(Inscrit inscrit) // méthode qui return un bool 
        {
            foreach(Inscrit ins in ListeInscrits) // on parcours la liste d'inscrits 
            {
                if (ins.Equals(inscrit) == true) // si la méthode la méthode Equals de Inscrit return true alors on return true 
                    return true;
            }
            return false; // si aucun inscrit et égal a celui donné en paramètre alors on return false 
        }

        public void AjouterInscrit(Inscrit ins)
        {
            ListeInscrits.Add(ins); // ajout d'un inscrit a la liste d'inscrits 
        }

        public string Connexion(string identifiant, string mdp) // méthode qui vas connécter un utilisateur a son compte 
        {
            Inscrit ins = new Inscrit(identifiant, mdp);
                if (ChercherInscrit(ins) == true && Connecte == false) // appelle de la méthode ChercherInscrit , on vérifie que l'utilisateur existe et qu'il n'est pas déja connecté 
                {
                    Connecte = true; 
                    return "Vous êtes connecté";
                }

                if (ChercherInscrit(ins) == true && Connecte == true) // on vérifie que l'utilisateur n'est pas déja connecté 
                {
                    return "Vous êtes déjà connecté";
                }
            return "Mdp ou/et identifiant invalide"; // si l'utilisateur n'est pas déja enregistré ou connécté alors on return un message d'erreur 
        }

        public string Deconnexion() // méthode qui déconnecte un utilisateur 
        {
            if (Connecte == true) // si l'utilisateur est connécté, alors on le déconnecte 
            {
                Connecte = false;
                return "Vous êtes déconnecté";
            }
            else return "vous êtes déjà déconnecté"; // sinon l'utilisateur est déjà déconnecté 
        }
    }
}
