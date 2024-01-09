using Film_Tsiory_Andrianasoloharison.Services;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Film_Tsiory_Andrianasoloharison.View
{
    /// <summary>
    /// Logique d'interaction pour Page.xaml
    /// </summary>
    public partial class Page : UserControl
    {
        public string Id { get; set; }

        public Page()
        {
            InitializeComponent();
        }

        // Méthode pour récupérer les détails du film
        public async void RecupererFilmDetail()
        {
            // Créer une instance de la classe Film
            Film film = new Film();

            // Appeler la méthode RecupererFilmById pour obtenir les détails du film par ID
            string filmDetail = await film.RecupererFilmById(Id);

            // Désérialiser les données JSON dans un objet Root
            Root root = JsonConvert.DeserializeObject<Root>(filmDetail);

            // Afficher le titre du film
            Titre.Text = root.original_title;

            // Code pour afficher l'image du film
            string urlImg = "https://image.tmdb.org/t/p/w500";
            string urlImagePourDetailsPage = urlImg + root.poster_path;
            Image.Source = new BitmapImage(new Uri(urlImagePourDetailsPage));

            // Construire une chaîne pour afficher les informations du film
            string genres = "";
            int count = root.genres.Count;

            // Parcourir la liste des genres
            foreach (Genre genre in root.genres)
            {
                genres += genre.name;

                if (--count > 0)
                {
                    genres += ", ";
                }
            }

            // Afficher les informations du film (date de sortie, genres, durée)
            Information.Text = root.release_date.ToString() + " - " + genres + " - " + root.runtime + " min";

            // Afficher un aperçu du film
            Apercu.Text = root.overview;

            // Construire une chaîne pour afficher les sociétés de production
            string productions = "";
            int countProd = root.production_companies.Count;

            // Parcourir la liste des sociétés de production
            foreach (ProductionCompany production_companies in root.production_companies)
            {
                productions += production_companies.name;
                if (--countProd > 0)
                {
                    productions += ", ";
                }
            }

            // Afficher les sociétés de production
            Production_companies.Text = productions;

            // Construire une chaîne pour afficher les pays de production
            string pays = "";
            int countPays = root.production_countries.Count;

            // Parcourir la liste des pays de production
            foreach (ProductionCountry production_countries in root.production_countries)
            {
                pays += production_countries.name;
                if (--countPays > 0)
                {
                    pays += ", ";
                }
            }

            // Afficher les pays de production
            Production_countries.Text = pays;
        }

        private void Favori_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();
            Windows_Container.Children.Clear();
            Button button = sender as Button;
            Favori favori = new Favori();
            Windows_Container.Children.Add(favori);
            
        }
    }
}
