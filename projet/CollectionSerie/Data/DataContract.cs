using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Modele;

namespace Data
{
    public class DataContract : IPersistance
    {

        public DataContract()
        {
        }
        public string FilePath { get; private set; } = "Données/XML";
        public string FileNameS { get; private set; } = "seriethequeDonnées.xml";

        public string FileNameC { get; private set; } = "comptesUtilisateurDonnées.xml";

        public void SauvegardeDonneesSerietheque(Serietheque serietheque)
        {
            var Serializer = new DataContractSerializer(typeof(Serietheque)); // on crée un Serializer du type de Seritheque 
            if(!Directory.Exists(FilePath)) // on vérifie que le répertoire /XML existe 
            {
                Directory.CreateDirectory(FilePath); // on crée le répertoire si besoin 
            }
            using (Stream s = File.Create(Path.Combine(FilePath,FileNameS))) // on instancie un Stream s sur le fichier seriethequeDonnées.xml
            {
                Serializer.WriteObject(s, serietheque); // on écrit dans le fichier seriethequeDonnées.xml les attributs qui sont DataMember de Serietheque
            }


        }

        public void SauvegardeDonneesComptesUtilisateur(ComptesUtilisateur comptesUtilisateur)
        {
            var Serializer = new DataContractSerializer(typeof(ComptesUtilisateur)); // on crée un Serializer du type de ComptesUtilisateur
            if (!Directory.Exists(FilePath)) // on vérifie que le répertoire /XML existe
            {
                Directory.CreateDirectory(FilePath); // on crée le répertoire si besoin
            }
            using (Stream s = File.Create(Path.Combine(FilePath,FileNameC))) // on instancie un Stream s sur le fichier comptesUtilisateurDonnées.xml
            {
                Serializer.WriteObject(s, comptesUtilisateur); //on écrit dans le fichier comptesUtilisateurDonnées.xml les attributs qui sont DataMember de CompteUtilisateur
            }
        }

        public ComptesUtilisateur ChargerDonneesComptesUtilisateur()
        {
            if (!File.Exists(Path.Combine(FilePath, FileNameC))) // on vérifie que le chemin ..//XML/comptesUtilisateurDonnées.xml existe et contient bien le fichier comptesUtilisateurDonnées.xml
            {
                throw new FileNotFoundException("Le fichier de donnée n'existe pas"); // on déclare une exception si le fichier comptesUtilisateurDonnées.xml n'existe pas 
            }
            var serializer = new DataContractSerializer(typeof(ComptesUtilisateur)); // on instancie un serializer de type ComptesUtilisateur

            ComptesUtilisateur comptesUtilisateur;
            using (Stream s = File.OpenRead(Path.Combine(FilePath, FileNameC))) // on instancie un Stream s sur le fichier comptesUtilisateurDonnées.xml
            {
                comptesUtilisateur = serializer.ReadObject(s) as ComptesUtilisateur; // On cast l'objet lu en objet de type ComptesUtilisateur et on affecte le contenu a la variable comptesUtilisateur
            }
            return comptesUtilisateur; // on retourne le comptesUtilisateur chargé 
        }

        public Serietheque ChargerDonneesSerietheque()
        {
            if (!File.Exists(Path.Combine(FilePath, FileNameS))) // on vérifie que le chemin ..//XML/seriethequeDonnées.xml existe et contient bien le fichier seriethequeDonnées.xml
            {
                throw new FileNotFoundException("Le fichier de données n'existe pas"); // on déclare une exception si le fichier seriethequeDonnées.xml n'existe pas
            }
            var serializer = new DataContractSerializer(typeof(Serietheque)); // on instancie un serializer de type Serietheque

            Serietheque serietheque;
            using (Stream s = File.OpenRead(Path.Combine(FilePath, FileNameS))) // on instancie un Stream s sur le fichier seriethequeDonnées.xml
            {
                serietheque = serializer.ReadObject(s) as Serietheque; // On cast l'objet lu en objet de type Serietheque et on affecte le contenu a la variable serietheque
            }
            return serietheque; // on retourne le comptesUtilisateur chargé
        }
    }
}
