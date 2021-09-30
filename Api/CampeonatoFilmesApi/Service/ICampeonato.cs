using CampeonatoFilmesApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampeonatoFilmesApi.Service
{
    /// <summary>
    /// Interface de agregação de 
    /// </summary>
    public interface ICampeonato
    {
        /// <summary>
        /// Organiza os filmes a partir das notas, em ordem decrescente. Caso sejam observadas notas iguais em dois elementos, nestes será utilizado o critério alfabético ascendente.
        /// </summary>
        /// <param name="participantes">Lista de filmes a serem organizados.</param>
        /// <returns>Filmes organizados nos critérios descritos.</returns>
        public List<Filme> ExecutaPartida(List<Filme> participantes);
        /// <summary>
        /// Organiza os filmes no formato First X Last, para a primeira rodada do campeonato.
        /// </summary>
        /// <param name="filmes">Lista de filmes a serem organizados.</param>
        /// <returns>Lista organizada de filmes.</returns>
        public List<Filme> PreOrganizaFilmes(List<Filme> filmes);
        /// <summary>
        /// Executa uma rodada do campeonato de filmes formada por duplas separadas em ordem ascendente.
        /// </summary>
        /// <param name="filmes">Filmes participa</param>
        /// <returns>Filmes campeões da rodada</returns>
        public List<Filme> ExecutaRodada(List<Filme> filmes);
    }
}
