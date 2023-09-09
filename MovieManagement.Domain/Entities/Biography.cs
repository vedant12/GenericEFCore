﻿namespace MovieManagement.Domain.Entities
{
    public class Biography
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ActorId { get;set; }
        public Actor? Actor { get; set; }
    }
}