using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stazhirovka.Models
{
    public class Movie
    {
        public Movie()
        {
                
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Relevance { get; set; }
        public GenreReference Genre{get;set;}
    }
}
