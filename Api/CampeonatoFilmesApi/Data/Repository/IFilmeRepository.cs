using CampeonatoFilmesApi.Domain.Entities;
using System.Collections.Generic;

namespace CampeonatoFilmesApi.Data.Repository
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
