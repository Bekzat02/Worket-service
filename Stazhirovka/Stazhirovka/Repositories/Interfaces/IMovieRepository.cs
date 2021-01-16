using Microsoft.AspNetCore.Mvc;
using Stazhirovka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stazhirovka.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> ByRelevance(bool relevance);
        Task<IEnumerable<Movie>> ByDateInterval(DateTime date, DateTime date1);
        Task<IEnumerable<Movie>> ByGenre(int genre);
        Task<IEnumerable<Movie>> ByName(string name);
    }
}
