using Film_Tsiory_Andrianasoloharison.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        public async void RecupererFilmDetail()
        {
            Film film = new Film();
            string filmDetail = await film.RecupererFilmById(Id);

            Root root = JsonConvert.DeserializeObject<Root>(filmDetail);

            Titre.Text = root.original_title;


            string genres = "";
            int count = root.genres.Count;

            foreach (Genre genre in root.genres)
            {
                genres += genre.name;

                if (--count > 0)
                {
                    genres += ", ";
                }
            }

            Information.Text = root.release_date.ToString() + " - " + genres + " - " + root.runtime + " min";
            Apercu.Text = root.overview;

            string productions = "";
            int countProd = root.production_companies.Count;

            foreach (ProductionCompany production_companies in root.production_companies)
            {
                productions += production_companies.name;
                if (--countProd > 0)
                {
                    productions += ", ";
                }
            }

            Production_companies.Text = productions;


            string pays = "";
            int countPays = root.production_countries.Count;

            foreach (ProductionCountry production_countries in root.production_countries)
            {
                pays += production_countries.name;
                if (--countPays > 0)
                {
                    pays += ", ";
                }
            }

            Production_countries.Text = pays;

        }
        
    }


}
