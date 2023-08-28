using WebApiPokemon.Models;

namespace WebApiPokemon.Interfaces
{
    public interface IPokemonRepository
    {
        public Task<ICollection<Pokemon>> GetAllPokemonAcsyn();
        public Task<Pokemon> GetPokemonAcsyn(int id);
        public Task<Pokemon> GetPokemonAcsyn(string name);
        public Task<decimal> GetPokemonAverageRating(int id);
        public Task<bool> PokemonExists(int id);
    }
}
