using System.Collections.Generic;
using System.Threading.Tasks;
using BackendLogic.DatabaseContext.DatabaseContext;
using BackendLogic.PC;

namespace BackendLogic.DatabaseContext
{
    public class CharacterService
    {
        private CharacterDbContext _dbContext;
        private List<Character> _characters;

        public CharacterService(CharacterDbContext dbContext)
        {
            _dbContext = dbContext;
            _characters = _dbContext.LoadCharacters();
        }

        public CharacterService() : this(new CharacterDbContext()) { }

        public List<Character> GetCharacters()
        {
            return _characters;
        }

        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }

        public void RemoveCharacter(Character character)
        {
            _characters.Remove(character);
        }

        public async Task SaveCharacters()
        {
            await _dbContext.SaveCharacters(_characters);
        }
    }
}
