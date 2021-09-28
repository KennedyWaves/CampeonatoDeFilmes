using CampeonatoFilmesApi.Domain.Entities;
using System;
using System.Collections.Generic;
using Xunit;

namespace CampeonatoFilmesApiTests
{
    public class FilmeServiceExecutaCampeonatoTests : FilmeBaseTest
    {
        #region Testes de ExecutaCampeonato
        [Fact]
        public void ListaComElementoInvalido_DeveLancar_ArgumentException()
        {
            // Arrange
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
                null,
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

            // Act
            void acao() { Service.ExecutaCampeonato(moc); }

            // Assert
            Assert.Throws<InvalidOperationException>(acao);

        }
        [Fact]
        public void FilmesDoTestCase_DeveRetornar_VingadoresEOsIncriveis2()
        {
            // Arrange
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
                new Filme(){
                Id= "tt3501632",
                Titulo="Thor: Ragnarok",
                Ano= 2017,
                Nota= 7.9f
                }
            };

            // Act
            List<Filme> resultado = Service.ExecutaCampeonato(moc);

            // Assert
            // Vingadores: Guerra Infinita
            Assert.Equal("Vingadores: Guerra Infinita", resultado[0].Titulo);
            // Os Incríveis 2
            Assert.Equal("Os Incríveis 2", resultado[1].Titulo);

        }
        [Fact]
        public void NotasIguais_DeveRetornar_AAA()
        {
            // Arrange
            List<Filme> moc = new List<Filme>()
            {
                new Filme()
                {
                Id= "tt3606756",
                Titulo="AAA",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt53466214",
                Titulo="aaa",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt5164214",
                Titulo="BBB",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt7784604",
                Titulo="Hereditário",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt4154756",
                Titulo="Vingadores: Guerra Infinita",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt5463162",
                Titulo="Deadpool 2",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt3778644",
                Titulo="Han Solo=Uma História Star Wars",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt3501632",
                Titulo="Thor: Ragnarok",
                Ano= 2017,
                Nota= 5f
                }
            };

            // Act
            List<Filme> resultado = Service.ExecutaCampeonato(moc);

            // Assert
            // Vingadores: Guerra Infinita
            Assert.Equal("AAA", resultado[0].Titulo);
            // Os Incríveis 2
            Assert.Equal("BBB", resultado[1].Titulo);

        }
        [Fact]
        public void NotasIguais_DeveRetornar_aaaaa()
        {
            // Arrange
            List<Filme> moc = new List<Filme>()
            {
                new Filme()
                {
                Id= "tt3606756",
                Titulo="aaaaa",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt53466214",
                Titulo="AAAAA",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt5164214",
                Titulo="BBB",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt7784604",
                Titulo="Hereditário",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt4154756",
                Titulo="Vingadores: Guerra Infinita",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt5463162",
                Titulo="Deadpool 2",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt3778644",
                Titulo="Han Solo=Uma História Star Wars",
                Ano= 2018,
                Nota= 5f
                },
                new Filme(){
                Id= "tt3501632",
                Titulo="Thor: Ragnarok",
                Ano= 2017,
                Nota= 5f
                }
            };

            // Act
            List<Filme> resultado = Service.ExecutaCampeonato(moc);

            // Assert
            // Vingadores: Guerra Infinita
            Assert.Equal("aaaaa", resultado[0].Titulo);
            // Os Incríveis 2
            Assert.Equal("BBB", resultado[1].Titulo);

        }
        [Fact]
        public void TePegueiPossuiNota99999_DeveRetornar_TePeguei()
        {
            // Arrange
            List<Filme> moc = new List<Filme>()
            {
                new Filme()
                {
                Id= "tt2854926",
                Titulo="Te Peguei!",
                Ano= 2018,
                Nota= 9.9999f
                },
                new Filme(){
                Id= "tt0317705",
                Titulo="Os Incríveis",
                Ano= 2004,
                Nota= 9.7f
                },
                new Filme(){
                Id= "tt3799232",
                Titulo="A Barraca do Beijo",
                Ano= 2018,
                Nota= 9.8f
                },
                new Filme(){
                Id= "tt1365519",
                Titulo="Tomb Raider: A Origem",
                Ano= 2018,
                Nota= 9.7f
                },
                new Filme(){
                Id= "tt1825683",
                Titulo="Pantera Negra",
                Ano= 2018,
                Nota= 9.6f
                },
                new Filme(){
                Id= "tt5834262",
                Titulo="Hotel Artemis",
                Ano= 2018,
                Nota= 9.5f
                },
                new Filme(){
                Id= "tt7690670",
                Titulo="Superfly",
                Ano= 2018,
                Nota= 9.4f
                },
                new Filme(){
                Id= "tt6499752",
                Titulo="Upgrade",
                Ano= 2018,
                Nota= 9.3f
                }
            };

            // Act
            List<Filme> resultado = Service.ExecutaCampeonato(moc);

            // Assert
            // Te Peguei!
            Assert.Equal("Te Peguei!", resultado[0].Titulo);

        }
        [Fact]
        public void MaisDeOitoFilmes_DeveLancar_ArgumentException()
        {
            // Arrange
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
                new Filme(){
                Id= "tt3501632",
                Titulo="Thor: Ragnarok",
                Ano= 2017,
                Nota= 7.9f
                },
                new Filme()
                {
                  Id= "46708-128",
                  Titulo= "Ricky Gervais Live: Animals",
                 Ano= 2000,
                  Nota= 8.497f
                }
            };
            // Act
            void acao() { Service.ExecutaCampeonato(moc); }

            // Assert
            Assert.Throws<ArgumentException>(acao);

        }
        [Fact]
        public void MenosDeOitoFilmes_DeveLancar_ArgumentException()
        {
            // Arrange
            List<Filme> moc = new List<Filme>()
            {
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
                },
                new Filme()
                {
                  Id= "46708-128",
                  Titulo= "Ricky Gervais Live: Animals",
                 Ano= 2000,
                  Nota= 8.497f
                }
            };
            // Act
            void acao() { Service.ExecutaCampeonato(moc); }

            // Assert
            Assert.Throws<ArgumentException>(acao);

        }
        #endregion

        #region testes de GetAll
        [Fact]
        public void DeveRetornar_FilmesDaApiPublica()
        {
            // Arrange
            List<Filme> resultado = Service.GetAll();
            // Act
            int contagem = resultado.Count;
            // Assert
            Assert.NotEqual(0, contagem);
        }
        #endregion
    }
}
