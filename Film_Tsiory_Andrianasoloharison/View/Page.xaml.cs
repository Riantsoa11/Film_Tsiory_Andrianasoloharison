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
        string cheminFichier = "Ressources/Fichiers/Favori.txt";

        public string Id { get; set; }
        public string LienTrailer { get; set; }

        public Page()
        {
            InitializeComponent();
            string cheminFichier = "Ressources/Fichiers/Favori.txt";
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
                // Ajouter le nom du genre à la chaîne "genres"
                genres += genre.name;

                // Vérifier s'il y a d'autres genres à traiter
                if (--count > 0)
                {
                    // S'il y a d'autres genres, ajouter une virgule pour séparer les noms de genre
                    genres += ", ";
                }
            }


            // Afficher les informations du film (date de sortie, genres, durée)
            Information.Text = root.release_date.ToString() + " - " + genres + " - " + root.runtime + " min";
            Idname.Text = Id;
            // Afficher un aperçu du film
            Apercu.Text = root.overview;

            // Construire une chaîne pour afficher les sociétés de production
            string productions = "";
            int countProd = root.production_companies.Count;

            // Parcourir la liste des sociétés de production
            foreach (ProductionCompany production_companies in root.production_companies)
            {
                // Ajouter le nom de la société de production à la chaîne "productions"
                productions += production_companies.name;

                // Vérifier s'il y a d'autres sociétés de production à traiter
                if (--countProd > 0)
                {
                    // S'il y a d'autres sociétés de production, ajouter une virgule pour séparer les noms de société
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
                // Ajouter le nom du pays à la chaîne "pays"
                pays += production_countries.name;

                // Vérifier s'il y a d'autres pays à traiter
                if (--countPays > 0)
                {
                    // S'il y a d'autres pays, ajouter une virgule pour séparer les noms de pays
                    pays += ", ";
                }
            }


            // Afficher les pays de production
            Production_countries.Text = pays;

            // Vérifier si le film est dans les favoris
            if (EstDansLesFavoris())
            {
                // Si le film est dans les favoris, masquer le bouton "Favori"
                Favori.Visibility = Visibility.Collapsed;
            }
            else
            {
                // Si le film n'est pas dans les favoris, afficher le bouton "Favori"
                Favori.Visibility = Visibility.Visible;
            }

        }

        private void Favori_Click(object sender, RoutedEventArgs e)
        {
            // Récupérer les informations du film actuel
            string titreFilm = Titre.Text;
            string cheminImageFilm = Image.Source.ToString(); 

            // Créer une instance de la classe Film
            Favoris favoris = new Favoris { Id = Idname.Text, Titre = titreFilm, CheminImage = cheminImageFilm };

            // Ajouter le film aux favoris (vous pouvez implémenter cette logique dans votre classe de service ou ailleurs)
            AjouterAuxFavoris(favoris);

            // Vous pouvez également afficher un message pour informer l'utilisateur que le film a été ajouté aux favoris
            MessageBox.Show("Film ajouté aux favoris !");
        }

        private void AjouterAuxFavoris(Favoris favoris)
        {
            try
            {
                // Lire le contenu actuel du fichier Favori.txt
                string contenuFavoris = System.IO.File.ReadAllText(cheminFichier);

                // Ajouter le film au contenu actuel
                contenuFavoris += $"{favoris.Id},{favoris.Titre},{favoris.CheminImage}{Environment.NewLine}";

                // Écrire le nouveau contenu dans le fichier Favori.txt
                System.IO.File.WriteAllText(cheminFichier, contenuFavoris);
            }
            catch (Exception ex)
            {
                // Gestion des exceptions : Afficher un message d'erreur en cas d'échec
                MessageBox.Show($"Erreur lors de l'ajout aux favoris : {ex.Message}");
            }
        }


        private bool EstDansLesFavoris()
        {
            // Lire le contenu actuel du fichier Favoris.txt
            string contenuFavoris = System.IO.File.ReadAllText(cheminFichier);

            // Obtenir l'URL de l'image à partir de la source de l'image actuelle
            string urlImage = (Image.Source as BitmapImage)?.UriSource?.AbsoluteUri;

            // Vérifier si le contenu du fichier Favoris.txt contient les informations actuelles
            if (contenuFavoris.Contains($"{Idname.Text},{Titre.Text},{urlImage}"))
            {
                // Si les informations actuelles sont présentes dans le fichier, retourner true
                return true;
            }
            else
            {
                // Si les informations actuelles ne sont pas présentes dans le fichier, retourner false
                return false;
            }

        }

        private void Lire_Click(object sender, RoutedEventArgs e)
        {
            ////// Supposons que vous avez une instance du film actuellement affiché
            ////Film filmActuel = // récupérer le film actuellement affiché

            ////// Vérifiez si le lien du trailer est disponible
            ////if (!string.IsNullOrEmpty(filmActuel.LienTrailer))
            ////{
            ////    // Ouvrir le navigateur Web par défaut avec le lien du trailer spécifique au film actuel
            ////    System.Diagnostics.Process.Start(filmActuel.LienTrailer);
            ////}
            ////else
            ////{
            ////    // Affichez un message ou gérez le cas où le lien du trailer est manquant
            ////    MessageBox.Show("Le lien du trailer n'est pas disponible pour ce film.");
            //}
        }
    }
}
