using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Film_Tsiory_Andrianasoloharison.Services
{
    public class Film
    {
        private readonly string apiKey = "b6926daf9ba6f3c90eff682064a85069";
        private readonly string apiUrl = "https://api.themoviedb.org/3/";

        // Url Popular
        //api.themoviedb.org/3/movie/popular?api_key=b6926daf9ba6f3c90eff682064a85069

        public async Task<string> RecupererFilm()
        {
            using (HttpClient client = new HttpClient())
            {
                string endpoint = $"movie/popular?api_key={apiKey}&language=fr-FR";
                //string endpoint = $"movie/11?api_key={apiKey}&language=fr-FR";
                HttpResponseMessage response = await client.GetAsync(apiUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // Gérer l'erreur ici
                    return null;
                }
            }
        }

        public async Task<string> RecupererFilmById(string Id)
        {
            using (HttpClient client = new HttpClient())
            {
                string endpoint = $"movie/{Id}?api_key={apiKey}&language=fr-FR";
                HttpResponseMessage response = await client.GetAsync(apiUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // Gérer l'erreur ici
                    return null;
                }
            }
        }

    }
}
