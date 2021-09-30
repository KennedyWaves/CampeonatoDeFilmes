using CampeonatoFilmesApi.Domain;
using System.Collections.Generic;

namespace CampeonatoFilmesApi.Data
{
    /// <summary>
    /// Interface de obtenção de dados da entidade Filme.
    /// </summary>
    public interface IFilmeRepository
    {
        /// <summary>
        /// Retorna todos os registros de filmes.
        /// </summary>
        /// <returns></returns>
        public List<Filme> ListAll();
    }
}
