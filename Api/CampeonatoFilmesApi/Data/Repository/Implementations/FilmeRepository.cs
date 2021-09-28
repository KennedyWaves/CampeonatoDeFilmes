using CampeonatoFilmesApi.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace CampeonatoFilmesApi.Data.Repository.Implementations
{
    /// <summary>
    /// Implementação da interface de repositório para entidade Filme.
    /// </summary>
    public class FilmeRepository : IFilmeRepository
    {
        public List<Filme> ListAll()
        {

            HttpWebRequest webRequest = WebRequest.Create("http://copafilmes.azurewebsites.net/api/filmes") as HttpWebRequest;
            if (webRequest == null)
            {
                throw new Exception("Comunicação com a API de filmes falhou.");
            }
            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using var s = webRequest.GetResponse().GetResponseStream();
            using var sr = new StreamReader(s);
            var filmeAsJson = sr.ReadToEnd();
            var filmes = JsonConvert.DeserializeObject<List<Filme>>(filmeAsJson);
            return filmes;

        }
    }
}
