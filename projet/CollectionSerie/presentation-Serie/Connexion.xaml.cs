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
using Modele;
using presentation_Serie;

namespace Connexion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ConnexionWindow : Window
    {
        public ConnexionWindow()
        {
            InitializeComponent();
        }
        private void Connexion(object sender, RoutedEventArgs e) // méthode lié au bouton Se connecter 
        {
            string Identifiant = identifiant.Text; // on récupère le contenu de la TextBox identifiant
            string passwd = mdp.Password; // on récupère le contenu de la PasswordBox mdp
            MessageBox.Show(((MainWindow)Application.Current.MainWindow).Manager.Connexion(Identifiant,passwd)); // on appelle la méthode Connexion de Manager et on affiche grâce a une MessageBox le message retourné

        }

        private void Inscription(object sender, RoutedEventArgs e) // méthode lié au bouton S'inscrire 
        {
            string Identifiant = identifiant.Text; // on récupère le contenu de la TextBox identifiant
            string passwd = mdp.Password; // on récupère le contenu de la PasswordBox mdp

            Inscrit inscrit = new Inscrit(Identifiant, passwd);
            MessageBox.Show(((MainWindow)Application.Current.MainWindow).Manager.Inscription(inscrit)); // on appelle la méthode Connexion de Manager et on affiche grâce a une MessageBox le message retourné
        }

        private void FermerFenetreCo(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
