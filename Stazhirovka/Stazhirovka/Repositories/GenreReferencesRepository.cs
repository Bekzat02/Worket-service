using Microsoft.EntityFrameworkCore;
using Stazhirovka.Data;
using Stazhirovka.DTOs;
using Stazhirovka.Models;
using Stazhirovka.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stazhirovka.Repositories
{
    public class GenreReferencesRepository : IGenreReferencesRepository
    {
        private readonly DataContext _db;
        public GenreReferencesRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<bool> Add(GenreReference genre)
        {
            await _db.GenreReferences.AddAsync(genre);
            return await _db.SaveChangesAsync()>0;
          
        }
        public async Task<IEnumerable<GenreReference>> GetGenre()
        {
            return await _db.GenreReferences.ToListAsync();
        }
    }
}
