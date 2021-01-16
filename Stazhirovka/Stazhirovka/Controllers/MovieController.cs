using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stazhirovka.Data;
using Stazhirovka.Models;
using Stazhirovka.Repositories.Interfaces;

namespace Stazhirovka.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepo;

        public MovieController(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }

        [HttpPost("date")]
        public async Task<IEnumerable<Movie>> GetMoviesFromDateInterval(DateTime date,DateTime date1)
        {
            return await _movieRepo.ByDateInterval(date, date1);
        }

        [HttpGet("{name}")]
        public async Task<IEnumerable<Movie>> GetMoviesFromName(string name)
        {
            return await _movieRepo.ByName(name);
        }

        [HttpGet("genre/{id}")]
        public async Task<IEnumerable<Movie>> GetMoviesFromDateInterval(int id)
        {
            return await _movieRepo.ByGenre(id);
        }

        [HttpGet("relevance/{relevant}")]
        public async Task<IEnumerable<Movie>> GetMoviesFromDateInterval(bool relevant)
        {
            return await _movieRepo.ByRelevance(relevant);
        }


    }
}
