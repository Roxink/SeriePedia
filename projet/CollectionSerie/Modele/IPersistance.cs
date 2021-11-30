using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    public interface IPersistance
    {
        void SauvegardeDonneesComptesUtilisateur(ComptesUtilisateur comptesUtilisateur); // méthode de sauvegarde des comptes utilisateurs 
        void SauvegardeDonneesSerietheque(Serietheque serietheque); // méthode de sauvergarde de la liste de série

        Serietheque ChargerDonneesSerietheque(); // méthode qui charge les données de Serietheque

        ComptesUtilisateur ChargerDonneesComptesUtilisateur(); // méthode qui charge les données de ComptesUtilisateur
    }
}
