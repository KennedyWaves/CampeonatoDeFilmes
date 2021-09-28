using CampeonatoFilmesApi.Data.Repository;
using CampeonatoFilmesApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CampeonatoFilmesApi.Service.Implementations
{
    /// <summary>
    /// Implementação da Interface de serviço para entidade Filme.
    /// </summary>
    public class FilmeService : IFilmeService
    {
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
        }
        public List<Filme> ExecutaCampeonato(List<Filme> filmes)
        {
            #region Pré-tratamento
            // Verificar se a lista é válida
            if (filmes == null || filmes.Count != 8)
            {
                throw new ArgumentException("A lista precisa ter pelo menos 8 elementos");
            }
            // Organizar em ordem alfabética
            filmes.Sort((a, b) => { return a.Titulo.ToLower().CompareTo(b.Titulo.ToLower()); });


            // Preparar a lista no formato first x last
            List<Filme> filmesParticipantes = new List<Filme>();
            for (var x = 0; x < filmes.Count / 2; x++)
            {
                Filme competidor1 = filmes[x];
                Filme competidor2 = filmes[(filmes.Count - 1) - x];
                filmesParticipantes.Add(competidor1);
                filmesParticipantes.Add(competidor2);
            }
            #endregion

            #region de facto Campeonato

            // Começa as rodadas
            List<Filme> filmesClassificados = new List<Filme>();
            while (filmesParticipantes.Count > 2)
            {
                for (var x = 0; x < filmesParticipantes.Count; x += 2)
                {
                    Filme competidor1 = filmesParticipantes[x];
                    Filme competidor2 = filmesParticipantes[x + 1];
                    List<Filme> competicao = new List<Filme>() { competidor1, competidor2 };
                    competicao = SortFilmesByNotaAndNome(competicao);
                    filmesClassificados.Add(competicao[0]);
                }
                filmesParticipantes = filmesClassificados.ToList();
                filmesClassificados.Clear();
            }
            #endregion

            #region Obtenção do resultado
            filmesParticipantes = SortFilmesByNotaAndNome(filmesParticipantes);
            return (filmesParticipantes);
            #endregion

        }
        /// <summary>
        /// Organiza os filmes a partir das notas, em ordem decrescente. Caso sejam observadas notas iguais em dois elementos, nestes será utilizado o critério alfabético ascendente.
        /// </summary>
        /// <param name="filmes">Lista de filmes a serem organizados.</param>
        /// <returns>Filmes organizados nos critérios descritos.</returns>
        private static List<Filme> SortFilmesByNotaAndNome(List<Filme> filmes)
        {
            filmes.Sort((a, b) =>
            {
                if (a.Nota == b.Nota)
                {
                    return a.Titulo.ToLower().CompareTo(b.Titulo.ToLower());
                }
                else
                {
                    return b.Nota.CompareTo(a.Nota);
                }
            });
            return filmes;
        }
        public List<Filme> GetAll()
        {
            return Repository.ListAll();
        }
    }
}

