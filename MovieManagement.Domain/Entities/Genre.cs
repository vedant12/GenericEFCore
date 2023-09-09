namespace MovieManagement.Domain.Entities
{
    public class Genre : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Movie>? Movies { get; set; }
    }
}