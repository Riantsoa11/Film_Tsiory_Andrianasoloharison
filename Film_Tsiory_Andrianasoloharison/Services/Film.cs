using System;
using System.Net.Http;
using System.Threading.Tasks;

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
    }
}
