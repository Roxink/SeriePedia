using Modele;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace presentation_Serie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Manager Manager { get; private set; } = new Manager(new DataContract());
       
        public MainWindow()
        {
            InitializeComponent();
            ListBoxSerie.DataContext = Manager.Serietheque;   // DataContext de la ListBox dans la MainWindow
        }

        

        public void OuvrirFenetreCo(object sender, RoutedEventArgs e) 
        {
                FenetreConnexion();
        }

        public void FermerMainWindow(object sender, RoutedEventArgs e)
        {
            Manager.Sauvegarde(); // on appelle la méthode de sauvegarde des données de Manager
            Close(); // on ferme la fenêtre principale 
        }

        public void  Recherche(object sender, RoutedEventArgs e)
        {
            string nomSerie = RechercheSerie.Text;
            Manager.RechercherSerie(nomSerie); // on appelle la méthode RecherhceSerie en lui donnant en paramêtre le nom de la série recherché
        }

        public void FenetreConnexion() // methode qui instancie et ouvre la fenêtre de connection 
        {
            Connexion.ConnexionWindow fenetreco = new Connexion.ConnexionWindow(); // création d'une fenêtre de connexion 
            fenetreco.ShowDialog();
        }


        public void TriSerie(object sender, SelectionChangedEventArgs e)
        {
            Manager.TriSeries(((ComboBox1.SelectedItem as ComboBoxItem).Content)as string); // on apelle la méthode triSeries est on lui donne en paramêtre le nom de l'item sélectionné converti en string
        }

        public void Deconnexion(object sender, RoutedEventArgs e) 
        {
            MessageBox.Show(Manager.Deconnexion()); // affichage dans une MessageBox du string return par la méthode Deconnexion de Manager 
        }
    }
}
