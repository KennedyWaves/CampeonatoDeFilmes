using CampeonatoFilmesApi.Controllers;
using CampeonatoFilmesApi.Data;
using CampeonatoFilmesApi.Service;
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
