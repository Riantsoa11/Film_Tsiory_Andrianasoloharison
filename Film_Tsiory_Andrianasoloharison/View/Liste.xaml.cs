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
            // Effacement des définitions de lignes existantes dans Windows_Container
            Windows_Container.RowDefinitions.Clear();
            // Effacement de tous les éléments enfants présents dans Windows_Container
            Windows_Container.Children.Clear();
            // Obtention du bouton déclencheur du clic
            Button button = sender as Button;
            // Construction du nom du TextBlock associé au bouton
            string textBlockName = "Id" + button.Name.Substring(3);
            // Recherche du TextBlock correspondant dans le contexte de la fenêtre actuelle
            TextBlock textBlock = FindName(textBlockName) as TextBlock;
            // Création d'une nouvelle instance de la classe Page
            Page page = new Page();
            // Affectation de la valeur du TextBlock au propriétaire de la page (Id)
            page.Id = textBlock.Text;
            // Ajout de la page en tant qu'enfant dans Windows_Container
            Windows_Container.Children.Add(page);
            // Appel de la méthode RecupererFilmDetail() pour récupérer les détails du film dans la page nouvellement ajoutée
            page.RecupererFilmDetail();


        }

        private void BTN_img2_Click(object sender, RoutedEventArgs e)
        {
            // Effacement des définitions de lignes existantes dans Windows_Container
            Windows_Container.RowDefinitions.Clear();
            // Effacement de tous les éléments enfants présents dans Windows_Container
            Windows_Container.Children.Clear();
            // Obtention du bouton déclencheur du clic
            Button button = sender as Button;
            // Construction du nom du TextBlock associé au bouton
            string textBlockName = "Id" + button.Name.Substring(3);
            // Recherche du TextBlock correspondant dans le contexte de la fenêtre actuelle
            TextBlock textBlock = FindName(textBlockName) as TextBlock;
            // Création d'une nouvelle instance de la classe Page
            Page page = new Page();
            // Affectation de la valeur du TextBlock au propriétaire de la page (Id)
            page.Id = textBlock.Text;
            // Ajout de la page en tant qu'enfant dans Windows_Container
            Windows_Container.Children.Add(page);
            // Appel de la méthode RecupererFilmDetail() pour récupérer les détails du film dans la page nouvellement ajoutée
            page.RecupererFilmDetail();
        }

        private void BTN_img3_Click(object sender, RoutedEventArgs e)
        {
            // Effacement des définitions de lignes existantes dans Windows_Container
            Windows_Container.RowDefinitions.Clear();
            // Effacement de tous les éléments enfants présents dans Windows_Container
            Windows_Container.Children.Clear();
            // Obtention du bouton déclencheur du clic
            Button button = sender as Button;
            // Construction du nom du TextBlock associé au bouton
            string textBlockName = "Id" + button.Name.Substring(3);
            // Recherche du TextBlock correspondant dans le contexte de la fenêtre actuelle
            TextBlock textBlock = FindName(textBlockName) as TextBlock;
            // Création d'une nouvelle instance de la classe Page
            Page page = new Page();
            // Affectation de la valeur du TextBlock au propriétaire de la page (Id)
            page.Id = textBlock.Text;
            // Ajout de la page en tant qu'enfant dans Windows_Container
            Windows_Container.Children.Add(page);
            // Appel de la méthode RecupererFilmDetail() pour récupérer les détails du film dans la page nouvellement ajoutée
            page.RecupererFilmDetail();
        }

        private void BTN_img4_Click(object sender, RoutedEventArgs e)
        {
            // Effacement des définitions de lignes existantes dans Windows_Container
            Windows_Container.RowDefinitions.Clear();
            // Effacement de tous les éléments enfants présents dans Windows_Container
            Windows_Container.Children.Clear();
            // Obtention du bouton déclencheur du clic
            Button button = sender as Button;
            // Construction du nom du TextBlock associé au bouton
            string textBlockName = "Id" + button.Name.Substring(3);
            // Recherche du TextBlock correspondant dans le contexte de la fenêtre actuelle
            TextBlock textBlock = FindName(textBlockName) as TextBlock;
            // Création d'une nouvelle instance de la classe Page
            Page page = new Page();
            // Affectation de la valeur du TextBlock au propriétaire de la page (Id)
            page.Id = textBlock.Text;
            // Ajout de la page en tant qu'enfant dans Windows_Container
            Windows_Container.Children.Add(page);
            // Appel de la méthode RecupererFilmDetail() pour récupérer les détails du film dans la page nouvellement ajoutée
            page.RecupererFilmDetail();

        }

        private void BTN_img5_Click(object sender, RoutedEventArgs e)
        {
            // Effacement des définitions de lignes existantes dans Windows_Container
            Windows_Container.RowDefinitions.Clear();
            // Effacement de tous les éléments enfants présents dans Windows_Container
            Windows_Container.Children.Clear();
            // Obtention du bouton déclencheur du clic
            Button button = sender as Button;
            // Construction du nom du TextBlock associé au bouton
            string textBlockName = "Id" + button.Name.Substring(3);
            // Recherche du TextBlock correspondant dans le contexte de la fenêtre actuelle
            TextBlock textBlock = FindName(textBlockName) as TextBlock;
            // Création d'une nouvelle instance de la classe Page
            Page page = new Page();
            // Affectation de la valeur du TextBlock au propriétaire de la page (Id)
            page.Id = textBlock.Text;
            // Ajout de la page en tant qu'enfant dans Windows_Container
            Windows_Container.Children.Add(page);
            // Appel de la méthode RecupererFilmDetail() pour récupérer les détails du film dans la page nouvellement ajoutée
            page.RecupererFilmDetail();

        }

        private void BTN_img6_Click(object sender, RoutedEventArgs e)
        {
            // Effacement des définitions de lignes existantes dans Windows_Container
            Windows_Container.RowDefinitions.Clear();
            // Effacement de tous les éléments enfants présents dans Windows_Container
            Windows_Container.Children.Clear();
            // Obtention du bouton déclencheur du clic
            Button button = sender as Button;
            // Construction du nom du TextBlock associé au bouton
            string textBlockName = "Id" + button.Name.Substring(3);
            // Recherche du TextBlock correspondant dans le contexte de la fenêtre actuelle
            TextBlock textBlock = FindName(textBlockName) as TextBlock;
            // Création d'une nouvelle instance de la classe Page
            Page page = new Page();
            // Affectation de la valeur du TextBlock au propriétaire de la page (Id)
            page.Id = textBlock.Text;
            // Ajout de la page en tant qu'enfant dans Windows_Container
            Windows_Container.Children.Add(page);
            // Appel de la méthode RecupererFilmDetail() pour récupérer les détails du film dans la page nouvellement ajoutée
            page.RecupererFilmDetail();

        }

        private void BTN_img7_Click(object sender, RoutedEventArgs e)
        {
            // Effacement des définitions de lignes existantes dans Windows_Container
            Windows_Container.RowDefinitions.Clear();
            // Effacement de tous les éléments enfants présents dans Windows_Container
            Windows_Container.Children.Clear();
            // Obtention du bouton déclencheur du clic
            Button button = sender as Button;
            // Construction du nom du TextBlock associé au bouton
            string textBlockName = "Id" + button.Name.Substring(3);
            // Recherche du TextBlock correspondant dans le contexte de la fenêtre actuelle
            TextBlock textBlock = FindName(textBlockName) as TextBlock;
            // Création d'une nouvelle instance de la classe Page
            Page page = new Page();
            // Affectation de la valeur du TextBlock au propriétaire de la page (Id)
            page.Id = textBlock.Text;
            // Ajout de la page en tant qu'enfant dans Windows_Container
            Windows_Container.Children.Add(page);
            // Appel de la méthode RecupererFilmDetail() pour récupérer les détails du film dans la page nouvellement ajoutée
            page.RecupererFilmDetail();

        }

        private void BTN_img8_Click(object sender, RoutedEventArgs e)
        {
            // Effacement des définitions de lignes existantes dans Windows_Container
            Windows_Container.RowDefinitions.Clear();
            // Effacement de tous les éléments enfants présents dans Windows_Container
            Windows_Container.Children.Clear();
            // Obtention du bouton déclencheur du clic
            Button button = sender as Button;
            // Construction du nom du TextBlock associé au bouton
            string textBlockName = "Id" + button.Name.Substring(3);
            // Recherche du TextBlock correspondant dans le contexte de la fenêtre actuelle
            TextBlock textBlock = FindName(textBlockName) as TextBlock;
            // Création d'une nouvelle instance de la classe Page
            Page page = new Page();
            // Affectation de la valeur du TextBlock au propriétaire de la page (Id)
            page.Id = textBlock.Text;
            // Ajout de la page en tant qu'enfant dans Windows_Container
            Windows_Container.Children.Add(page);
            // Appel de la méthode RecupererFilmDetail() pour récupérer les détails du film dans la page nouvellement ajoutée
            page.RecupererFilmDetail();

        }

        // Méthode pour récupérer la liste des films
        public async void RecupererFilms()
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

        public async void RecupererFilmAvecGenre(string genreName)
        {
            // Création d'une instance de la classe Film
            Film film = new Film();
            // Appel de la méthode RecuperGenre() pour récupérer les genres depuis une source (probablement une API)
            string genre = await film.RecuperGenre();
            // Désérialisation de la réponse JSON (probablement contenant une liste de genres) en utilisant la classe GenreContainer
            var genres = JsonConvert.DeserializeObject<GenreContainer>(genre);
            // Recherche du genre spécifié dans la liste des genres
            var selectedGenre = genres.Genres.Find(g => g.name.Equals(genreName, StringComparison.OrdinalIgnoreCase));
            // URL de base pour les images des films
            string urlImg = "https://image.tmdb.org/t/p/w500";
            // Appeler la méthode pour récupérer la liste des films
            string filmsListe = await film.RecupererFilmAvecGenre(selectedGenre.id.ToString());
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
