using static WebApiPokemon.Models.Enums;

namespace WebApiPokemon.Models
{
    public class ModelMappers
    {
        public static string ?MapPokemonTypeEnumToPokemTypeString(int pokemonType)
        {
            return Enum.GetName(typeof(PokemonType), pokemonType);
        }
    }
}
