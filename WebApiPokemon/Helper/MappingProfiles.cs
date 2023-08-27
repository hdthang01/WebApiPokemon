using AutoMapper;
using WebApiPokemon.Dto;
using WebApiPokemon.Models;

namespace WebApiPokemon.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>().ReverseMap();
        }
    }
}
