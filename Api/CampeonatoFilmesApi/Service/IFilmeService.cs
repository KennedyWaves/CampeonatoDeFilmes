using CampeonatoFilmesApi.Domain;
using System.Collections.Generic;

namespace CampeonatoFilmesApi.Service
{
    /// <summary>
    /// Interface da classe de serviço para a entidade Filme.
    /// </summary>
    public interface IFilmeService
    {
        /// <summary>
        /// Executa validação da lista a partir de critérios predefinidos de aceitabilidade.
        /// </summary>
        /// <param name="filmes">Lista de filmes a ser validada.</param>
        /// <returns>True: Lista é válida<br/>False: Lista é inválida.</returns>
        public bool ValidaListaCampeonato(List<Filme> filmes);
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
