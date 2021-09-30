using CampeonatoFilmesApi.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace CampeonatoFilmesApiTests
{
    public class FilmeControllerTests : FilmeBaseTest
    {
        #region campeonato tests
        [Fact]
        public void FilmesDoTestCase_DeveRetornar_OkObjectResult()
        {
            /// Arrange

            List<Filme> filmes = new List<Filme>()
            {
                new Filme()
                {
                Id= "tt3606756",
                Titulo="Os Incríveis 2",
                Ano= 2018,
                Nota= 8.5f
                },
                new Filme(){
                Id= "tt4881806",
                Titulo="Jurassic World: Reino Ameaçado",
                Ano= 2018,
                Nota= 6.7f
                },
                new Filme(){
                Id= "tt5164214",
                Titulo="Oito Mulheres e um Segredo",
                Ano= 2018,
                Nota= 6.3f
                },
                new Filme(){
                Id= "tt7784604",
                Titulo="Hereditário",
                Ano= 2018,
                Nota= 7.8f
                },
                new Filme(){
                Id= "tt4154756",
                Titulo="Vingadores: Guerra Infinita",
                Ano= 2018,
                Nota= 8.8f
                },
                new Filme(){
                Id= "tt5463162",
                Titulo="Deadpool 2",
                Ano= 2018,
                Nota= 8.1f
                },
                new Filme(){
                Id= "tt3778644",
                Titulo="Han Solo=Uma História Star Wars",
                Ano= 2018,
                Nota= 7.2f
                },
                new Filme(){
                Id= "tt3501632",
                Titulo="Thor: Ragnarok",
                Ano= 2017,
                Nota= 7.9f
                }
            };

            /// Act

            IActionResult result = Controller.Campeonato(filmes);

            /// Assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void ListaVazia_DeveRetornar_BadRequest()
        {
            /// Arrange

            List<Filme> filmes = new List<Filme>();

            /// Act

            IActionResult result = Controller.Campeonato(filmes);

            /// Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public void ListaNull_DeveRetornar_BadRequest()
        {
            /// Arrange

            List<Filme> filmes = null;

            /// Act

            IActionResult result = Controller.Campeonato(filmes);

            /// Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public void ListaComMais8Elementos_DeveRetornar_BadRequest()
        {
            /// Arrange

            List<Filme> filmes = new List<Filme>() { new Filme(), new Filme(), new Filme(), new Filme(), new Filme(), new Filme(), new Filme(), new Filme(), new Filme() };

            /// Act

            IActionResult result = Controller.Campeonato(filmes);
            Debug.WriteLine(result);

            /// Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public void ListaComMenos8Elementos_DeveRetornar_BadRequest()
        {
            /// Arrange

            List<Filme> filmes = new List<Filme>() { new Filme(), new Filme(), new Filme(), new Filme(), new Filme(), new Filme(), new Filme() };

            /// Act

            IActionResult result = Controller.Campeonato(filmes);
            Debug.WriteLine(result);

            /// Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public void ListaComElementoInvalido_DeveRetornar_BadRequest()
        {
            /// Arrange
            List<Filme> moc = new List<Filme>()
            {
                new Filme()
                {
                Id= "tt3606756",
                Titulo="Os Incríveis 2",
                Ano= 2018,
                Nota= 8.5f
                },
                new Filme(){
                Id= "tt4881806",
                Titulo="Jurassic World: Reino Ameaçado",
                Ano= 2018,
                Nota= 6.7f
                },
                new Filme(){
                Id= "tt5164214",
                Titulo="Oito Mulheres e um Segredo",
                Ano= 2018,
                Nota= 6.3f
                },
                new Filme(){
                Id= "tt7784604",
                Titulo="Hereditário",
                Ano= 2018,
                Nota= 7.8f
                },
                new Filme(){
                Id= "tt4154756",
                Titulo="Vingadores: Guerra Infinita",
                Ano= 2018,
                Nota= 8.8f
                },
                new Filme(){
                Id= "tt5463162",
                Titulo="Deadpool 2",
                Ano= 2018,
                Nota= 8.1f
                },
                new Filme(){
                Id= "tt3778644",
                Titulo="Han Solo=Uma História Star Wars",
                Ano= 2018,
                Nota= 7.2f
                },
                null
            };

            /// Act

            IActionResult result = Controller.Campeonato(moc);
            Debug.WriteLine(result);

            /// Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
        #endregion
    }
}
