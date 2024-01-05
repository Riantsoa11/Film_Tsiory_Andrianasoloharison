﻿using System;
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
            InitializeComponent();
            Windows_Container.Children.Clear();
            View.Home home = new View.Home();
            Windows_Container.Children.Add(home);
        }
        
        private void BTN_Home_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.Children.Clear();
            View.Home home = new View.Home();
            Windows_Container.Children.Add(home);
        }

        private void BTN_Liste_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.Children.Clear();
            View.Liste liste = new View.Liste();
            Windows_Container.Children.Add(liste);
        }

        private void BTN_Favori_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.Children.Clear();
            View.Favori favori = new View.Favori();
            Windows_Container.Children.Add(favori); 
        }

        
    }

    
}
