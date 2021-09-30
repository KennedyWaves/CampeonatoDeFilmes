using CampeonatoFilmesApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampeonatoFilmesApi.Service
{
    public class Campeonato : ICampeonato
    {
        public List<Filme> ExecutaPartida(List<Filme> participantes)
        {
            participantes.Sort((a, b) =>
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
            return participantes;
        }

        public List<Filme> ExecutaRodada(List<Filme> filmes)
        {
            List<Filme> filmesClassificados = new List<Filme>();

            for (var x = 0; x < filmes.Count; x += 2)
            {
                Filme competidor1 = filmes[x];
                Filme competidor2 = filmes[x + 1];
                List<Filme> jogo = new() { competidor1, competidor2 };
                List<Filme> resultado = this.ExecutaPartida(jogo);
                filmesClassificados.Add(resultado[0]);
            }
            return filmesClassificados;
        }

        public List<Filme> PreOrganizaFilmes(List<Filme> filmes)
        {
            filmes.Sort((a, b) =>
            {
                return a.Titulo.ToLower().CompareTo(b.Titulo.ToLower());
            });
            List<Filme> filmesParticipantes = new List<Filme>();
            for (var x = 0; x < filmes.Count / 2; x++)
            {
                Filme competidor1 = filmes[x];
                Filme competidor2 = filmes[(filmes.Count - 1) - x];
                filmesParticipantes.Add(competidor1);
                filmesParticipantes.Add(competidor2);
            }
            return filmesParticipantes;
        }
    }
}
