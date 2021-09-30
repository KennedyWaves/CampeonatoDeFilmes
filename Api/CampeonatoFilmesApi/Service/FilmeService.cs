using CampeonatoFilmesApi.Data;
using CampeonatoFilmesApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CampeonatoFilmesApi.Service
{
    /// <summary>
    /// Implementação da Interface de serviço para entidade Filme.
    /// </summary>
    public class FilmeService : IFilmeService
    {
        /// <summary>
        /// Instância de classe auxiliar para execução do campeonato de filmes.
        /// </summary>
        private ICampeonato Campeonato;
        /// <summary>
        /// Instância de repositório para entidade Filme.
        /// </summary>
        private IFilmeRepository Repository { get; }
        /// <summary>
        /// Construtor da classe.
        /// </summary>
        /// <param name="repo">Injeção de dependência para classe de repostiório.</param>
        public FilmeService(IFilmeRepository repo)
        {
            this.Repository = repo;
            this.Campeonato = new Campeonato();
        }
        public List<Filme> ExecutaCampeonato(List<Filme> filmes)
        {
            List<Filme> filmesParticipantes = Campeonato.PreOrganizaFilmes(filmes);

            while (filmesParticipantes.Count > 2)
            {
                filmesParticipantes = Campeonato.ExecutaRodada(filmesParticipantes);
            }

            filmesParticipantes = Campeonato.ExecutaPartida(filmesParticipantes);

            return (filmesParticipantes);
        }
        public List<Filme> GetAll()
        {
            return Repository.ListAll();
        }

        public bool ValidaListaCampeonato(List<Filme> filmes)
        {
            int qtMinimaDeFilmes = 8;
            try
            {
                return filmes.Count == qtMinimaDeFilmes;
            }
            catch
            {
                return false;
            }
        }
    }
}

