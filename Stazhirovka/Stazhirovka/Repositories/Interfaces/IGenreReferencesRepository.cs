using Stazhirovka.DTOs;
using Stazhirovka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stazhirovka.Repositories.Interfaces
{
    public interface IGenreReferencesRepository
    {
         Task<bool> Add(GenreReference genre);
        Task<IEnumerable<GenreReference>> GetGenre();
    }
}
