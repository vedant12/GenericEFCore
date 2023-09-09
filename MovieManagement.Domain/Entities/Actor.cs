using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class Actor : BaseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public List<Movie>? Movies { get; set; }
        public Biography? Biography { get; set; }
    }
}
