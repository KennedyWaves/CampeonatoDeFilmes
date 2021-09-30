using CampeonatoFilmesApi.Data;
using CampeonatoFilmesApi.Domain;
using CampeonatoFilmesApi.Service;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace CampeonatoFilmesApiTests
{
    public class ListaFilmesTests : FilmeBaseTest
    {

        #region testes de GetAll
        [Fact]
        public void DeveRetornar_FilmesDaApiPublica()
        {
            // Arrange

            IFilmeService mockService = new FilmeService(new Mock<FilmeRepository>().Object);
            List<Filme> resultado = Service.GetAll();
            // Act
            int contagem = resultado.Count;
            // Assert
            Assert.NotEqual(0, contagem);
        }
        #endregion
    }
}
