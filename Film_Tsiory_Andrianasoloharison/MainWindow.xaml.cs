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
//API
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;



namespace Film_Tsiory_Andrianasoloharison
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    
    public class BelongsToCollection
    {
        public int id { get; set; }
        public string name { get; set; }
        public string poster_path { get; set; }
        public string backdrop_path { get; set; }
    }
 
    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
    }
 
    public class ProductionCompany
    {
        public int id { get; set; }
        public string logo_path { get; set; }
        public string name { get; set; }
        public string origin_country { get; set; }
    }
 
    public class ProductionCountry
    {
        public string iso_3166_1 { get; set; }
        public string name { get; set; }
    }
 
    public class Root
    {
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public BelongsToCollection belongs_to_collection { get; set; }
        public int budget { get; set; }
        public List<Genre> genres { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public string imdb_id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public List<ProductionCompany> production_companies { get; set; }
        public List<ProductionCountry> production_countries { get; set; }
        public string release_date { get; set; }
        public int revenue { get; set; }
        public int runtime { get; set; }
        public List<SpokenLanguage> spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
    }

    public class FilmsContainer
    {
        [JsonProperty("results")]
        public List<Root> Films { get; set; }
    }


    public class SpokenLanguage
    {
        public string english_name { get; set; }
        public string iso_639_1 { get; set; }
        public string name { get; set; }
    }
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Initialisation de la fenêtre principale
            InitializeComponent();
            // Effacer les enfants du conteneur Windows_Container
            Windows_Container.Children.Clear();
            // Créer une instance de la vue Home
            View.Home home = new View.Home();
            // Ajouter la vue Home comme enfant du conteneur Windows_Container
            Windows_Container.Children.Add(home);
        }

        // Méthode appelée lors du clic sur le bouton Home (BTN_Home)
        private void BTN_Home_Click(object sender, RoutedEventArgs e)
        {
            // Effacer les enfants du conteneur Windows_Container
            Windows_Container.Children.Clear();
            // Créer une nouvelle instance de la vue Home
            View.Home home = new View.Home();
            // Ajouter la vue Home comme enfant du conteneur Windows_Container
            Windows_Container.Children.Add(home);
        }

        // Méthode appelée lors du clic sur le bouton Liste (BTN_Liste)
        private void BTN_Liste_Click(object sender, RoutedEventArgs e)
        {
            // Effacer les enfants du conteneur Windows_Container
            Windows_Container.Children.Clear();
            // Créer une nouvelle instance de la vue Liste
            View.Liste liste = new View.Liste();
            // Ajouter la vue Liste comme enfant du conteneur Windows_Container
            Windows_Container.Children.Add(liste);
        }

        // Méthode appelée lors du clic sur le bouton Favori (BTN_Favori)
        private void BTN_Favori_Click(object sender, RoutedEventArgs e)
        {
            // Effacer les enfants du conteneur Windows_Container
            Windows_Container.Children.Clear();
            // Créer une nouvelle instance de la vue Favori
            View.Favori favori = new View.Favori();
            // Ajouter la vue Favori comme enfant du conteneur Windows_Container
            Windows_Container.Children.Add(favori); 
        }

        
    }

    
}
