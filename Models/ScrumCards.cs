
namespace Caso_de_estudio1.Models
{
    public class ScrumCards
    {
        public int ID { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Encargado { get; set; }
        public string? Descripcion { get; set; }
        public string? Comentario { get; set; }
        public string? Tipo { get; set; }
        public int Puntos { get; set; }
        public string? NombreSprint { get; set; }
        public string? Estado { get; set; }

        public ScrumCards()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Encargado = string.Empty;
            Descripcion = string.Empty;
            Comentario = string.Empty;
            Tipo = string.Empty;
            NombreSprint = string.Empty;
            Estado = string.Empty;
        }
    }
}