using CampeonatoFilmesApi.Domain.Entities;
using CampeonatoFilmesApi.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;

namespace CampeonatoFilmesApi.Controllers
{
    /// <summary>
    /// Fornece métodos de resposta a requisições de clientes externos para entidade Filme.
    /// </summary>
    [Route("api/filmes")]
    [ApiController]
    public class FilmeController : Controller
    {
        /// <summary>
        /// Construtor da classe.
        /// </summary>
        /// <param name="srv">Dependência injetada para classe de serviço.</param>
        /// <param name="logger">Dependência injetada para a classe de log.</param>
        public FilmeController(IFilmeService srv,ILogger<FilmeController> logger)
        {
            this.Logger = logger;
            this.Service = srv;
        }
        private ILogger Logger { get; }
        /// <summary>
        /// Fornece instância de da classe de Serviço da entidade Filme.
        /// </summary>
        private IFilmeService Service { get; }


        /// <summary>
        /// Retorna uma lista de todos os filmes disponíveis.
        /// </summary>
        /// <returns>
        /// 200 - Retorna lista de filmes<br/>
        /// 500 - Erro na otenção da lista.
        /// </returns>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Filme>))]
        [ProducesResponseType(500)]
        public IActionResult GetAll()
        {
            try
            {
                List<Filme> lista = Service.GetAll();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        /// <summary>
        /// Fornece o resultado do campeonato de filmes.
        /// </summary>
        /// <param name="filmes">Lista contendo exatamente 8 filmes.</param>
        /// <returns>
        /// 200 - Lista contendo os vencedores, sendo index 0 para o campeão e 1 para o vice-campeão.<br/>
        /// 400 - Problema na composição da lista.<br/>
        /// 500 - Falha na execução do campeonato.
        /// </returns>
        [Route("campeonato")]
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(List<Filme>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Campeonato([FromBody] List<Filme> filmes)
        {
            try
            {
                List<Filme> lista = Service.ExecutaCampeonato(filmes);
                return Ok(lista);

            }
            catch (ArgumentException ex)
            {
                Logger.LogError(ex.ToString());
                return BadRequest(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Logger.LogError(ex.ToString());
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
