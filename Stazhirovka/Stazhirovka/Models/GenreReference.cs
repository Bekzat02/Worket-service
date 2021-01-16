using Stazhirovka.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stazhirovka.Models
{
    public class GenreReference
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public ICollection<Movie> Movies { get; set; }

        public GenreReference(GenreDTO dto)
        {
            
            GenreName = dto.Name;
        }
        public GenreReference()
        {

        }
    }
}
