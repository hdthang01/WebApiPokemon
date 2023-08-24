using WebApiPokemon.Models;

namespace WebApiPokemon.Interfaces
{
    public interface IPokemonRepository
    {
        public Task<ICollection<Pokemon>> GetAllPokemonAcsyn();
    }
}
