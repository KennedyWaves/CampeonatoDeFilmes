using CampeonatoFilmesApi.Domain.Entities;
using System.Collections.Generic;

namespace CampeonatoFilmesApi.Service
{
    /// <summary>
    /// Interface da classe de serviço para a entidade Filme.
    /// </summary>
    public interface IFilmeService
    {
        /// <summary>
        /// Retorna todos os registros de Filme.
        /// </summary>
        /// <returns>Lista contendo todos os filmes.</returns>
        public List<Filme> GetAll();

        /// <summary>
        /// Executa o campeonato de filmes.
        /// </summary>
        /// <param name="filmes">Lista de 8 filmes participantes.</param>
        /// <returns>Lista contendo os dois primeiros lugares do campeonato de filmes.</returns>
        public List<Filme> ExecutaCampeonato(List<Filme> filmes);
    }
}
