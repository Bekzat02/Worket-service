using Microsoft.EntityFrameworkCore;
using Stazhirovka.Data;
using Stazhirovka.Models;
using Stazhirovka.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stazhirovka.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _db;

        public MovieRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Movie>> ByDateInterval( DateTime date,  DateTime date1)
        {
            if (date.ToString("MMMM") == "October" && date1.ToString("MMMM") == "November")
            {
                return await _db.Movies.Where(x => x.Relevance == true).ToListAsync();
            }
            return await _db.Movies.(x => x.Relevance == false).ToListAsync();
        }

        public  async Task<IEnumerable<Movie>> ByGenre(int genre)
        {
            return await _db.Movies.Where(x => x.Genre.Id==genre).ToListAsync();

        }

        public async Task<IEnumerable<Movie>> ByName(string name)
        {
            return await _db.Movies.Where(x => x.Name == name).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> ByRelevance(bool relevance)
        {
            if (relevance == true)
            {
                return await _db.Movies.Where(x => x.Relevance == true).ToListAsync();
            }
            return await _db.Movies.Where(x => x.Relevance == false).ToListAsync();
        }
    }
}
