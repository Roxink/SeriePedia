using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace Modele
{
    [DataContract]
    public class Commentaire
    {
        public Commentaire(string avis) // constructeur de commentaire
        {
            Avis = avis;
        }

        [DataMember]
        public string Avis { get; private set; }

        public override string ToString() // redéfinition de la méthode ToSring
        {
            return Avis;
        }
    }
}
