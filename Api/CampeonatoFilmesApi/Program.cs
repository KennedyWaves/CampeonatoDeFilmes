using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace CampeonatoFilmesApi
{
    /// <summary>
    /// Classe de EntryPoint da aplica��o
    /// </summary>
    public class Program
    {
        /// <summary>
        /// M�todo de EntryPoint da classe.
        /// </summary>
        /// <param name="args">argumentos</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
