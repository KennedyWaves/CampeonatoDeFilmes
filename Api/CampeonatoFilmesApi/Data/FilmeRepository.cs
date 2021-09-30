using CampeonatoFilmesApi.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace CampeonatoFilmesApi.Data
{
    /// <summary>
    /// Implementação da interface de repositório para entidade Filme.
    /// </summary>
    public class FilmeRepository : IFilmeRepository
    {
        public List<Filme> ListAll()
        {
            string URI = "http://copafilmes.azurewebsites.net/api/filmes";
            WebClient wc = new WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/json";
            string filmeAsJson = wc.DownloadString(URI);
            var filmes = JsonConvert.DeserializeObject<List<Filme>>(filmeAsJson);
            return filmes;

        }
    }
}
