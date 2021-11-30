using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace Modele
{
    [DataContract]
    public class Serietheque : INotifyPropertyChanged
    {

        public string CategorieSelectionne { get; set; } // nom de la catégorie sélectionné
        public string Recherche { get; set; } = null; // nom de la série recherché 
        [DataMember]
        public ObservableCollection<Serie> ListeSeries { get; private set; } = new ObservableCollection<Serie>();
        public IList<Serie> ListeSeriesAffiche {                  // Liste relié a la listBox
            get                                                   // Propriété calculé de ListeSerieAffiche 
            { 
                if(!(string.IsNullOrEmpty(Recherche)))            // On rentre dans le if que si recherche contient un nom de série 
                {
                   
                   var temp =ListeSeries.Where(s => s.Nom == Recherche).ToList<Serie>(); // La variable temp est initialisé en Liste de serie qui contient la série recherché
                   Recherche = null; // On réinitialise recherche a null pour que le if ne soit pas toujours vrai 
                   return temp; // on return la liste de série contenant la série recherché
                }
                else if(CategorieSelectionne != "Tous" && CategorieSelectionne != null) // on rentre dans le if que si la catégorie séléctionné est différentes de Tous et si categoriesellectionne n'est pas null 
                    {
                       return ListeSeries.Where(s => s.Categorie == CategorieSelectionne).ToList<Serie>(); // on return une Liste de série contant des série de catégorie sélectionné 
                    }
               return ListeSeries; // Si aucune recherche ou aucun tri est éféctué on return la liste de toutes les séries
            }
            
        } 

        public Serietheque() // Constructeur de Serietheque
        {
        }

        public void AjouterSeries(Serie serie)
        {
            ListeSeries.Add(serie); // ajout d'une série a ListSeries
        }


        public event PropertyChangedEventHandler PropertyChanged; // création d'un event ProtertyChanged

        public void EventOn()
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ListeSeriesAffiche")); //on Invoque un Evénement pour que l'affichage du contenue de la listbox s'actualise
        }
    }
}
