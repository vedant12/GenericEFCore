﻿namespace MovieManagement.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Genre>? Genres { get; set; }
        public int ActorId { get; set; }
        public Actor? Actor { get; set; }
    }
}