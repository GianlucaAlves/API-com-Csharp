using api.Models;

namespace api.Services;

public interface IVideoGameCharacterService
{
    Task<List<Character>> GetAllCharactersAsync();
    Task<Character> GetCharacterByIdAsync(int id);

    Task<Character> AddCharacterAsync();
    Task<bool> UpdateCharacterAsync(int id, Character character);
    Task<bool> DeleteCharacterAsync(int id);
}
