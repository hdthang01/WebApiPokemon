using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiPokemon.Data;
using WebApiPokemon.Dto;
using WebApiPokemon.Interfaces;
using WebApiPokemon.Models;

namespace WebApiPokemon.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<ICollection<Pokemon>> GetAllPokemonAcsyn()
        {
            return await _context.Pokemon.ToListAsync();
        }

        public async Task<Pokemon> ?GetPokemonAcsyn(int id)
        {
            return await _context.Pokemon.FindAsync(id);
        }

        public async Task<Pokemon> ?GetPokemonAcsyn(string name)
        {
            return await _context.Pokemon.FirstOrDefaultAsync(p => p.Name == name);
        }

        public async Task<decimal> GetPokemonAverageRating(int id)
        {
            var review = await _context.Reviews.Where(p => p.Pokemon.Id == id).ToListAsync();
            decimal reviewValue = 0;

            if (review.Count() > 0)
            {
                reviewValue = (decimal)review.Sum(p => p.Rating) / review.Count();
            }

            return reviewValue;

        }

        public async Task<bool> PokemonExists(int id)
        {
            return await _context.Pokemon.AnyAsync(p => p.Id == id);
        }
    }
}
