using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Film_Tsiory_Andrianasoloharison.Services
{
    public class Film
    {
        // Clé d'API pour accéder à l'API de themoviedb.org
        private readonly string apiKey = "b6926daf9ba6f3c90eff682064a85069";

        // URL de base de l'API de themoviedb.org
        private readonly string apiUrl = "https://api.themoviedb.org/3/";

        // Méthode pour récupérer la liste des films populaires
        public async Task<string> RecupererFilm()
        {
            // Utilisation du bloc using pour assurer la libération des ressources après utilisation
            using (HttpClient client = new HttpClient())
            {
                // Construction de l'URL d'endpoint pour les films populaires
                string endpoint = $"movie/popular?api_key={apiKey}&language=fr-FR";

                // Envoi de la requête HTTP GET à l'API
                HttpResponseMessage response = await client.GetAsync(apiUrl + endpoint);

                // Vérification si la requête a réussi
                if (response.IsSuccessStatusCode)
                {
                    // Retourne la réponse sous forme de chaîne JSON
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // Gérer l'erreur ici (peut retourner une chaîne vide ou une indication d'erreur)
                    return null;
                }
            }
        }

        public async Task<string> RecupererFilmAvecGenre(string genreId)
        {
            // Utilisation du bloc using pour assurer la libération des ressources après utilisation
            using (HttpClient client = new HttpClient())
            {
                // Construction de l'URL d'endpoint pour les films populaires
                string endpoint = $"discover/movie?api_key={apiKey}&with_genres={genreId}";
            
                // Envoi de la requête HTTP GET à l'API
                HttpResponseMessage response = await client.GetAsync(apiUrl + endpoint);

                // Vérification si la requête a réussi
                if (response.IsSuccessStatusCode)
                {
                    // Retourne la réponse sous forme de chaîne JSON
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // Gérer l'erreur ici (peut retourner une chaîne vide ou une indication d'erreur)
                    return null;
                }
            }
        }

        public async Task<string> RecuperGenre()
        {
            // Utilisation du bloc using pour assurer la libération des ressources après utilisation
            using (HttpClient client = new HttpClient())
            {
                // Construction de l'URL d'endpoint pour les films populaires
                string endpoint = $"genre/movie/list?api_key={apiKey}";

                // Envoi de la requête HTTP GET à l'API
                HttpResponseMessage response = await client.GetAsync(apiUrl + endpoint);

                // Vérification si la requête a réussi
                if (response.IsSuccessStatusCode)
                {
                    // Retourne la réponse sous forme de chaîne JSON
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // Gérer l'erreur ici (peut retourner une chaîne vide ou une indication d'erreur)
                    return null;
                }
            }

        }


        // Méthode pour récupérer les détails d'un film par son ID
        public async Task<string> RecupererFilmById(string Id)
        {
            using (HttpClient client = new HttpClient())
            {
                // Construction de l'URL d'endpoint pour récupérer un film par son ID
                string endpoint = $"movie/{Id}?api_key={apiKey}&language=fr-FR";

                // Envoi de la requête HTTP GET à l'API
                HttpResponseMessage response = await client.GetAsync(apiUrl + endpoint);

                // Vérification si la requête a réussi
                if (response.IsSuccessStatusCode)
                {
                    // Retourne la réponse sous forme de chaîne JSON
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // Gérer l'erreur ici (peut retourner une chaîne vide ou une indication d'erreur)
                    return null;
                }
            }
        }

        //public async Task<Film> RecupererDetailsFilm(int idFilm)
        //{

        //    using (HttpClient client = new HttpClient())
        //    {
        //        // Appeler l'API TMDB pour récupérer les détails du film par ID
        //        string endpoint = $"movie{idFilm}?api_key={apiKey}&language=fr-FR";
        //        HttpResponseMessage reponse = await client.GetAsync(apiUrl + endpoint);

        //        if (reponse.IsSuccessStatusCode)
        //        {
        //            return await reponse.Content.ReadAsStringAsync();


        //            //// Extraire le titre et le lien du trailer
        //            //string titre = detailsFilm.title;
        //            //string lienTrailer = "https://www.youtube.com/watch?v=" + detailsFilm.videos.results[0].key;

        //            //// Créer et retourner une instance de Film
        //            //return new Film { Id = idFilm, Titre = titre, LienTrailer = lienTrailer };
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Erreur de l'API TMDB : {reponse.ReasonPhrase}");
        //        }
        //    }
        //}
    }
}
