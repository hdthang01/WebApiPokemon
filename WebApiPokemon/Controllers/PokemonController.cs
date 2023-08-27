using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using WebApiPokemon.Dto;
using WebApiPokemon.Interfaces;
using WebApiPokemon.Models;

namespace WebApiPokemon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository pokemonRepository;
        private readonly IMapper _mapper;

        public PokemonController(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            this.pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PokemonDto>), 200)]
        public async Task<IActionResult> GetAllPokemon()
        {
            //var pokemons = pokemonRepository.GetAllPokemonAcsyn();
            var pokemons = _mapper.Map<List<PokemonDto>>(await pokemonRepository.GetAllPokemonAcsyn());
            return Ok(pokemons);
        }
    }
}
