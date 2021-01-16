using Microsoft.AspNetCore.Mvc;
using Stazhirovka.DTOs;
using Stazhirovka.Models;
using Stazhirovka.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stazhirovka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : Controller
    {
        private readonly IGenreReferencesRepository _genreRepo;

        public GenreController(IGenreReferencesRepository genreRepo)
        {
            _genreRepo = genreRepo;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(GenreDTO dto)
        {
            GenreReference genre = new GenreReference(dto);
            if (await _genreRepo.Add(genre))
            {
                return Ok("A new genre was added");
            }
            return BadRequest("Beka is greatest");
        }
        public async Task<IEnumerable<GenreReference>> GetGenre()
        {
            return await _genreRepo.GetGenre();
        }
    }
}
