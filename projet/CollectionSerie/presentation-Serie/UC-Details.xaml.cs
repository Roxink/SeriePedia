using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Modele;
using System.Diagnostics;
using Path = System.IO.Path;

namespace presentation_Serie
{
    /// <summary>
    /// Logique d'interaction pour UC_Details.xaml
    /// </summary>
    public partial class UC_Details : UserControl
    {
        public UC_Details()
        {
            InitializeComponent();
            //var temp = ((MainWindow)Application.Current.MainWindow).ListBoxSerie.SelectedItem as Serie;
            //MediaElement.Source = new Uri(temp.BandeAnnonce,UriKind.Relative);
        }

        public void Commentaire(object sender, RoutedEventArgs e) // évenement déclaché par l'appuie sur le bouton PosterCommentaire
        {
            if (((MainWindow)Application.Current.MainWindow).Manager.ComptesUtilisateur.Connecte == true)
            {
                string CommentaireSaisie = EcrireCommentaire.Text; // on récupère le commentaire écrit dans la textBox EcrireCommentaire et on le place dans la variable CommentaireSaisie
                Serie temp = ((MainWindow)Application.Current.MainWindow).ListBoxSerie.SelectedItem as Serie; // on récupère l'item actuellement sélectionné dans la ListBox et on le cast en Serie
                if (temp != null)
                {
                    ((MainWindow)Application.Current.MainWindow).Manager.AjouterCom(temp, CommentaireSaisie); // on appelle la méthode AjouterCom du manager initialisé dans MainWindow
                    return;
                }
                else
                {
                    MessageBox.Show("Aucune série sélectionné");
                    return;
                }
            }
            MessageBox.Show("vous devez être connécté pour commenter");
        }
    }
}
