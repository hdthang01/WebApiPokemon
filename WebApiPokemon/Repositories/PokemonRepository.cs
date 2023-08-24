using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiPokemon.Data;
using WebApiPokemon.Interfaces;
using WebApiPokemon.Models;

namespace WebApiPokemon.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext dataContext;

        public PokemonRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task<ICollection<Pokemon>> GetAllPokemonAcsyn()
        {
            return await dataContext.Pokemon.ToListAsync();
        }
    }
}
