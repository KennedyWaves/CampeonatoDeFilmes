namespace CampeonatoFilmesApi.Domain.Entities
{
    /// <summary>
    /// Entidade que representa um Filme.
    /// </summary>
    public class Filme
    {
        /// <summary>
        /// Identificação do filme.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Título do filme.
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Ano de lançamento do filme.
        /// </summary>
        public int Ano { get; set; }
        /// <summary>
        /// Nota recebida pelo filme.
        /// </summary>
        public float Nota { get; set; }

    }
}
