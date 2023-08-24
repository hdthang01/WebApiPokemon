using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPokemon.Interfaces;

namespace WebApiPokemon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            this.pokemonRepository = pokemonRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPokemon()
        {
            return Ok(await pokemonRepository.GetAllPokemonAcsyn());
        }
    }
}
