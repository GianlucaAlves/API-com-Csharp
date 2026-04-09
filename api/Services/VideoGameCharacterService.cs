using api.Models;

namespace api.Services
{
    public class VideoGameCharacterService : IVideoGameCharacterService
    {
        static List<Character> characters = new List<Character>
        {
            new Models.Character{Id = 1, Name = "Mario", Game = "Super Mario Bros", Role = "Protagonist"},
            new Models.Character {Id = 2, Name = "Link", Game = "The Legend of Zelda", Role = "Protagonist"},
            new Models.Character {Id = 3, Name = "Bowser", Game = "Super Mario Bros", Role = "Villain"},
            new Models.Character {Id = 4, Name = "Ezio", Game = "Assassin's Creed 2", Role = "Protagonist"}

        };
        public Task<Character> AddCharacterAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Character>> GetAllCharactersAsync()
            => await Task.FromResult(characters);
        

        public async Task<Character> GetCharacterByIdAsync(int id)
        {
            var result = characters.FirstOrDefault(c => c.Id == id);
            return await Task.FromResult(result);
        }

        public Task<bool> UpdateCharacterAsync(int id, Character character)
        {
            throw new NotImplementedException();
        }
    }
}
