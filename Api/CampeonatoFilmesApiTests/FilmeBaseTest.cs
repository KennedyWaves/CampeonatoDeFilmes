using CampeonatoFilmesApi.Controllers;
using CampeonatoFilmesApi.Data.Repository;
using CampeonatoFilmesApi.Data.Repository.Implementations;
using CampeonatoFilmesApi.Service;
using CampeonatoFilmesApi.Service.Implementations;
using Microsoft.Extensions.Logging;
using Moq;

namespace CampeonatoFilmesApiTests
{
    public abstract class FilmeBaseTest
    {
        public IFilmeRepository Repository { get; }
        public IFilmeService Service { get; }
        public FilmeController Controller { get; }
        public FilmeBaseTest()
        {
            Repository = new FilmeRepository();
            Service = new FilmeService(Repository);
            Controller = new FilmeController(Service,new Mock<ILogger<FilmeController>>().Object);
        }
    }
}
