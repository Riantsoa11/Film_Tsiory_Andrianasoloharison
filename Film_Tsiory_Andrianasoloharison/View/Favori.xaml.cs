﻿using Film_Tsiory_Andrianasoloharison.Services;
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

namespace Film_Tsiory_Andrianasoloharison.View
{
    /// <summary>
    /// Logique d'interaction pour Favori.xaml
    /// </summary>
    public partial class Favori : UserControl
    {
        readonly string cheminFichier = "D:/Tsiory/Projet/Film_Tsiory_Andrianasoloharison/Film_Tsiory_Andrianasoloharison/Ressources/Fichiers/Favori.txt";
        public Favori()
        {
            InitializeComponent();
            ChargerFilmsDepuisFichier(cheminFichier);
        }

        public void ChargerFilmsDepuisFichier(string cheminFichier)
        {
            try
            {
                // Lire toutes les lignes du fichier
                string[] lignes = System.IO.File.ReadAllLines(cheminFichier);

                int i = 1;

                foreach (string ligne in lignes)
                   
                {
                    if (i < 5)
                    {
                        // Séparer les éléments de la ligne (supposons qu'ils sont séparés par des virgules)
                        string[] elements = ligne.Split(',');

                        // Vérifier si la ligne a le bon nombre d'éléments
                        if (elements.Length == 3)
                        {
                            string buttonName = "Img_favori_" + i;
                            Button image = FindName(buttonName) as Button;
                            string textBlockName = "Favorititre" + i;
                            TextBlock titre = FindName(textBlockName) as TextBlock;
                            string id = "Id" + i;
                            TextBlock idnumber = FindName(id) as TextBlock;
                            string urlImg = "https://image.tmdb.org/t/p/w500";
                            ImageBrush imageBrush = new ImageBrush(new BitmapImage(new Uri(urlImg + elements[2])));
                            titre.Text = elements[1];
                            image.Background = imageBrush;
                            idnumber.Text = elements[0];

                        }
                    }
                    i++;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la lecture du fichier : {ex.Message}");
            }
        }

        public void SupprimerFilmDuFichier(string idFilmASupprimer)
        {
            try
            {
                // Lire toutes les lignes du fichier
                string[] lignes = System.IO.File.ReadAllLines(cheminFichier);

                // Créer une liste pour stocker les lignes à conserver
                List<string> nouvellesLignes = new List<string>();

                // Parcourir chaque ligne
                foreach (string ligne in lignes)
                {
                    // Séparer les éléments de la ligne (supposons qu'ils sont séparés par des virgules)
                    string[] elements = ligne.Split(',');

                    // Vérifier si la ligne a le bon nombre d'éléments et si l'ID ne correspond pas à celui que vous souhaitez supprimer
                    if (elements.Length == 3 && elements[0] != idFilmASupprimer)
                    {
                        // Ajouter la ligne à la liste des nouvelles lignes
                        nouvellesLignes.Add(ligne);
                    }
                }

                // Réécrire le fichier avec les nouvelles lignes
                System.IO.File.WriteAllLines(cheminFichier, nouvellesLignes.ToArray());
                Windows_Container.Children.Clear();
                // Créer une nouvelle instance de la vue Favori
                View.Favori favori = new View.Favori();
                // Ajouter la vue Favori comme enfant du conteneur Windows_Container
                Windows_Container.Children.Add(favori);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la suppression du film du fichier : {ex.Message}");
            }
        }



        private void BTN_1_Delete_Click(object sender, RoutedEventArgs e)
        {
            SupprimerFilmDuFichier(Id1.Text);
        }
    

        private void BTN_2_Delete_Click(object sender, RoutedEventArgs e)
        {
            SupprimerFilmDuFichier(Id2.Text);

        }

        private void BTN_3_Delete_Click(object sender, RoutedEventArgs e)
        {
            SupprimerFilmDuFichier(Id3.Text);

        }

        private void BTN_4_Delete_Click(object sender, RoutedEventArgs e)
        {
            SupprimerFilmDuFichier(Id4.Text);

        }
    }
}
