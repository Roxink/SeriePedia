using System.Runtime.Serialization;

namespace Modele
{
    [DataContract]
    public class Inscrit
    {
        public Inscrit(string identifiant, string motDePasse) // Constructeur de Inscrit 
        {
            Identifiant = identifiant;
            MotDePasse = motDePasse;
        }
        [DataMember]
        public string Identifiant { get; private set; }

        [DataMember]
        public string MotDePasse { get; private set; }

        public override bool Equals(object obj) // Redefinition de la méthode Equals 
        {
            return obj is Inscrit inscrit &&
                   Identifiant == inscrit.Identifiant &&
                   MotDePasse == inscrit.MotDePasse;
        }
    }
}