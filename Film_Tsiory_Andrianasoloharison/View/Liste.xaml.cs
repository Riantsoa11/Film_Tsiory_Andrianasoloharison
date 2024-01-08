using Film_Tsiory_Andrianasoloharison.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using static System.Net.WebRequestMethods;

namespace Film_Tsiory_Andrianasoloharison.View
{
    /// <summary>
    /// Logique d'interaction pour Liste.xaml
    /// </summary>
    public partial class Liste : UserControl
    {
        public Liste()
        {
            InitializeComponent();
            RecupererFilms();

        }
        // Méthode appelée lorsqu'un bouton (BTN_img1) est cliqué
        private async void BTN_img1_Click(object sender, RoutedEventArgs e)
        {
            // Effacer les définitions de lignes et les enfants du conteneur
            Windows_Container.RowDefinitions.Clear();
            Windows_Container.Children.Clear();

            // Récupérer le bouton cliqué
            Button button = sender as Button;
            string textBlockName = "Id" + button.Name.Substring(3);

            // Trouver le TextBlock dans la hiérarchie visuelle du bouton
            TextBlock textBlock = FindName(textBlockName) as TextBlock;

            // Créer une nouvelle page
            Page page = new Page();
            page.Id = textBlock.Text;
            Windows_Container.Children.Add(page);
            // Appeler la méthode pour récupérer les détails du film
            page.RecupererFilmDetail();

        }

        private void BTN_img2_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();
            Windows_Container.Children.Clear();

            Button button = sender as Button;
            string textBlockName = "Id" + button.Name.Substring(3);

            TextBlock textBlock = FindName(textBlockName) as TextBlock;

            Page page = new Page();
            page.Id = textBlock.Text;
            Windows_Container.Children.Add(page);
            page.RecupererFilmDetail();
        }

        private void BTN_img3_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();
            Windows_Container.Children.Clear();

            Button button = sender as Button;
            string textBlockName = "Id" + button.Name.Substring(3);

            TextBlock textBlock = FindName(textBlockName) as TextBlock;

            Page page = new Page();
            page.Id = textBlock.Text;
            Windows_Container.Children.Add(page);
            page.RecupererFilmDetail();
        }

        private void BTN_img4_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();
            Windows_Container.Children.Clear();

            Button button = sender as Button;
            string textBlockName = "Id" + button.Name.Substring(3);

            TextBlock textBlock = FindName(textBlockName) as TextBlock;

            Page page = new Page();
            page.Id = textBlock.Text;
            Windows_Container.Children.Add(page);
            page.RecupererFilmDetail();
        }

        private void BTN_img5_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();
            Windows_Container.Children.Clear();

            Button button = sender as Button;
            string textBlockName = "Id" + button.Name.Substring(3);

            TextBlock textBlock = FindName(textBlockName) as TextBlock;

            Page page = new Page();
            page.Id = textBlock.Text;
            Windows_Container.Children.Add(page);
            page.RecupererFilmDetail();
        }

        private void BTN_img6_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();
            Windows_Container.Children.Clear();

            Button button = sender as Button;
            string textBlockName = "Id" + button.Name.Substring(3);

            TextBlock textBlock = FindName(textBlockName) as TextBlock;

            Page page = new Page();
            page.Id = textBlock.Text;
            Windows_Container.Children.Add(page);
            page.RecupererFilmDetail();
        }

        private void BTN_img7_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();
            Windows_Container.Children.Clear();

            Button button = sender as Button;
            string textBlockName = "Id" + button.Name.Substring(3);

            TextBlock textBlock = FindName(textBlockName) as TextBlock;

            Page page = new Page();
            page.Id = textBlock.Text;
            Windows_Container.Children.Add(page);
            page.RecupererFilmDetail();
        }

        private void BTN_img8_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();
            Windows_Container.Children.Clear();

            Button button = sender as Button;
            string textBlockName = "Id" + button.Name.Substring(3);

            TextBlock textBlock = FindName(textBlockName) as TextBlock;

            Page page = new Page();
            page.Id = textBlock.Text;
            Windows_Container.Children.Add(page);
            page.RecupererFilmDetail();
        }

        // Méthode pour récupérer la liste des films
        private async void RecupererFilms()
        {
            // URL de base pour les images des films
            string urlImg = "https://image.tmdb.org/t/p/w500";
            Film film = new Film();
            // Appeler la méthode pour récupérer la liste des films
            string filmsListe = await film.RecupererFilm();
            // Désérialiser la liste des films à partir de la chaîne JSON
            FilmsContainer filmsContainer = JsonConvert.DeserializeObject<FilmsContainer>(filmsListe);
            // Récupérer la liste des films
            List<Root> movies = filmsContainer.Films;
            // Variable pour itérer sur les premiers 8 films
            int i = 1;

            // Parcourir la liste des films
            foreach (var movie in movies)
            {
                // S'assurer que nous ne traitons que les 8 premiers films
                if (i < 9)
                {
                    // Nom du bouton basé sur l'itération
                    string nomBouton = "Img" + i;
                    // Trouver le bouton associé dans la hiérarchie visuelle
                    Button bouton = FindName(nomBouton) as Button;
                    // Créer une brosse d'image avec l'URL de l'image du film
                    ImageBrush imageBrush = new ImageBrush(new BitmapImage(new Uri(urlImg + movie.poster_path)));
                    bouton.Background = imageBrush;

                    // Nom du TextBlock pour le titre du film
                    string nomTextBlock = "Titre" + i;
                    // Trouver le TextBlock associé dans la hiérarchie visuelle
                    TextBlock textBlock = FindName(nomTextBlock) as TextBlock;
                    // Définir le texte du TextBlock avec le titre du film
                    textBlock.Text = movie.original_title;

                    // Nom du TextBlock pour l'ID du film
                    string nomTextBlockID = "Id" + i;
                    // Trouver le TextBlock associé dans la hiérarchie visuelle
                    TextBlock textBlockId = FindName(nomTextBlockID) as TextBlock;
                    // Définir le texte du TextBlock avec l'ID du film
                    textBlockId.Text = movie.id.ToString();

                    i++;
                }
            }
        }
    }
}
