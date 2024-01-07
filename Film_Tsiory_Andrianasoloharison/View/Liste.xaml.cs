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

        private async void BTN_img1_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();
            Windows_Container.Children.Clear();

            Button button = sender as Button;
            string textBlockName = "Id" + button.Name.Substring(3);

            // Trouver le TextBlock dans la hiérarchie visuelle du bouton
            TextBlock textBlock = FindName(textBlockName) as TextBlock;

            Page page = new Page();
            page.Id = textBlock.Text;
            Windows_Container.Children.Add(page);
            page.RecupererFilmDetail();

        }

        private void BTN_img2_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();


            Windows_Container.Children.Clear();
            Page page = new Page();
            Windows_Container.Children.Add(page);
        }

        private void BTN_img3_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();


            Windows_Container.Children.Clear();
            Page page = new Page();
            Windows_Container.Children.Add(page);
        }

        private void BTN_img4_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();


            Windows_Container.Children.Clear();
            Page page = new Page();
            Windows_Container.Children.Add(page);
        }

        private void BTN_img5_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();


            Windows_Container.Children.Clear();
            Page page = new Page();
            Windows_Container.Children.Add(page);
        }

        private void BTN_img6_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();


            Windows_Container.Children.Clear();
            Page page = new Page();
            Windows_Container.Children.Add(page);
        }

        private void BTN_img7_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();


            Windows_Container.Children.Clear();
            Page page = new Page();
            Windows_Container.Children.Add(page);
        }

        private void BTN_img8_Click(object sender, RoutedEventArgs e)
        {
            Windows_Container.RowDefinitions.Clear();


            Windows_Container.Children.Clear();
            Page page = new Page();
            Windows_Container.Children.Add(page);
        }


        private async void RecupererFilms()
        {
            string urlImg = "https://image.tmdb.org/t/p/w500";
            Film film = new Film();
            string filmsListe = await film.RecupererFilm();

            FilmsContainer filmsContainer = JsonConvert.DeserializeObject<FilmsContainer>(filmsListe);

            List<Root> movies = filmsContainer.Films;

            int i = 1;

            foreach (var movie in movies)
            {
                if (i < 9)
                {
                    string nomBouton = "Img" + i;
                    Button bouton = FindName(nomBouton) as Button;

                    ImageBrush imageBrush = new ImageBrush(new BitmapImage(new Uri(urlImg + movie.poster_path)));
                    bouton.Background = imageBrush;

                    string nomTextBlock = "Titre" + i;
                    TextBlock textBlock = FindName(nomTextBlock) as TextBlock;
                    textBlock.Text = movie.original_title;

                    string nomTextBlockID = "Id" + i;
                    TextBlock textBlockId = FindName(nomTextBlockID) as TextBlock;
                    textBlockId.Text = movie.id.ToString();

                    i++;
                }

            }
        }


    }
}
